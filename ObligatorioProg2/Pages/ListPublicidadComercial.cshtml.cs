using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ObligatorioProg2.Dominio;

namespace ObligatorioProg2.Pages
{
    public class ListPublicidadComercialModel : PageModel
    {
        public List<PublicidadComercial> PublicidadAListar { get; set; }
        public IActionResult OnGet()
        {
            PublicidadAListar = Empresa.Instancia.ObtenerPublicidadesComercial();
            return Page();
        }

    }
}
