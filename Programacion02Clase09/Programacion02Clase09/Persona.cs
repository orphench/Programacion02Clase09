using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion02Clase09
{
    public abstract class Persona:SerHumano//La clase abstracta no se puede instanciar
    {
        public string dni;
        protected string _nombre;

        public abstract string Nombre
        {
            get;

            set;
        }

        public abstract void MostrarFecha();//Metodo abstracto

        public void MostrarDni()
        {
            Console.WriteLine("DNI: " + this.dni);
        }

        //CONSTRUCTOR
        public Persona(string dni)
        {
            this.dni = dni;
        }

        public override void AlgoVirtual()
        {
            base.AlgoVirtual();
        }
    }
}
