using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ObligatorioProg2.Dominio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ObligatorioProg2.Pages
{
    public class verPubConImagenModel : PageModel
    {
        public List<PublicidadComercial> PublicidadAListar { get; set; }
        public IActionResult OnGet()
        {
            PublicidadAListar = Empresa.Instancia.ObtenerPublicidadesComercial();
            return Page();
        }

    }
}
