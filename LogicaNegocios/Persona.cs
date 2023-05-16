using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public class Persona
    {
        string cedula;
        string nombre;
        byte edad;
        char sexo;

        public Persona(string cedula, string nombre, byte edad, char sexo)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
        }

        public Persona() { }
    }
}
