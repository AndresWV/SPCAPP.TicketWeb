#pragma checksum "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\TicketSpc\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "544d819a8e18448b50a15445c76525f3323cb9f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TicketSpc_Index), @"mvc.1.0.view", @"/Views/TicketSpc/Index.cshtml")]
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
#line 1 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\_ViewImports.cshtml"
using SPCAPP.TicketWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\_ViewImports.cshtml"
using SPCAPP.TicketWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"544d819a8e18448b50a15445c76525f3323cb9f0", @"/Views/TicketSpc/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dbb5a18410db83aa2bdacbf0ef617f44f652fec", @"/Views/_ViewImports.cshtml")]
    public class Views_TicketSpc_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SPCAPP.TicketWeb.Models.TicketSpc>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/indexTicket.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\TicketSpc\Index.cshtml"
  
    ViewData["Title"] = "Lista de ticket";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container AREA_PARTIAL_VIEW\">\r\n    <!--Notificacion de que el Ticket se a creado correctamente-->\r\n");
#nullable restore
#line 9 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\TicketSpc\Index.cshtml"
     if (TempData["mensaje"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-warning alert-dismissible fade show\" role=\"alert\">\r\n            ");
#nullable restore
#line 12 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\TicketSpc\Index.cshtml"
       Write(TempData["mensaje"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n                <span aria-hidden=\"true\">&times;</span>\r\n            </button>\r\n        </div>\r\n");
#nullable restore
#line 17 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\TicketSpc\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row mb-4"">
        <div class=""col-sm-7"" style=""margin-left:5%"">
            <h3 class=""text-right"">TICKET GENERADOS</h3>
        </div>
        <div class=""col-sm-4"">

            <a class=""btn float-lg-right colorB"" onclick=""crearModal(1,0)"">Crear Ticket</a>
        </div>
    </div>



    <div class=""row"">

");
#nullable restore
#line 32 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\TicketSpc\Index.cshtml"
         if (Model.Count() > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table id=""dtBasicExample"" class=""table table-bordered table-hover w-100"" style=""display:none"">
                <thead class=""table-striped"">
                    <tr class=""table-striped text-white small"">
                        <td class=""text-uppercase"">");
#nullable restore
#line 37 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\TicketSpc\Index.cshtml"
                                              Write(Html.DisplayNameFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-uppercase\">");
#nullable restore
#line 38 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\TicketSpc\Index.cshtml"
                                              Write(Html.DisplayNameFor(m => m.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-uppercase\">");
#nullable restore
#line 39 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\TicketSpc\Index.cshtml"
                                              Write(Html.DisplayNameFor(m => m.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-uppercase\">");
#nullable restore
#line 40 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\TicketSpc\Index.cshtml"
                                              Write(Html.DisplayNameFor(m => m.Empresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        <td class=\"text-uppercase\">");
#nullable restore
#line 42 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\TicketSpc\Index.cshtml"
                                              Write(Html.DisplayNameFor(m => m.Tecnico));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        <td>ACCIONES</td>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 48 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\TicketSpc\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr class=\"w-100\">\r\n                            <td>");
#nullable restore
#line 51 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\TicketSpc\Index.cshtml"
                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 52 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\TicketSpc\Index.cshtml"
                           Write(item.Fecha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"text-uppercase\">");
#nullable restore
#line 53 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\TicketSpc\Index.cshtml"
                                                  Write(item.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"text-uppercase\">");
#nullable restore
#line 54 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\TicketSpc\Index.cshtml"
                                                  Write(item.Empresa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                            <td class=\"text-uppercase\">");
#nullable restore
#line 57 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\TicketSpc\Index.cshtml"
                                                  Write(item.Tecnico);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                            <td>\r\n");
#nullable restore
#line 60 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\TicketSpc\Index.cshtml"
                                  
                                    ViewData["idd"] = (int)@item.Id;
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <!--Ver-->\r\n                                <a class=\"btn coloAction\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2538, "\"", 2570, 3);
            WriteAttributeValue("", 2548, "crearModal(2,", 2548, 13, true);
#nullable restore
#line 64 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\TicketSpc\Index.cshtml"
WriteAttributeValue("", 2561, item.Id, 2561, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2569, ")", 2569, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-search-plus\"></i></a>\r\n");
#nullable restore
#line 65 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\TicketSpc\Index.cshtml"
                                 if (item.Estado.ToString() != "TERMINADO")
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <!--Editar-->\r\n                                    <a class=\"btn coloAction\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2836, "\"", 2868, 3);
            WriteAttributeValue("", 2846, "crearModal(3,", 2846, 13, true);
#nullable restore
#line 68 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\TicketSpc\Index.cshtml"
WriteAttributeValue("", 2859, item.Id, 2859, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2867, ")", 2867, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-edit\"></i></a>\r\n");
#nullable restore
#line 69 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\TicketSpc\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <!--Editar-->\r\n                                    <a class=\"btn coloAction2\" disabled><i class=\"fas fa-edit\"></i></a>\r\n");
#nullable restore
#line 74 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\TicketSpc\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <!--Eliminar-->\r\n                                <a class=\"btn coloAction\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3308, "\"", 3340, 3);
            WriteAttributeValue("", 3318, "crearModal(4,", 3318, 13, true);
#nullable restore
#line 76 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\TicketSpc\Index.cshtml"
WriteAttributeValue("", 3331, item.Id, 3331, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3339, ")", 3339, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-trash-alt\"></i></a>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 79 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\TicketSpc\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 82 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\TicketSpc\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>No existen registros</p>\r\n");
#nullable restore
#line 86 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\TicketSpc\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <div id=""load"">
            <center><img src=""https://novacer.spcapp.cl/loading.gif"" /></center>
        </div>
       
            <div class=""modal fade"" id=""modalCreate"" data-mdb-backdrop=""static"" data-mdb-keyboard=""false"" tabindex=""-1""
                 aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
            </div>
               <div class=""modal fade"" id=""modelMike"" data-mdb-backdrop=""static"" data-mdb-keyboard=""false"" tabindex=""-1""
             aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
            <div class=""modal-dialog modal-lg"">
                <div class=""modal-content"">
                    <!--Titulo-->
                    <div class=""modal-header modalColor"">
                        <div class=""col-8"">
                            <h5 id=""staticBackdropLabel"" class=""modal-title titulo"">TICKET SPCAA</h5>
                        </div>
                        <div class=""col-4"">
                            <button type=""button"" class=""close"" da");
            WriteLiteral(@"ta-dismiss=""modal"" aria-label=""Close"">
                                <span aria-hidden=""true"">&times;</span>
                            </button>
                        </div>
                    </div>

                    <div class=""modal-body"">
                        <h1>Contenido prueba</h1>
                    </div>

                    <div class=""modal-footer modalColor"">

                        <div class=""col text-center"">
                            <button type=""submit"" class=""btn btn-lg buttCreate"" style=""background: white;"">Crear Ticket</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "544d819a8e18448b50a15445c76525f3323cb9f016616", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SPCAPP.TicketWeb.Models.TicketSpc>> Html { get; private set; }
    }
}
#pragma warning restore 1591
