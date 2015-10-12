using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
using DiegoLib;


/* ----------------------------------------------------
 * CLASE RECETA
 * ---------------------------------------------------- */
public class Receta
{
    /* ---------- Propiedades de clase ---------- */
    private string[] finRecopilarInfo = { "exit", "quit", "bye", "listo", "ya", "nos vemos", "chao", "salir" };
    private string nombre = "";
	private string[] Ingredientes = new string[10];
	private string descripcion = "";

	/* ---------- CONSTRUCTOR ---------- */
		public Receta (string título, string[] listado, string pasos)
	{
		nombre = título.Trim().ToUpper();
		Ingredientes = listado;
		descripcion = pasos.Trim();
		saveInDisk ();
	}

	/* ---------- MÉTODOS de clase ---------- */
	/* -------------------------------------- */
	public void imprimir()
	{
		int i = 0;
		Console.WriteLine (nombre + "\n");
		foreach (var ing in Ingredientes) {
			Console.WriteLine ("Ingrediente {0}: {1}", ++i, ing);
		}
		Console.WriteLine ("\nInstrucciones\n"+descripcion);
	}

	public void saveInDisk()
	{
		StreamWriter escrituraIndividual = File.CreateText(@"C:\Recetario\" + this.nombreReceta() + ".txt");
		escrituraIndividual.Write ("{0}\n\n", this.nombre);
		foreach (var ing in this.Ingredientes) {
			escrituraIndividual.WriteLine (ing);
		}
		escrituraIndividual.Write ("\n\n"+this.descripcion);
		escrituraIndividual.Close ();
	}

	public string nombreReceta()
	{
		return nombre;
	}

    public void eliminar()
    {
        File.Delete(@"C:\Recetario\" + this.nombreReceta() + ".txt");
    }

    public void menuCambios()
    {
        string[] opciones = { "1", "2", "3", "4", "título", "ingredientes", "descripción", "cancelar" };

        Console.Clear();
        string title = "CAMBIOS EN: " + this.nombreReceta();

        Basics.printd(" ", Console.WindowWidth / 2 - title.Length / 2);
        Console.WriteLine(title);
        Basics.printd(" ", Console.WindowWidth / 2 - title.Length / 2);
        Console.WriteLine();

        Console.WriteLine("1) Título");
        Console.WriteLine("2) Ingredientes");
        Console.WriteLine("3) Descripción");
        Console.WriteLine("4) Cancelar");

        string cambiar;
        do
        {
            cambiar = Basics.getString("\nIngresa la opción: ").ToLower();
        } while (!opciones.Contains(cambiar));
        Console.Clear();

        if (cambiar == "4" || cambiar == "cancelar")
        {
            return;
        }

        if (cambiar == "1" || cambiar == "título")
        {
            nombre = Basics.getString("Nuevo título: ").ToUpper();
        }

        if (cambiar == "2" || cambiar == "ingredientes")
        {
            string[] tempIng = new string[6];
            tempIng[5] = null;
            for (int i = 0; i < 5; i++)
            {
            pedir: tempIng[i] = Basics.getString("Ingrediente " + (i + 1) + ": ");
                if (finRecopilarInfo.Contains(tempIng[i]))
                {
                    if (i == 0)
                    {
                        goto pedir;
                    }
                    tempIng[i] = null;
                    break;
                }
            }
            tempIng = tempIng.Take(Array.IndexOf(tempIng, null)).ToArray();
            Ingredientes = tempIng;
        }

        if (cambiar == "3" || cambiar == "descripción")
        {
            descripcion = Basics.getString("Nueva descripción: ");
        }

        this.eliminar();
        this.saveInDisk();
    }
};


/* ----------------------------------------------------
 * CLASE LIBRO
 * ---------------------------------------------------- */
public class Libro
{
	/* ---------- Propiedades de clase ---------- */
	private string[] finRecopilarInfo = { "exit", "quit", "bye", "listo", "ya", "nos vemos", "chao", "salir" };
	private int count = 0;
	private Receta[] listaRecetas = new Receta[1000];

	/* ---------- CONSTRUCTOR ---------- */
	public Libro (){
		foreach (string receta in Directory.EnumerateFiles(@"C:\Recetario\", "*.txt")) {
			string all = File.ReadAllText(receta);
			string[] contents = Regex.Split (all.Trim(), @"(?:\n){2,}");
			string nombre = contents [0];
			string[] ingredientes = contents [1].Split('\n');
			string pasos = contents [2];
			guardar (nombre, ingredientes, pasos);
		}
	}

	/* ---------- MÉTODOS de clase ---------- */
	/* -------------------------------------- */
	private bool existeTitulo(string t)
	{
		for (int i = 0; i < count; i++) {
			if (listaRecetas[i].nombreReceta() == t.ToUpper()) {
				return true;
			}
		}
		return false;
	}

    private Receta recetaPosicion(string t)
    {
        for (int i = 0; i < count; i++)
        {
            if (listaRecetas[i].nombreReceta() == t.ToUpper())
            {
                return listaRecetas[i];
            }
        }
        return listaRecetas[1000];
    }

    public void guardar(string título, string[] listado, string pasos)
	{
		listaRecetas[count] = new Receta(título, listado, pasos);
		count++;
	}

	public void crearReceta()
	{
		Console.Clear ();
		string título;

		do {
			título = Basics.getString("Título de la receta: ");
		} while (existeTitulo(título));

		Console.WriteLine ();
		string[] ingredientes = new string[6];
        ingredientes[5] = null;
		for (int i = 0; i < 5; i++) {
			pedir: ingredientes[i] = Basics.getString ("Ingrediente " + (i+1) + ": ");
			if (finRecopilarInfo.Contains(ingredientes[i])) {
                if (i == 0)
                {
                    goto pedir;
                }
				ingredientes [i] = null;
				break;
			}
		}
		Console.WriteLine ();
		string pasos = Basics.getString ("Instrucciones\n");
		ingredientes = ingredientes.Take (Array.IndexOf(ingredientes, null)).ToArray();
		guardar (título, ingredientes, pasos);
	}

	public void imprimeNombres()
	{
		Console.Clear ();
		for (int i = 0; i < count; i++) {
			Console.WriteLine ("{0}) {1}", i+1, listaRecetas[i].nombreReceta());
		}
		Basics.printd ("-", 70);
		string action = Basics.getString ("\nIngresa el número de receta o salir: ");
		if (finRecopilarInfo.Contains(action)) {
			return;
		}
		try {
			Console.Clear ();
			listaRecetas[int.Parse(action)-1].imprimir();
			Console.ReadLine();
		} catch (Exception) {
			imprimeNombres ();
		}
	}

    public void eliminaReceta()
    {
        Console.Clear();
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("{0}) {1}", i + 1, listaRecetas[i].nombreReceta());
        }
        Basics.printd("-", 70);
        string action = Basics.getString("\nIngresa el número de receta o salir: ");
        if (finRecopilarInfo.Contains(action))
        {
            return;
        }
        try
        {
            Console.Clear();
            int pos = int.Parse(action) - 1;
            Receta[] izquierda = new Receta[500];
            Receta[] derecha = new Receta[500];
            Array.Copy(listaRecetas, izquierda, pos-1);
            Array.Copy(listaRecetas, derecha, pos+1);
            listaRecetas.Concat(izquierda).Concat(derecha).ToArray();
            listaRecetas[pos].eliminar();
            --count;
        }
        catch (Exception)
        {
            eliminaReceta();
        }
    }

    public void cambiosEnReceta()
    {
        Console.Clear();
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("{0}) {1}", i + 1, listaRecetas[i].nombreReceta());
        }
        Basics.printd("-", 70);
        string action = Basics.getString("\nIngresa el número de receta o salir: ");
        if (finRecopilarInfo.Contains(action))
        {
            return;
        }
        try
        {
            listaRecetas[int.Parse(action) - 1].menuCambios();
        }
        catch (Exception)
        {
            cambiosEnReceta();
        }
    }
};



/* ------------------------------------------------------------------ */
/* ------------------------------ MAIN ------------------------------ */
/* ------------------------------------------------------------------ */
class MainClass
{
	public static void Main (string[] args)
	{
		string[] accionesAdmin = { "alta", "baja", "cambio", "ver", "recetas", "ver recetas", "salir", "1", "2", "3", "4", "5" };
		string[] accionesUsuario = { "ver", "recetas", "ver recetas", "1", "2" };
		string[] finRecopilarInfo = { "exit", "quit", "bye", "listo", "ya", "nos vemos", "chao", "salir" };

		Libro lib = new Libro();

		string accion;
		string user;
		string password = "123";
		string input;

		do {
			user = "user";
			Console.Clear();
			input = Basics.getString("> LOGIN\nDeseas ser admin o usuario o salir: ").ToLower();
			if (finRecopilarInfo.Contains(input)) {
				break;
			}

			if (!input.Contains('u')) {
				if (Basics.getString("Contraseña: ") == password) {
					user = "admin";
				}
			}

			if (user == "user") {
				do 
				{
					userMenu ();
					do {
						accion = Basics.getString("\nAcción a realizar: ").ToLower();
					} while ( !finRecopilarInfo.Contains(accion) && !accionesUsuario.Contains(accion) );

					if (accion == "2" || finRecopilarInfo.Contains(accion)) {
						break;
					}

					lib.imprimeNombres();
				}
				while (!finRecopilarInfo.Contains(accion));
			}

			if (user == "admin") {
				do 
				{
					adminMenu ();
					do {
						accion = Basics.getString("\nAcción a realizar: ").ToLower();
					} while ( !finRecopilarInfo.Contains(accion) && !accionesAdmin.Contains(accion) );

					if (accion == "5" || finRecopilarInfo.Contains(accion)) {
						break;
					}

					if (accion == "1" || accion == "alta") {
						lib.crearReceta();
					}

                    if (accion == "2" || accion == "baja")
                    {
                        lib.eliminaReceta();
                    }

                    if (accion == "3" || accion == "cambio")
                    {
                        lib.cambiosEnReceta();
                    }

                    if ( accion == "4" || accion.Contains("ver") || accion.Contains("receta")) {
						lib.imprimeNombres();
					}
				}
				while (!finRecopilarInfo.Contains(accion));
			}

		} while (true);
	}

	/* ---------- Funciones de Main --------- */
	/* -------------------------------------- */
	public static void userMenu()
	{
		string title = "MENU DE USUARIO";

		Console.Clear ();
		Basics.printd (" ", Console.WindowWidth/2 - title.Length/2);
		Console.WriteLine (title);
		Basics.printd (" ", Console.WindowWidth/2 - title.Length/2);

		Console.WriteLine ();
		Console.WriteLine ("1) Ver recetas");
		Console.WriteLine ("2) Salir");
	}

	public static void adminMenu()
	{
		string title = "MENU DE ADMIN";

		Console.Clear ();
		Basics.printd (" ", Console.WindowWidth/2 - title.Length/2);
		Console.WriteLine (title);
		Basics.printd (" ", Console.WindowWidth/2 - title.Length/2);

		Console.WriteLine ();
		Console.WriteLine ("1) Alta");
		Console.WriteLine ("2) Baja");
		Console.WriteLine ("3) Cambio");
		Console.WriteLine ("4) Ver recetas");
		Console.WriteLine ("5) Salir");
	}
}