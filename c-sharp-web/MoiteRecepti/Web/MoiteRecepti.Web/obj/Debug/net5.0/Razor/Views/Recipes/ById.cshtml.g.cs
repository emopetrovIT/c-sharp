#pragma checksum "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\Recipes\ById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be84417d05da8a5366d4d20d448eb5816aed8d71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipes_ById), @"mvc.1.0.view", @"/Views/Recipes/ById.cshtml")]
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
#nullable restore
#line 1 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\Recipes\ById.cshtml"
using MoiteRecepti.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be84417d05da8a5366d4d20d448eb5816aed8d71", @"/Views/Recipes/ById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dcad4bea33db1a082fdf2a6517a3aea2eb20ca4", @"/Views/_ViewImports.cshtml")]
    public class Views_Recipes_ById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MoiteRecepti.Web.ViewModels.Recipes.SingleRecipeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Recipes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("deleteForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SendToEmail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("antiForgeryForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\Recipes\ById.cshtml"
  
    this.ViewData["Title"] = Model.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"single-recipe-layout1\">\n    <div class=\"ctg-name\">");
#nullable restore
#line 8 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\Recipes\ById.cshtml"
                     Write(Model.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n    <h2 class=\"item-title\">");
#nullable restore
#line 9 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\Recipes\ById.cshtml"
                      Write(this.ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n    <div class=\"row mb-4\">\n        <div class=\"col-xl-9 col-12\">\n            <ul class=\"entry-meta\">\n                <li class=\"single-meta\">\n                    <i class=\"far fa-calendar-alt\"></i>\n                    ");
#nullable restore
#line 15 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\Recipes\ById.cshtml"
               Write(Model.CreatedOn.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </li>\n                <li class=\"single-meta\">\n                    <i class=\"fas fa-user\"></i> by\n");
#nullable restore
#line 19 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\Recipes\ById.cshtml"
                     if (string.IsNullOrWhiteSpace(Model.AddedByUserEmail))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 776, "\"", 801, 1);
#nullable restore
#line 21 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\Recipes\ById.cshtml"
WriteAttributeValue("", 783, Model.OriginalUrl, 783, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">recepti.gotvach.bg</a>\n");
#nullable restore
#line 22 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\Recipes\ById.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>");
#nullable restore
#line 25 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\Recipes\ById.cshtml"
                         Write(Model.AddedByUserEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 26 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\Recipes\ById.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </li>
                <li class=""single-meta"">
                    <ul class=""item-rating"">
                        <li class=""star-fill"" data-vote=""1""><i class=""fas fa-star""></i></li>
                        <li class=""star-fill"" data-vote=""2""><i class=""fas fa-star""></i></li>
                        <li class=""star-fill"" data-vote=""3""><i class=""fas fa-star""></i></li>
                        <li class=""star-fill"" data-vote=""4""><i class=""fas fa-star""></i></li>
                        <li class=""star-fill"" data-vote=""5""><i class=""fas fa-star""></i></li>
                        <li><span id=""averageVoteValue"">");
#nullable restore
#line 35 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\Recipes\ById.cshtml"
                                                   Write(Model.AverageVote.ToString("0.0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span> / 5</span> </li>\n                    </ul>\n                </li>\n");
#nullable restore
#line 38 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\Recipes\ById.cshtml"
                 if (this.User.IsInRole(GlobalConstants.AdministratorRoleName))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"single-meta\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be84417d05da8a5366d4d20d448eb5816aed8d7110984", async() => {
                WriteLiteral("Edit");
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
#line 41 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\Recipes\ById.cshtml"
                                                                        WriteLiteral(Model.Id);

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
            WriteLiteral("\n                    </li>\n                    <li class=\"single-meta\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be84417d05da8a5366d4d20d448eb5816aed8d7113587", async() => {
                WriteLiteral("\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\Recipes\ById.cshtml"
                                                                                  WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        <button class=\"btn btn-danger\" data-toggle=\"modal\" data-target=\"#deleteModal\">Delete</button>\n                    </li>\n                    <li class=\"single-meta\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be84417d05da8a5366d4d20d448eb5816aed8d7116611", async() => {
                WriteLiteral("\n                            <button class=\"btn btn-warning\">Send to my email</button>\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\Recipes\ById.cshtml"
                                                                       WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </li>\n                    <li class=\"single-meta\">\n                        <button class=\"btn btn-warning\" onclick=\"window.print()\">Print</button>\n                    </li>\n");
#nullable restore
#line 56 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\Recipes\ById.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\n        </div>\n    </div>\n    <div class=\"item-figure\">\n        <img class=\"img-fluid w-100\"");
            BeginWriteAttribute("src", " src=\"", 2941, "\"", 2962, 1);
#nullable restore
#line 61 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\Recipes\ById.cshtml"
WriteAttributeValue("", 2947, Model.ImageUrl, 2947, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2963, "\"", 2980, 1);
#nullable restore
#line 61 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\Recipes\ById.cshtml"
WriteAttributeValue("", 2969, Model.Name, 2969, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
    </div>
    <div class=""item-feature"">
        <ul>
            <li>
                <div class=""feature-wrap"">
                    <div class=""media"">
                        <div class=""feature-icon"">
                            <i class=""far fa-clock""></i>
                        </div>
                        <div class=""media-body space-sm"">
                            <div class=""feature-title"">PREP TIME</div>
                            <div class=""feature-sub-title"">");
#nullable restore
#line 73 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\Recipes\ById.cshtml"
                                                      Write(Model.PreparationTime.TotalMinutes);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Mins</div>
                        </div>
                    </div>
                </div>
            </li>
            <li>
                <div class=""feature-wrap"">
                    <div class=""media"">
                        <div class=""feature-icon"">
                            <i class=""fas fa-utensils""></i>
                        </div>
                        <div class=""media-body space-sm"">
                            <div class=""feature-title"">COOK TIME</div>
                            <div class=""feature-sub-title"">");
#nullable restore
#line 86 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\Recipes\ById.cshtml"
                                                      Write(Model.CookingTime.TotalMinutes);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Mins</div>
                        </div>
                    </div>
                </div>
            </li>
            <li>
                <div class=""feature-wrap"">
                    <div class=""media"">
                        <div class=""feature-icon"">
                            <i class=""fas fa-users""></i>
                        </div>
                        <div class=""media-body space-sm"">
                            <div class=""feature-title"">SERVING</div>
                            <div class=""feature-sub-title"">
                                ");
#nullable restore
#line 100 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\Recipes\ById.cshtml"
                           Write(Model.PortionsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 101 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\Recipes\ById.cshtml"
                                 if (Model.PortionsCount == 1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span>Person</span>\n");
#nullable restore
#line 104 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\Recipes\ById.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span>People</span>\n");
#nullable restore
#line 108 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\Recipes\ById.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                        </div>
                    </div>
                </div>
            </li>
            <li>
                <div class=""feature-wrap"">
                    <div class=""media"">
                        <div class=""feature-icon"">
                            <i class=""fa fa-list-ol""></i>
                        </div>
                        <div class=""media-body space-sm"">
                            <div class=""feature-title"">CATEGORY RECIPES</div>
                            <div class=""feature-sub-title"">");
#nullable restore
#line 122 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\Recipes\ById.cshtml"
                                                      Write(Model.CategoryRecipesCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        </div>
                    </div>
                </div>
            </li>
        </ul>
    </div>
    <div class=""making-elements-wrap"">
        <div class=""row"">
            <div class=""col-md-6"">
                <p class=""item-description"">
                    ");
#nullable restore
#line 133 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\Recipes\ById.cshtml"
               Write(Model.Instructions);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </p>\n            </div>\n            <div class=\"col-md-6\">\n                <div class=\"ingridients-wrap\">\n                    <h3 class=\"item-title\"><i class=\"fas fa-list-ul\"></i>Ingridients</h3>\n");
#nullable restore
#line 139 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\Recipes\ById.cshtml"
                     foreach (var ingredient in Model.Ingredients)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"checkbox checkbox-primary\">\n                            <label for=\"checkbox1\">");
#nullable restore
#line 142 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\Recipes\ById.cshtml"
                                              Write(ingredient.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 142 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\Recipes\ById.cshtml"
                                                                   Write(ingredient.IngredientName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                        </div>\n");
#nullable restore
#line 144 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\Recipes\ById.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n            </div>\n        </div>\n    </div>\n</div>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be84417d05da8a5366d4d20d448eb5816aed8d7127492", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    <script>\n        $(\"li[data-vote]\").each(function (el) {\n            $(this).click(function () {\n                var value = $(this).attr(\"data-vote\");\n                var recipeId = ");
#nullable restore
#line 156 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\Recipes\ById.cshtml"
                          Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
                var antiForgeryToken = $('#antiForgeryForm input[name=__RequestVerificationToken]').val();
                var data = { recipeId: recipeId, value: value };
                $.ajax({
                    type: ""POST"",
                    url: ""/api/Votes"",
                    data: JSON.stringify(data),
                    headers: {
                        'X-CSRF-TOKEN': antiForgeryToken
                    },
                    success: function (data) {
                        $('#averageVoteValue').html(data.averageVote.toFixed(1));
                    },
                    contentType: 'application/json',
                });
            })
        });
    </script>
");
            }
            );
            WriteLiteral("\n<div class=\"modal\" tabindex=\"-1\" role=\"dialog\" id=\"deleteModal\">\n    <div class=\"modal-dialog\" role=\"document\">\n        <div class=\"modal-content\">\n            <div class=\"modal-body\">\n                <p>Do you want to delete \"");
#nullable restore
#line 180 "C:\Repositories\c-sharp-repository\c-sharp-web\ASP.NET\MoiteRecepti\Web\MoiteRecepti.Web\Views\Recipes\ById.cshtml"
                                     Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""?</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-danger"" onclick=""deleteForm.submit()"">Yes</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">No</button>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MoiteRecepti.Web.ViewModels.Recipes.SingleRecipeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591