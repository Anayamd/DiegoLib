using System;
using DiegoLib;

class Ejercicio3
{
	public static bool isPrime(int n)
	{
		if (n<2) {
			return false;
		}
		if (n == 2) {
			return true;
		}
		for (int i = 2; i <= n/2 + 1; i++) {
			if (n%i == 0) {
				return false;
			}
		}
		return true;
	}

	public static void Main (string[] args)
	{
		int num = Basics.getInt("Ingrese un número: ");
		bool respuesta = isPrime (num);

		if (respuesta) {
			Console.WriteLine ("\n{0} si es primo! :D", num);
		} else {
			Console.WriteLine ("\n{0} NO es primo...", num);
		}
		Console.WriteLine ();
	}
}