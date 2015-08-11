/*	Libreria de Diego

	Instrucciones:
	Copiar el archivo DiegoLib.dll en la misma carpeta que el .cs al que importaremos
	$ mcs -t:library DiegoLib.cs	//Comando para compilar
	En el .cs importar con el comando: using static Diego.Basics;

	Basics (7 funciones):
		> getInt()
		> getByte()
		> getDecimal()
		> getDouble()
		> getFloat()
		> getLong()
		> getShort()
*/

namespace Diego
{
	public class Basics
	{
		//------------------------------------------------------//
		public static int getInt( int num = 0 )
		{
			try
			{
				if (num == 1) {					
					System.Console.Write("Ingresa un número (int): ");
				}			
				int x = int.Parse(System.Console.ReadLine());
				return x;
			}
			catch
			{
				if (num != 1) {					
					System.Console.Write("No permitido, intenta de nuevo: ");
				}
				return getInt(num);
			}
		}
		
		//------------------------------------------------------//
		public static byte getByte( int num = 0 )
		{
			try
			{
				if (num == 1) {		
					System.Console.Write("Ingresa un número (byte): ");
				}
				byte x = byte.Parse(System.Console.ReadLine());
				return x;
			}
			catch
			{
				if (num != 1) {					
					System.Console.Write("No permitido, intenta de nuevo: ");
				}
				return getByte(num);
			}
		}
		
		//------------------------------------------------------//
		public static decimal getDecimal( int num = 0 )
		{
			try
			{
				if (num == 1) {		
					System.Console.Write("Ingresa un número (decimal): ");
				}		
				decimal x = decimal.Parse(System.Console.ReadLine());
				return x;
			}
			catch
			{
				if (num != 1) {					
					System.Console.Write("No permitido, intenta de nuevo: ");
				}
				return getDecimal(num);
			}
		}
		
		//------------------------------------------------------//
		public static double getDouble( int num = 0 )
		{
			try
			{
				if (num == 1) {		
					System.Console.Write("Ingresa un número (double): ");
				}		
				double x = double.Parse(System.Console.ReadLine());
				return x;
			}
			catch
			{
				if (num != 1) {					
					System.Console.Write("No permitido, intenta de nuevo: ");
				}
				return getDouble(num);
			}
		}
		
		//------------------------------------------------------//
		public static float getFloat( int num = 0 )
		{
			try
			{
				if (num == 1) {		
					System.Console.Write("Ingresa un número (float): ");
				}		
				float x = float.Parse(System.Console.ReadLine());
				return x;
			}
			catch
			{
				if (num != 1) {					
					System.Console.Write("No permitido, intenta de nuevo: ");
				}
				return getFloat(num);
			}
		}
		
		//------------------------------------------------------//
		public static long getLong( int num = 0 )
		{
			try
			{
				if (num == 1) {		
					System.Console.Write("Ingresa un número (long): ");
				}		
				long x = long.Parse(System.Console.ReadLine());
				return x;
			}
			catch
			{
				if (num != 1) {					
					System.Console.Write("No permitido, intenta de nuevo: ");
				}
				return getLong(num);
			}
		}
		
		//------------------------------------------------------//
		public static short getShort( int num = 0 )
		{
			try
			{
				if (num == 1) {		
					System.Console.Write("Ingresa un número (short): ");
				}		
				short x = short.Parse(System.Console.ReadLine());
				return x;
			}
			catch
			{
				if (num != 1) {					
					System.Console.Write("No permitido, intenta de nuevo: ");
				}
				return getShort(num);
			}
		}
		
	}
}



/*

--- Versión 1.0  -------------------------------------------------------
	
	Incluye 7 funciones
	> getInt()
	> getByte()
	> getDecimal()
	> getDouble()
	> getFloat()
	> getLong()
	> getShort()
	
	Ahorran lineas de código
	Evitan los errores de introducción de letras
	Evitan errores de tamaño mayor al posible
	Evita que termine tu programa inespreadamente
	
	Instrucciones de uso:
	1) Copiar el archivo en la misma carpeta que el archivo con el que lo queremos usar.
	2) Importar al archivo (exemplo.cs) en el que estamos trabajando, usando la linea de código siguiente:
	      using static Diego.Basics;
	3) Listo! Disfruta de las funciones. Ejemplo:
	      int x = getInt();
	
	Función extra:
	Mandando el número 1 como parámetro podemos indicar que se imprima la linea default para pedir el número, ejemplo:
	x int = getInt()	//No imprime nada, solo espera un input
	x int = getInt(1)	//Imprime la linea "Ingresa un número (int): " y espera un input
	
*/