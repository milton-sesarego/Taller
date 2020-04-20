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

namespace WinClientes
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
            actualizar();
        }

        public int IDCliente;
        public Bitmap iconoGuardar = Resources.guardar;
        public Bitmap iconoAgregar = Resources.agregar;
        private void btnNuevoGuardar_Click(object sender, EventArgs e)
        {
            string strNombre, strApellido, strFechaNacimiento, strDireccion, strNroDocumento;
            strNombre = txtNombre.Text;
            strApellido = txtApellido.Text;
            strFechaNacimiento = pckrFechaNacimiento.Value.Year.ToString() + '/' + pckrFechaNacimiento.Value.Month.ToString() + '/' + pckrFechaNacimiento.Value.Day.ToString();
            strDireccion = txtDireccion.Text;
            strNroDocumento = txtNroDocumento.Text;
            string consulta = null;
            SqlCommand comando = null;
            SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-RVDRODE\\SQLEXPRESS;Initial Catalog=Taller;Integrated Security=true;");

            consulta = string.Format("SELECT IdCliente, Nro_Documento FROM clientes where Nro_documento = '{0}'",
                strNroDocumento);
            comando = new SqlCommand(consulta, conectar);

            conectar.Open();
            SqlDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                if (IDCliente == 0)
                {
                    MessageBox.Show("Error al añadir. Ya existe un registro con ese Nro de Documento");
                    conectar.Close();
                    return;
                }
                else
                {
                    if (reader.GetInt32(0) != IDCliente)
                    {
                        MessageBox.Show("Error al editar. Ya existe un registro con ese Nro de Documento");
                        conectar.Close();
                        return;
                    }
                }
            }
            conectar.Close();
            
            if (IDCliente == 0){
               consulta = string.Format("Insert into clientes (Nombre, Apellido, Fecha_Nacimiento, Nro_Documento, Direccion) values ('{0}','{1}','{2}','{3}','{4}')",
               strNombre, strApellido, strFechaNacimiento, strNroDocumento, strDireccion);
            }else{
               consulta = string.Format("Update clientes set Nombre='{0}', Apellido='{1}', Fecha_Nacimiento='{2}', Nro_Documento='{3}', Direccion='{4}' where IDCliente='{5}'",
               strNombre, strApellido, strFechaNacimiento, strNroDocumento, strDireccion, IDCliente);
            }
            
            comando = new SqlCommand(consulta, conectar);

            conectar.Open();
            comando.ExecuteNonQuery();
            conectar.Close();
            
            if (IDCliente == 0)
            {
                MessageBox.Show("Se añadió un nuevo registro");
            }
            else
            {
                MessageBox.Show("Se modificó el registro seleccionado");
            }
            actualizar();
            resetear();
        }
        private void actualizar()
        {
            List<Cliente> lista = new List<Cliente>();

            SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-RVDRODE\\SQLEXPRESS;Initial Catalog=Taller;Integrated Security=true;");
            String consulta = "SELECT IdCliente, Nombre, Apellido, Fecha_Nacimiento, Nro_Documento, Direccion FROM clientes";
            SqlCommand comando = new SqlCommand(consulta, conectar);

            conectar.Open();
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Cliente pCliente = new Cliente();
                pCliente.Id = reader.GetInt32(0);
                pCliente.Nombre = reader.GetString(1);
                pCliente.Apellido = reader.GetString(2);
                pCliente.Fecha_Nac = reader.GetString(3);
                pCliente.Nro_Doc = reader.GetString(4);
                pCliente.Direccion = reader.GetString(5);
                lista.Add(pCliente);
            }

            conectar.Close();
            dgv.DataSource = lista;
            IDCliente = 0;
        }
        private class Cliente
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Fecha_Nac { get; set; }
            public string Nro_Doc { get; set; }
            public string Direccion { get; set; }
        }
        private void dgv_Click(object sender, EventArgs e)
        {
            IDCliente = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
            txtNombre.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
            txtApellido.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
            pckrFechaNacimiento.Value = Convert.ToDateTime(dgv.CurrentRow.Cells[3].Value);
            txtNroDocumento.Text = Convert.ToString(dgv.CurrentRow.Cells[4].Value);
            txtDireccion.Text = Convert.ToString(dgv.CurrentRow.Cells[5].Value);
            btnNuevoGuardar.Image = iconoGuardar;
            btnNuevoGuardar.Text = "Guardar";
            Debug.WriteLine(IDCliente);
        }
        private void resetear()
        {
            IDCliente = 0;
            txtNombre.Text = "";
            txtApellido.Text = "";
            pckrFechaNacimiento.Value = DateTime.Now;
            txtDireccion.Text = "";
            txtNroDocumento.Text = "";
            btnNuevoGuardar.Image = iconoAgregar;
            btnNuevoGuardar.Text = "Nuevo";
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            resetear();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-RVDRODE\\SQLEXPRESS;Initial Catalog=Taller;Integrated Security=true;");
            string consulta = null;

            if (IDCliente == 0){
                MessageBox.Show("No hay ningún registro seleccionado");
            }
            else{
                consulta = string.Format("DELETE FROM clientes WHERE IDCliente='{0}'",
                IDCliente);
                SqlCommand comando = new SqlCommand(consulta, conectar);

                conectar.Open();
                comando.ExecuteNonQuery();
                conectar.Close();
                actualizar();
                resetear();
                MessageBox.Show("El registro fue eliminado");
            }
        }
    }
}