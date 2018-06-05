using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace PresentacionAgenteServicio
{
    public class CManejadorServicio
    {
        readonly string _urlPrincipalServicio;

        static readonly HttpClient Client = new HttpClient();

        protected CManejadorServicio()
        {
            _urlPrincipalServicio = CParametroServicio.ServicioAdmin;
        }

        //protected CManejadorServicio(string serviceUrl)
        //{
        //    _urlPrincipalServicio = CParametroServicio.ServicioAdmin;
        //}

        public async Task<object> SaveObjectAsync(object objeto, string urlResource)
        {
            try
            {
                var url = Path.Combine(_urlPrincipalServicio, urlResource);
                
                Type type = objeto.GetType();

                //var response = Client.PostAsJsonAsync(url, objeto).Result;
                var response = await Client.PostAsJsonAsync(url, objeto).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();

                if (response.IsSuccessStatusCode)
                {
                    //Success
                    var result = response.Content.ReadAsStringAsync().Result;

                    var jss = new JavaScriptSerializer();

                    var request = jss.Deserialize(result, type);
                    return request;
                }
            }
            catch (Exception ex)
            {

                throw;
            }

            //retornamos un objeto vacio
            return objeto;
        }

        public async Task<object> UpdateObjectAsync(object objeto, string urlResourceWithPk)
        {
            try
            {
                var url = _urlPrincipalServicio + "/" + urlResourceWithPk;
                Type type = objeto.GetType();

                HttpResponseMessage response = await Client.PutAsJsonAsync(url, objeto).ConfigureAwait(false);
                //HttpResponseMessage response = await Client.PutAsJsonAsync("api/products/{product.Id}", objeto).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();

                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync().Result;

                    var jss = new JavaScriptSerializer();

                    var request = jss.Deserialize(result, type);
                    return request;
                }
            }
            catch (Exception ex)
            {

                throw;
            }


            return objeto;
        }

        public async Task<bool> DeleteObjectAsync(string urlResourceWithPk)
        {
            try
            {
                var url = _urlPrincipalServicio + "/" + urlResourceWithPk;

                HttpResponseMessage response = await Client.DeleteAsync(url).ConfigureAwait(false);
                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode.ToString() == "OK")
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }

        public async Task<object> GetProductAsync(object objeto, string urlResource)
        {
            try
            {
                var url = _urlPrincipalServicio + "/" + urlResource;
                Type type = objeto.GetType();

                HttpResponseMessage response = await Client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync().Result;

                    var jss = new JavaScriptSerializer();

                    var request = jss.Deserialize(result, type);
                    return request;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return objeto;
        }

        public object GetList_Object(object objeto, string urlResource)
        {
            object request;
            try
            {
                var url = Path.Combine(_urlPrincipalServicio, urlResource);
                //var builder = new UriBuilder(url);

                //builder.Path = VirtualPathUtility.AppendTrailingSlash(builder.Path);

                var webrequest = (HttpWebRequest)WebRequest.Create(url);
                
                Type type = objeto.GetType();

                using (var response1 = webrequest.GetResponse())
                using (var reader1 = new StreamReader(response1.GetResponseStream()))
                {
                    var result = reader1.ReadToEnd();
                    var jss = new JavaScriptSerializer();

                    request = jss.Deserialize(result, type);
                }
                return request;
            }
            catch (Exception ex)
            {

                throw;
            }

            return request;
        }
    }
}
