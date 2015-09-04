using System;
using System.Linq;
using DiegoLib;

class EjercicioPDF_2
{
	public static void Main()
	{
		Console.Clear();
		
		string frase = Basics.getString("Ingrese una frase: ");
		
		frase = frase.ToLower().Replace("a", "4").Replace("e", "3").Replace("i", "1").Replace("o", "0").Replace("u", "5");
		Console.WriteLine(frase);	
		
		Console.Read();
		Console.Clear();
	}
}