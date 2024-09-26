using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pregunta02.Models
{
    public class Asistente : Trabajador
    {
        public int num_hijos { get; set; }
        public string grado_educacion { get; set; }

        public double calcularMontoBasico()
        {
            if (grado_educacion == "secundaria")
                return 950;
            else if (grado_educacion == "superior")
                return 1500;

            return 0;
        }

        public double calcularEscolaridad()
        {
            return num_hijos * 95;
        }

        public double calcularBonificacion()
        {
            DateTime fechaHoy = DateTime.Today;
            int aniosContrato = fechaHoy.Year - fecContrato.Year;

            if (fechaHoy < fecContrato.AddYears(aniosContrato))
                aniosContrato--;

            
            if (aniosContrato <= 1)
                return calcularMontoBasico() * 0.05; 
            else
                return calcularMontoBasico() * 0.10;
        }

        public double calcularMonto()
        {
            return calcularMontoBasico() + calcularEscolaridad() + calcularBonificacion();
        }
    }
}