using System;
using static Diego.Basics;

class test1
{
	public static void Main()
	{
		System.Console.Write("Escribe tu edad: ");
		int i = getInt();
		int ii = getInt(1);
		byte b = getByte(1);
		decimal dec = getDecimal(1);
		double d = getDouble(1);
		float f = getFloat(1);
		long l = getLong(1);
		short s = getShort(1);
		Console.WriteLine("\nint={0}, byte={1}, decimal={2}, double={3}, float={4}, long={5}, short={6}", i, b, dec, d, f, l, s);
		Console.Read();
	}
}