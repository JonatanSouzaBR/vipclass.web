#pragma checksum "/Users/jonatansouza/Desktop/Projetos/VIPCLASS/VIPCLASS/Views/Course/Start.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bca38e2460ba1fdcd60033c9cdfe949776e26f55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Start), @"mvc.1.0.view", @"/Views/Course/Start.cshtml")]
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
#line 1 "/Users/jonatansouza/Desktop/Projetos/VIPCLASS/VIPCLASS/Views/_ViewImports.cshtml"
using VIPCLASS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/jonatansouza/Desktop/Projetos/VIPCLASS/VIPCLASS/Views/_ViewImports.cshtml"
using VIPCLASS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bca38e2460ba1fdcd60033c9cdfe949776e26f55", @"/Views/Course/Start.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3827282ac71a3169a0eab465383cf4d9bd7acf2a", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_Start : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn card-single"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Course", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Single", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn card-multiple"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Multiple", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<style>\r\n    .card-single {\r\n        color: white !important;\r\n        border-radius: 35px !important;\r\n        border: 1px solid rgba(255, 255, 255, 0.1) !important;\r\n");
            WriteLiteral("        margin-left: 15%;\r\n        margin-top: 30px;\r\n        width: 450px;\r\n        padding: 64px 64px 42px;\r\n");
            WriteLiteral("        text-align: center;\r\n        -moz-box-align: center;\r\n        align-items: center;\r\n        -moz-box-pack: center;\r\n        justify-content: center;\r\n");
            WriteLiteral("        display: flex;\r\n        flex-direction: column;\r\n");
            WriteLiteral("    }\r\n\r\n    .card-multiple {\r\n        color: white !important;\r\n        border-radius: 35px !important;\r\n        border: 1px solid rgba(255, 255, 255, 0.1) !important;\r\n");
            WriteLiteral("         margin-left: -5%;\r\n        margin-top: 30px;\r\n        width: 450px;\r\n        padding: 64px 64px 42px;\r\n");
            WriteLiteral(" text-align: center;\r\n        -moz-box-align: center;\r\n        align-items: center;\r\n        -moz-box-pack: center;\r\n        justify-content: center;\r\n");
            WriteLiteral(" display: flex;\r\n        flex-direction: column;\r\n");
            WriteLiteral(" ");
            WriteLiteral(" ");
            WriteLiteral(" ");
            WriteLiteral(@"
    }

    .span-titulo {
        font-family: inherit;
        font-weight: 700;
        font-size: 46px;
        padding-left: 20px;
        margin-left: 5%;
        color: rgb(255, 255, 255);
    }

    .span-subtitulo {
        font-size: 22px;
        font-family: inherit;
        font-weight: inherit;
        vertical-align: inherit;
        color: rgb(140, 140, 140);
        margin: 0px;
        margin-top: 0px;
        padding: 0px;
        border: 0px none;
        margin-left: 7%;
        font-weight: 400;
        margin-top: 8px;
        width: 100%;
    }

    .span-subtitulo-white {
        color: white;
        font-size: 24px;
        font-family: inherit;
        font-weight: 700;
    }

    .span-subtitulo-grey {
        font-size: 16px;
        margin-top: 12px;
        font-family: inherit;
        font-weight: inherit;
        vertical-align: inherit;
        color: rgb(140, 140, 140);
    }

    .imagem{
        margin: 30px;
    }

</style");
            WriteLiteral(@">

<div class=""span-titulo"">
    <span>Choose Type</span>
</div>
<div class=""span-subtitulo"">
    <span>Choose “Single” for one of a kind or “Multiple” if you want to sell
    <br />one collectible multiple times</span>
</div>

<div class=""row"">
    <div class=""col-6"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bca38e2460ba1fdcd60033c9cdfe949776e26f557642", async() => {
                WriteLiteral(@"
            <img src=""/images/Single.png"" width=""60"" height=""92"" class=""imagem"">
            <span class=""span-subtitulo-white"" style=""margin: 10px"">
                Single
            </span>
            <span class=""span-subtitulo-grey"">
                If you want to highlight the uniqueness and individuality of your item
            </span>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n    <div class=\"col-6\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bca38e2460ba1fdcd60033c9cdfe949776e26f559677", async() => {
                WriteLiteral(@"
            <img src=""/images/Multiple.png"" width=""60"" height=""92"" class=""imagem"">
            <span class=""span-subtitulo-white"" style=""margin: 10px"">
                Multiple
            </span>
            <span class=""span-subtitulo-grey"">
                If you want to share your item with a large number of community members
            </span>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n</div>");
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
