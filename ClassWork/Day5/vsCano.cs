using System;
using DiegoLib;

class lol
{
	public static void Main (string[] args)
	{
		int num1 = Basics.getInt ("Ingresa el primer número: ");
		int num2 = Basics.getInt ("Ingresa el segundo número: ");

		if (num1 > num2) {
			int temp = num2;
			num2 = num1;
			num1 = temp;
		}

		for (int i = num1; i <= num2; i++) {
			if (i%10 == 4) {
				Console.WriteLine (i);
			}
		}

		Console.Read ();
	}
}
