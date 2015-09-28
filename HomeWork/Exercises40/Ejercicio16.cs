using DiegoLib;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Ejercicio16
{
	static void Main(string[] args)
	{
		double _IVA = 1.15;
		double _DESC = .02;
		double subtotal;
		double final;

		double precio = Basics.getDouble ("Precio del artículo: ");
		int unidades;

		do {
			unidades = Basics.getInt ("Número de unidades: ");
		} while (unidades < 0);

		subtotal = precio * unidades * _IVA;
		final = subtotal;

		if (final > 100) {
			final = final - final * _DESC;
		}

		Console.WriteLine ("\n----------------------------------\n");
		Console.WriteLine ("Unidades:\t\t{0,5}\nPrecio Unitario:\t{1,5}\nValor de venta:\t\t{2,5}\nSubtotal:\t\t{3,5}\nTotal:\t\t\t{4,5}", unidades, precio, precio*unidades, subtotal, final);

		Console.Read();
	}
}

