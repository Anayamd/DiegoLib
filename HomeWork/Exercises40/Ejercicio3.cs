using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Ejercicio3
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa un a cantidad: ");
        int n = int.Parse(Console.ReadLine());

        int[] N = new int[n];
        int suma = 0;
        int negativos = 0;

        for (int i = 0; i < N.Length; i++)
        {
            Console.Write("Ingresa un número: ");
            N[i] = int.Parse(Console.ReadLine());
        }

        foreach (int num in N)
        {
            if (num < 0)
            {
                suma += num;
                negativos++;
            }
        }

        Console.WriteLine("El promedio de los negativos es {0}", suma * 1.0 / negativos);
        Console.Read();
    }
}