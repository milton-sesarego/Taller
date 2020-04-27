using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using BusinessLogic;
using Domain;

namespace WebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public int IDProducto;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ActualizarGrilla();
            }
            else
            {

            }
                
        }
        protected void ActualizarGrilla()
        {
            List<Producto> lista = ProductosManager.Buscar();
            dgv.DataSource = lista;
            dgv.DataBind();
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Producto pProducto = ObtenerProducto();
            if(pProducto is null)
            {
                return;
            }

            if (ProductosManager.Guardar(pProducto) == 0)
            {
                Response.Write("<script>alert('Error al añadir o actualizar registro')</script>");
            }
            else
            {
                if (Convert.ToInt32(Page.Session["IDProducto"]) == 0)
                {
                    Response.Write("<script>alert('Se añadió un nuevo registro')</script>");
                }
                else
                {
                    Response.Write("<script>alert('Se modificó el registro seleccionado')</script>");
                }
            }
            ActualizarGrilla();
            Limpiar();
        }
        protected Producto ObtenerProducto()
        {
            Producto pProducto = new Producto();
            pProducto.ID = Convert.ToInt32(Page.Session["IDProducto"]);
            pProducto.Nombre = txtNombre.Text;
            pProducto.Descripcion = txtDescripcion.Text;

            if (!string.IsNullOrEmpty(txtPrecio.Text))
            {
                decimal res;
                if (decimal.TryParse(txtPrecio.Text, out res))
                {
                    pProducto.Precio = res;
                }
                else
                {
                    Response.Write("<script>alert('El precio debe ser un valor numérico')</script>");
                    return null;
                }
            }
            if (!string.IsNullOrEmpty(txtStock.Text))
            {
                int res;
                if (int.TryParse(txtStock.Text, out res))
                {
                    pProducto.Stock = res;
                }
                else
                {
                    Response.Write("<script>alert('El stock debe ser un valor numérico')</script>");
                    return null;
                }
            }

            // Validamos que el stock sea mayor que 0
            if (pProducto.Stock < 0)
            {
                Response.Write("<script>alert('El Stock debe ser mayor o igual a 0')</script>");
                return null;
            }
            // Validamos que el precio sea mayor a 0
            if (pProducto.Precio < 0)
            {
                Response.Write("<script>alert('El Precio debe ser mayor o igual a 0')</script>");
                return null;
            }

            return pProducto;
        }
        protected void Limpiar()
        {
            Page.Session["IDProducto"] = 0;
            txtNombre.Text = "";
            txtStock.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            btnGuardar.Text = "Nuevo";
        }
        protected void ActualizarControles()
        {
            btnGuardar.Text = "Modificar";
            foreach (GridViewRow row in dgv.Rows)
            {
                if(row.RowIndex == dgv.SelectedIndex)
                {
                    row.BackColor = ColorTranslator.FromHtml("#A1DCF2");
                }
                else
                {
                    row.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                }
            }
            Page.Session["IDProducto"] = Convert.ToInt32(dgv.SelectedRow.Cells[0].Text);
            txtNombre.Text = Convert.ToString(dgv.SelectedRow.Cells[1].Text);
            txtDescripcion.Text = Convert.ToString(dgv.SelectedRow.Cells[2].Text);
            txtPrecio.Text = Convert.ToString(dgv.SelectedRow.Cells[3].Text);
            txtStock.Text = Convert.ToString(dgv.SelectedRow.Cells[4].Text);
        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Page.Session["IDProducto"]) == 0)
            {
                Response.Write("<script>alert('No hay ningún registro seleccionado')</script>");
            }
            else
            {
                if (ProductosManager.Eliminar(Convert.ToInt32(Page.Session["IDProducto"])) == 0)
                {
                    Response.Write("<script>alert('Ocurrió un error al querer eliminar el registro')</script>");
                }
                else
                {
                    Response.Write("<script>alert('El registro fue eliminado')</script>");
                }
                ActualizarGrilla();
                Limpiar();
            }
        }
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Producto> lista = ProductosManager.Buscar(txtNombre.Text);
            dgv.DataSource = lista;
            dgv.DataBind();
        }
        protected void dgv_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if(e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(dgv, "Select$" + e.Row.RowIndex);
            }
        }
        protected void dgv_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarControles();
        }
    }
}