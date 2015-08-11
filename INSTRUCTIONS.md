Instructions for DiegoLib
======
1) Copiar el archivo en la misma carpeta que el archivo con el que lo queremos usar.

2) Importar al archivo (exemplo.cs) en el que estamos trabajando, usando la linea de código siguiente:
      using static Diego.Basics;

3) Listo! Disfruta de las funciones. Ejemplo:
      int x = getInt();

#### Parámetros:
Mandando el número 1 como parámetro podemos indicar que se imprima la linea default para pedir el número, ejemplo:
x int = getInt()	//No imprime nada, solo espera un input
x int = getInt(1)	//Imprime la linea "Ingresa un número (int): " y espera un input