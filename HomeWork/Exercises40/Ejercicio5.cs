using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenExercises
{
    class Ejercicio5
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un año: ");
            int n = int.Parse(Console.ReadLine());

            if (n%4 == 0 && (n%100 != 0 ||n%400 == 0))
            {
                Console.WriteLine("\nEl año {0} es bisiesto", n);
            }
            else
            {
                Console.WriteLine("\nEl número {0} NO es bisiesto", n);
            }
            Console.Read();
        }
    }
}
