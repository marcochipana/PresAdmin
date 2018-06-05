using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace PresentacionWeb
{
    public partial class Principal : System.Web.UI.MasterPage
    {
        private static int _intIdAplicacion;
        private static string _strUserDomain;
        protected void Page_Init(object sender, EventArgs e)
        {
            //Page.Error += Page_Error;

            //var link = new HtmlLink();
            //link.Href = "~/UI/css/Themes/" + CParametrosComplejos.GetCssTheme();
            //link.Attributes.Add("rel", "stylesheet");
            //link.Attributes.Add("type", "text/css");
            //Page.Header.Controls.Add(link);

        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}