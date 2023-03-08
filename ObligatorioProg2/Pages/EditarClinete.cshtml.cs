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
    public class EditarClineteModel : PageModel
    {

         public int CodigoClienteAEditar { get; set; }
        public Cliente ClienteEditado { get; set; }

        public IActionResult OnGet(int codigo)
            {
            Cliente c = Empresa.Instancia.buscarClienteXCodigo(codigo);
            if (c == null)
            {
                NotFound();
            }
            ClienteEditado = c;
            return Page();
            }

            public IActionResult OnPost() // aca deberia recibir el codigo del cliente a editar
            {
                HttpRequest r = Request;
                int cod = Convert.ToInt32(r.Form["codigo"]);
                string nom = r.Form["nombre"];
                string dir = r.Form["direccion"];
                int tel = Convert.ToInt32(r.Form["telefono"]);
                int TipoDoc = Convert.ToInt32(r.Form["TDoc"]);
                int doc = Convert.ToInt32(r.Form["documento"]);
                Cliente cDatosModificados = new Cliente();
                cDatosModificados.Codigo = cod;
                cDatosModificados.Nombre = nom;
                cDatosModificados.Direccion = dir;
                cDatosModificados.Telefono = tel;
                cDatosModificados.TipoDoc = TipoDoc;
                cDatosModificados.Documento = doc;
                Empresa.Instancia.modiificarCliente(cod, cDatosModificados);
                return RedirectToPage("./listadoCliente");
            }
        }
    }

