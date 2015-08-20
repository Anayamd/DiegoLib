using System;
using System.Linq;
using System.IO;

class main
{

	public static void Main()
	{
		// Current path 
		string appPath = Directory.GetCurrentDirectory(); 		
		
		// Obtenemos 5 ingredientes
		string [] listaIngredientes = new string [5];
		for (int i = 0; i < 5; i++)
		{
			do
			{
				Console.Write("Ingresa el ingrediente {0}: ", i+1);
				listaIngredientes[i] = Console.ReadLine();
				listaIngredientes[i] = listaIngredientes[i].ToLower();
			}
			while (listaIngredientes[i] == "");
			if (listaIngredientes[i] == "exit" || listaIngredientes[i] == "quit" || listaIngredientes[i] == "bye")
			{
				break;
			}
		}
		
		// Contamos archivos .txt
		int numRecetas = Directory.EnumerateFiles(appPath, "*.txt").Count<string>();
		Console.WriteLine("\nNúmero de recetas: {0}\n", numRecetas);
				
		// Lista con nombre de las recetas
		string [] listaRecetas = new string [numRecetas];
		
		// Lista con coincidencias para cada receta
		int [] coincidencias = new int[numRecetas];
		for (int i = 0; i < numRecetas; i++)
		{
			coincidencias[i] = 0;
		}
		
		// Para cada receta
		int j = 0;
		foreach (string receta in Directory.EnumerateFiles(appPath, "*.txt"))
		{
			// Nombre del archivo con la receta
			string filename = Path.GetFileName(receta);
			listaRecetas[j] = filename;
			Console.WriteLine("------------------------\n"+listaRecetas[j]+"\n------------------------");
			
			// Leemos contenido
			string contents = File.ReadAllText(receta);
			
			// Buscamos si algún ingrediente dado esta en el archivo actual
			foreach (string ingrediente in listaIngredientes)
			{
				coincidencias[j] += findInFile(ingrediente, contents);		
			}
			
			Console.WriteLine();
			j++;
		}
		
		Console.WriteLine("\n============================================");
		
		// Imprimimos el nombre de la receta y su número de coincidencias
		for (int i = 0; i < numRecetas; i++)
		{
			Console.WriteLine("Receta: {0,8}\tCoincidencias: {1,-3:#0}", listaRecetas[i].Remove(listaRecetas[i].Length - 4), coincidencias[i]);
		}
		
		// FIN
		Console.Read();
	}
	
	public static int findInFile(string s, string textoReceta)
	{
		if (textoReceta.ToLower().Contains(s)) {
			Console.WriteLine(s);
			return 1;
		}
		return 0;
	}
	
}