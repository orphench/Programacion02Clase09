using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion02Clase09
{
    public abstract class SerHumano
    {
        public int fechaNacimiento;

        public abstract void MostrarFechaNacimiento();

        public virtual void AlgoVirtual()
        { 

        }
    }
}
