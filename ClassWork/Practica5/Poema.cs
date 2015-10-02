using System;
using System.IO;
using System.Linq;
using System.Threading;
using DiegoLib;

class Poema
{
	public static void Main (string[] args)
	{
		StreamReader file = File.OpenText (@"C:\Users\DiegoSaid\OneDrive\Universidad\Primer Semestre\Programacion\C#\ClassWork\Practica5\poem.txt");
		string poem = file.ReadToEnd ();
		string[] words = poem.Split ('\n', ' ', ',', '.');
		Console.BackgroundColor = ConsoleColor.Black;

		foreach (var w in words) {
			if (w.Trim().Length == 0) {
				Console.Clear ();
				continue;
			}

			// IMPRIMIMOS LOS ESPACIOS
			Console.ForegroundColor = ConsoleColor.White;
			Basics.printd ("\n", Console.WindowHeight/2 - 1);
			Basics.printd (" ", Console.WindowWidth/2 - w.Length/2);

			// PARTE INICIAL
			if (w.Trim().Length % 2 == 0) {
				Basics.printd (w.Substring(0, w.Trim().Length/2-1));
			} else {
				Basics.printd (w.Substring (0, w.Trim().Length / 2));
			}

			// PARTE CENTRAL
			Console.ForegroundColor = ConsoleColor.Red;
			if (w.Trim().Length % 2 == 0) {
				Basics.printd (w.Substring(w.Trim().Length/2-1, 2));
			} else {
				Basics.printd (w.Substring(w.Trim().Length/2, 1));
			}
			Console.ForegroundColor = ConsoleColor.White;

			// ÚLTIMA PARTE
			if (w.Trim().Length % 2 == 0) {
				Basics.printd (w.Substring(w.Trim().Length/2+1, w.Trim().Length/2-1));
			} else {
				Basics.printd (w.Substring(w.Trim().Length/2+1, w.Trim().Length/2));
			}

			// IMPRIMIMOS LOS ESPACIOS
			Basics.printd (" ", Console.WindowWidth/2 - w.Length/2);
			Basics.printd ("\n", Console.WindowHeight/2 - 1);

			Thread.Sleep (800);
			Console.Clear ();
		}

		Console.Read ();
	}
}
