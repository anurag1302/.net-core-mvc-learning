#pragma checksum "C:\.net-core-mvc-learning\MVCDemo\MVCDemo\Views\Print\_DocumentTypesPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67ae4ff31a8d0dabe4d91904a7485b369b85855f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Print__DocumentTypesPartial), @"mvc.1.0.view", @"/Views/Print/_DocumentTypesPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67ae4ff31a8d0dabe4d91904a7485b369b85855f", @"/Views/Print/_DocumentTypesPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20c82645f380a66647f653cb87c3f0bf90f91097", @"/Views/_ViewImports.cshtml")]
    public class Views_Print__DocumentTypesPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DocumentType>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<table border=""1"" style=""font-family:Arial;width:100%;background-color:coral"">
    <thead>
        <tr>
            <td align=""center"">Document Id</td>
            <td align=""center"">Document Type</td>
            <td align=""center"">Extension</td>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 12 "C:\.net-core-mvc-learning\MVCDemo\MVCDemo\Views\Print\_DocumentTypesPartial.cshtml"
         if (Model != null && Model.Count() > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\.net-core-mvc-learning\MVCDemo\MVCDemo\Views\Print\_DocumentTypesPartial.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td align=\"center\">");
#nullable restore
#line 17 "C:\.net-core-mvc-learning\MVCDemo\MVCDemo\Views\Print\_DocumentTypesPartial.cshtml"
                                  Write(item.DocumentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td align=\"center\">");
#nullable restore
#line 18 "C:\.net-core-mvc-learning\MVCDemo\MVCDemo\Views\Print\_DocumentTypesPartial.cshtml"
                                  Write(item.DocType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td align=\"center\">");
#nullable restore
#line 19 "C:\.net-core-mvc-learning\MVCDemo\MVCDemo\Views\Print\_DocumentTypesPartial.cshtml"
                                  Write(item.DocExtension);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 21 "C:\.net-core-mvc-learning\MVCDemo\MVCDemo\Views\Print\_DocumentTypesPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\.net-core-mvc-learning\MVCDemo\MVCDemo\Views\Print\_DocumentTypesPartial.cshtml"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td colspan=\"3\">No Records Found</td>\r\n            </tr>\r\n");
#nullable restore
#line 28 "C:\.net-core-mvc-learning\MVCDemo\MVCDemo\Views\Print\_DocumentTypesPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DocumentType>> Html { get; private set; }
    }
}
#pragma warning restore 1591
