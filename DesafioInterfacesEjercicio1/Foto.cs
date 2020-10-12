using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioInterfaces
{
    class Foto : Imprimible
    {
        public void imprimir()
        {
            Console.WriteLine("Soy una selfie pal insta pa");
        }
    }
}
