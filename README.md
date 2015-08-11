# DiegoLib
# --- Versión 1.0  -------------------------------------------------------
#	
#	Incluye 7 funciones
#	> getInt()
#	> getByte()
#	> getDecimal()
#	> getDouble()
#	> getFloat()
#	> getLong()
#	> getShort()
#	
#	Ahorran lineas de código
#	Evitan los errores de introducción de letras
#	Evitan errores de tamaño mayor al posible
#	Evita que termine tu programa inespreadamente
#	
#	Instrucciones de uso:
#	1) Copiar el archivo en la misma carpeta que el archivo con el que lo queremos usar.
#	2) Importar al archivo (exemplo.cs) en el que estamos trabajando, usando la linea de código siguiente:
#	      using static Diego.Basics;
#	3) Listo! Disfruta de las funciones. Ejemplo:
#	      int x = getInt();
#	
#	Función extra:
#	Mandando el número 1 como parámetro podemos indicar que se imprima la linea default para pedir el número, ejemplo:
#	x int = getInt()	//No imprime nada, solo espera un input
#	x int = getInt(1)	//Imprime la linea "Ingresa un número (int): " y espera un input