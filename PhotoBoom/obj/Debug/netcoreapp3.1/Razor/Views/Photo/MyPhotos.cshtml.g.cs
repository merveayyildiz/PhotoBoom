#pragma checksum "C:\Users\MERVE-AYYILDIZ-PC\Documents\PhotoBoom\PhotoBoom\Views\Photo\MyPhotos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "983596bb681ee2bc100316758cbd9ab66761ff93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Photo_MyPhotos), @"mvc.1.0.view", @"/Views/Photo/MyPhotos.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"983596bb681ee2bc100316758cbd9ab66761ff93", @"/Views/Photo/MyPhotos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb2979c8a926187e59d19eb3b689fcf07728ad58", @"/Views/_ViewImports.cshtml")]
    public class Views_Photo_MyPhotos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PhotoBoom.Models.Concrete.Photo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("250px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("150px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Click For Details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddPhoto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-align:center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\MERVE-AYYILDIZ-PC\Documents\PhotoBoom\PhotoBoom\Views\Photo\MyPhotos.cshtml"
  
    ViewData["Title"] = "MyPhotos";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n\r\n    #center {\r\n        text-align: center;\r\n    }\r\n</style>\r\n\r\n\r\n<h3 align=\"center\">My Photos</h3>\r\n<br />\r\n<br />\r\n<br />\r\n");
#nullable restore
#line 18 "C:\Users\MERVE-AYYILDIZ-PC\Documents\PhotoBoom\PhotoBoom\Views\Photo\MyPhotos.cshtml"
 if (ViewBag.NoPhotos != null)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div id=\"center\">");
#nullable restore
#line 21 "C:\Users\MERVE-AYYILDIZ-PC\Documents\PhotoBoom\PhotoBoom\Views\Photo\MyPhotos.cshtml"
                Write(ViewBag.NoPhotos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 22 "C:\Users\MERVE-AYYILDIZ-PC\Documents\PhotoBoom\PhotoBoom\Views\Photo\MyPhotos.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div align=\"center\">\r\n\r\n");
#nullable restore
#line 27 "C:\Users\MERVE-AYYILDIZ-PC\Documents\PhotoBoom\PhotoBoom\Views\Photo\MyPhotos.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 420, "\"", 450, 2);
            WriteAttributeValue("", 427, "/Photo/Details/", 427, 15, true);
#nullable restore
#line 29 "C:\Users\MERVE-AYYILDIZ-PC\Documents\PhotoBoom\PhotoBoom\Views\Photo\MyPhotos.cshtml"
WriteAttributeValue("", 442, item.Id, 442, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"margin:10px\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "983596bb681ee2bc100316758cbd9ab66761ff936849", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\MERVE-AYYILDIZ-PC\Documents\PhotoBoom\PhotoBoom\Views\Photo\MyPhotos.cshtml"
               WriteLiteral("~/img/"+item.ImageName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 30 "C:\Users\MERVE-AYYILDIZ-PC\Documents\PhotoBoom\PhotoBoom\Views\Photo\MyPhotos.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </a>\r\n");
#nullable restore
#line 32 "C:\Users\MERVE-AYYILDIZ-PC\Documents\PhotoBoom\PhotoBoom\Views\Photo\MyPhotos.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 34 "C:\Users\MERVE-AYYILDIZ-PC\Documents\PhotoBoom\PhotoBoom\Views\Photo\MyPhotos.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<br />\r\n<div style=\"text-align:center\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "983596bb681ee2bc100316758cbd9ab66761ff939641", async() => {
                WriteLiteral("Add Photo");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PhotoBoom.Models.Concrete.Photo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
