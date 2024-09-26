using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pregunta03.Models
{
    public class Trabjador
    {
        public string dniTrab { get; set; }
        public string apeTrab { get; set; }
        public string nomTrab { get; set; }
        public DateTime fecContrato { get; set; }
        public string categoriaTrab { get; set; }


        public double calcularMontoBasico()
        {
            int años = DateTime.Now.Year - fecContrato.Year;
            if (fecContrato > DateTime.Now.AddYears(-años)) años--;

            if (años <= 3)
            {
                return 1000;
            }
            else if (años > 3 && años <= 5)
            {
                return 1500;
            }
            else if (años > 5 && años <= 10)
            {
                return 2500;
            }
            else
                return 3500;
        }

        public double calcularBonificacion()
        {
            if (categoriaTrab == "A" || categoriaTrab == "B" || categoriaTrab == "C")
                return calcularMontoBasico() * 0.10;
            else
                return calcularMontoBasico() * 0.15;
        }

        public double calcularMonto()
        {
            return calcularMontoBasico() + calcularBonificacion();
        }
    }
}
