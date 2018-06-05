using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentacionAgenteServicio
{
    public class CParametroServicio
    {
        //Este es el directorio base del servicio al que nos conectaremos
        public static string ServicioAdmin = "http://localhost:13371/ServicioFactAdmin.svc";

        // urls especificas

        #region lexico

        public static string UrlLexicoByTabla = "LexicoByTabla";

        #endregion

        #region empresa

        public static string UrlSaveEmpresa = "SaveEmpresa";

        #endregion

        #region roles

        public static string UrlGetListRoles = "GetListRoles";
        
        public static string UrlSaveRoles = "SaveRoles";

        public static string UrlUpdateRoles = "UpdateRoles";

        #endregion        
    }
}
