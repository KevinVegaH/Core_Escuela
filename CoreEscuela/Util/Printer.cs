using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace CoreEscuela.Util
{
    // 'static' las clases estaticas no permiten crear nuevas instancias. 
    //  La clase en si misma funcionará como un objeto.
    //  Se pueden utilizar todas las funcionalidades de la clase sin instanciarla.

    public static class Printer
    {

        public static void DibujarLinea(int tam = 10) {

            var linea = "".PadLeft(tam,'='); 
            WriteLine(linea); // <-- Imprime linea con un tamaño definido.

        }

        public static void WriteTitle(string titulo) // <-- Agregamos formato aun titulo.
        {
            var tamaño = titulo.Length + 4;
            DibujarLinea(tamaño);
            WriteLine($"| {titulo} |");
            DibujarLinea(tamaño);

        }
    }
}
