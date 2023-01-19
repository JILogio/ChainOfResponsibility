using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Comprador : Aprobador
    {
        public override void Procesar(Compra c)
        {
            if(c.Importe < 100)
            {
                Console.WriteLine(String.Format("Compra aprobada por {0}",this.GetType().Name));
            }
            else
            {
                _siguiente.Procesar(c);
            }
        }
    }
}
