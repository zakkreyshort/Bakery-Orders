#pragma checksum "/Users/zakkreyshort/Desktop/Bakery-Orders/Bakery/Views/Vendors/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1652b12ede941fcda1b61820f77762eb822957d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendors_Show), @"mvc.1.0.view", @"/Views/Vendors/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vendors/Show.cshtml", typeof(AspNetCore.Views_Vendors_Show))]
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
#line 5 "/Users/zakkreyshort/Desktop/Bakery-Orders/Bakery/Views/Vendors/Show.cshtml"
using Bakery.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1652b12ede941fcda1b61820f77762eb822957d", @"/Views/Vendors/Show.cshtml")]
    public class Views_Vendors_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/zakkreyshort/Desktop/Bakery-Orders/Bakery/Views/Vendors/Show.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(29, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(52, 33, true);
            WriteLiteral("\n<h3>Here are all the orders for ");
            EndContext();
            BeginContext(86, 20, false);
#line 7 "/Users/zakkreyshort/Desktop/Bakery-Orders/Bakery/Views/Vendors/Show.cshtml"
                           Write(Model["vendor"].Name);

#line default
#line hidden
            EndContext();
            BeginContext(106, 15, true);
            WriteLiteral(" : </h3>\n\n<ul>\n");
            EndContext();
#line 10 "/Users/zakkreyshort/Desktop/Bakery-Orders/Bakery/Views/Vendors/Show.cshtml"
     foreach (Order order in @Model["orders"])
    {

#line default
#line hidden
            BeginContext(174, 14, true);
            WriteLiteral("        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 188, "\'", 240, 4);
            WriteAttributeValue("", 195, "/vendors/", 195, 9, true);
#line 12 "/Users/zakkreyshort/Desktop/Bakery-Orders/Bakery/Views/Vendors/Show.cshtml"
WriteAttributeValue("", 204, Model["vendor"].Id, 204, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 223, "/orders/", 223, 8, true);
#line 12 "/Users/zakkreyshort/Desktop/Bakery-Orders/Bakery/Views/Vendors/Show.cshtml"
WriteAttributeValue("", 231, order.Id, 231, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(241, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(243, 10, false);
#line 12 "/Users/zakkreyshort/Desktop/Bakery-Orders/Bakery/Views/Vendors/Show.cshtml"
                                                               Write(order.Name);

#line default
#line hidden
            EndContext();
            BeginContext(253, 10, true);
            WriteLiteral("</a></li>\n");
            EndContext();
#line 13 "/Users/zakkreyshort/Desktop/Bakery-Orders/Bakery/Views/Vendors/Show.cshtml"
    }

#line default
#line hidden
            BeginContext(269, 12, true);
            WriteLiteral("</ul>\n\n<p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 281, "\'", 327, 3);
            WriteAttributeValue("", 288, "/vendors/", 288, 9, true);
#line 16 "/Users/zakkreyshort/Desktop/Bakery-Orders/Bakery/Views/Vendors/Show.cshtml"
WriteAttributeValue("", 297, Model["vendor"].Id, 297, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 316, "/orders/new", 316, 11, true);
            EndWriteAttribute();
            BeginContext(328, 24, true);
            WriteLiteral(">Add a new order</a></p>");
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
