#pragma checksum "D:\6th semester\Enterprise Application Development\EAD\ASP.NET CORE MVC\13) Ajax\webapp\Views\Shared\_Partial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49317fc87b38c0229f7ebb3e037f0b5f048bf90e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Partial), @"mvc.1.0.view", @"/Views/Shared/_Partial.cshtml")]
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
#line 1 "D:\6th semester\Enterprise Application Development\EAD\ASP.NET CORE MVC\13) Ajax\webapp\Views\_ViewImports.cshtml"
using webapp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\6th semester\Enterprise Application Development\EAD\ASP.NET CORE MVC\13) Ajax\webapp\Views\_ViewImports.cshtml"
using webapp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49317fc87b38c0229f7ebb3e037f0b5f048bf90e", @"/Views/Shared/_Partial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9199b4e53545c67bd84ad2eaa2357bc02933d8df", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Partial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div style=\"background-color:yellow; padding:10px; margin: 0 0 10px 0; box-shadow: 0 0 20px;\">\r\n    <h1>This is Partial View</h1>\r\n    <p>Name I got using ViewBag: ");
#nullable restore
#line 3 "D:\6th semester\Enterprise Application Development\EAD\ASP.NET CORE MVC\13) Ajax\webapp\Views\Shared\_Partial.cshtml"
                            Write(ViewBag.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Age I got using ViewData: ");
#nullable restore
#line 4 "D:\6th semester\Enterprise Application Development\EAD\ASP.NET CORE MVC\13) Ajax\webapp\Views\Shared\_Partial.cshtml"
                            Write(ViewData["age"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591