#pragma checksum "C:\Users\alitan\Desktop\MvcCoreSample\MvcCoreSample\MvcCoreSample\Views\Product\Components\ProductCard\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e02fdd7a416e9e7e5fc1a95c42186a3fb76fe62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Components_ProductCard_Default), @"mvc.1.0.view", @"/Views/Product/Components/ProductCard/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Components/ProductCard/Default.cshtml", typeof(AspNetCore.Views_Product_Components_ProductCard_Default))]
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
#line 1 "C:\Users\alitan\Desktop\MvcCoreSample\MvcCoreSample\MvcCoreSample\Views\_ViewImports.cshtml"
using MvcCoreSample;

#line default
#line hidden
#line 2 "C:\Users\alitan\Desktop\MvcCoreSample\MvcCoreSample\MvcCoreSample\Views\_ViewImports.cshtml"
using MvcCoreSample.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e02fdd7a416e9e7e5fc1a95c42186a3fb76fe62", @"/Views/Product/Components/ProductCard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"587dda7943de2fac7511111b146e30e504ce5822", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Components_ProductCard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MvcCoreSample.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Card image cap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 58, true);
            WriteLiteral("\r\n\r\n    <div class=\"card\" style=\"width: 18rem;\">\r\n        ");
            EndContext();
            BeginContext(95, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f1ce56cdc8b844f9808fdf65afb8e862", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 126, "~/images/", 126, 9, true);
#line 5 "C:\Users\alitan\Desktop\MvcCoreSample\MvcCoreSample\MvcCoreSample\Views\Product\Components\ProductCard\Default.cshtml"
AddHtmlAttributeValue("", 135, Model.Image, 135, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(195, 70, true);
            WriteLiteral("\r\n        <div class=\"card-body\">\r\n            <h4 class=\"card-title\">");
            EndContext();
            BeginContext(266, 10, false);
#line 7 "C:\Users\alitan\Desktop\MvcCoreSample\MvcCoreSample\MvcCoreSample\Views\Product\Components\ProductCard\Default.cshtml"
                              Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(276, 113, true);
            WriteLiteral("</h4>\r\n        </div>\r\n        <ul class=\"list-group list-group-flush\">\r\n            <li class=\"list-group-item\">");
            EndContext();
            BeginContext(390, 11, false);
#line 10 "C:\Users\alitan\Desktop\MvcCoreSample\MvcCoreSample\MvcCoreSample\Views\Product\Components\ProductCard\Default.cshtml"
                                   Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(401, 50, true);
            WriteLiteral(" TL</li>\r\n            <li class=\"list-group-item\">");
            EndContext();
            BeginContext(452, 11, false);
#line 11 "C:\Users\alitan\Desktop\MvcCoreSample\MvcCoreSample\MvcCoreSample\Views\Product\Components\ProductCard\Default.cshtml"
                                   Write(Model.Stock);

#line default
#line hidden
            EndContext();
            BeginContext(463, 27, true);
            WriteLiteral(" Adet</li>\r\n        </ul>\r\n");
            EndContext();
            BeginContext(660, 12, true);
            WriteLiteral("    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MvcCoreSample.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591