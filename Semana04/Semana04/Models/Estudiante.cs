using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Semana04.Models
{
    public class Estudiante
    {
        public int idEstudiante { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }

        public Estudiante(int idEstudiante, string nombre, string apellido, string telefono, string correo)
        {
            this.idEstudiante = idEstudiante;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.correo = correo;
        }

        public Estudiante()
        {
        }
    }
}