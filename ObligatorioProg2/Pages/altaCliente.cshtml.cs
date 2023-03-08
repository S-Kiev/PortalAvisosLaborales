using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ObligatorioProg2.Dominio;

namespace ObligatorioProg2.Pages
{
    public class altaClienteModel : PageModel
    {
        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            string nom = Request.Form["nombre"];
            string dir = Request.Form["direccion"];
            int tel = Convert.ToInt32(Request.Form["telefono"]);
            int TipoDoc = Convert.ToInt32(Request.Form["TDoc"]); 
            int doc = Convert.ToInt32(Request.Form["documento"]);
            Cliente c = new Cliente();
            c.Nombre = nom;
            c.Direccion = dir;
            c.Telefono = tel;
            c.TipoDoc = TipoDoc;
            c.Documento = doc;
            c.FechaAlta = DateTime.Today;
            Empresa.Instancia.agregarCliente(c);
            return RedirectToPage("./listadoCliente");
        }
    }
}
