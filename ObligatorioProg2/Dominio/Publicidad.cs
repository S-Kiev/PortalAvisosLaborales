using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObligatorioProg2.Dominio
{
    public class Publicidad
    {

        public Publicidad (int numero, DateTime fechaAlta, DateTime fechaInicio, DateTime fechaFin, string titulo, string detalle, Cliente cliente)
        {
            Numero = numero;
            FechaAlta = fechaAlta;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            Titulo = titulo;
            Detalle = detalle;
            Cliente = cliente;
        }

        public Publicidad()
        {

        }

        public int Numero { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Titulo { get; set; }
        public string Detalle { get; set; }
        public Cliente Cliente { get; set; }
        public bool Activa { get; set; }
        public TimeSpan Periodo { get; set; }


        public virtual float CalcularPrecio()
        {
           
            return -1;
        }

        public virtual TimeSpan periodoDePublicacion()
        { 
                 Periodo= FechaFin - FechaInicio;
            return Periodo;
        }



       /* public virtual TimeSpan calcularPorFechaDada(DateTime fecha, Publicidad pub)
        {
            TimeSpan periodo = new TimeSpan();
            periodo = fecha - pub.FechaAlta;
            return periodo;
        } */





    }
}
