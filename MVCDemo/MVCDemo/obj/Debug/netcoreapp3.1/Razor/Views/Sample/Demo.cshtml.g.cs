#pragma checksum "C:\.net-core-mvc-learning\MVCDemo\MVCDemo\Views\Sample\Demo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bf9898f812a2237b16d7ba5bca65e58849bcbbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sample_Demo), @"mvc.1.0.view", @"/Views/Sample/Demo.cshtml")]
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
#line 1 "C:\.net-core-mvc-learning\MVCDemo\MVCDemo\Views\_ViewImports.cshtml"
using MVCDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\.net-core-mvc-learning\MVCDemo\MVCDemo\Views\_ViewImports.cshtml"
using MVCDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\.net-core-mvc-learning\MVCDemo\MVCDemo\Views\_ViewImports.cshtml"
using MVCDemo.Models.Login;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\.net-core-mvc-learning\MVCDemo\MVCDemo\Views\_ViewImports.cshtml"
using MVCDemo.Models.Admission;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bf9898f812a2237b16d7ba5bca65e58849bcbbb", @"/Views/Sample/Demo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c39bb88dd2f7176bfc1bfb67b00077c85c07f17f", @"/Views/_ViewImports.cshtml")]
    public class Views_Sample_Demo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DemoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n    <p>Count - ");
#nullable restore
#line 4 "C:\.net-core-mvc-learning\MVCDemo\MVCDemo\Views\Sample\Demo.cshtml"
          Write(Model.ViewDataCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <hr />\r\n    <p>Keys: </p>\r\n    <ul>\r\n");
#nullable restore
#line 8 "C:\.net-core-mvc-learning\MVCDemo\MVCDemo\Views\Sample\Demo.cshtml"
         foreach (var item in Model.ViewDataKeys)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 10 "C:\.net-core-mvc-learning\MVCDemo\MVCDemo\Views\Sample\Demo.cshtml"
           Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 11 "C:\.net-core-mvc-learning\MVCDemo\MVCDemo\Views\Sample\Demo.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n    <hr />\r\n    <p>Values : </p>\r\n    <ul>\r\n");
#nullable restore
#line 16 "C:\.net-core-mvc-learning\MVCDemo\MVCDemo\Views\Sample\Demo.cshtml"
         foreach (var item in Model.ViewDataValues)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 18 "C:\.net-core-mvc-learning\MVCDemo\MVCDemo\Views\Sample\Demo.cshtml"
           Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 19 "C:\.net-core-mvc-learning\MVCDemo\MVCDemo\Views\Sample\Demo.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DemoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
