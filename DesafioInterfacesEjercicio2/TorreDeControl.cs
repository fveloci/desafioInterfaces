using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioInterfacesEjercicio2
{
    class TorreDeControl
    {
        private List<Volador> voladores = new List<Volador>();

        public void VuelenTodos()
        {
            foreach (Volador vol in voladores)
            {
                vol.volador();
                Console.WriteLine("........");
            }
            Console.WriteLine("\n");
        }

        public void AgregarVolador(Volador volador)
        {
            voladores.Add(volador);
        }
    }
}
