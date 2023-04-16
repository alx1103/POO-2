using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace Semana02.Models
{
    public class Alumno
    {
        public int codigo { get; set; }
        public String nombre { get; set; }
        public int nota1 { get; set; }
        public int nota2 { get; set; }

        public Alumno()
        {

        }

        public Alumno(int codigo, string nombre, int nota1, int nota2)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public double Promedio()
        {
            return (this.nota1 + this.nota2) / 2.0;
        }

        public String Condicion()
        {
            if (this.Promedio() >= 12.5)
            {
                return "aprobado";
            }
            else
            {
                return "desaprobado";
            }
        }







    }
}