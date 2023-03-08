using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ObligatorioProg2.Dominio;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ObligatorioProg2.Pages
{
    public class ListAvisoTrabajoModel : PageModel
    {
        public List<AvisosTrabajo> PublicidadAListar { get; set; }
        public IActionResult OnGet()
        {
            PublicidadAListar = Empresa.Instancia.ObtenerAvisoTrabajo(); 
            return Page();
        } 
        
    }
}
