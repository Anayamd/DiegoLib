using DiegoLib;
using System;
using System.Collections.Generic;
using System.Linq;

class Ejercicio18
{
	static void Main(string[] args)
	{
		/* USO DEL PROGRAMA */
		Random random = new Random();
		string[] _ESTADOS = {"AGUASCALIENTES", "BAJA CALIFORNIA", "BAJA CALIFORNIA SUR", "CAMPECHE", "COAHUILA", "COLIMA", "CHIAPAS", "CHIHUAHUA",
			"DF", "DURANGO", "GUANAJUATO", "GUERRERO", "HIDALGO", "JALISCO", "MÉXICO", "MICHOACÁN", "MORELOS", "NAYARIT", "NUEVO LEÓN", "OAXACA",
			"PUEBLA", "QUERÉTARO","QUINTANA ROO", "SAN LUIS POTOSÍ", "SINALOA", "SONORA", "TABASCO", "TAMAULIPAS", "TLAXCALA", "VERACRUZ", 
			"YUCATÁN", "ZACATECAS", "EXTRANJERO"};
		string[] _CLAVES = { "AS", "BC", "BS", "CC", "CL", "CM", "CS", "CH", "DF", "DG", "GT", "GR", "HG", "JC", "MC", "MN", "MS", "NT", "NL", "OC",
							"PL", "QT", "QR", "SP", "SL", "SR", "TC", "TS", "TL", "VZ", "YN", "ZS", "NE"};
		string[] _VOWELS = {"A", "E", "I", "O", "U"};
		string[] curp = new string[18];

		/* VARIABLES */
		string full;
		string[] nombres;
		string paterno;
		string materno;
		string fechaFull;
		string[] fecha;
		string gender;
		string[] estado = new string[2];

		/* OBTENEMOS INFORMACIÓN */
		do {
			full = Basics.getString ("Ingresa tu nombre: ");
			nombres = full.ToUpper().Split ();
		} while (nombres.Length < 3);

		do {
			fechaFull = Basics.getString("Fecha de nacimiento (dd/mm/aaaa): ");
			fecha = fechaFull.Split('/');
		} while (fecha.Length != 3 || fecha[2].Length != 4 || int.Parse(fecha[1]) > 12);

		do {
			gender = Basics.getString ("Género (H|M): ").ToUpper();
		} while (gender != "H" && gender != "M");

		Console.WriteLine ();

		foreach (string est in _ESTADOS) {
			Console.Write ( est[0] + est.Substring(1).ToLower() + " - ");
		}

		Console.WriteLine ("\n");

		do {
			estado[0] = Basics.getString("Estado de nacimiento: ").ToUpper();
		} while ( !_ESTADOS.Contains(estado[0]) );

		/* CREACIÓN DEL CURP */
		nombres = nombres.Where(val => val != "DE" && val != "LA" && val != "Y" && val != "VAN" && val != "MC").ToArray();
		//nombres = nombres.Where(val => val != "LA").ToArray();
		paterno = nombres [nombres.Length-2];
		materno = nombres [nombres.Length-1];

		// CHAR 0
		curp [0] = paterno [0]+"";

		// CHAR 1
		foreach (char c in paterno) {
			if (_VOWELS.Contains(c+"")) {
				curp [1] = c+"";
				break;
			}
		}

		// CHAR 2
		curp[2] = materno[0]+"";

		// CHAR 3
		curp[3] = nombres[0][0]+"";

		// CHAR 4
		curp[4] = fecha[2][2]+"";

		// CHAR 5
		curp[5] = fecha[2][3]+"";

		// CHAR 6
		curp[6] = fecha[1][0]+"";

		// CHAR 7
		curp[7] = fecha[1][1]+"";

		// CHAR 8
		curp[8] = fecha[0][0]+"";

		// CHAR 9
		curp[9] = fecha[0][1]+"";

		//CHAR 10
		curp[10] = gender;

		//CHAR 11
		estado[1] = _CLAVES[ Array.IndexOf(_ESTADOS, estado[0]) ];
		curp[11] = estado[1][0]+"";

		// CHAR 12
		curp[12] = estado[1][1]+"";

		// CHAR 13
		foreach (char c in paterno.Substring(1)) {
			if (!_VOWELS.Contains(c+"")) {
				curp [13] = c+"";
				break;
			}
		}

		// CHAR 14
		foreach (char c in materno.Substring(1)) {
			if (!_VOWELS.Contains(c+"")) {
				curp [14] = c+"";
				break;
			}
		}

		// CHAR 15
		foreach (char c in nombres[0].Substring(1)) {
			if (!_VOWELS.Contains(c+"")) {
				curp [15] = c+"";
				break;
			}
		}

		// CHAR 16
		if (int.Parse(fecha[2]) < 2000) {
			curp[16] = "0";
		} else {
			curp[16] = "A";
		}

		// CHAR 17
		curp[17] = "9";

		/* IMPRIMIMOS CURP */
		Console.WriteLine ();
		Basics.printd ("-", 70);
		Console.WriteLine ();
		Console.Write ("CURP : ");
		foreach (string c in curp) {
			Console.Write (c);
		}

		Console.Read();
	}
}

