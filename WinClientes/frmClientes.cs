using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using WinClientes.Properties;
using BussinesLogic;
using Domain;

namespace WinClientes
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        public int IDCliente;
        public Bitmap iconoGuardar = Resources.guardar;
        public Bitmap iconoAgregar = Resources.agregar;
        public bool busquedaActiva = false;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente pCliente = ObtenerCliente();
            if (ClientesManager.Guardar(pCliente) == 0)
            {
                MessageBox.Show("Error al añadir o actualizar registro");
            }
            else
            {
                if (IDCliente == 0)
                {
                    MessageBox.Show("Se añadió un nuevo registro");
                }
                else
                {
                    MessageBox.Show("Se modificó el registro seleccionado");
                }
            }
            ActualizarGrilla();
            Limpiar();
        }
        private Cliente ObtenerCliente()
        {
            Cliente pCliente = new Cliente();

            pCliente.ID = IDCliente;
            pCliente.Nombre = txtNombre.Text;
            pCliente.Apellido = txtApellido.Text;
            pCliente.Fecha_Nac = dtpFechaNacimiento.Value.Year.ToString() + '/' + dtpFechaNacimiento.Value.Month.ToString() + '/' + dtpFechaNacimiento.Value.Day.ToString(); ;
            pCliente.Nro_Doc = txtNroDocumento.Text;
            pCliente.Direccion = txtDireccion.Text;

            return pCliente;
        }
        private void ActualizarGrilla()
        {
            List<Cliente> lista = ClientesManager.Buscar();
            dgv.DataSource = lista;
            setBusquedaActiva(false);
        }
        private void dgv_Click(object sender, EventArgs e)
        {
            ActualizarControles();
        }
        private void ActualizarControles()
        {
            IDCliente = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
            txtNombre.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
            txtApellido.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
            if (!string.IsNullOrEmpty(Convert.ToString(dgv.CurrentRow.Cells[3].Value)))
            {
                dtpFechaNacimiento.Value = Convert.ToDateTime(dgv.CurrentRow.Cells[3].Value);
            }
            else
            {
                dtpFechaNacimiento.Value = DateTime.Now.Date;
            }
            txtNroDocumento.Text = Convert.ToString(dgv.CurrentRow.Cells[4].Value);
            txtDireccion.Text = Convert.ToString(dgv.CurrentRow.Cells[5].Value);
            btnGuardar.Image = iconoGuardar;
            btnGuardar.Text = "Modificar";
        }
        private void Limpiar()
        {
            IDCliente = 0;
            txtNombre.Text = "";
            txtApellido.Text = "";
            dtpFechaNacimiento.Value = DateTime.Now.Date;
            txtDireccion.Text = "";
            txtNroDocumento.Text = "";
            btnGuardar.Image = iconoAgregar;
            btnGuardar.Text = "Nuevo";
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (IDCliente == 0)
            {
                MessageBox.Show("No hay ningún registro seleccionado");
            }
            else
            {
                if (ClientesManager.Eliminar(IDCliente) == 0)
                {
                    MessageBox.Show("Ocurrió un error al querer eliminar el registro");
                }
                else
                {
                    MessageBox.Show("El registro fue eliminado"); 
                }
                ActualizarGrilla();
                Limpiar();
            }
        }
        private void frmClientes_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            setBusquedaActiva(!busquedaActiva);
            if (busquedaActiva)
            {
                List<Cliente> lista = ClientesManager.Buscar(txtNombre.Text, txtApellido.Text);
                dgv.DataSource = lista;
            }
            else
            {
                ActualizarGrilla();
                Limpiar();
            }
        }
        private void setBusquedaActiva(bool estado)
        {
            busquedaActiva = estado;
            if (busquedaActiva)
            {
                btnBuscar.Text = "Restablecer";
            }
            else
            {
                btnBuscar.Text = "Buscar";
            }
        }
    }
}