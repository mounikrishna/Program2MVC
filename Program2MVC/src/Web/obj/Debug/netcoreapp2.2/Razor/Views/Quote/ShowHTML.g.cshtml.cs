#pragma checksum "C:\Users\S533897\Documents\SEMESTER 2\C#.NET\Program2MVC\Program2MVC\src\Web\Views\Quote\ShowHTML.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7c84e81bce1c34800c1d6e1a500f514057ee602"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quote_ShowHTML), @"mvc.1.0.view", @"/Views/Quote/ShowHTML.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Quote/ShowHTML.cshtml", typeof(AspNetCore.Views_Quote_ShowHTML))]
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
#line 1 "C:\Users\S533897\Documents\SEMESTER 2\C#.NET\Program2MVC\Program2MVC\src\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#line 2 "C:\Users\S533897\Documents\SEMESTER 2\C#.NET\Program2MVC\Program2MVC\src\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7c84e81bce1c34800c1d6e1a500f514057ee602", @"/Views/Quote/ShowHTML.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_Quote_ShowHTML : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\S533897\Documents\SEMESTER 2\C#.NET\Program2MVC\Program2MVC\src\Web\Views\Quote\ShowHTML.cshtml"
  
    ViewData["Title"] = "HTML";

#line default
#line hidden
            BeginContext(40, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(45, 17, false);
#line 4 "C:\Users\S533897\Documents\SEMESTER 2\C#.NET\Program2MVC\Program2MVC\src\Web\Views\Quote\ShowHTML.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(62, 38, true);
            WriteLiteral("</h1>\r\n\r\n<p>This is a HTML page.</p>\r\n");
            EndContext();
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
