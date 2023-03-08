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
    public class altaAvisoTrabajoModel : PageModel
    {
        public List<Cliente> ClienteAListar { get; set; } 
        public IActionResult OnGet()
        {
            ClienteAListar = Empresa.Instancia.obtenerCliente();
            return Page();
        }

        public IActionResult OnPost()
        {
            DateTime fechaInicio = Convert.ToDateTime(Request.Form["fInicio"]);
            DateTime fechaFin = Convert.ToDateTime(Request.Form["fFin"]);
            string titulo = Request.Form["titulo"];
            string detalle = Request.Form["detalle"];
            int codC = Convert.ToInt32(Request.Form["selCliente"]);  
            AvisosTrabajo a = new AvisosTrabajo();
            Cliente cli = Empresa.Instancia.buscarClienteXCodigo(codC);
            a.FechaAlta = DateTime.Today;
            a.FechaInicio = fechaInicio;
            a.FechaFin = fechaFin;
            a.Titulo = titulo;
            a.Detalle = detalle;
            a.Cliente = cli;
            Empresa.Instancia.agregarPublicidad(a);
            return RedirectToPage("./ListAvisoTrabajo");
        }
    }
}