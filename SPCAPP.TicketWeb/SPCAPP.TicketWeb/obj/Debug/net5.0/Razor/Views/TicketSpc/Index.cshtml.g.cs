#pragma checksum "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\TicketSpc\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5059c79ab73747161098509b49f218e2a658541a"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5059c79ab73747161098509b49f218e2a658541a", @"/Views/TicketSpc/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dbb5a18410db83aa2bdacbf0ef617f44f652fec", @"/Views/_ViewImports.cshtml")]
    public class Views_TicketSpc_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SPCAPP.TicketWeb.Models.TicketSpc>>
    {
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
            WriteLiteral("</td>\r\n\r\n                            <td>\r\n                                <!--Ver-->\r\n                                <a class=\"btn coloAction\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2397, "\"", 2429, 3);
            WriteAttributeValue("", 2407, "crearModal(2,", 2407, 13, true);
#nullable restore
#line 61 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\TicketSpc\Index.cshtml"
WriteAttributeValue("", 2420, item.Id, 2420, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2428, ")", 2428, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-search-plus\"></i></a>\r\n                                <!--Editar-->\r\n                                <a class=\"btn coloAction\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2575, "\"", 2607, 3);
            WriteAttributeValue("", 2585, "crearModal(3,", 2585, 13, true);
#nullable restore
#line 63 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\TicketSpc\Index.cshtml"
WriteAttributeValue("", 2598, item.Id, 2598, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2606, ")", 2606, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-edit\"></i></a>\r\n                                <!--Eliminar-->\r\n                                <a class=\"btn coloAction\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2748, "\"", 2780, 3);
            WriteAttributeValue("", 2758, "crearModal(4,", 2758, 13, true);
#nullable restore
#line 65 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\TicketSpc\Index.cshtml"
WriteAttributeValue("", 2771, item.Id, 2771, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2779, ")", 2779, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-trash-alt\"></i></a>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 68 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\TicketSpc\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 71 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\TicketSpc\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>No existen registros</p>\r\n");
#nullable restore
#line 75 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\TicketSpc\Index.cshtml"
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
                WriteLiteral(@"
    <script>
        //Cargar los script como al abrir el modal no se estaban cargando debido a que al abrir una ventana emergente
        //no se vuelven a llamar
        function cargarScript() {
            //modal
            var s = document.createElement(""script"");
            s.type = ""text/javascript"";
            s.src = ""/js/modal.js"";
            $(""head"").append(s);
            //mdb input
            var s2 = document.createElement(""script"");
            s2.type = ""text/javascript"";
            s2.src = ""/js/lineasInput.js"";
            $(""head"").append(s2);
            //calendario
            var s3 = document.createElement(""script"");
            s3.type = ""text/javascript"";
            s3.src = ""/js/calendarBack.js"";
            $(""head"").append(s3);

            $('#modalCreate').modal(""show"");
        }
        //Controlar que modal se abrira
        function crearModal(buttonOption, idd) {
            //Crear ticket
            if (buttonOption == 1) {
          ");
                WriteLiteral(@"      $(""#modalCreate"").load(""/TicketSpc/Create"", function () {
                    cargarScript();
                });
            }
            //ver ticket
            else if (buttonOption == 2) {
                $(""#modalCreate"").load(""/TicketSpc/View"", { id : idd} ,function () {
                    cargarScript();
                });
            }
            //Editat ticket
            else if (buttonOption == 3) {
                $(""#modalCreate"").load(""/TicketSpc/Edit"", { id: idd }, function () {
                    cargarScript();
                });
            }
            //Eliminar ticket
            else {
                $(""#modalCreate"").load(""/TicketSpc/Delete"", { id: idd }, function () {
                    cargarScript();
                });
            }
        }
    </script>
");
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