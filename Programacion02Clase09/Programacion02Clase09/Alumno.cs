using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion02Clase09
{
    class Alumno:Persona
    {
        public int legajo;

        public override void MostrarFecha()//implementacion
        {
            //throw new NotImplementedException();
            Console.WriteLine("\nLEGAJO: " + this.legajo + "\nNOMBRE: " + this._nombre);
            base.MostrarDni();
        }

        public override void MostrarFechaNacimiento()
        {
            Console.WriteLine(this.fechaNacimiento);
        }

        public override string Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                this._nombre = value;
            }
        }

        //CONSTRUCTOR
        public Alumno(string dni, int legajo, string nombre)
            : base(dni)
        {
            this.legajo = legajo;
            this.Nombre = nombre;
        }

        public virtual void otroVirtual()
        {

        }
    }
}
