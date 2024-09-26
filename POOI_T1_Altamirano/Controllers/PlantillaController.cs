using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using POOI_T1_Altamirano.Models;

namespace POOI_T1_Altamirano.Controllers
{
    public class PlantillaController : Controller
    {
        // GET: Plantilla

        List<Trabajador> lstTrabajadores = new List<Trabajador>();
        public ActionResult Index()
        {
            lstTrabajadores = new List<Trabajador>
            {
                new Trabajador() { dniTrab = "78653301", apeTrab = "Lopez", nomTrab= "Ricardo", fecContrato= DateTime.Parse("2020-09-23"), categoriaTrab= "A"},
                new Trabajador() { dniTrab = "70113498", apeTrab = "Perez", nomTrab= "Silvana", fecContrato= DateTime.Parse("2022-06-15"), categoriaTrab= "B"},
                new Trabajador() { dniTrab = "72319088", apeTrab = "Huamani", nomTrab= "Felipe", fecContrato= DateTime.Parse("2020-09-23"), categoriaTrab= "C"},
                new Trabajador() { dniTrab = "70104436", apeTrab = "Mendez", nomTrab= "Fabiana", fecContrato= DateTime.Parse("2019-04-07"), categoriaTrab= "D"},
            };
            return View(lstTrabajadores);

        }
        [HttpGet]
        public ActionResult createTrabajador()
        {
            return View(new Trabajador());
        }

        [HttpPost]
        public ActionResult createTrabajador(Trabajador trabajador)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Basico = trabajador.calcularMontoBasico();
                ViewBag.Bonificación = trabajador.calcularBonificacion();
                ViewBag.Monto = trabajador.calcularMonto();
            }
            return View(trabajador);
        }
    }
}