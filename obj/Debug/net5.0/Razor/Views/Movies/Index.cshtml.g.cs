#pragma checksum "F:\DotNetProjects\Movies\Movies\Views\Movies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11af70a2a0cb160149d148d1782149b10708d27a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Index), @"mvc.1.0.view", @"/Views/Movies/Index.cshtml")]
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
#line 1 "F:\DotNetProjects\Movies\Movies\Views\_ViewImports.cshtml"
using Movies;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\DotNetProjects\Movies\Movies\Views\_ViewImports.cshtml"
using Movies.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\DotNetProjects\Movies\Movies\Views\_ViewImports.cshtml"
using Movies.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11af70a2a0cb160149d148d1782149b10708d27a", @"/Views/Movies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e08fd9e0b71eca44659473198d29eda78a53330", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Movies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Movie>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "F:\DotNetProjects\Movies\Movies\Views\Movies\Index.cshtml"
  
    ViewData["Title"]="Movies";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>\r\n    <i class=\"bi bi-film\"></i>\r\n    Movies\r\n    \r\n</h2>\r\n<hr>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11af70a2a0cb160149d148d1782149b10708d27a4166", async() => {
                WriteLiteral("\r\n    <i class=\"bi bi-plus-lg\"></i>\r\n    Add New Movie\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"mt-4\">\r\n");
#nullable restore
#line 19 "F:\DotNetProjects\Movies\Movies\Views\Movies\Index.cshtml"
     if (!Model.Any())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-warning\" role=\"alert\">\r\n            <i class=\"bi bi-exclamation-triangle\"></i>\r\n            No Movies Found!\r\n        </div>\r\n");
#nullable restore
#line 25 "F:\DotNetProjects\Movies\Movies\Views\Movies\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <ul>\r\n");
#nullable restore
#line 29 "F:\DotNetProjects\Movies\Movies\Views\Movies\Index.cshtml"
             foreach(var movie in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>");
#nullable restore
#line 31 "F:\DotNetProjects\Movies\Movies\Views\Movies\Index.cshtml"
               Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 32 "F:\DotNetProjects\Movies\Movies\Views\Movies\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n");
#nullable restore
#line 34 "F:\DotNetProjects\Movies\Movies\Views\Movies\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Movie>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
