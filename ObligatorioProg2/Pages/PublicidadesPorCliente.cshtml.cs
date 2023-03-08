using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ObligatorioProg2.Dominio;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ObligatorioProg2.Pages
{
    public class PublicidadesPorClienteModel : PageModel
    {
        public List<Publicidad> PublicidadesDeCliente { get; set; }
        public Cliente ClienteSeleccionado { get; set; }
        public void OnGet(int codigo)
        {
            PublicidadesDeCliente = Empresa.Instancia.listaPubXCliente(codigo);
            ClienteSeleccionado = Empresa.Instancia.buscarClienteXCodigo(codigo);
;            if (PublicidadesDeCliente == null)
            {
                NotFound();
            }
        }
    }
}
