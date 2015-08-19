using System;
using static DiegoLib.Basics;

class test1
{
	public static void Main()
	{
		byte menorCien;
		
		int i = getInt("Escribe tu edad: ");
		byte b = getByte();
		decimal dec = getDecimal();
		double d = getDouble();
		float f = getFloat();
		long l = getLong();
		short s = getShort();
		
		do
		{
			menorCien = getByte("Escribe un número entre 0 y 100: ");
		} while (menorCien < 0 || menorCien > 100);
		
		Console.WriteLine("\nint={0}, byte={1}, decimal={2}, double={3}, float={4}, long={5}, short={6}", i, b, dec, d, f, l, s);
		printd(menorCien + " ", 5);
		Console.Read();
	}
}