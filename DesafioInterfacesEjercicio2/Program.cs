using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioInterfacesEjercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Boeing747 boeing = new Boeing747(0);
            Pato pato = new Pato(100);
            Superman superman = new Superman(0);

            TorreDeControl torre1 = new TorreDeControl();

            torre1.AgregarVolador(boeing);
            torre1.AgregarVolador(pato);
            torre1.AgregarVolador(superman);

            torre1.VuelenTodos();
            torre1.VuelenTodos();

            Console.ReadKey();  

        }
    }
}
