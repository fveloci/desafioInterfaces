using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioInterfacesEjercicio2
{
    abstract class SuperHeroe
    {
        protected int experiencia;

        public SuperHeroe(int experiencia)
        {
            this.experiencia = experiencia;
        }
    }
}
