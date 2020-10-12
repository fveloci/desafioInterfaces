using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioInterfacesEjercicio2
{
    class Superman: SuperHeroe, Volador
    {

        public Superman(int experiencia): base(experiencia)
        {

        }

        public void volador()
        {
            experiencia += 3;
            Console.WriteLine("Estoy volando como un campeon..."+"\n"+"Experiencia: "+experiencia);
        }
    }
}
