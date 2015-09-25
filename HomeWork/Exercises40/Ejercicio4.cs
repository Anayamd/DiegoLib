using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenExercises
{
    class Ejercicio4
    {

        public static bool isPrime(int n)
        {
            if (n < 2)
            {
                return false;
            }
            if (n == 2)
            {
                return true;
            }
            for (int i = 2; i < n/2+1; i++)
            {
                if (n%i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("Ingresa un número: ");
            int n = int.Parse(Console.ReadLine());

            if (isPrime(n))
            {
                Console.WriteLine("\nEl número {0} es primo", n);
            }
            else
            {
                Console.WriteLine("\nEl número {0} es compuesto", n);
            }
            Console.Read();
        }
    }
}