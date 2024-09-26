using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pregunta02.Models
{
    public class Trabajador
    {
        public string dniTrab { get; set; }
        public string apeTrab { get; set; }
        public string nomTrab { get; set; }
        public DateTime fecContrato { get; set; }
        public string categoriaTrab { get; set; }

     
        public double calcularMontoBasico()
        {
            
            return 0; 
        }

       
        public double calcularBonificacion()
        {
            return 0; 
        }


        public double calcularMonto()
        {
            return calcularMontoBasico() + calcularBonificacion();
        }
    }
}