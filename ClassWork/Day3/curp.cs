using System;
using static DiegoLib.Basics;

class curp
{
	public static void Main()
	{
		Console.Clear();
		
		int numVocales = 0;
		
		string nombreCompleto = getString("Ingrese su nombre completo, inicie con su nombre: ");
		string [] nomSeparado = nombreCompleto.Split(' ');
		string fecha = getString("Fecha de nacimiento (dd/mm/aa): ");
		string [] fechaSeparado = fecha.Split('/');
		
		string curp = nomSeparado[1].Substring(0,2) + nomSeparado[2].Substring(0,1) + nomSeparado[0].Substring(0,1);
		curp = curp + fechaSeparado[0] + fechaSeparado[1] + fechaSeparado[2];
		curp = curp.ToUpper();
		
		Console.WriteLine("\nTu curp es: {0}", curp);
		
		foreach (char letra in nombreCompleto.ToLower())
		{
			if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
			{
				numVocales += 1;
			}
		}
		
		Console.WriteLine("\n {0} contiene {1} vocales", nombreCompleto, numVocales);
	}
}