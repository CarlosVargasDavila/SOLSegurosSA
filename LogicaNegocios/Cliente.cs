using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    internal class Cliente : Persona
    {
        public string id { get; set; }
        public string origen { get; set; }
        public float monto { get; set; }    
        public string direccion {get; set; }
        public string fecha { get; set; }   

        public Cliente(string cedula, string nombre, byte edad, char sexo) : base(cedula, nombre, edad, sexo)
        {
            this.id = "";
            this.origen = "";
            this.monto = 0;
            this.direccion = "";
            this.fecha = "";

        }
        public Cliente() { }

    }
}
