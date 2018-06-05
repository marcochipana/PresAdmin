using DominioEntidades.ModeloFactAdmin;
using PresentacionAgenteServicio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace PresentacionWeb.Sitio.Controladores.Administracion
{
    public class CCreaEmpresa : CManejadorServicio
    {       
        public List<empresa> GetListEmpresaByNombre(string strNombre)
        {
            try
            {
                string urlResource = Path.Combine("GetListEmpresa", strNombre);
                //string urlResource = "GetListEmpresa/" + strNombre;

                var lstEmpresas = new List<empresa>();
                return (List<empresa>)GetList_Object(lstEmpresas, urlResource);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public empresa GetObjEmpresaById(long longId)
        {
            try
            {
                string urlResource = Path.Combine("GetEmpresaById", Convert.ToString(longId));
                //string urlResource = "GetListEmpresa/" + strNombre;

                var lstEmpresas = new empresa();
                return (empresa)GetList_Object(lstEmpresas, urlResource);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public empresa SaveObjEmpresa(empresa objEmpresa)
        {
            try
            {                
                return (empresa)SaveObjectAsync(objEmpresa, CParametroServicio.UrlSaveEmpresa).Result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}