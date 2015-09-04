using System;
using System.Linq;
using DiegoLib;

class EjercicioPDF_3
{
	public static void Main()
	{
		Console.Clear();
		
		string frase = Basics.getString("Ingrese una frase: ");
		
		for (int i = 0; i < frase.Length; i++)
		{
			if ( (i%2) != 0 )
			{
				Console.Write("0");
			}
			else
			{
				Console.Write(frase.Substring(i, 1) );
			}
		}

		Console.Read();
		Console.Clear();
	}
}