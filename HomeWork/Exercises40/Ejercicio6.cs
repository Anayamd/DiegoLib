using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenExercises
{
    class Ejercicio6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Horas trabajadas: ");
            int horas = int.Parse(Console.ReadLine());

            Console.WriteLine("Tarifa: ");
            double tarifa = double.Parse(Console.ReadLine());

            double pago = 0;            

            if (horas > 40)
            {
                pago = 40 * tarifa + (horas-40)*tarifa*1.5;
            }
            else
            {
                pago = horas * tarifa;
            }

            Console.WriteLine("\nPago total de: {0}", pago);

            Console.Read();
        }
    }
}
