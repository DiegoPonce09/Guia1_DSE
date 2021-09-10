using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Persona.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Persona(string dui, string nombre, string apellido, string fecha, string direccion, string correo)
        {
            ViewBag.DUI = dui;
            ViewBag.Nombre = nombre;
            ViewBag.Apellido = apellido;
            ViewBag.Fecha = fecha;
            ViewBag.Direccion = direccion;
            ViewBag.Correo = correo;
            return View();
        }
    }
}