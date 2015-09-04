using System;
using DiegoLib;

class EjercicioPDF_1
{
	public static void Main()
	{
		Console.Clear();
		
		int contador = 0;
		string frase = Basics.getString("Ingrese una frase: ");
		Console.Write("Ingrese una letra para analizar en la frase: ");
		char c = char.Parse(Console.ReadLine());
		
		foreach (char letra in frase.ToLower())
		{
			if (letra == c)
			{
				contador += 1;
			}
		}
		
		Console.WriteLine("Se encontró la letra {0} {1} veces en la frase.", c, contador);	
		
		Console.Read();
		Console.Clear();
	}
}