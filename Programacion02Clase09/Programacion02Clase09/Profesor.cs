using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion02Clase09
{
    class Profesor:Persona
    {
        public Profesor(string nombre, string dni):base(dni)
        {
            this._nombre = nombre;
        }

        public override void MostrarFecha()
        {
            throw new NotImplementedException();
        }

        public override void MostrarFechaNacimiento()
        {
            throw new NotImplementedException();
        }

        public override string Nombre
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override void AlgoVirtual()
        {
            base.AlgoVirtual();
        }
    }
}
