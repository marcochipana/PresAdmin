using DominioEntidades.ModeloFactAdmin;
using PresentacionWeb.Sitio.Controladores.Administracion;
using PresentacionWeb.Sitio.Controladores.Parametros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWeb.Sitio.Vistas.Parametros
{
    public partial class Perfiles : System.Web.UI.Page
    {
        CRoles _cRoles = new CRoles();
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

        protected void grdListaPerfiles_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            var dataKey = grdListaPerfiles.DataKeys[Convert.ToInt32(e.CommandArgument)];
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

                        var objRoles = _cRoles.GetObjEmpresaById(id);
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

        protected void grdListaPerfiles_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void btGuardar_Click(object sender, EventArgs e)
        {            
            roles objRoles = new roles();

            objRoles.rovc_nombre_rol = txtNombrePerfil.Text;
            if (ViewState["ID"] == null)
            {
                //si es nulo es un nuevo registro                
                _cRoles.SaveObjRoles(objRoles);
            }
            else
            {
                //si no es nulo es actualizacion
                string strRolId = (string)ViewState["ID"];
                _cRoles.UpdateObjRoles(objRoles, strRolId);
            }

            MtdLoadInicial();
            ScriptManager.RegisterStartupScript(this, typeof(Page), "closeLoader", "hideLoader()", true);
            ScriptManager.RegisterStartupScript(this, typeof(Page), "response", "toastr.success('success')", true);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlForm.Visible = false;
            pnlList.Visible = true;
            ClearControls();
        }
        #endregion

        #region Metodos publicos

        private void MtdLoadInicial()
        {
            pnlForm.Visible = false;
            pnlList.Visible = true;
            grdListaPerfiles.DataSource = _cRoles.GetListRolesActivo();
            grdListaPerfiles.DataBind();
            
            ClearControls();
        }

        private void ClearControls()
        {
            txtNombrePerfil.Text = string.Empty;            
            ViewState["ID"] = null;
        }

        #endregion


    }
}