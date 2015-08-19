using System;

class number_3
{
	public static void Main()
	{
		for (int i=0; i < 5; i++){
			
			for (int x = 5; x > i; x--)
			{
				Console.Write("1");
			}
			Console.WriteLine();
		}
		//FIN del programa
		Console.Read();
	}
}