using System;
using DiegoLib;

class TablaMultiplicar
{
	public static void Main (string[] args)
	{
		for (int i = 0; i < 11; i++) {
			Console.WriteLine ("5 * {0,2} = {1,3}", i, 5*i);
		}

		Console.Read ();
	}
}

