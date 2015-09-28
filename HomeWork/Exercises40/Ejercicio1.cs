using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Ejercicio1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingresa un número: ");
        int n = int.Parse(Console.ReadLine());

        if (n%2 == 0)
        {
            Console.WriteLine("\nEl número {0} es par", n);
        }
        else
        {
            Console.WriteLine("\nEl número {0} es impar", n);
        }
        Console.Read();
    }
}