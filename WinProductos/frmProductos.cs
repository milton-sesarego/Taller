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
using WinProductos.Properties;
using BusinessLogic;
using Domain;

namespace WinProductos
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        public int IDProducto;
        public Bitmap iconoGuardar = Resources.guardar;
        public Bitmap iconoAgregar = Resources.agregar;
        public bool busquedaActiva = false;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Producto pProducto = ObtenerProducto();
            if (ProductosManager.Guardar(pProducto) == 0)
            {
                MessageBox.Show("Error al añadir o actualizar registro");
            }
            else
            {
                if (IDProducto == 0)
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
        private Producto ObtenerProducto()
        {
            Producto pProducto = new Producto();

            pProducto.ID = IDProducto;
            pProducto.Nombre = txtNombre.Text;
            pProducto.Descripcion = txtDescripcion.Text;
            if (!string.IsNullOrEmpty(txtPrecio.Text))
            {
                pProducto.Precio = Convert.ToDecimal(txtPrecio.Text);
            }
            if (!string.IsNullOrEmpty(txtStock.Text))
            {
                pProducto.Stock = Convert.ToInt32(txtStock.Text);
            }
            return pProducto;
        }
        private void ActualizarGrilla()
        {
            List<Producto> lista = ProductosManager.Buscar();
            dgv.DataSource = lista;
        }
        private void dgv_Click(object sender, EventArgs e)
        {
            ActualizarControles();
        }
        private void ActualizarControles()
        {
            btnGuardar.Image = iconoGuardar;
            btnGuardar.Text = "Modificar";
            IDProducto = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
            txtNombre.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
            txtDescripcion.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
            txtPrecio.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value);
            txtStock.Text = Convert.ToString(dgv.CurrentRow.Cells[4].Value);
        }
        private void Limpiar()
        {
            IDProducto = 0;
            txtNombre.Text = "";
            txtStock.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            btnGuardar.Image = iconoAgregar;
            btnGuardar.Text = "Nuevo";
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (IDProducto == 0)
            {
                MessageBox.Show("No hay ningún registro seleccionado");
            }
            else
            {
                if (ProductosManager.Eliminar(IDProducto) == 0)
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
        private void frmProductos_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            busquedaActiva = !busquedaActiva;
            if (busquedaActiva)
            {
                btnBuscar.Text = "Restablecer";
                List<Producto> lista = ProductosManager.Buscar(txtNombre.Text);
                dgv.DataSource = lista;
            }
            else
            {
                btnBuscar.Text = "Buscar";
                ActualizarGrilla();
                Limpiar();
            }
        }
    }
}