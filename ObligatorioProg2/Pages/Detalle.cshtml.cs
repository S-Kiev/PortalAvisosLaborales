using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ObligatorioProg2.Dominio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ObligatorioProg2.Pages
{
    public class DetalleModel : PageModel
    {
        public Publicidad PublicidadAVerDetalle { get; set; }

        public IActionResult OnGet(int numero)
        {
            PublicidadAVerDetalle = Empresa.Instancia.buscarPublicidadXNumero(numero);
            if (PublicidadAVerDetalle == null)
            {
                NotFound();
            }
             return Page();
        }

    }
}
