#pragma checksum "D:\Projects\Test\TestWebApp\TestWebApp\Views\Films\_PagingData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67a55a6a994938ce85a5e86d1a8aa955c71534c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Films__PagingData), @"mvc.1.0.view", @"/Views/Films/_PagingData.cshtml")]
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
#line 1 "D:\Projects\Test\TestWebApp\TestWebApp\Views\_ViewImports.cshtml"
using TestWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\Test\TestWebApp\TestWebApp\Views\_ViewImports.cshtml"
using TestWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67a55a6a994938ce85a5e86d1a8aa955c71534c6", @"/Views/Films/_PagingData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adcf018d0d57c86b8130e53afa8bfc7d57484832", @"/Views/_ViewImports.cshtml")]
    public class Views_Films__PagingData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TestWebApp.Models.FilmsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Films", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-currentPage", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-label", new global::Microsoft.AspNetCore.Html.HtmlString("Frist"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-label", new global::Microsoft.AspNetCore.Html.HtmlString("Next"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-label", new global::Microsoft.AspNetCore.Html.HtmlString("Previous"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-label", new global::Microsoft.AspNetCore.Html.HtmlString("Last"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Projects\Test\TestWebApp\TestWebApp\Views\Films\_PagingData.cshtml"
  
    ViewData["Title"] = "_PagingData";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div style=\"float: right;\">\r\n    <button class=\"btnAccept btnNew\"");
            BeginWriteAttribute("onclick", " onclick=\"", 153, "\"", 213, 3);
            WriteAttributeValue("", 163, "location.href=\'", 163, 15, true);
#nullable restore
#line 8 "D:\Projects\Test\TestWebApp\TestWebApp\Views\Films\_PagingData.cshtml"
WriteAttributeValue("", 178, Url.Action("CreateFilm", "Films"), 178, 34, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 212, "\'", 212, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">Создать новую запись</button>   
</div>

<table class=""mat-table table table-bordered"">
    <thead role=""rowgroup"">
        <tr class=""mat-header-row"">
            <td class=""mat-cell tableHeader"">Название</td>
            <td class=""mat-cell tableHeader"">Описание</td>
            <td class=""mat-cell tableHeader"">год выпуска</td>
            <td class=""mat-cell tableHeader"">Режиссёр</td>
            <td class=""mat-cell tableHeader"">Постер</td>
            <td class=""mat-cell tableHeader""></td>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 23 "D:\Projects\Test\TestWebApp\TestWebApp\Views\Films\_PagingData.cshtml"
         foreach (var data in Model.FilmList)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td class=\"mat-cell\">");
#nullable restore
#line 26 "D:\Projects\Test\TestWebApp\TestWebApp\Views\Films\_PagingData.cshtml"
                                Write(data.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"mat-cell\">");
#nullable restore
#line 27 "D:\Projects\Test\TestWebApp\TestWebApp\Views\Films\_PagingData.cshtml"
                                Write(data.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"mat-cell\">");
#nullable restore
#line 28 "D:\Projects\Test\TestWebApp\TestWebApp\Views\Films\_PagingData.cshtml"
                                Write(data.ReleaseYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"mat-cell\">");
#nullable restore
#line 29 "D:\Projects\Test\TestWebApp\TestWebApp\Views\Films\_PagingData.cshtml"
                                 Write(data.Director?.Name ?? "Нет данных");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"mat-cell\">\r\n");
#nullable restore
#line 31 "D:\Projects\Test\TestWebApp\TestWebApp\Views\Films\_PagingData.cshtml"
                     if (data.Poster != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img");
            BeginWriteAttribute("src", " src=", 1239, "", 1302, 1);
#nullable restore
#line 33 "D:\Projects\Test\TestWebApp\TestWebApp\Views\Films\_PagingData.cshtml"
WriteAttributeValue("", 1244, $"data:{data.Poster.Type};base64,{data.Poster.Content}", 1244, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"80\" height=\"80\">\r\n");
#nullable restore
#line 34 "D:\Projects\Test\TestWebApp\TestWebApp\Views\Films\_PagingData.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td class=\"mat-cell\">\r\n                    <div class=\"btnContainer\"");
            BeginWriteAttribute("id", " id=\"", 1458, "\"", 1484, 2);
            WriteAttributeValue("", 1463, "btnContainer_", 1463, 13, true);
#nullable restore
#line 37 "D:\Projects\Test\TestWebApp\TestWebApp\Views\Films\_PagingData.cshtml"
WriteAttributeValue("", 1476, data.Id, 1476, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 38 "D:\Projects\Test\TestWebApp\TestWebApp\Views\Films\_PagingData.cshtml"
                         if (data.IsOwner)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <button class=\"btnAccept btnReject\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1622, "\"", 1652, 3);
            WriteAttributeValue("", 1632, "deleteFilm(", 1632, 11, true);
#nullable restore
#line 40 "D:\Projects\Test\TestWebApp\TestWebApp\Views\Films\_PagingData.cshtml"
WriteAttributeValue("", 1643, data.Id, 1643, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1651, ")", 1651, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Удалить</button>\r\n                            <button class=\"btnAccept btnFixed\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1734, "\"", 1820, 3);
            WriteAttributeValue("", 1744, "location.href=\'", 1744, 15, true);
#nullable restore
#line 41 "D:\Projects\Test\TestWebApp\TestWebApp\Views\Films\_PagingData.cshtml"
WriteAttributeValue("", 1759, Url.Action("UpdateFilm", "Films", new { filmId = data.Id }), 1759, 60, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1819, "\'", 1819, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Редактировать</button>\r\n");
#nullable restore
#line 42 "D:\Projects\Test\TestWebApp\TestWebApp\Views\Films\_PagingData.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 46 "D:\Projects\Test\TestWebApp\TestWebApp\Views\Films\_PagingData.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<nav aria-label=\"Page navigation\">\r\n    <ul class=\"pagination flex-wrap\">\r\n        <li");
            BeginWriteAttribute("class", " class=\"", 2066, "\"", 2128, 2);
            WriteAttributeValue("", 2074, "page-item", 2074, 9, true);
#nullable restore
#line 52 "D:\Projects\Test\TestWebApp\TestWebApp\Views\Films\_PagingData.cshtml"
WriteAttributeValue(" ", 2083, Model.EnablePrevious ? " " : " disabled" , 2084, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67a55a6a994938ce85a5e86d1a8aa955c71534c612594", async() => {
                WriteLiteral("\r\n                <span aria-hidden=\"true\">|<</span>\r\n                <span class=\"sr-only\">First</span>\r\n            ");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-currentPage", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentPage"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </li>\r\n        <li");
            BeginWriteAttribute("class", " class=\"", 2434, "\"", 2496, 2);
            WriteAttributeValue("", 2442, "page-item", 2442, 9, true);
#nullable restore
#line 60 "D:\Projects\Test\TestWebApp\TestWebApp\Views\Films\_PagingData.cshtml"
WriteAttributeValue(" ", 2451, Model.EnablePrevious ? " " : " disabled" , 2452, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67a55a6a994938ce85a5e86d1a8aa955c71534c615275", async() => {
                WriteLiteral("\r\n                <span aria-hidden=\"true\"><</span>\r\n                <span class=\"sr-only\">Next</span>\r\n            ");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-currentPage", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "D:\Projects\Test\TestWebApp\TestWebApp\Views\Films\_PagingData.cshtml"
                           WriteLiteral(Model.CurrentPage -1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentPage"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentPage", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentPage"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </li>\r\n");
#nullable restore
#line 68 "D:\Projects\Test\TestWebApp\TestWebApp\Views\Films\_PagingData.cshtml"
          
            var startIndex = Model.CurrentPage - 2 > 0 ? 0 : Model.CurrentPage - 2 - 1;
            var endIndex = Model.TotalPages - Model.CurrentPage > 2 ? 0 : Model.TotalPages - Model.CurrentPage - 2;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "D:\Projects\Test\TestWebApp\TestWebApp\Views\Films\_PagingData.cshtml"
         for (var i = Model.CurrentPage - 2 + endIndex; i <= Model.CurrentPage + 2 - startIndex; i++)
        {
            if (i > 0 && i <= Model.TotalPages)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li");
            BeginWriteAttribute("class", " class=\"", 3236, "\"", 3297, 2);
            WriteAttributeValue("", 3244, "page-item", 3244, 9, true);
#nullable restore
#line 76 "D:\Projects\Test\TestWebApp\TestWebApp\Views\Films\_PagingData.cshtml"
WriteAttributeValue(" ", 3253, i == Model.CurrentPage ? " active" : "" , 3254, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67a55a6a994938ce85a5e86d1a8aa955c71534c619201", async() => {
#nullable restore
#line 79 "D:\Projects\Test\TestWebApp\TestWebApp\Views\Films\_PagingData.cshtml"
                                    Write(i);

#line default
#line hidden
#nullable disable
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-currentPage", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "D:\Projects\Test\TestWebApp\TestWebApp\Views\Films\_PagingData.cshtml"
                                  WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentPage"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentPage", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentPage"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 81 "D:\Projects\Test\TestWebApp\TestWebApp\Views\Films\_PagingData.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li");
            BeginWriteAttribute("class", " class=\"", 3527, "\"", 3585, 2);
            WriteAttributeValue("", 3535, "page-item", 3535, 9, true);
#nullable restore
#line 83 "D:\Projects\Test\TestWebApp\TestWebApp\Views\Films\_PagingData.cshtml"
WriteAttributeValue(" ", 3544, Model.EnableNext ? " " : " disabled" , 3545, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67a55a6a994938ce85a5e86d1a8aa955c71534c622527", async() => {
                WriteLiteral("\r\n                <span aria-hidden=\"true\">></span>\r\n                <span class=\"sr-only\">Previous</span>\r\n            ");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-currentpage", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "D:\Projects\Test\TestWebApp\TestWebApp\Views\Films\_PagingData.cshtml"
                           WriteLiteral(Model.CurrentPage + 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentpage"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentpage", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentpage"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </li>\r\n        <li");
            BeginWriteAttribute("class", " class=\"", 3919, "\"", 3977, 2);
            WriteAttributeValue("", 3927, "page-item", 3927, 9, true);
#nullable restore
#line 91 "D:\Projects\Test\TestWebApp\TestWebApp\Views\Films\_PagingData.cshtml"
WriteAttributeValue(" ", 3936, Model.EnableNext ? " " : " disabled" , 3937, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67a55a6a994938ce85a5e86d1a8aa955c71534c625700", async() => {
                WriteLiteral("\r\n                <span aria-hidden=\"true\">>|</span>\r\n                <span class=\"sr-only\">Last</span>\r\n            ");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-currentPage", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 93 "D:\Projects\Test\TestWebApp\TestWebApp\Views\Films\_PagingData.cshtml"
                          WriteLiteral(Model.TotalPages);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentPage"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentPage", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentPage"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </li>\r\n    </ul>\r\n</nav>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TestWebApp.Models.FilmsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
