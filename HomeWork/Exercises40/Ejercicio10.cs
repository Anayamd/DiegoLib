using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenExercises
{
    class Ejercicio10
    {
        static void Main(string[] args)
        {
            Console.Write("Minutos: ");
            int minutos = int.Parse(Console.ReadLine());
            int horas = 0;
            int dias = 0;

            while (minutos > 1440)
            {
                minutos -= 1440;
                dias++;
            }

            while (minutos > 60)
            {
                minutos -= 60;
                horas++;
            }

            Console.WriteLine("\nDías: {0}\nHoras: {1}\nMinutos: {2}", dias, horas, minutos);

            Console.Read();
        }
    }
}
