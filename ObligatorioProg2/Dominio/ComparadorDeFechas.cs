using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObligatorioProg2.Dominio
{
    public class ComparadorDeFechas : IComparer<Publicidad>
    {
        public int Compare (Publicidad A, Publicidad B)
        {
            if (A.FechaAlta > B.FechaAlta)
            {
                return 1;
            } else if (A.FechaAlta < B.FechaAlta)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
