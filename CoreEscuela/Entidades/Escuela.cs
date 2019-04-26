using System;
using System.Collections.Generic;
using System.Text;

namespace CoreEscuela.Entidades
{
    public class Escuela
    {

        string nombre;

        public string Nombre
        {

            get { return nombre; }
            set { nombre = value; }
        }

        public int AñoDeCreación { get; set; }

        public string Pais { get; set; }

        public string Ciudad { get; set; }

        public TiposEscuela TipoEscuela { get; set; }

        public List<Curso> Cursos { get; set; }

        public Escuela(string nombre, int año) => (Nombre, AñoDeCreación) = (nombre, año); // --> Constructor

        public Escuela(string nombre, int año, TiposEscuela tipo, string pais="", string ciudad="")
        {

            (Nombre, AñoDeCreación) = (nombre, año);
            Pais = pais;
            Ciudad = ciudad;
        }

        public override string ToString() // --> Metodo ToString sobre-escrito.
        {
            // Nota: {System.Environment.NewLine} Salto de linea valida para cualquier sistema diferente a Windows. Puesto que, en sistemas como linux el valor '\n' no existe.

            return $"Nombre: {Nombre} \n Tipo: {TipoEscuela} {System.Environment.NewLine} Pais: {Pais} \n Ciudad: {Ciudad}"; //  --> Retorna los datos de la escuela mostrandolos en pantalla cuando el objeto es impreso.
        }

    } 
}
