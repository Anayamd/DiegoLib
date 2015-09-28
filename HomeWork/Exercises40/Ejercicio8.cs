using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Ejercicio8
{
    static void Main(string[] args)
    {
        Console.WriteLine("Monto: ");
        int sueldo = int.Parse(Console.ReadLine());

        double descuento = 0;

        if (sueldo > 100)
        {
            descuento = .1;
        }
        else
        {
            descuento = .02;
        }

        Console.WriteLine("\nMonto: {0}\nDescuento: {1}\nMonto Neto: {2}", sueldo, descuento, sueldo - sueldo * descuento);

        Console.Read();
    }
}