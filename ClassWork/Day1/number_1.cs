using System;

class number_1
{
	public static void Main()
	{
		int x=0;
		
		for (int i=0; i < 10; i++){
			Console.Write("1");
		}
		
		Console.WriteLine();
		
		do{
			Console.Write("1");
			x++;			
		}
		while(x<10);
		
		Console.WriteLine();
		
		while(x>0){
			Console.Write("1");
			x--;			
		}
		//FIN del programa
		Console.Read();
	}
}