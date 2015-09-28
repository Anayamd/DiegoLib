using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Ejercicio7
{
    static void Main(string[] args)
    {
        Console.WriteLine("Sueldo: ");
        int sueldo = int.Parse(Console.ReadLine());

        double descuento = 0;

        if (sueldo <= 1000)
        {
            descuento = .1;
        }
        else if (sueldo <= 2000)
        {
            descuento = .05;
        }
        else
        {
            descuento = .03 ;
        }

        Console.WriteLine("\nSueldo: {0}\nDescuento: {1}\nSueldo Neto: {2}", sueldo, descuento, sueldo-sueldo*descuento);

        Console.Read();
    }
}