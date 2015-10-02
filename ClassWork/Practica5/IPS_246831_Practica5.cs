using System;
using System.IO;
using System.Linq;
using DiegoLib;

class IPS_246831_Practica5
{
	public static void Main (string[] args)
	{
		StreamWriter write = File.AppendText (@"C:\Users\DiegoSaid\OneDrive\Universidad\Primer Semestre\Programacion\C#\ClassWork\Practica5\practica5.txt");
		string opción = "no";

		do {
			string nombre = Basics.getString ("Ingresa el nombre: ");
			write.WriteLine(nombre);

			byte edad = Basics.getByte("Ingresa la edad: ");
			write.WriteLine(edad);

			opción = Basics.getString ("Deseas ingresar otro dato?: ").ToLower();
			Console.WriteLine ();

		} while ((opción.Contains("s") || opción.Contains("y")) && !opción.Contains("n"));

		write.Close ();

		Console.Clear ();

		StreamReader read = File.OpenText (@"C:\Users\DiegoSaid\OneDrive\Universidad\Primer Semestre\Programacion\C#\ClassWork\Practica5\practica5.txt");
		string content = read.ReadToEnd ();
		string find = Basics.getString ("Ingresa el nombre a buscar: ").ToLower();
		string[] elements = content.Split ('\n');
		int pos = -1;

		for (int i = 0; i < elements.Length; i+=2) {
			if (find == elements[i].Trim().ToLower()) {
				pos = i;
				break;
			}
		}

		if (pos != 1) {
			Console.WriteLine ("\n{0}: edad {1}", find, elements[pos+1]);
		}

		Console.Read ();
	}
}