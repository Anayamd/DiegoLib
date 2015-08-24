using System;
using System.Linq;
using System.IO;

class main
{

	public static void Main()
	{
		Console.WriteLine("\n========================= Recetario =========================\n");
		
		string [] finRecopilarInfo = { "exit", "quit", "bye", "listo", "ya", "nos vemos", "chao" };
		
		// Current path 
		string appPath = Directory.GetCurrentDirectory(); 		
		
		// Obtenemos 5 ingredientes
		string [] listaIngredientes = new string [5];
		for (int i = 0; i < 5; i++)
		{
			do
			{
				Console.Write("Ingresa el ingrediente {0}:  ", i+1);
				listaIngredientes[i] = Console.ReadLine();
				listaIngredientes[i] = listaIngredientes[i].ToLower();
			}
			while (listaIngredientes[i] == "");
			if (finRecopilarInfo.Contains(listaIngredientes[i]))
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
				if (ingrediente == null || finRecopilarInfo.Contains(ingrediente))
				{
					break;
				}
				coincidencias[j] += findInFile(ingrediente, contents);		
			}
			
			Console.WriteLine();
			j++;
		}
		
		Console.WriteLine("\n********* Recomendación ******************************************");
		
		// Sorteamos las recetas
		Array.Sort( coincidencias, listaRecetas );
		
		// Imprimimos 5 recetas orden descendiente
		for (int i = 5; i >= 0; i--)
		{
			if (coincidencias[i] > 0)
			{
				Console.WriteLine("Receta: {0,-20}Coincidencias: {1,-3:#0}", listaRecetas[i].Remove(listaRecetas[i].Length - 4), coincidencias[i]);
			}
			else
			{
				break;
			}
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