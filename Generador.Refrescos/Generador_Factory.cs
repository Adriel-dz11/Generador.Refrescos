using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generador.Refrescos
{
    public class Generador_Factory
    {
        

        public static Refresco Generador(int Tipo)
        {
            switch (Tipo)
            {
                case 1:
                    return new RefrescoBase();
                case 2:
                    return new RefrecoLight();
                default:
                    return null;
            }
        }
    }
}
