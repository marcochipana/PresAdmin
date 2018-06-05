using DominioEntidades.ModeloFactAdmin;
using PresentacionWeb.Sitio.Controladores.Administracion;
using PresentacionWeb.Sitio.Controladores.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWeb.Sitio.Vistas.Producto
{
    public partial class Producto : System.Web.UI.Page
    {
        CProducto cProducto = new CProducto();
        CCreaEmpresa cEmpresa = new CCreaEmpresa();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var test3 = cEmpresa.SaveObjEmpresa(new empresa
                {
                    emvc_nombre_empresa = "test",
                });
                //var test2 = cProducto.SaveObjProducto(new producto
                //{
                //    cain_categoria_id = 1,
                //});


                //var test= cProducto.GetProductAsync("1");
            }

        }

        
    }
}