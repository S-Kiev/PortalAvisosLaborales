using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using ObligatorioProg2.Dominio;

namespace ObligatorioProg2.Pages
{
    public class listadoClienteModel : PageModel
    {
        public List<Cliente> ClienteAListar { get; set; }
        public List<Publicidad> PublicidadAListar { get; set; }


        public IActionResult OnGet()
        {
            ClienteAListar = Empresa.Instancia.obtenerCliente();
            PublicidadAListar = Empresa.Instancia.obtenerPublicidad();
            return Page();
        }
    }
}
