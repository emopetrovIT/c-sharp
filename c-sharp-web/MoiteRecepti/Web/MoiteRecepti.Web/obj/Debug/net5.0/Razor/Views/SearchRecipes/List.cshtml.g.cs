#pragma checksum "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\SearchRecipes\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c97879c37b0df956e59bd0d5454545dc2191aa7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SearchRecipes_List), @"mvc.1.0.view", @"/Views/SearchRecipes/List.cshtml")]
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
#line 1 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\_ViewImports.cshtml"
using MoiteRecepti.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\_ViewImports.cshtml"
using MoiteRecepti.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c97879c37b0df956e59bd0d5454545dc2191aa7c", @"/Views/SearchRecipes/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dcad4bea33db1a082fdf2a6517a3aea2eb20ca4", @"/Views/_ViewImports.cshtml")]
    public class Views_SearchRecipes_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MoiteRecepti.Web.ViewModels.SearchRecipes.ListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Recipes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ById", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\SearchRecipes\List.cshtml"
  
    ViewData["Title"] = "Search result";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>");
#nullable restore
#line 7 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\SearchRecipes\List.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n");
#nullable restore
#line 9 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\SearchRecipes\List.cshtml"
 if (!Model.Recipes.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Nothing found.</p>\n");
#nullable restore
#line 12 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\SearchRecipes\List.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\n");
#nullable restore
#line 16 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\SearchRecipes\List.cshtml"
         foreach (var recipe in this.Model.Recipes)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card col-md-3\">\n                <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 369, "\"", 391, 1);
#nullable restore
#line 19 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\SearchRecipes\List.cshtml"
WriteAttributeValue("", 375, recipe.ImageUrl, 375, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 392, "\"", 410, 1);
#nullable restore
#line 19 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\SearchRecipes\List.cshtml"
WriteAttributeValue("", 398, recipe.Name, 398, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                <div class=\"card-body\">\n                    <h5 class=\"card-title\">");
#nullable restore
#line 21 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\SearchRecipes\List.cshtml"
                                      Write(recipe.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                    <p class=\"card-text\">");
#nullable restore
#line 22 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\SearchRecipes\List.cshtml"
                                    Write(recipe.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c97879c37b0df956e59bd0d5454545dc2191aa7c7240", async() => {
                WriteLiteral("Go to recipe");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\SearchRecipes\List.cshtml"
                                                                    WriteLiteral(recipe.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n            </div>\n");
#nullable restore
#line 26 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\SearchRecipes\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n");
#nullable restore
#line 28 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\SearchRecipes\List.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MoiteRecepti.Web.ViewModels.SearchRecipes.ListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
