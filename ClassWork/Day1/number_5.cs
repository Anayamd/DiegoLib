using System;

class number_2
{
	public static void Main()
	{
		for (int i=0; i < 5; i++)
		{	
			for (int x=0; x <= i; x++)
			{
				Console.Write("{0}",x+1);
			}
			Console.WriteLine();
		}
		
		//FIN del programa
		Console.Read();
	}
}