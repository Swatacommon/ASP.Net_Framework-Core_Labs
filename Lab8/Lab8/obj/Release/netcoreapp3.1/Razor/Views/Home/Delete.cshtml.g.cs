#pragma checksum "D:\Studying\Course_3\Second_2sem\ASP.NET\Labs\Lab8\Lab8\Views\Home\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80910b921c6120d5e92f11d3d0003d99f4a12fd2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Delete), @"mvc.1.0.view", @"/Views/Home/Delete.cshtml")]
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
#line 1 "D:\Studying\Course_3\Second_2sem\ASP.NET\Labs\Lab8\Lab8\Views\_ViewImports.cshtml"
using Lab8;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Studying\Course_3\Second_2sem\ASP.NET\Labs\Lab8\Lab8\Views\_ViewImports.cshtml"
using Lab8.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80910b921c6120d5e92f11d3d0003d99f4a12fd2", @"/Views/Home/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54392077b573ca062b662c621eb32a31c11c50ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab8.Models.Phone>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Studying\Course_3\Second_2sem\ASP.NET\Labs\Lab8\Lab8\Views\Home\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>Удаление</h2>\r\n\r\n<h3>Вы точно хотите удалить этот телефон?</h3>\r\n<div>\r\n    <hr />\r\n    <dl>\r\n        <dt>\r\n            ");
#nullable restore
#line 15 "D:\Studying\Course_3\Second_2sem\ASP.NET\Labs\Lab8\Lab8\Views\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 19 "D:\Studying\Course_3\Second_2sem\ASP.NET\Labs\Lab8\Lab8\Views\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 23 "D:\Studying\Course_3\Second_2sem\ASP.NET\Labs\Lab8\Lab8\Views\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Phone_Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 27 "D:\Studying\Course_3\Second_2sem\ASP.NET\Labs\Lab8\Lab8\Views\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Phone_Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n\r\n");
#nullable restore
#line 32 "D:\Studying\Course_3\Second_2sem\ASP.NET\Labs\Lab8\Lab8\Views\Home\Delete.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\Studying\Course_3\Second_2sem\ASP.NET\Labs\Lab8\Lab8\Views\Home\Delete.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <input type=\"submit\" value=\"Удалить\" />\r\n            <br />\r\n            <br />\r\n            ");
#nullable restore
#line 40 "D:\Studying\Course_3\Second_2sem\ASP.NET\Labs\Lab8\Lab8\Views\Home\Delete.cshtml"
       Write(Html.ActionLink("К списку телефонов", "Info"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 42 "D:\Studying\Course_3\Second_2sem\ASP.NET\Labs\Lab8\Lab8\Views\Home\Delete.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab8.Models.Phone> Html { get; private set; }
    }
}
#pragma warning restore 1591
