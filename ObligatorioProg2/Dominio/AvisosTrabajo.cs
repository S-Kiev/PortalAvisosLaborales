using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObligatorioProg2.Dominio
{
    public class AvisosTrabajo : Publicidad
    {

        public AvisosTrabajo(int numero, DateTime fechaAlta, DateTime fechaInicio, DateTime fechaFin, string titulo, string detalle, Cliente cliente) : base( numero,  fechaAlta,  fechaInicio,  fechaFin,  titulo,  detalle, cliente)
        {

        }

        public AvisosTrabajo()
        {

        }


        public override float CalcularPrecio()
        {

            if (Detalle.Length <= 50)
            {
                return 0;
            }
            else if (Detalle.Length > 50 && Detalle.Length <= 100)
            {
                return 40;
            }
            else if (Detalle.Length > 100 && Detalle.Length <= 500)
            {
                return 70;
            }
            else
            {
                return 100;
            }
        }
    }
}
