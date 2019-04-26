using CoreEscuela.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreEscuela.App
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {
       
        }

        public void Inicializar()
        {

            Escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria,
                 pais: "Colombia", ciudad: "Bogotá" // <-- Parametros opcionales
                 );

            CargarCursos();

            CargarAsignaturas();

            CargarEvaluaciones();

        }

        private void CargarEvaluaciones()
        {
         
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos) {

                var listaASignaturas = new List<Asignatura>() {
                    new Asignatura{ Nombre ="Matematicas"},
                    new Asignatura{ Nombre ="Educación Fisica"},
                    new Asignatura{ Nombre ="Castellano"},
                    new Asignatura{ Nombre ="Ciencias Naturales"},

                };
                    

                curso.Asignaturas = listaASignaturas;

            }
        }

        private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
        {
            string[] nombre1 = { "Kevin", "Pedro", "Juan" };
            string[] apellido1 = { "Vega", "Bladimir", "Hernandez" };
            string[] nombre2 = { "Alberto", "Jose", "Toledo" };

            // Producto carteciano de los 3 vectores realizado con linq.

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { Nombre = $"{n1} {n2} {a1}" };

            return listaAlumnos.OrderBy((alumno) => alumno.UniqueId).Take(cantidad).ToList();
        }

        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>()
            {
                new Curso() { Nombre = "101" , Jornada = TiposJornada.Mañana},

                new Curso() { Nombre = "201" , Jornada = TiposJornada.Mañana},

                new Curso() { Nombre = "301" , Jornada = TiposJornada.Mañana},

                new Curso() { Nombre = "401" , Jornada = TiposJornada.Tarde},

                new Curso() { Nombre = "501" , Jornada = TiposJornada.Tarde},

            };

            Random rnd = new Random();

            foreach (var c in Escuela.Cursos) {

                int cantRandom = rnd.Next(5, 20); // Genera un numero aleatorio entre 5 y 20.

                c.Alumnos = GenerarAlumnosAlAzar(cantRandom);

            }

        }

        //escuela.Cursos.AddRange(otraColeccion); // añadimos otra colección a las colecciones 
        //escuela.Cursos.RemoveAll((cur) => cur.Nombre == "301");


    }
}
