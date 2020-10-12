using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioInterfacesEjercicio2
{
    class Pato: Animal,Volador
    {
        

        public Pato(int energia): base(energia)
        {
           
        }

        public void volador()
        {
            if(energia >= 5)
            {
                energia -= 5;
                Console.WriteLine("Estoy volando como un pato... ¡Cuak!"+"\n"+"Energia: "+energia);
            }
            else
            {
                Console.WriteLine("No tengo energia... ¡Cuak!");
            }
            

                        
        }
    }
}
