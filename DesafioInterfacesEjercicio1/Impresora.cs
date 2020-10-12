using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioInterfaces
{
    class Impresora
    {

        private List<Imprimible> colaDeImpresion = new List<Imprimible>();

        public void ImprimirTodo()
        {
            foreach (Imprimible imp in colaDeImpresion)
            {
                imp.imprimir();
            }
        }
        public void AgregarImprimible(Imprimible unInprimible)
        {
            colaDeImpresion.Add(unInprimible);
        }
    }
}
