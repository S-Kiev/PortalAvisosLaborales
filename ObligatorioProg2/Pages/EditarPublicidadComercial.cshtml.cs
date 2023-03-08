using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ObligatorioProg2.Dominio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ObligatorioProg2.Pages
{
    public class EditarPublicidadComercialModel : PageModel
    {
        public List<Cliente> ClienteAListar { get; set; }
        public int NumeroPubAModificar { get; set; }
        public PublicidadComercial PublicidadEditada { get; set; }

        public IActionResult OnGet(int numero)
        {
            ClienteAListar = Empresa.Instancia.obtenerCliente();
            PublicidadComercial p = Empresa.Instancia.buscarPubComercialXNumero(numero);
            if (p == null)
            {
                NotFound();
            }
            PublicidadEditada = p;
            return Page();
        }

        public IActionResult OnPost()
        {
            HttpRequest r = Request;
            int num = Convert.ToInt32(r.Form["numPub"]);
            DateTime fechaInicio = Convert.ToDateTime(r.Form["fInicio"]);
            DateTime fechaFin = Convert.ToDateTime(r.Form["fFin"]);
            string titulo = r.Form["titulo"];
            string img = r.Form["imagen"];
            string detalle = r.Form["detalle"];
            int c = Convert.ToInt32(r.Form["selCliente"]);
            Cliente cli = Empresa.Instancia.buscarClienteXCodigo(c);
            PublicidadComercial pDatosModificados = new PublicidadComercial();
            pDatosModificados.FechaInicio = fechaInicio;
            pDatosModificados.FechaFin = fechaFin;
            pDatosModificados.Titulo = titulo;
            pDatosModificados.Detalle = detalle;
            pDatosModificados.Cliente = cli;
            pDatosModificados.Imagen = img;
            Empresa.Instancia.modificarPubComercial(num, pDatosModificados);
            return RedirectToPage("./ListPublicidadComercial");
        }
    }
}
