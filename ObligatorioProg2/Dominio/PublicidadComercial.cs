using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObligatorioProg2.Dominio
{
    public class PublicidadComercial : Publicidad
    {

        public string Imagen { get; set; }
        public static float PrecioBaseCaracter { get; set; } = 2;

        public PublicidadComercial(int numero, DateTime fechaAlta, DateTime fechaInicio, DateTime fechaFin, string titulo, string detalle, Cliente cliente, string imagen) : base (numero, fechaAlta, fechaInicio, fechaFin, titulo, detalle, cliente)
        {
            Imagen = imagen;
        }

        public PublicidadComercial()
        {

        }



        //public void asignarImagen(string img)
        //{
        //    PublicidadComercial pImg = new PublicidadComercial(img);
        //    pImg.Imagen = img;
        //}
        
        public override float CalcularPrecio()
        {
            float Precio = PrecioBaseCaracter * Detalle.Length * (float) this.periodoDePublicacion().TotalDays;
            if (!String.IsNullOrWhiteSpace(Imagen))
            {
                float extra = 20 * (float) this.periodoDePublicacion().TotalDays;
                Precio += extra;
            }
            return Precio;
        }
      
    }
}
