#pragma checksum "/Volumes/Disk Ismael/Desktop/ProyectosC#/backupProject/Proyecto/ProyectoWeb/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40f8460b64c15553b72300c59e071a7aa31fb927"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Volumes/Disk Ismael/Desktop/ProyectosC#/backupProject/Proyecto/ProyectoWeb/Views/_ViewImports.cshtml"
using ProyectoWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Volumes/Disk Ismael/Desktop/ProyectosC#/backupProject/Proyecto/ProyectoWeb/Views/_ViewImports.cshtml"
using ProyectoWeb.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Volumes/Disk Ismael/Desktop/ProyectosC#/backupProject/Proyecto/ProyectoWeb/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40f8460b64c15553b72300c59e071a7aa31fb927", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53a09034ba28c670023e38457d3709a9888be7ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PuestoTrabajo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/descarga .jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration:none;color:black;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Volumes/Disk Ismael/Desktop/ProyectosC#/backupProject/Proyecto/ProyectoWeb/Views/Home/Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.Title = "Todos los Trabajos";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""banner"">

    <h2 class=""mb-0 text-white"">Your Future Start Here Know</h2>
    <h6 style=""color: white; margin-Top: 0px;margin-bottom:30px; margin-left: 90px;"">Search Millions Of Jobs For Free</h6>
    <div class=""py-1"" style=""border-radius: 50px;background-color:white;"">
        <input class=""border-0 ml-1  "" style=""border-radius: 50px;"" type=""text"" placeholder=""Search Job by Location""");
            BeginWriteAttribute("value", " value=\"", 522, "\"", 530, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
        <button class=""float-right border-0 bg-white mr-1"" style=""border-radius: 50px;""><i class=""fa fa-search text-success bg-white ""></i></button>
    </div>

</div>

<main>
    <div class=""row mt-5 "">
        <div class=""col"">
            <h1 class=""text-center mb-4 text-black-50 text-monospacefont-weight-bold"">The Most Resent Post</h1>
            <div class=""list-group "" style=""background-color:#F9EBEA ;"">
");
#nullable restore
#line 23 "/Volumes/Disk Ismael/Desktop/ProyectosC#/backupProject/Proyecto/ProyectoWeb/Views/Home/Index.cshtml"
                   foreach (var t in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div href=""#"" class=""list-group-item list-group-item-action flex-column align-item-start mt-3 "">
                            <div class=""d-flex w-100 justify-content-between align-item-center"">
                                <h4 class=""font-weight-bold"">");
#nullable restore
#line 27 "/Volumes/Disk Ismael/Desktop/ProyectosC#/backupProject/Proyecto/ProyectoWeb/Views/Home/Index.cshtml"
                                                        Write(t.Compania);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                                <small>");
#nullable restore
#line 28 "/Volumes/Disk Ismael/Desktop/ProyectosC#/backupProject/Proyecto/ProyectoWeb/Views/Home/Index.cshtml"
                                  Write(t.FechaPublicacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\n                            </div>\n                            <div class=\"row\">\n                                <div class=\"col-3\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "40f8460b64c15553b72300c59e071a7aa31fb9277650", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\n                                <div class=\"col-6 \"><pre class=\"text-center\">");
#nullable restore
#line 32 "/Volumes/Disk Ismael/Desktop/ProyectosC#/backupProject/Proyecto/ProyectoWeb/Views/Home/Index.cshtml"
                                                                        Write(t.Categoria);

#line default
#line hidden
#nullable disable
            WriteLiteral("              ");
#nullable restore
#line 32 "/Volumes/Disk Ismael/Desktop/ProyectosC#/backupProject/Proyecto/ProyectoWeb/Views/Home/Index.cshtml"
                                                                                                  Write(t.Posicion);

#line default
#line hidden
#nullable disable
            WriteLiteral("             ");
#nullable restore
#line 32 "/Volumes/Disk Ismael/Desktop/ProyectosC#/backupProject/Proyecto/ProyectoWeb/Views/Home/Index.cshtml"
                                                                                                                          Write(t.TipoEmpleado.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </pre> </div>
                                        <div class=""col-3 px-1"">
                                            <ul class=""responsive float-right "">
                                                <li class=""nav-item regist_log  px-3 py-2 mr-2"" style=""background-color:lightgrey;"">
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40f8460b64c15553b72300c59e071a7aa31fb92710114", async() => {
                WriteLiteral("  Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "/Volumes/Disk Ismael/Desktop/ProyectosC#/backupProject/Proyecto/ProyectoWeb/Views/Home/Index.cshtml"
                                                                                                                                              WriteLiteral(t.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                                </li>\n                                                <li class=\"nav-item regist_log  px-4 py-2\" style=\"background-color:#53b427;\">\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40f8460b64c15553b72300c59e071a7aa31fb92712878", async() => {
                WriteLiteral(" Aply");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "/Volumes/Disk Ismael/Desktop/ProyectosC#/backupProject/Proyecto/ProyectoWeb/Views/Home/Index.cshtml"
                                                                                                                                           WriteLiteral(t.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                                </li>\n\n                                            </ul>\n                                        </div> \n                            </div>\n                        </div>\n");
#nullable restore
#line 46 "/Volumes/Disk Ismael/Desktop/ProyectosC#/backupProject/Proyecto/ProyectoWeb/Views/Home/Index.cshtml"
                    }

                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n\n            <a class=\"nav-link text-success text-right font-weight-bolder\">More Options </a>\n\n\n        </div>\n    </div>\n</main>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PuestoTrabajo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
