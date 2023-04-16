using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Semana02.Models;


namespace Semana02.Controllers
{
    public class AlumnoController : Controller
    {
        // GET: Alumno
        public ActionResult Calificaciones(Alumno obj)
        {
            ViewBag.nota1 = obj.nota1;
            ViewBag.nota2 = obj.nota2;

            ViewBag.promedio = obj.Promedio();

            ViewBag.condicion = obj.Condicion();

            return View();
        }
    }
}