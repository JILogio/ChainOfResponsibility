using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Director : Aprobador
    {
        public override void Procesar(Compra c)
        {
            Console.WriteLine(String.Format("Compra aprobada por {0}",this.GetType().Name));
        }
    }
}
