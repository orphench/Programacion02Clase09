using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion02Clase09
{
    class AlumnoEgresado:Alumno
    {
        public int añoEgreso;

        public override void MostrarFecha()
        {
            base.MostrarFecha();
            //MostrarDni();
            Console.WriteLine("AÑO DE EGRESO: " + this.añoEgreso);
            
        }

        //CONSTRUCTOR
        public AlumnoEgresado(string dni, int legajo, string nombre, int añoDeEgreso) 
            : base(dni, legajo, nombre) 
        {
            this.añoEgreso = añoDeEgreso;
        }

        public override void otroVirtual()
        {
            base.otroVirtual();
        }
    }
}
