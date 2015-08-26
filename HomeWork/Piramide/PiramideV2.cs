using System;
using static DiegoLib.Basics;

class Piramide
{
	public static void Main()
	{
		/*
		/	Este programa crea un Piramide		  *
		/										 ***
		/										*****
		*/
		
		int bPiramid = (int) getByte("Tamaño base de la pirámide: ");
		int hPiramid = (bPiramid + 1) / 2;
		int temp;
		
		Console.WriteLine();
		
		// Imprimimos la Piramide
		for (int i = 0; i < hPiramid; i++)
		{
			// Num de "*" a imprimir
			temp = i * 2 + 1;
			
			// Espacios
			printd( "   ", (bPiramid-temp)/2 );
			
			// Piramide
			printd( " * ", temp );
			
			//Espacios
			printd( "   ", (bPiramid-temp)/2 );
			
			Console.WriteLine();			
		}
		
		// Imprimimos los números
		Console.WriteLine();
		for (int i = 0; i < bPiramid; i++)
		{
			Console.Write(" {0} ", ((i+1)%10));
		}
		Console.WriteLine();
		
		//Esperamos una tecla para cerar
		Console.Read();
	}
}