#pragma checksum "C:\Users\Hp\source\repos\ObligatorioProg2\ObligatorioProg2\Pages\PublicidadesPorCliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58a4bb923cf2cbc559341b7dd621c4fab725e0a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ObligatorioProg2.Pages.Pages_PublicidadesPorCliente), @"mvc.1.0.razor-page", @"/Pages/PublicidadesPorCliente.cshtml")]
namespace ObligatorioProg2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Hp\source\repos\ObligatorioProg2\ObligatorioProg2\Pages\_ViewImports.cshtml"
using ObligatorioProg2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hp\source\repos\ObligatorioProg2\ObligatorioProg2\Pages\PublicidadesPorCliente.cshtml"
using ObligatorioProg2.Dominio;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58a4bb923cf2cbc559341b7dd621c4fab725e0a3", @"/Pages/PublicidadesPorCliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8f994c0511f36197415d7d0ec5ba5c16c9741fb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_PublicidadesPorCliente : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Listar Publicidades de ");
#nullable restore
#line 7 "C:\Users\Hp\source\repos\ObligatorioProg2\ObligatorioProg2\Pages\PublicidadesPorCliente.cshtml"
                      Write(Model.ClienteSeleccionado.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(", Total de Publicidades: ");
#nullable restore
#line 7 "C:\Users\Hp\source\repos\ObligatorioProg2\ObligatorioProg2\Pages\PublicidadesPorCliente.cshtml"
                                                                                Write(Model.PublicidadesDeCliente.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<table class=\"table table-striped table-bordered\">\r\n    <tr><th>Número</th><th>Tipo</th><th>Fecha de Alta</th><th>Fecha de Inicio</th><th>Fecha de Fin</th><th>Titulo</th><th>Cliente</th><th>Precio</th></tr>\r\n\r\n");
#nullable restore
#line 12 "C:\Users\Hp\source\repos\ObligatorioProg2\ObligatorioProg2\Pages\PublicidadesPorCliente.cshtml"
     foreach (Publicidad pub in Model.PublicidadesDeCliente)
    {
        string tipo;
        if(pub is PublicidadComercial)
        {
            tipo = "Publicidad Comercial";
        }
        else
        {
            tipo = " Aviso de Trabajo";
        }


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr><td>");
#nullable restore
#line 24 "C:\Users\Hp\source\repos\ObligatorioProg2\ObligatorioProg2\Pages\PublicidadesPorCliente.cshtml"
               Write(pub.Numero);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td><td>");
#nullable restore
#line 24 "C:\Users\Hp\source\repos\ObligatorioProg2\ObligatorioProg2\Pages\PublicidadesPorCliente.cshtml"
                                    Write(tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td>");
#nullable restore
#line 24 "C:\Users\Hp\source\repos\ObligatorioProg2\ObligatorioProg2\Pages\PublicidadesPorCliente.cshtml"
                                                  Write(pub.FechaAlta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td>");
#nullable restore
#line 24 "C:\Users\Hp\source\repos\ObligatorioProg2\ObligatorioProg2\Pages\PublicidadesPorCliente.cshtml"
                                                                         Write(pub.FechaInicio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td>");
#nullable restore
#line 24 "C:\Users\Hp\source\repos\ObligatorioProg2\ObligatorioProg2\Pages\PublicidadesPorCliente.cshtml"
                                                                                                  Write(pub.FechaFin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td>");
#nullable restore
#line 24 "C:\Users\Hp\source\repos\ObligatorioProg2\ObligatorioProg2\Pages\PublicidadesPorCliente.cshtml"
                                                                                                                        Write(pub.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td>");
#nullable restore
#line 24 "C:\Users\Hp\source\repos\ObligatorioProg2\ObligatorioProg2\Pages\PublicidadesPorCliente.cshtml"
                                                                                                                                            Write(pub.Cliente.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td>");
#nullable restore
#line 24 "C:\Users\Hp\source\repos\ObligatorioProg2\ObligatorioProg2\Pages\PublicidadesPorCliente.cshtml"
                                                                                                                                                                        Write(pub.CalcularPrecio());

#line default
#line hidden
#nullable disable
            WriteLiteral(";</td><td><a class=\"btn btn-success btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 965, "\"", 1016, 2);
            WriteAttributeValue("", 972, "/EditarPublicidad?codigo=", 972, 25, true);
#nullable restore
#line 24 "C:\Users\Hp\source\repos\ObligatorioProg2\ObligatorioProg2\Pages\PublicidadesPorCliente.cshtml"
WriteAttributeValue("", 997, pub.Cliente.Codigo, 997, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Ver Más</a></td></tr>\r\n");
#nullable restore
#line 25 "C:\Users\Hp\source\repos\ObligatorioProg2\ObligatorioProg2\Pages\PublicidadesPorCliente.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ObligatorioProg2.Pages.PublicidadesPorClienteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ObligatorioProg2.Pages.PublicidadesPorClienteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ObligatorioProg2.Pages.PublicidadesPorClienteModel>)PageContext?.ViewData;
        public ObligatorioProg2.Pages.PublicidadesPorClienteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
