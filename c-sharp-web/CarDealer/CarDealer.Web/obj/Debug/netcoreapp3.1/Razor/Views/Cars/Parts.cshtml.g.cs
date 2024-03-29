#pragma checksum "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\CarDealer\CarDealer.Web\Views\Cars\Parts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2b561d914c6ed6ebc9a1772c38cb530f4ef9bbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_Parts), @"mvc.1.0.view", @"/Views/Cars/Parts.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\CarDealer\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\CarDealer\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Services.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\CarDealer\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Services.Models.Cars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\CarDealer\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Services.Models.Customers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\CarDealer\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Services.Models.Parts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\CarDealer\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Services.Models.Sales;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\CarDealer\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Web.Infrastructure.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\CarDealer\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Web.Models.Cars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\CarDealer\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Web.Models.Customers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\CarDealer\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Web.Models.Parts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\CarDealer\CarDealer.Web\Views\_ViewImports.cshtml"
using CarDealer.Web.Models.Suppliers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2b561d914c6ed6ebc9a1772c38cb530f4ef9bbe", @"/Views/Cars/Parts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bea31545a52ed1c61a2410b25b2291b01d93f14", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_Parts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CarWithPartsModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\CarDealer\CarDealer.Web\Views\Cars\Parts.cshtml"
  
    ViewData["Title"] = "All Cars With Their Parts";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>\r\n    ");
#nullable restore
#line 8 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\CarDealer\CarDealer.Web\Views\Cars\Parts.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" 
    <a href=""/cars/create"" class=""btn btn-primary"">Add Car</a>
</h2>
<table class=""table table-bordered table-hover"">
    <thead>
        <tr>
            <th>Make</th>
            <th>Model</th>
            <th>Travelled Distance</th>
            <th>Parts</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 21 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\CarDealer\CarDealer.Web\Views\Cars\Parts.cshtml"
         foreach (var car in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 559, "\"", 581, 2);
            WriteAttributeValue("", 566, "/cars/", 566, 6, true);
#nullable restore
#line 25 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\CarDealer\CarDealer.Web\Views\Cars\Parts.cshtml"
WriteAttributeValue("", 572, car.Make, 572, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 25 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\CarDealer\CarDealer.Web\Views\Cars\Parts.cshtml"
                                         Write(car.Make);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </td>\r\n                <td>");
#nullable restore
#line 27 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\CarDealer\CarDealer.Web\Views\Cars\Parts.cshtml"
               Write(car.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\CarDealer\CarDealer.Web\Views\Cars\Parts.cshtml"
                Write(car.TravelledDistance / 1000);

#line default
#line hidden
#nullable disable
            WriteLiteral(" KM</td>\r\n                <td>\r\n                    <ul>\r\n");
#nullable restore
#line 31 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\CarDealer\CarDealer.Web\Views\Cars\Parts.cshtml"
                         foreach (var part in car.Parts)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>");
#nullable restore
#line 33 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\CarDealer\CarDealer.Web\Views\Cars\Parts.cshtml"
                           Write(part.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - $");
#nullable restore
#line 33 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\CarDealer\CarDealer.Web\Views\Cars\Parts.cshtml"
                                         Write(part.Price.ToPrice());

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 34 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\CarDealer\CarDealer.Web\Views\Cars\Parts.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 38 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\CarDealer\CarDealer.Web\Views\Cars\Parts.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CarWithPartsModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
