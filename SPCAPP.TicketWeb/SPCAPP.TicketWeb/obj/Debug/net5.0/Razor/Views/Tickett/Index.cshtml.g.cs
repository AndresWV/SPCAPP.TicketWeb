#pragma checksum "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3729543afb0ad55042c5d2c9b1555ca2e507d598"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tickett_Index), @"mvc.1.0.view", @"/Views/Tickett/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3729543afb0ad55042c5d2c9b1555ca2e507d598", @"/Views/Tickett/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dbb5a18410db83aa2bdacbf0ef617f44f652fec", @"/Views/_ViewImports.cshtml")]
    public class Views_Tickett_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SPCAPP.TicketWeb.Models.Tickett>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success d-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Tickett", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
  
    ViewData["Title"] = "Lista de ticket";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <!--Notificacion de que el Ticket se a creado correctamente-->\r\n");
#nullable restore
#line 10 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
     if (TempData["mensaje"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-warning alert-dismissible fade show\" role=\"alert\">\r\n            ");
#nullable restore
#line 13 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
       Write(TempData["mensaje"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n                <span aria-hidden=\"true\">&times;</span>\r\n            </button>\r\n        </div>\r\n");
#nullable restore
#line 18 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-sm-6\">\r\n            <h3>Lista de Ticket</h3>\r\n        </div>\r\n        <div class=\"col-sm-6\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3729543afb0ad55042c5d2c9b1555ca2e507d5987102", async() => {
                WriteLiteral("Crear Ticket");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 28 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
         if (Model.Count() > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <table class=\"table table-bordered table-striped\">\r\n                <thead>\r\n                    <tr>\r\n                        <td>");
#nullable restore
#line 33 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 34 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.Folio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 35 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 36 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.Hora));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 37 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 38 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.Cliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 39 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.Alias));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 40 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.Emailempresa));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 41 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.Contacto));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 42 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.Telefono1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 43 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.Telefono2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 44 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.Telefono3));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 45 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 46 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.ModoContacto));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 47 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.AreaTrabajo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 48 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.TipoSoporte));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 49 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.Asignado));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 50 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.Proyecto));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 51 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                       Write(Html.DisplayNameFor(m => m.ResumenTicket));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>Acciones</td>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 56 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 59 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 60 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                           Write(item.Folio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 61 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                           Write(item.Fecha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 62 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                           Write(item.Hora);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 63 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                           Write(item.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 64 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                           Write(item.Cliente);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 65 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                           Write(item.Alias);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 66 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                           Write(item.Emailempresa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 67 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                           Write(item.Contacto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 68 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                           Write(item.Telefono1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 69 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                           Write(item.Telefono2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 70 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                           Write(item.Telefono3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 71 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                           Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 72 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                           Write(item.ModoContacto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 73 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                           Write(item.AreaTrabajo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 74 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                           Write(item.TipoSoporte);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 75 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                           Write(item.Asignado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 76 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                           Write(item.Proyecto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 77 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                           Write(item.ResumenTicket);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3729543afb0ad55042c5d2c9b1555ca2e507d59821457", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
#line 79 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                                                                                WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3729543afb0ad55042c5d2c9b1555ca2e507d59823993", async() => {
                WriteLiteral("Eliminar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                                                                                  WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 83 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 86 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>No existen registros</p>\r\n");
#nullable restore
#line 90 "C:\Users\andre\Desktop\C#\SPCAPP_TicketWeb\SPCAPP.TicketWeb\SPCAPP.TicketWeb\Views\Tickett\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SPCAPP.TicketWeb.Models.Tickett>> Html { get; private set; }
    }
}
#pragma warning restore 1591
