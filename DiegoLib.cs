/*	Libreria de Diego

	Instrucciones:
	Copiar el archivo DiegoLib.dll en la misma carpeta que el .cs al que importaremos
	$ mcs -t:library DiegoLib.cs	//Comando para compilar
	En el .cs importar con el comando: using static DiegoLib.Basics;

	Basics (8 funciones):
		> getInt( [""] )
		> getByte( [""] )
		> getDecimal( [""] )
		> getDouble( [""] )
		> getFloat( [""] )
		> getLong( [""] )
		> getShort( [""] )
		> printd( texto [, repeticion] [, separador] )
*/

namespace DiegoLib
{
	public class Basics
	{
		//------------------------------------------------------//
		public static int getInt( string text = "default" )
		{
			try
			{
				if (text == "default") {					
					System.Console.Write("Ingresa un número (int): ");
				}		
				else {
					System.Console.Write(text);
				}
				int x = int.Parse(System.Console.ReadLine());
				return x;
			}
			catch
			{
				return getInt(text);
			}
		}
		
		//------------------------------------------------------//
		public static byte getByte( string text = "default" )
		{
			try
			{
				if (text == "default") {		
					System.Console.Write("Ingresa un número (byte): ");
				}
				
				else {
					System.Console.Write(text);
				}
				byte x = byte.Parse(System.Console.ReadLine());
				return x;
			}
			catch
			{
				return getByte(text);
			}
		}
		
		//------------------------------------------------------//
		public static decimal getDecimal( string text = "default" )
		{
			try
			{
				if (text == "default") {		
					System.Console.Write("Ingresa un número (decimal): ");
				}	
				else {
					System.Console.Write(text);
				}
				decimal x = decimal.Parse(System.Console.ReadLine());
				return x;
			}
			catch
			{
				return getDecimal(text);
			}
		}
		
		//------------------------------------------------------//
		public static double getDouble( string text = "default" )
		{
			try
			{
				if (text == "default") {		
					System.Console.Write("Ingresa un número (double): ");
				}	
				else {
					System.Console.Write(text);
				}
				double x = double.Parse(System.Console.ReadLine());
				return x;
			}
			catch
			{
				return getDouble(text);
			}
		}
		
		//------------------------------------------------------//
		public static float getFloat( string text = "default" )
		{
			try
			{
				if (text == "default") {		
					System.Console.Write("Ingresa un número (float): ");
				}	
				else {
					System.Console.Write(text);
				}
				float x = float.Parse(System.Console.ReadLine());
				return x;
			}
			catch
			{
				return getFloat(text);
			}
		}
		
		//------------------------------------------------------//
		public static long getLong( string text = "default" )
		{
			try
			{
				if (text == "default") {		
					System.Console.Write("Ingresa un número (long): ");
				}	
				else {
					System.Console.Write(text);
				}
				long x = long.Parse(System.Console.ReadLine());
				return x;
			}
			catch
			{
				return getLong(text);
			}
		}
		
		//------------------------------------------------------//
		public static short getShort( string text = "default" )
		{
			try
			{
				if (text == "default") {		
					System.Console.Write("Ingresa un número (short): ");
				}
				else {
					System.Console.Write(text);
				}
				short x = short.Parse(System.Console.ReadLine());
				return x;
			}
			catch
			{
				return getShort(text);
			}
		}
		
		//------------------------------------------------------//
		public static void printd( string s, int num = 1 )
		{
			for (int i = 0; i < num; i++)
			{
					System.Console.Write(s);
			}
		}
		
		//------------------------------------------------------//
		public static string getString( string text = "default" )
		{
			try
			{
				if (text == "default") {		
					System.Console.Write("Ingresa un texto: ");
				}
				else {
					System.Console.Write(text);
				}
				string x = System.Console.ReadLine();
				return x;
			}
			catch
			{
				return getString(text);
			}
		}
		
	}	// Final de Basics
	
}



/*

--- Versión 1.0  -------------------------------------------------------
	
	Incluye 8 funciones
	> getInt( [""] )
	> getByte( [""] )
	> getDecimal( [""] )
	> getDouble( [""] )
	> getFloat( [""] )
	> getLong( [""] )
	> getShort( [""] )
	> printd(texto [, repeticiones] [, separador] )
	
	Ahorran lineas de código
	Evitan los errores de introducción de letras
	Evitan errores de tamaño mayor al posible
	Evita que termine tu programa inespreadamente
	
	Instrucciones de uso:
	1) Copiar el archivo en la misma carpeta que el archivo con el que lo queremos usar.
	2) Importar al archivo (exemplo.cs) en el que estamos trabajando, usando la linea de código siguiente:
	      using static DiegoLib.Basics;
	3) Listo! Disfruta de las funciones. Ejemplo:
	      int x = getInt();
	
	Función extra:
	Mandando texto como parámetro podemos indicar que no se imprima la linea default para pedir el número, ejemplo:
	x int = getInt("Dame un número: ")	//Imprime la linea dame un número y espera input
	x int = getInt()	//Imprime la linea "Ingresa un número (int): " y espera un input
	
*/