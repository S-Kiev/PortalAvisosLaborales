#pragma checksum "C:\Users\Hp\source\repos\ObligatorioProg2\ObligatorioProg2\Pages\VerAvTrabajo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02e2d3a49cd10659191a1d1bb3d37c9990ffe50a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ObligatorioProg2.Pages.Pages_VerAvTrabajo), @"mvc.1.0.razor-page", @"/Pages/VerAvTrabajo.cshtml")]
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
#line 2 "C:\Users\Hp\source\repos\ObligatorioProg2\ObligatorioProg2\Pages\VerAvTrabajo.cshtml"
using ObligatorioProg2.Dominio;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02e2d3a49cd10659191a1d1bb3d37c9990ffe50a", @"/Pages/VerAvTrabajo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8f994c0511f36197415d7d0ec5ba5c16c9741fb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_VerAvTrabajo : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Ver Aviosos Laborales</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Hp\source\repos\ObligatorioProg2\ObligatorioProg2\Pages\VerAvTrabajo.cshtml"
 foreach (AvisosTrabajo p in Model.PublicidadAListar)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-12 m-2\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 15 "C:\Users\Hp\source\repos\ObligatorioProg2\ObligatorioProg2\Pages\VerAvTrabajo.cshtml"
                                  Write(p.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"card-text\">");
#nullable restore
#line 16 "C:\Users\Hp\source\repos\ObligatorioProg2\ObligatorioProg2\Pages\VerAvTrabajo.cshtml"
                                Write(p.Detalle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 431, "\"", 481, 2);
            WriteAttributeValue("", 438, "/EditarPublicidadComercial?numero=", 438, 34, true);
#nullable restore
#line 17 "C:\Users\Hp\source\repos\ObligatorioProg2\ObligatorioProg2\Pages\VerAvTrabajo.cshtml"
WriteAttributeValue("", 472, p.Numero, 472, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Editar</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 22 "C:\Users\Hp\source\repos\ObligatorioProg2\ObligatorioProg2\Pages\VerAvTrabajo.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ObligatorioProg2.Pages.VerAvTrabajoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ObligatorioProg2.Pages.VerAvTrabajoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ObligatorioProg2.Pages.VerAvTrabajoModel>)PageContext?.ViewData;
        public ObligatorioProg2.Pages.VerAvTrabajoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
