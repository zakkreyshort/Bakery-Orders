#pragma checksum "/Users/zakkreyshort/Desktop/Bakery-Orders.Solution/BakeryOrders/Views/Vendors/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "544d895e0a11ee7d0c5d6b2390b07f72c1c4ede5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendors_Index), @"mvc.1.0.view", @"/Views/Vendors/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vendors/Index.cshtml", typeof(AspNetCore.Views_Vendors_Index))]
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
#line 5 "/Users/zakkreyshort/Desktop/Bakery-Orders.Solution/BakeryOrders/Views/Vendors/Index.cshtml"
using Bakery.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"544d895e0a11ee7d0c5d6b2390b07f72c1c4ede5", @"/Views/Vendors/Index.cshtml")]
    public class Views_Vendors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/zakkreyshort/Desktop/Bakery-Orders.Solution/BakeryOrders/Views/Vendors/Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(29, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(52, 19, true);
            WriteLiteral("\n<h1>Vendors</h1>\n\n");
            EndContext();
#line 9 "/Users/zakkreyshort/Desktop/Bakery-Orders.Solution/BakeryOrders/Views/Vendors/Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
            BeginContext(96, 35, true);
            WriteLiteral("    <h3>No Vendors added yet.</h3>\n");
            EndContext();
#line 12 "/Users/zakkreyshort/Desktop/Bakery-Orders.Solution/BakeryOrders/Views/Vendors/Index.cshtml"
}

#line default
#line hidden
            BeginContext(133, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 14 "/Users/zakkreyshort/Desktop/Bakery-Orders.Solution/BakeryOrders/Views/Vendors/Index.cshtml"
 foreach (Vendor vendor in Model)
{

#line default
#line hidden
            BeginContext(170, 10, true);
            WriteLiteral("    <h3><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 180, "\'", 206, 2);
            WriteAttributeValue("", 187, "/vendors/", 187, 9, true);
#line 16 "/Users/zakkreyshort/Desktop/Bakery-Orders.Solution/BakeryOrders/Views/Vendors/Index.cshtml"
WriteAttributeValue("", 196, vendor.Id, 196, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(207, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(209, 11, false);
#line 16 "/Users/zakkreyshort/Desktop/Bakery-Orders.Solution/BakeryOrders/Views/Vendors/Index.cshtml"
                                 Write(vendor.Name);

#line default
#line hidden
            EndContext();
            BeginContext(220, 10, true);
            WriteLiteral("</a></h3>\n");
            EndContext();
#line 17 "/Users/zakkreyshort/Desktop/Bakery-Orders.Solution/BakeryOrders/Views/Vendors/Index.cshtml"
}

#line default
#line hidden
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
