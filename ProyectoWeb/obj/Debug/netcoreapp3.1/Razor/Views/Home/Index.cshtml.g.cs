#pragma checksum "/Volumes/Disk Ismael/Desktop/ProyectosC#/Proyecto1/ProyectoWeb/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e528575cb5446552ca11f1e2e0c3f563d2d72925"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e528575cb5446552ca11f1e2e0c3f563d2d72925", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProyectoWeb.Models.BaseUser>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e528575cb5446552ca11f1e2e0c3f563d2d729252693", async() => {
                WriteLiteral(@"
    <meta charset='utf-8'>
    <meta http-equiv='X-UA-Compatible' content='IE=edge'>
    <title>Page Title</title>
    <meta name='viewport' content='width=device-width, initial-scale=1'>
    <link rel='stylesheet' type='text/css' media='screen' href='main.css'>
    <script src='main.js'></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e528575cb5446552ca11f1e2e0c3f563d2d729253940", async() => {
                WriteLiteral("\n    <h2>Estamos en la Pagina donde se mostrara todos los trabajos disponible para postularse</h2>\n\n");
#nullable restore
#line 15 "/Volumes/Disk Ismael/Desktop/ProyectosC#/Proyecto1/ProyectoWeb/Views/Home/Index.cshtml"
      
        foreach (var Usuario in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div style=\"margin=30px\">\n                <div>\n                    <b>Id:</b> ");
#nullable restore
#line 20 "/Volumes/Disk Ismael/Desktop/ProyectosC#/Proyecto1/ProyectoWeb/Views/Home/Index.cshtml"
                          Write(Usuario.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </div>\n                <div>\n                    <b>Nombre:</b> ");
#nullable restore
#line 23 "/Volumes/Disk Ismael/Desktop/ProyectosC#/Proyecto1/ProyectoWeb/Views/Home/Index.cshtml"
                              Write(Usuario.Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </div>\n                <div>\n                    <b>Apellido:</b> ");
#nullable restore
#line 26 "/Volumes/Disk Ismael/Desktop/ProyectosC#/Proyecto1/ProyectoWeb/Views/Home/Index.cshtml"
                                Write(Usuario.Apellido);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </div>\n                <div>\n                    <b>Usuario:</b> ");
#nullable restore
#line 29 "/Volumes/Disk Ismael/Desktop/ProyectosC#/Proyecto1/ProyectoWeb/Views/Home/Index.cshtml"
                               Write(Usuario.UsuarioNombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </div>\n                <div>\n                    <b>Contraseña:</b> ");
#nullable restore
#line 32 "/Volumes/Disk Ismael/Desktop/ProyectosC#/Proyecto1/ProyectoWeb/Views/Home/Index.cshtml"
                                  Write(Usuario.UsuarioContra);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </div>\n                <div>\n                    <b>Correo:</b> ");
#nullable restore
#line 35 "/Volumes/Disk Ismael/Desktop/ProyectosC#/Proyecto1/ProyectoWeb/Views/Home/Index.cshtml"
                              Write(Usuario.Correo);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </div>\n                <div>\n                    <b>Tipo de Usuario:</b> ");
#nullable restore
#line 38 "/Volumes/Disk Ismael/Desktop/ProyectosC#/Proyecto1/ProyectoWeb/Views/Home/Index.cshtml"
                                       Write(Usuario.TipoUsuario);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </div>\n                <div>\n                    <b>Telefono:</b> ");
#nullable restore
#line 41 "/Volumes/Disk Ismael/Desktop/ProyectosC#/Proyecto1/ProyectoWeb/Views/Home/Index.cshtml"
                                Write(Usuario.Telefono);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </div>\n                <div>\n                    <b>Imagen:</b> ");
#nullable restore
#line 44 "/Volumes/Disk Ismael/Desktop/ProyectosC#/Proyecto1/ProyectoWeb/Views/Home/Index.cshtml"
                              Write(Usuario.Imagen);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </div>\n                <div>\n                    <b>Aptitudes:</b> ");
#nullable restore
#line 47 "/Volumes/Disk Ismael/Desktop/ProyectosC#/Proyecto1/ProyectoWeb/Views/Home/Index.cshtml"
                                 Write(Usuario.Aptitudes);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </div>\n                <hr>\n            </div>\n");
#nullable restore
#line 51 "/Volumes/Disk Ismael/Desktop/ProyectosC#/Proyecto1/ProyectoWeb/Views/Home/Index.cshtml"
        }
    

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProyectoWeb.Models.BaseUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591