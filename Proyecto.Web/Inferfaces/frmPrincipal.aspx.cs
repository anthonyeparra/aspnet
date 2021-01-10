using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Proyecto.Web.Inferfaces
{
    public partial class frmPrincipal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtIdentificacion.Focus();
            
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            try 
            {
                lblMensaje.Text = "";
                Logica.Class.clsClientes obclsClientes = new Logica.Class.clsClientes();
               lblMensaje.Text= obclsClientes.stInsertarClientes(
                    Convert.ToInt64(txtIdentificacion.Text),txtNombres.Text,txtApellidos.Text);
            }
            catch (Exception ex) { lblMensaje.Text = ex.Message; }

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                long valor = 0;
                lblMensaje.Text = "";
                if (txtIdentificacion.Text == "") valor = -1;
                else valor = Convert.ToInt64(txtIdentificacion.Text);

                Logica.Class.clsClientes obclsClientes = new Logica.Class.clsClientes();
                DataSet dsConsulta = obclsClientes.stConsultarClientes(valor);
                if (dsConsulta.Tables[0].Rows.Count == 0 || txtIdentificacion.Text =="-1") 
                    gvwDatos.DataSource = null;
                else gvwDatos.DataSource = dsConsulta;
                gvwDatos.DataBind();
                
            }
            catch (Exception ex) { lblMensaje.Text = ex.Message; }

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                lblMensaje.Text = "";
                Logica.Class.clsClientes obclsClientes = new Logica.Class.clsClientes();
                lblMensaje.Text = obclsClientes.stModifcarClientes(
                     Convert.ToInt64(txtIdentificacion.Text), txtNombres.Text, txtApellidos.Text);
                LimpiarCajas();
            }
            catch (Exception ex) { lblMensaje.Text = ex.Message; }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                lblMensaje.Text = "";
                Logica.Class.clsClientes obclsClientes = new Logica.Class.clsClientes();
                lblMensaje.Text = obclsClientes.stEliminarClientes(
                     Convert.ToInt64(txtIdentificacion.Text));
                LimpiarCajas();
            }
            catch (Exception ex) { lblMensaje.Text = ex.Message; }
        }
        public void LimpiarCajas()
        { 

            txtIdentificacion.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";

        }
    }
}