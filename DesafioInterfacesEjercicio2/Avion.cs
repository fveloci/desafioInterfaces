using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioInterfacesEjercicio2
{
    abstract class Avion
    {
        protected int horasDeVuelo;

        public Avion(int horasDeVuelo)
        {
            this.horasDeVuelo = horasDeVuelo;
        }
    }
}
