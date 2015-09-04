using System;
using System.Linq;
using DiegoLib;

class EjercicioPDF_6
{
	public static void Main()
	{
		string frase = Basics.getString("Ingrese una frase: ");

		for (int i = 0; i < frase.Length ; i++) {
			if (i%2 == 0) {
				Console.Write (char.ToLower(frase[i]));
			} else {
				Console.Write (char.ToUpper(frase[i]));
			}
		}

		Console.Read();
	}
}

