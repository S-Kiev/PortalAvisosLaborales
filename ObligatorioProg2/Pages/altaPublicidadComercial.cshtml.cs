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
    public class altaPublicidadComercialModel : PageModel
    {
        public List<Cliente> ClienteAListar { get; set; }
        public IActionResult OnGet()
        {
            ClienteAListar = Empresa.Instancia.obtenerCliente();
            return Page();
        }

        public IActionResult OnPost()
        {

            HttpRequest r = Request;
            DateTime fechaInicio = Convert.ToDateTime(r.Form["fInicio"]);
            DateTime fechaFin = Convert.ToDateTime(r.Form["fFin"]);
            string titulo = r.Form["titulo"];
            string img = r.Form["imagen"];
            string detalle = r.Form["detalle"];
            int codC = Convert.ToInt32(r.Form["selCliente"]);
            Cliente cli = Empresa.Instancia.buscarClienteXCodigo(codC);
            PublicidadComercial p = new PublicidadComercial();

            p.FechaAlta = DateTime.Today;
            p.FechaInicio = fechaInicio;
            p.FechaFin = fechaFin;
            p.Titulo = titulo;
            p.Imagen = img;
            p.Detalle = detalle;
            p.Cliente = cli;
            Empresa.Instancia.agregarPublicidad(p);
            return RedirectToPage("./ListPublicidadComercial");
        }
    }
}
