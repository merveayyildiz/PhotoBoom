#pragma checksum "C:\Users\MERVE-AYYILDIZ-PC\Documents\PhotoBoom\PhotoBoom\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42a44f5bcba6312a588dcffcd3e57dec3a6c6bcb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\MERVE-AYYILDIZ-PC\Documents\PhotoBoom\PhotoBoom\Views\_ViewImports.cshtml"
using PhotoBoom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MERVE-AYYILDIZ-PC\Documents\PhotoBoom\PhotoBoom\Views\_ViewImports.cshtml"
using PhotoBoom.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42a44f5bcba6312a588dcffcd3e57dec3a6c6bcb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb2979c8a926187e59d19eb3b689fcf07728ad58", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\MERVE-AYYILDIZ-PC\Documents\PhotoBoom\PhotoBoom\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    #p {\r\n        line-height:10;\r\n    }\r\n</style>\r\n\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\" >PhotoBoom</h1>\r\n    <p id=\"p\">Welcome to your favourite website.</p>\r\n    <a");
            BeginWriteAttribute("href", " href=\'", 238, "\'", 277, 1);
#nullable restore
#line 13 "C:\Users\MERVE-AYYILDIZ-PC\Documents\PhotoBoom\PhotoBoom\Views\Home\Index.cshtml"
WriteAttributeValue("", 245, Url.Action("MyPhotos", "Photo"), 245, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">My Photos</a>\r\n</div>\r\n");
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
