using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Pregunta03.Models;
namespace Pregunta03.Controllers
{
    public class PlantillaController : Controller
    {
        // GET: Plantilla
        private static List<Asistente> lstAsi = new List<Asistente>();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Listado()
        {
            return View(lstAsi);
        }


        [HttpGet]
        public ActionResult create()
        {
            return View(new Asistente());
        }

        [HttpPost]
        public ActionResult create(Asistente asistente)
        {
            if (lstAsi.Any(a => a.dniTrab == asistente.dniTrab))
            {
                ModelState.AddModelError("dniTrab", "El DNI ya está registrado.");
            }

            if (ModelState.IsValid)
            {
                lstAsi.Add(asistente);
                ViewBag.Message = "Asistente registrado correctamente.";
                return RedirectToAction("Listado");
            }
            return View(asistente);
        }
    }
}