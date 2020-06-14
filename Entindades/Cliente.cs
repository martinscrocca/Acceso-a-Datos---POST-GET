using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entindades
{
    [DataContract] // paso 3
    public class Cliente
    {
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private string _email;
        private DateTime _fechaNacimiento;


        [DataMember]
        public string Nombre { get => _nombre; set => _nombre = value; }

        [DataMember]
        public string Apellido { get => _apellido; set => _apellido = value; }

        [DataMember]
        public string Direccion { get => _direccion; set => _direccion = value; }

        [DataMember(Name =  "email")]
        public string CorreoElectronico { get => _email; set => _email = value; }

        [DataMember]
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }

        public override string ToString()
        {

            string p = "Cliente: Nombre " + this._nombre + " Apellido " + this._apellido + " Dirección: " + this._direccion + " email :" + this._email + _fechaNacimiento;

            return p;
            //return string.Format("Cliente {0}, {1}, Direccón {2}, email {3} ,  fecha de nacimiento {4}", this._apellido, this._nombre, this._direccion ,this._email, this._fechaNacimiento);
        }
    }
}
