#pragma checksum "C:\Users\user\source\repos\Week_13\Week_13\Views\Home\GetUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80c47b8dff133a71e5c2b6a19cae30f3601323ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetUsers), @"mvc.1.0.view", @"/Views/Home/GetUsers.cshtml")]
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
#line 1 "C:\Users\user\source\repos\Week_13\Week_13\Views\_ViewImports.cshtml"
using Week_13;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\Week_13\Week_13\Views\_ViewImports.cshtml"
using Week_13.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80c47b8dff133a71e5c2b6a19cae30f3601323ed", @"/Views/Home/GetUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"200fb79b6b602120a3de7f3de49c19ad9ee76f07", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_GetUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UserViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\user\source\repos\Week_13\Week_13\Views\Home\GetUsers.cshtml"
  
    ViewData["Title"] = "InsertUser";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>InsertUser</h1>

<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">First Name</th>
            <th scope=""col"">Last Name</th>
            <th scope=""col"">Doctor</th>
            <th scope=""col"">Visit Time</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 19 "C:\Users\user\source\repos\Week_13\Week_13\Views\Home\GetUsers.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 22 "C:\Users\user\source\repos\Week_13\Week_13\Views\Home\GetUsers.cshtml"
                           Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"row\">");
#nullable restore
#line 23 "C:\Users\user\source\repos\Week_13\Week_13\Views\Home\GetUsers.cshtml"
                           Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"row\">");
#nullable restore
#line 24 "C:\Users\user\source\repos\Week_13\Week_13\Views\Home\GetUsers.cshtml"
                           Write(item.Doctor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"row\">");
#nullable restore
#line 25 "C:\Users\user\source\repos\Week_13\Week_13\Views\Home\GetUsers.cshtml"
                           Write(item.Time.ToString("HH:mm M/d/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            </tr>\r\n");
#nullable restore
#line 27 "C:\Users\user\source\repos\Week_13\Week_13\Views\Home\GetUsers.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UserViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591