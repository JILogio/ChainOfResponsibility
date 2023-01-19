using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            var comprador = new Comprador();
            var gerente = new Gerente();
            var director = new Director();

            comprador.AgregarSiguiente(gerente);
            gerente.AgregarSiguiente(director);

            var c = new Compra();
            double import = 1;
            while (import != 0)
            {
                Console.WriteLine("Ingresar el importe de compra (0 para terminar)");
                import = double.Parse(s: Console.ReadLine());
                c.Importe = import;
                comprador.Procesar(c);
            }
        }
    }
}
