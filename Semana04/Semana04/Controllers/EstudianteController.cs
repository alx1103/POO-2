using Semana04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Semana04.Controllers
{
    public class EstudianteController : Controller
    {
        // GET: Estudiante
        public ActionResult Registrar(Estudiante obj)
        {
            ViewBag.nombre = obj.nombre;
            ViewBag.apellido = obj.apellido;
            ViewBag.correo = obj.correo;
            ViewBag.telefono = obj.telefono;

            EstudianteDao dao = new EstudianteDao();

            String rpta = dao.insertar(obj);

            if(rpta == "ok")
            {
                ViewBag.mensaje = "Estudiante registrado";
            }
            else if(rpta == "no")
            {
                ViewBag.mensaje = "Ingresa al estudiante";
            }

            return View();
        }
    }
}