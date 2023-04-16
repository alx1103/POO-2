using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Semana02.Models
{
    public class Cliente
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }

        public Cliente() {}
        public Cliente (int codigo, string nombre, string apellido, string email) {
            this.codigo = codigo;   
            this.nombre = nombre;   
            this.apellido=apellido;
            this.email = email;
        }

    }
}