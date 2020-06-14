using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;
using System.Configuration;
using System.Threading.Tasks;
using Entindades;
using Newtonsoft.Json;

namespace Datos
{
    public class ClienteMapper // paso 2 get  paso 3 post
    {
        public List<Cliente> TraerTodos()
        {
            string json2 = WebHelper.Get("/api/v1/cliente");// trae un texto en formato json de una web
            List<Cliente> resultado = MapList(json2);  // mapea el json , determinando los objetos que hay dentro, si coincide con los data member

            return resultado;
        } 

        private List<Cliente> MapList (string json)
        {
            var lst = JsonConvert.DeserializeObject<List<Cliente>>(json);
            return lst;
        }


        public TransactionResult Insert (Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente); // convierta 1 objetos a json, se inserta de a uno  = serializacion

            string result = WebHelper.Post("/api/v1/cliente", obj);

            TransactionResult resultadoTransaccion = MapResultado(result);

            return resultadoTransaccion;



        }


        private NameValueCollection ReverseMap(Cliente cliente)
        {
            NameValueCollection n = new NameValueCollection(); // DICCIONARIO , TRANSFORMO EL CLIENTE EN UN DICIONARIO (CODIGO VALOR)
            n.Add("Nombre", cliente.Nombre);
            n.Add("Apellido", cliente.Apellido);
            n.Add("Dirección", cliente.Direccion);
            //n.Add("Usuario", ConfigurationManager.AppSettings["Legajo"]);

            return n;


        }

        private TransactionResult MapResultado(string json)
        {
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lst;
        }
    }
}
