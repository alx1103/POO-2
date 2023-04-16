using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

/*tenemos que llamar a la carpeta*/
using Semana02.Models;

namespace Semana02.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        /*todos los metodos son httpost por eso no lo ponemos de actionresult, si quieres get si
         tienes que colocar httpGet*/
        public ActionResult Registro(Cliente obj)
        {
            ViewBag.codigo = obj.codigo;
            ViewBag.nombre = obj.nombre;
            ViewBag.email = obj.email; 
            ViewBag.apellido = obj.apellido;

            return View();
        }
    }
}