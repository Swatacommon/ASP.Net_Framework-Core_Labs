#pragma checksum "D:\Studying\Course_3\Second_2sem\ASP.NET (+)\Labs\Lab8\Lab8\Views\Home\Info.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51f4b206d96c34d113c6096390e174e531db76b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Info), @"mvc.1.0.view", @"/Views/Home/Info.cshtml")]
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
#line 1 "D:\Studying\Course_3\Second_2sem\ASP.NET (+)\Labs\Lab8\Lab8\Views\_ViewImports.cshtml"
using Lab8;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Studying\Course_3\Second_2sem\ASP.NET (+)\Labs\Lab8\Lab8\Views\_ViewImports.cshtml"
using Lab8.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51f4b206d96c34d113c6096390e174e531db76b9", @"/Views/Home/Info.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54392077b573ca062b662c621eb32a31c11c50ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Info : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Lab8.Models.Phone>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Studying\Course_3\Second_2sem\ASP.NET (+)\Labs\Lab8\Lab8\Views\Home\Info.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    tr {\r\n        border: 1px solid #000000;\r\n    }\r\n</style>\r\n\r\n<h2>Index</h2>\r\n<p><a href=\"/Home/Add\">Добавить</a></p>\r\n\r\n<table>\r\n    <tr>\r\n        <td>Имя</td>\r\n        <td>Телефон</td>\r\n        <td></td>\r\n        <td></td>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 23 "D:\Studying\Course_3\Second_2sem\ASP.NET (+)\Labs\Lab8\Lab8\Views\Home\Info.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 26 "D:\Studying\Course_3\Second_2sem\ASP.NET (+)\Labs\Lab8\Lab8\Views\Home\Info.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "D:\Studying\Course_3\Second_2sem\ASP.NET (+)\Labs\Lab8\Lab8\Views\Home\Info.cshtml"
           Write(item.Phone_Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><p><a");
            BeginWriteAttribute("href", " href=\"", 487, "\"", 515, 2);
            WriteAttributeValue("", 494, "/Home/Update/", 494, 13, true);
#nullable restore
#line 28 "D:\Studying\Course_3\Second_2sem\ASP.NET (+)\Labs\Lab8\Lab8\Views\Home\Info.cshtml"
WriteAttributeValue("", 507, item.Id, 507, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Обновить</a></p></td>\r\n            <td><p><a");
            BeginWriteAttribute("href", " href=\"", 561, "\"", 589, 2);
            WriteAttributeValue("", 568, "/Home/Delete/", 568, 13, true);
#nullable restore
#line 29 "D:\Studying\Course_3\Second_2sem\ASP.NET (+)\Labs\Lab8\Lab8\Views\Home\Info.cshtml"
WriteAttributeValue("", 581, item.Id, 581, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Удалить</a></p></td>\r\n        </tr>\r\n");
#nullable restore
#line 31 "D:\Studying\Course_3\Second_2sem\ASP.NET (+)\Labs\Lab8\Lab8\Views\Home\Info.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Lab8.Models.Phone>> Html { get; private set; }
    }
}
#pragma warning restore 1591
