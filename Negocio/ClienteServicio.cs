using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entindades;

using Datos;

namespace Negocio
{
    public class ClienteServicio //paso 4  GET  -- POST paso 2
    {
        private ClienteMapper mapper;

        public ClienteServicio()
        {
            mapper = new ClienteMapper();
        }

        public List<Cliente> TraerClientes()
        {
            List<Cliente> result = mapper.TraerTodos();
            return result;
        }


        public List<Cliente > TraerClientesMas25()
        {
            
            List <Cliente> result1 = mapper.TraerTodos();
            List<Cliente> mayores25 = new List<Cliente>();
            foreach(Cliente cl in result1)
            {
                int edad = Convert.ToInt32((DateTime.Now - cl.FechaNacimiento).Days / 365);
                if (edad > 25)
                {
                    mayores25.Add(cl);
                }

            }

            return mayores25;
            
        }

        public List<Cliente> BuscarClienteXApelli(string apell)
        {
            string apellido = apell;
            List<Cliente> result1 = mapper.TraerTodos();
            List<Cliente> ListConApell = new List<Cliente>();

            foreach(Cliente cl in result1)
            {
                if (apellido == cl.Apellido)
                {
                    ListConApell.Add(cl);
                }
            }
            return ListConApell;
        }



        public int InsertarCliente(string nombre, string apellido, string direccion)
        {
            Cliente cliente = new Cliente();
            cliente.Apellido = apellido;
            cliente.Nombre = nombre;
            cliente.Direccion = direccion;

            TransactionResult resultante = mapper.Insert(cliente);

            if (resultante.IsOk)
                return resultante.Id;
            else
                throw new Exception("Hubo un error en la petición al servidor. Detalle: " + resultante.Error);

        }
    }
}
