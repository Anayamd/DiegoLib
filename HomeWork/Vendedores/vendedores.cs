/* Programa para n vendedores y su monto de ventas del mes. Si el vendedor vende menos de 500 se lleva el .5% de comisión
// Mayor o igual a 500 pero menor a 1000 = 1%
// Mayor o igual a 1000 pero menor a 1500 = 2%
// Mayor o igual a 1500 = 2.5%
*/

using System;
using static DiegoLib.Basics;

class vendedores
{
	public static void Main()
	{
		Console.Clear();
		int x;
		do
		{
			x = getInt("Ingresa el número de vendedores: ");
		} while (x<1);
		printd("\n");
		string [] vendedores = new string [x];
		double [,] montoComision = new double[2,x];
		
		for (int i = 0; i < x; i++)
		{
			vendedores[i] = getString("Ingresa el vendedor " + (i+1) + ": ");
			montoComision[0,i] = getDouble("Monto del vendedor " + vendedores[i] + ": ");
			printd("\n");
		}
		
		Console.WriteLine();
		printd("#", 70);
		printd("\n");
		Console.WriteLine();
		
		for (int i = 0; i < x; i++)
		{
			if (montoComision[0,i] < 500){
				montoComision[1,i] = .005;
			}
			else if (montoComision[0,i] >= 500 && montoComision[0,i] < 1000)
			{
				montoComision[1,i] = .01;
			}
			else if (montoComision[0,i] >= 1000 && montoComision[0,i] < 1500)
			{
				montoComision[1,i] = .015;
			}
			else
			{
				montoComision[1,i] = .025;
			}
			Console.WriteLine( "Monto de {0,-7}: {1,-5}\tComisión: {2,3:0.00}\tGanancia: {3,7:0.00}", vendedores[i], montoComision[0,i], montoComision[1,i], montoComision[0,i] * montoComision[1,i]);
		}
		printd("\n");
		printd("#", 70);
		
		Console.Read();
	}
}