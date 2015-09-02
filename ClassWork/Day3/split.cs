using System;

class Day3
{
	public static void Main()
	{
		Console.Clear();
		string texto = "Este es un texto de prueba, este es un segundo elemento";
		Console.WriteLine(texto + "\n");
		string [] palabras = texto.Split(' ', ',');
		
		for (int i = 0; i < palabras.Length; i++)
		{
			Console.WriteLine(palabras[i]);
		}
		
		System.Console.WriteLine("\n" + texto.Substring(0,6));
		System.Console.WriteLine("\n" + texto.Substring(texto.Length - 2, 2));	//Substring(PosInicial, Pasos);
		Console.Read();
		Console.Clear();
	}
}