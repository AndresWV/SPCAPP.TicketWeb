#pragma checksum "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Avances\trbRealizadoVista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5dbb8e1a211bac7af125e78c05783c987ef2aec8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Avances_trbRealizadoVista), @"mvc.1.0.view", @"/Views/Avances/trbRealizadoVista.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5dbb8e1a211bac7af125e78c05783c987ef2aec8", @"/Views/Avances/trbRealizadoVista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dbb5a18410db83aa2bdacbf0ef617f44f652fec", @"/Views/_ViewImports.cshtml")]
    public class Views_Avances_trbRealizadoVista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SPCAPP.TicketWeb.Models.TicketSpc>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!--TRABAJO REALIZADO-->
<div class=""row"">
    <!--checks-->
    <div class=""row"">
        <div class=""col-6 form-check"">
            <label class=""form-check-label textForm3 ml-3 mr-5"" for=""trjProgramado"" >TRABAJO REALIZADO</label>
            <input class=""form-check-input ml-3"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 345, "\"", 353, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"trjRealizado\" />\r\n        </div>\r\n        <div class=\"col-3 form-check\">\r\n            <label class=\"form-check-label textForm3 ml-3 mr-3\" for=\"trjProgramado\">CON OT</label>\r\n            <input class=\"form-check-input ml-1\" type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 597, "\"", 605, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"trjRealizado\" />\r\n        </div>\r\n        <div class=\"col-3 form-check\">\r\n            <label class=\"form-check-label textForm3 ml-3 mr-3\" for=\"trjProgramado\">CON TW</label>\r\n            <input class=\"form-check-input ml-1\" type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 849, "\"", 857, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""trjRealizado"" />
        </div>
    </div>
    <div class=""row mt-3"">
        <div class=""col-7"">
            <div class=""col-5 float-left "">
                <div class=""row"">
                    <div class=""form-outline"">
                        <input type=""text"" id=""nOrden"" class=""form-control"" readonly />
                        <label class=""form-label"" for=""nOrden"">N° ORDEN</label>
                    </div>
                </div>
                <div class=""row mt-3"">
                    <input type=""date"" id=""dateTrabRlz"" name=""trip-start"" />
                </div>
            </div>
            <div class=""col-5 float-right"">
                <div class=""row"">
                    <input type=""time"" id=""hraIni"" name=""appt"" required>
                </div>
                <div class=""row mt-3"">
                    <input type=""time"" id=""hraTerm"" name=""appt2"" required>
                </div>
            </div>
        </div>
        <div class=""col-5"">
            <div clas");
            WriteLiteral(@"s=""col-5 float-lg-left"">
                <div class=""row"">
                    <div class=""row"">
                        <div class=""form-check"">
                            <input class=""form-check-input"" type=""radio"" name=""visitaCheckk"" id=""visitaCheck"">
                            <label class=""form-check-label"" for=""visitaCheck"">
                                VISITA
                            </label>
                        </div>
                    </div>
                    <div class=""row mt-3"">
                        <div class=""form-check"">
                            <input class=""form-check-input"" type=""radio"" name=""remotoCheckk"" id=""remotoCheck"">
                            <label class=""form-check-label"" for=""remotoCheck"">
                                REMOTO
                            </label>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-5 float-lg-right"">
                <div class=""");
            WriteLiteral(@"row float-lg-right"">
                    <div class=""row"">
                        <div class=""form-check"">
                            <input class=""form-check-input"" type=""radio"" name=""tallerCheckk"" id=""tallerCheck"">
                            <label class=""form-check-label"" for=""tallerCheck"">
                                TALLER
                            </label>
                        </div>
                    </div>
                    <div class=""row mt-3"">
                        <div class=""form-check"">
                            <input class=""form-check-input"" type=""radio"" name=""telCheckk"" id=""telCheck"">
                            <label class=""form-check-label"" for=""telCheck"">
                                TELEFONICO
                            </label>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""row mt-3"">
        <div class=""form-group"">
            <textarea class=""f");
            WriteLiteral(@"orm-control"" id=""trabaRejoDesc"" rows=""7""></textarea>
            <label for=""trabaRejoDesc"">DESCRIPCION DEL TRABAJO REALIZADO</label>
        </div>
    </div>
    <div class=""row mt-2"">
        <div class=""col-5"">
            <button type=""button"" onclick=""abrirGastos()"" class=""btn coloAction ml-3"">GASTOS</button>
        </div>
        <div class=""col-7"">
            <select class=""form-select float-lg-right"" id=""asignadoo2"" aria-label=""Default select example"">
                ASIGNADO
            </select>
        </div>
    </div>
    <div class=""row mt-3"" id=""gastosVista"" style=""display:none"">
        <!--Titulo-->
        <div class=""row"">
            <div class=""col-8 mr-3"">
                <h5 class=""text-right"">DESGLOSE DE GASTOS</h5>
            </div>
            <div class=""col-2"">
                <div class=""form-outline float-lg-right"">
                    <input class=""form-control"" id=""totalGastos"" readonly />
                    <label class=""form-label"" for=""totalGasto");
            WriteLiteral("s\">TOTAL</label>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <!--Datos-->\r\n        <div class=\"row mt-3\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5dbb8e1a211bac7af125e78c05783c987ef2aec89211", async() => {
                WriteLiteral(@"
                <div class=""col-5"">
                    <select class=""form-select"" id=""gastosSelect"" aria-label=""Default select example"">
                    </select>
                </div>
                <div class=""col-3"">
                    <div class=""form-outline"">
                        <input type=""number"" class=""form-control"" id=""cantidad"" readonly />
                        <label class=""form-label"" for=""cantidad"">CANTIDAD</label>
                    </div>
                </div>
                <div class=""col-3"">
                    <div class=""form-outline"">
                        <input type=""number"" class=""form-control"" id=""precioGasto"" readonly />
                        <label class=""form-label"" for=""precioGasto"">PRECIO</label>
                    </div>
                </div>
                <div class=""col-1"">
                    <a class=""btn coloAction""");
                BeginWriteAttribute("onclick", " onclick=\"", 6014, "\"", 6024, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fas fa-plus\"></i></a>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        </div>\r\n        <!--Tabla de gastos-->\r\n        <div class=\"row mt-2\" id=\"vistaGastoss\"></div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SPCAPP.TicketWeb.Models.TicketSpc> Html { get; private set; }
    }
}
#pragma warning restore 1591
