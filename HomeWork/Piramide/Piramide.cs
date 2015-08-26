using System;

class Piramide
{
	public static void Main()
	{
		/*
		/	Este programa crea un Piramide		  *
		/										 ***
		/										*****
		*/
		
		Console.Write("Ingresa un número: ");
		
		int bPiramid = int.Parse(Console.ReadLine());
		int hPiramid = (bPiramid + 1) / 2;
		int temp;
		
		Console.WriteLine();
		
		// Imprimimos la Piramide
		for (int i = 0; i < hPiramid; i++)
		{
			// Num de "*" a imprimir
			temp = i * 2 + 1;
			
			// Espacios
			for (int x = 0; x < (bPiramid-temp)/2; x++)
			{				
				Console.Write("   ");
			}
			
			// Piramide
			for (int x = 0; x < temp; x++)
			{
				Console.Write(" * ");
			}
			
			//Espacios
			for (int x = 0; x < (bPiramid-temp)/2; x++)
			{
				Console.Write("   ");				
			}
			
			Console.WriteLine();			
		}
		
		// Imprimimos los números
		Console.WriteLine();
		for (int i = 0; i < bPiramid; i++)
		{
			Console.Write(" {0} ", ((i+1)%10));
		}
		Console.WriteLine();
		
		Console.Read();
	}
}