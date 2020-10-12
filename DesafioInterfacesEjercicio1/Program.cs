using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Contrato con = new Contrato();
            Foto foto = new Foto();
            Documento doc = new Documento();
            Impresora impresora = new Impresora();

            impresora.AgregarImprimible(con);
            impresora.AgregarImprimible(foto);
            impresora.AgregarImprimible(doc);
            impresora.ImprimirTodo();

            Console.ReadKey();
        }
    }
}
