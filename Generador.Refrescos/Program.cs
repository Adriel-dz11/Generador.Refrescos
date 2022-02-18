using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generador.Refrescos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int RBase = 0;
            int RLight = 0;

            while (n == 0)
            {

                Console.WriteLine("Escribe 1 para generar un refresco normal o 2 para generar un refresco light");
                String TR = Console.ReadLine();

                if (TR == "1")
                {
                    RBase += 1;
                    Generador_Factory.Generador(1);
                    Console.WriteLine("Se ha agregado un nuevo refresco normal" + "Cantidad de refrescos normales:" + RBase);

                }
                else if (TR == "2")
                {
                    RLight += 1;
                    Generador_Factory.Generador(2);
                    Console.WriteLine("Se ha agregado un nuevo refresco light" + "Cantidad de refrescos light:" + RLight);

                }
                else
                {
                    Console.WriteLine("Escribe 1 o 2");
                }

                //Código para salir
                Console.WriteLine("Seguir agregando(1), Salir?(s)");
                String Salida= Console.ReadLine();
                if (Salida == "1")
                {
                    n = 0;
                }
                else if (Salida == "s")
                {
                    n++;
                }



            }
        }
    }
}
