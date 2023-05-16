using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public class Empleado : Persona
    {
        string codigo;
        float salario;

        public Empleado(string cedula, string nombre, byte edad, char sexo) : base(cedula, nombre, edad, sexo)
        {
            this.codigo = "";
            this.salario = 0f;
        }

        public Empleado() { }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public float Salario
        { get { return salario; } set { salario = value; } }

        public float calSalario(float sal)
        {
            sal -= sal * 0.07f;
            float salNeto = sal - (sal * 0.15f);
            return salNeto;
        }
    }
}
