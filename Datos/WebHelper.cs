using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public static class WebHelper
    {
        static WebClient client;
        static string rutaBase;

        static WebHelper()  // 1 - GET , 1 -POST
        {
            client = new WebClient();
            client.Encoding = Encoding.UTF8;
            rutaBase = "https://cai-api.azurewebsites.net/";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        public static string Get (string url)
        {
            var urlCompl = rutaBase + url;
            var responseString = client.DownloadString(urlCompl);
            return responseString;
        }

        public static string Post (string url, NameValueCollection Parametros)
        {

            string uri = rutaBase + url;

            try
            {
                var response = client.UploadValues(uri, Parametros);
                var responseString = Encoding.Default.GetString(response);

                return responseString;

            }
            catch (Exception ex)
            {

                return "{ \"isOk\":false,\"id\":-1,\"error\":\"Error en el llamado al servicio\"}";
            }


        }


    }
}
