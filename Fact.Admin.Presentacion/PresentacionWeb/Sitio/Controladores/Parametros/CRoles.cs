using DominioEntidades.ModeloFactAdmin;
using PresentacionAgenteServicio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace PresentacionWeb.Sitio.Controladores.Parametros
{
    public class CRoles : CManejadorServicio
    {
        public List<roles> GetListRolesActivo()
        {
            try
            {
                string urlResource = Path.Combine(CParametroServicio.UrlGetListRoles);
                //string urlResource = "GetListEmpresa/" + strNombre;

                var lstRoles = new List<roles>();
                return (List<roles>)GetList_Object(lstRoles, urlResource);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public roles SaveObjRoles(roles objRoles)
        {
            try
            {
                return (roles)SaveObjectAsync(objRoles, CParametroServicio.UrlSaveEmpresa).Result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool UpdateObjRoles(roles objRoles, string strRolId)
        {
            try
            {
                string urlResource = Path.Combine(CParametroServicio.UrlUpdateRoles, strRolId);
                return (bool)UpdateObjectAsync(objRoles, urlResource).Result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}