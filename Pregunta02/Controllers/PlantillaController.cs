using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pregunta02.Models;
namespace Pregunta02.Controllers
{
    public class PlanillaControlador : Controller
    {

        List<Trabajador> lstTraba = new List<Trabajador>();
        public ActionResult Index()
        {
            lstTraba = new List<Trabajador>
        {
            new Vendedor() { dniTrab = "78653301", apeTrab = "Lopez", nomTrab = "Ricardo", fecContrato = DateTime.Parse("2020-09-23"), categoriaTrab = "A" },
            new Vendedor() { dniTrab = "70113498", apeTrab = "Perez", nomTrab = "Silvana", fecContrato = DateTime.Parse("2022-06-15"), categoriaTrab = "B" },
            new Asistente() { dniTrab = "72319088", apeTrab = "Huamani", nomTrab = "Felipe", fecContrato = DateTime.Parse("2021-01-10"), categoriaTrab = "C", num_hijos = 2, grado_educacion = "secundaria" },
            new Asistente() { dniTrab = "70104436", apeTrab = "Mendez", nomTrab = "Fabiana", fecContrato = DateTime.Parse("2019-04-07"), categoriaTrab = "D", num_hijos = 1, grado_educacion = "superior" }
        };

            return View(lstTraba);
        }


        [HttpGet]
        public ActionResult createAsistente()
        {
            return View(new Asistente());
        }

        [HttpPost]
        public ActionResult createAsistente(Asistente asistente)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Basico = asistente.calcularMontoBasico();
                ViewBag.Escolaridad = asistente.calcularEscolaridad();
                ViewBag.Bonificacion = asistente.calcularBonificacion();
                ViewBag.Monto = asistente.calcularMonto();
            }
            return View(asistente);
        }
    }
}