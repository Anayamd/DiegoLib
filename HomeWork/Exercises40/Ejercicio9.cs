using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenExercises
{
    class Ejercicio9
    {
        static void Main(string[] args)
        {
            Console.Write("Segundos: ");
            double segundos = double.Parse(Console.ReadLine());

            segundos = segundos % 60;

            Console.WriteLine("\nFaltan {0} segundos para completar el minuto", 60 - segundos);

            Console.Read();
        }
    }
}
