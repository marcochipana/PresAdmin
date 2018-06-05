
using DominioEntidades.ModeloFactAdmin;
using PresentacionAgenteServicio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace PresentacionWeb.Sitio.Controladores.Administracion
{
    public class CLexico : CManejadorServicio
    {
        public List<lexico> GetListLexicoByTabla(string strTabla)
        {
            try
            {
                string urlResource = Path.Combine(CParametroServicio.UrlLexicoByTabla, strTabla);
                //string urlResource = "GetListEmpresa/" + strNombre;

                var lstLexico = new List<lexico>();
                return (List<lexico>)GetList_Object(lstLexico, urlResource);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}