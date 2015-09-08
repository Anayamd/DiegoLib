using System;
using DiegoLib;

class EsPrimo
{
	public static bool isPrime (int n)
	{
		if (n<2) {
			return false;
		}
		if (n == 2) {
			return true;
		}
		for (int i = 2; i < Math.Sqrt(n)+1; i++) {
			if (n%i == 0) {
				return false;
			}
		}
		return true;
	}
	public static void Main (string[] args)
	{
		int num = Basics.getInt ("Ingresa un número: ");
		if (isPrime(num)) {
			Console.WriteLine ("\nEl número: {0} es primo\n", num);
		} else {
			Console.WriteLine ("\nEl número: {0} NO es primo\n", num);
		}
	}
}
