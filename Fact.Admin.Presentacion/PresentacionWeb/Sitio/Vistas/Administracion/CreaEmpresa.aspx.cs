using DominioEntidades.ModeloFactAdmin;
using PresentacionWeb.Parametros;
using PresentacionWeb.Sitio.Controladores.Administracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWeb.Sitio.Vistas.Administracion
{
    public partial class CreaEmpresa : System.Web.UI.Page
    {
        CCreaEmpresa _cCreaEmpresa = new CCreaEmpresa();
        CLexico _cLexico = new CLexico();

        #region metodos privados

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }

            MtdLoadInicial();
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            pnlList.Visible = false;
            pnlForm.Visible = true;
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            grdListaEmpresas.DataSource = _cCreaEmpresa.GetListEmpresaByNombre(txtBuscaNombreEmpresa.Text);
            grdListaEmpresas.DataBind();

            //ocultamos loading
            ScriptManager.RegisterStartupScript(this, typeof(Page), "closeLoader", "hideLoader()", true);
        }

        protected void btGuardar_Click(object sender, EventArgs e)
        {
            //ScriptManager.RegisterStartupScript(this, typeof(Page), "openLoader", "showLoader('Registrando Empresa...')", true);
            //Thread.Sleep(10000);
            empresa objEmpresa = new empresa();

            if (ViewState["ID"] == null)
            {
                //si es nulo es un nuevo registro
                objEmpresa.embi_empresa_id = 1;
                objEmpresa.emvc_nombre_empresa = txtNombreEmpresa.Text;
                objEmpresa.emvc_sucursal_empresa = txtSucursal.Text;
                objEmpresa.emvc_nit_empresa = txtNit.Text;
                objEmpresa.emvc_direccion_empresa = txtDireccion.Text;
                objEmpresa.emvc_telefono_empresa = txtTelefono.Text;
                objEmpresa.emvc_cel_empresa = txtCelular.Text;
                objEmpresa.lxvc_ciudad = cmbCiudad.SelectedValue;
                objEmpresa.emdt_fecha_insert = DateTime.Now;
                objEmpresa.emvc_user_insert = "";
                objEmpresa.emdt_fecha_modif = DateTime.Now;
                objEmpresa.emvc_user_modif = "";
                objEmpresa.embt_is_hidden = false;
                _cCreaEmpresa.SaveObjEmpresa(objEmpresa);
            }
            else
            {
                //si no es nulo es actualizacion


            }
            


            MtdLoadInicial();
            ScriptManager.RegisterStartupScript(this, typeof(Page), "closeLoader", "hideLoader()", true);
            ScriptManager.RegisterStartupScript(this, typeof(Page), "response", "toastr.success('success')", true);
        }

        protected void grdListaEmpresas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            var dataKey = grdListaEmpresas.DataKeys[Convert.ToInt32(e.CommandArgument)];
            if (dataKey != null)
            {
                var id = Convert.ToInt64(dataKey.Value);
                string strCommand = e.CommandName;
                switch (strCommand)
                {
                    case "EDITAR":
                        pnlForm.Visible = true;
                        pnlList.Visible = false;
                        //lblTitle.Text = "Modificacion de Recargo";
                        ViewState["ID"] = id;

                        var objEmpresa = _cCreaEmpresa.GetObjEmpresaById(id);
                        txtNombreEmpresa.Text = objEmpresa.emvc_nombre_empresa;
                        txtSucursal.Text = objEmpresa.emvc_sucursal_empresa;
                        //txtValorAsegurado.Text = Convert.ToString(objCoberturaAfiliacionT.CAMO_VALOR_ASEGURADO);
                        //txtPorcentajeCobertura.Text = Convert.ToString(objCoberturaAfiliacionT.CAFL_PORCENTAJE_COBERTURA);
                        //txtCondicion.Text = objCoberturaAfiliacionT.CTVC_DESCRIPCION;

                        //pnlFormSaveEdit.Visible = true;
                        //pnlListaRecargasPendientes.Visible = false;
                        break;
                    case "ELIMINAR":
                        //var response = _cRecargoValidacion.UpdateDeleteRecargo(id);
                        //if (response)
                        //{
                        //    //el registro cobertura afiliacion temporal ha sido eliminado
                        //    ScriptManager.RegisterStartupScript(this, typeof(Page), "response",
                        //        CParametrosComplejos.ToastrSuccess("El Recargo ha sido eliminado"), true);
                        //    LoadInitial();
                        //}
                        //else
                        //{
                        //    ScriptManager.RegisterStartupScript(this, typeof(Page), "response", CParametrosComplejos.ToastrError("No se puede Eliminar el registro"), true);
                        //}
                        break;
                }
            }
        }

        protected void grdListaEmpresas_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[0].Attributes["data-title"] = "Empresa";
                e.Row.Cells[1].Attributes["data-title"] = "Sucursal";
                e.Row.Cells[2].Attributes["data-title"] = "Direccion";
                e.Row.Cells[3].Attributes["data-title"] = "Ciudad";
                e.Row.Cells[4].Attributes["data-title"] = "Telefono";
                e.Row.Cells[5].Attributes["data-title"] = "Celular";
                e.Row.Cells[6].Attributes["data-title"] = "Nit";

                //((ImageButton)e.Row.Cells[7].Controls[0]).OnClientClick = "showLoader('Procesando');"; // add any JS you want here
                //((ImageButton)e.Row.Cells[8].Controls[0]).OnClientClick = "if(!confirm('Desea Eliminar el Recargo?')) { return;}else{ showLoader('Guardando cambios');}"; // add any JS you want here
                //((ImageButton)e.Row.Cells[8].Controls[0]).OnClientClick = "if(!confirm('Desea Eliminar el Recargo?')) return;"; // add any JS you want here
            }
        }

        #endregion

        #region Metodos publicos

        private void MtdLoadInicial()
        {
            pnlForm.Visible = false;
            pnlList.Visible = true;
            grdListaEmpresas.DataSource = _cCreaEmpresa.GetListEmpresaByNombre(string.Empty);
            grdListaEmpresas.DataBind();
            
            cmbCiudad.DataSource = _cLexico.GetListLexicoByTabla(CParametros.LX_CIUDAD);
            cmbCiudad.DataTextField = "lxvc_desc";
            cmbCiudad.DataValueField = "lxvc_valor";
            cmbCiudad.DataBind();

            ClearControls();
        }

        private void ClearControls()
        {
            txtNombreEmpresa.Text = string.Empty;
            txtSucursal.Text = string.Empty;
            txtNit.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCelular.Text = string.Empty;
            cmbCiudad.SelectedIndex = 0;
            ViewState["ID"] = null;
        }


        #endregion

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlForm.Visible = false;
            pnlList.Visible = true;
            ClearControls();
        }
    }
}