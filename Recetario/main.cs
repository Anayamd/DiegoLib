using System;
using System.IO;

class main
{
	public static void Main()
	{
		StreamWriter writeFile = new StreamWriter("test.txt");
		writeFile.WriteLine("Diego es guapisimo");
		writeFile.WriteLine("\nAtte: Diego");
		
		Console.Write("Ingresa un producto: ");
		string s = Console.ReadLine();
		string [] productList = new string [5];
		productList[0] = "huevos";
		productList[1] = "leche";
		productList[2] = "queso";
		productList[3] = "pan";
		productList[4] = "crema";
		
		foreach (string product in productList)
		{
			if (s in product.ToLower()){
				Console.WriteLine(product + " :)");
				writeFile.Write("\n" + product);
			}
			else
			{
				Console.WriteLine(product);
			}
		}
		
		writeFile.Close();
		Console.Read();
	}
}