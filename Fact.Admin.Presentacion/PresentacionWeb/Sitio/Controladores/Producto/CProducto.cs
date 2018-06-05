
using DominioEntidades.ModeloFactAdmin;
using PresentacionAgenteServicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PresentacionWeb.Sitio.Controladores.Producto
{
    public class CProducto : CManejadorServicio
    {
        public List<producto> GetListProductos(string strNombreProducto)
        {
            try
            {
                string urlResource = "GetListProductos/" + strNombreProducto;

                var lstProducto = new List<producto>();
                return (List<producto>)GetList_Object(lstProducto, urlResource);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public producto GetProductAsync(string strProductoId)
        {
            try
            {
                string urlResource = "GetProducto/" + strProductoId;

                var objProducto = new producto();     
                return (producto)GetList_Object(objProducto, urlResource);
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public producto SaveObjProducto(producto objProducto)
        {
            try
            {
                const string urlResource = "SaveProducto";
                return (producto)SaveObjectAsync(objProducto, urlResource).Result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public producto UpdateObjProducto(producto objProducto)
        {
            try
            {
                // var objPersona = new personas();

                string urlResource = "UpdateProducto/" + objProducto.prin_producto_id;
                return (producto)UpdateObjectAsync(objProducto, urlResource).Result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //public bool DeleteObjProducto(producto objProducto)
        //{
        //    try
        //    {
        //        string urlResource = "Transaction/" + objProducto.prin_producto_id;
        //        return DeleteObjectAsync(urlResource).Result;
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //}
    }
}