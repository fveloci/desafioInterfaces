using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioInterfacesEjercicio2
{
    class Boeing747: Avion, Volador
    {
        public Boeing747(int horasDeVuelo): base(horasDeVuelo)
        {
            
        }

        public void volador()
        {
            horasDeVuelo += 13;
            Console.WriteLine("Estoy volando como un avion..."+"\n"+"Horas de vuelo: "+horasDeVuelo);
        }
    }
}
