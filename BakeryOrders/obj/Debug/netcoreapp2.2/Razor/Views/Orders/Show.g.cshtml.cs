#pragma checksum "/Users/zakkreyshort/Desktop/Bakery-Orders.Solution/BakeryOrders/Views/Orders/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19ed05744e638e0d9a6c392e08b180b6a7d1def0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Show), @"mvc.1.0.view", @"/Views/Orders/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/Show.cshtml", typeof(AspNetCore.Views_Orders_Show))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19ed05744e638e0d9a6c392e08b180b6a7d1def0", @"/Views/Orders/Show.cshtml")]
    public class Views_Orders_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/zakkreyshort/Desktop/Bakery-Orders.Solution/BakeryOrders/Views/Orders/Show.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(29, 30, true);
            WriteLiteral("\n<h1>Order Details:</h1>\n\n<H2>");
            EndContext();
            BeginContext(60, 19, false);
#line 7 "/Users/zakkreyshort/Desktop/Bakery-Orders.Solution/BakeryOrders/Views/Orders/Show.cshtml"
Write(Model["order"].Name);

#line default
#line hidden
            EndContext();
            BeginContext(79, 23, true);
            WriteLiteral("</h2>\n<h3>Description: ");
            EndContext();
            BeginContext(103, 26, false);
#line 8 "/Users/zakkreyshort/Desktop/Bakery-Orders.Solution/BakeryOrders/Views/Orders/Show.cshtml"
            Write(Model["order"].Description);

#line default
#line hidden
            EndContext();
            BeginContext(129, 17, true);
            WriteLiteral("</h3>\n<h3>Price: ");
            EndContext();
            BeginContext(147, 20, false);
#line 9 "/Users/zakkreyshort/Desktop/Bakery-Orders.Solution/BakeryOrders/Views/Orders/Show.cshtml"
      Write(Model["order"].Price);

#line default
#line hidden
            EndContext();
            BeginContext(167, 16, true);
            WriteLiteral("</h3>\n<h3>Date: ");
            EndContext();
            BeginContext(184, 19, false);
#line 10 "/Users/zakkreyshort/Desktop/Bakery-Orders.Solution/BakeryOrders/Views/Orders/Show.cshtml"
     Write(Model["order"].Date);

#line default
#line hidden
            EndContext();
            BeginContext(203, 9, true);
            WriteLiteral("</h3>\n\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 212, "\'", 258, 3);
            WriteAttributeValue("", 219, "/vendors/", 219, 9, true);
#line 12 "/Users/zakkreyshort/Desktop/Bakery-Orders.Solution/BakeryOrders/Views/Orders/Show.cshtml"
WriteAttributeValue("", 228, Model["vendor"].Id, 228, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 247, "/orders/new", 247, 11, true);
            EndWriteAttribute();
            BeginContext(259, 26, true);
            WriteLiteral(">Add another new order</a>");
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