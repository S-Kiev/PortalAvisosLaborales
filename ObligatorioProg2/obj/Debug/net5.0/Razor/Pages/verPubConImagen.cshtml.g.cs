#pragma checksum "C:\Users\Hp\source\repos\ObligatorioProg2\ObligatorioProg2\Pages\verPubConImagen.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "830e43b3378315e9a70685322bba91aa4d5ca432"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ObligatorioProg2.Pages.Pages_verPubConImagen), @"mvc.1.0.razor-page", @"/Pages/verPubConImagen.cshtml")]
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
#line 2 "C:\Users\Hp\source\repos\ObligatorioProg2\ObligatorioProg2\Pages\verPubConImagen.cshtml"
using ObligatorioProg2.Dominio;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"830e43b3378315e9a70685322bba91aa4d5ca432", @"/Pages/verPubConImagen.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8f994c0511f36197415d7d0ec5ba5c16c9741fb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_verPubConImagen : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Ver Publicidades Comerciales</h1>\r\n");
#nullable restore
#line 8 "C:\Users\Hp\source\repos\ObligatorioProg2\ObligatorioProg2\Pages\verPubConImagen.cshtml"
 foreach (PublicidadComercial p in Model.PublicidadAListar)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card-columns\">\r\n");
#nullable restore
#line 12 "C:\Users\Hp\source\repos\ObligatorioProg2\ObligatorioProg2\Pages\verPubConImagen.cshtml"
         if (!String.IsNullOrWhiteSpace(p.Imagen))
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card\" style=\"width: 48rem;\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 378, "\"", 393, 1);
#nullable restore
#line 16 "C:\Users\Hp\source\repos\ObligatorioProg2\ObligatorioProg2\Pages\verPubConImagen.cshtml"
WriteAttributeValue("", 384, p.Imagen, 384, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\"");
            BeginWriteAttribute("alt", " alt=\"", 415, "\"", 421, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 18 "C:\Users\Hp\source\repos\ObligatorioProg2\ObligatorioProg2\Pages\verPubConImagen.cshtml"
                                      Write(p.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 19 "C:\Users\Hp\source\repos\ObligatorioProg2\ObligatorioProg2\Pages\verPubConImagen.cshtml"
                                    Write(p.Detalle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 604, "\"", 654, 2);
            WriteAttributeValue("", 611, "/EditarPublicidadComercial?numero=", 611, 34, true);
#nullable restore
#line 20 "C:\Users\Hp\source\repos\ObligatorioProg2\ObligatorioProg2\Pages\verPubConImagen.cshtml"
WriteAttributeValue("", 645, p.Numero, 645, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Editar</a>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 23 "C:\Users\Hp\source\repos\ObligatorioProg2\ObligatorioProg2\Pages\verPubConImagen.cshtml"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card\" style=\"width: 48rem;\">\r\n                <div class=\"card-body\" style=\"width: 18rem;\">\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
#nullable restore
#line 30 "C:\Users\Hp\source\repos\ObligatorioProg2\ObligatorioProg2\Pages\verPubConImagen.cshtml"
                                          Write(p.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p class=\"card-text\">");
#nullable restore
#line 31 "C:\Users\Hp\source\repos\ObligatorioProg2\ObligatorioProg2\Pages\verPubConImagen.cshtml"
                                        Write(p.Detalle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1098, "\"", 1148, 2);
            WriteAttributeValue("", 1105, "/EditarPublicidadComercial?numero=", 1105, 34, true);
#nullable restore
#line 32 "C:\Users\Hp\source\repos\ObligatorioProg2\ObligatorioProg2\Pages\verPubConImagen.cshtml"
WriteAttributeValue("", 1139, p.Numero, 1139, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Editar</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 36 "C:\Users\Hp\source\repos\ObligatorioProg2\ObligatorioProg2\Pages\verPubConImagen.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 38 "C:\Users\Hp\source\repos\ObligatorioProg2\ObligatorioProg2\Pages\verPubConImagen.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ObligatorioProg2.Pages.verPubConImagenModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ObligatorioProg2.Pages.verPubConImagenModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ObligatorioProg2.Pages.verPubConImagenModel>)PageContext?.ViewData;
        public ObligatorioProg2.Pages.verPubConImagenModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591