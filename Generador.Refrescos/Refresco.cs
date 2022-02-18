using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generador.Refrescos
{
    public abstract class Refresco
    {
        public abstract int Cantidad();
 
    }

    public class RefrescoBase : Refresco
    {
        public override int Cantidad()
        {
            return 1;
        }
        

    }

    public class RefrecoLight : Refresco
    {
        public override int Cantidad()
        {
            return 1;
        }

    }




}
