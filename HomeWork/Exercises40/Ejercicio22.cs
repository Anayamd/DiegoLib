using DiegoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Ejercicio22
{
	public static bool narcissistic(string digits)
	{
		double sum = 0;
		for (int i = 0; i < digits.Length; i++) {
			sum += Math.Pow(Convert.ToDouble(digits [i]+""), digits.Length);
		}
		if (Convert.ToInt32 (digits) == sum) {
			return true;
		}
		return false;
	}

	static void Main(string[] args)
	{
		//int[] narcissistNums = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 153, 370, 371, 407, 1634, 8208, 9474 };

		int num;
		string digits;

		do {
			num =Basics.getInt("Ingresa un número: ");
		} while (num<0 || num>10000);

		digits = num + "";

		Console.WriteLine ("\n{0} es un número narcisista = {1}", num, narcissistic(digits));

		Console.Read ();
	}
}

