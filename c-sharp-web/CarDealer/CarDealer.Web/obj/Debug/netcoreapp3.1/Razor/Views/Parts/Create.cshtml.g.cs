#pragma checksum "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\CarDealer\CarDealer.Web\Views\Parts\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "849af1f4a4f260c8cee3b585f2f6cd46db374b1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Parts_Create), @"mvc.1.0.view", @"/Views/Parts/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"849af1f4a4f260c8cee3b585f2f6cd46db374b1b", @"/Views/Parts/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bea31545a52ed1c61a2410b25b2291b01d93f14", @"/Views/_ViewImports.cshtml")]
    public class Views_Parts_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PartFormModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PartForm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\CarDealer\CarDealer.Web\Views\Parts\Create.cshtml"
   
    ViewData["Title"] = "Add Part";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 7 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\CarDealer\CarDealer.Web\Views\Parts\Create.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "849af1f4a4f260c8cee3b585f2f6cd46db374b1b6081", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 11 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\CarDealer\CarDealer.Web\Views\Parts\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PartFormModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
