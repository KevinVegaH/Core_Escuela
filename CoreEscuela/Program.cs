using CoreEscuela.App;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using System;
using System.Collections.Generic;
using static System.Console; // <-- Permite simplificar el escribir comandos como 'Console.WriteLine()' definiendolo simplemente como 'WriteLine()'

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
                  
            ImprimirCursosEscuela(engine.Escuela);

        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {

            Printer.WriteTitle("Cursos Escuela");

             // '?' no verificará cursos, salvo que la escuela sea diferente de null.
            if (escuela?.Cursos != null)
                {

                    foreach (var curso in escuela.Cursos)
                    {
                        WriteLine($"Nombre: {curso.Nombre}, Id {curso.UniqueId}");
                    }
                    ReadLine();

                }
            ReadLine();
        }

        private static void ImprimirCursosWhile(Curso[] arregloCursos)
        {
            int contador = 0;

            while (contador < arregloCursos.Length) {

                WriteLine($"Nombre: {arregloCursos[contador].Nombre}, Id: {arregloCursos[contador].UniqueId}");
                contador = contador + 1;

            }

        }

        private static void ImprimirCursosDoWhile(Curso[] arregloCursos)
        {
            int contador = 0;

            do 
            {

                WriteLine($"Nombre: {arregloCursos[contador].Nombre}, Id: {arregloCursos[contador].UniqueId}");
                contador = contador + 1;

            } while (contador < arregloCursos.Length);

        }

        private static void ImprimirCursosFor(Curso[] arregloCursos)
        {
            for (int i = 0; i < arregloCursos.Length; i++)
            {

                WriteLine($"Nombre: {arregloCursos[i].Nombre}, Id: {arregloCursos[i].UniqueId}");
             
            }
       
        }

        private static void ImprimirCursosForEach(Curso[] arregloCursos)
        {
     
            foreach (var curso in arregloCursos) {

                WriteLine($"Nombre: {curso.Nombre}, Id {curso.UniqueId}");

            }

        }

    }
}
