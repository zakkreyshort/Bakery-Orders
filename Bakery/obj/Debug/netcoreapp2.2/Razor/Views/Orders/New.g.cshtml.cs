#pragma checksum "/Users/zakkreyshort/Desktop/Bakery-Orders.Solution/Bakery/Views/Orders/New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "192ba6046ba5ed75f9286498dc231b44523a6973"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_New), @"mvc.1.0.view", @"/Views/Orders/New.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/New.cshtml", typeof(AspNetCore.Views_Orders_New))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"192ba6046ba5ed75f9286498dc231b44523a6973", @"/Views/Orders/New.cshtml")]
    public class Views_Orders_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/zakkreyshort/Desktop/Bakery-Orders.Solution/Bakery/Views/Orders/New.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(29, 24, true);
            WriteLiteral("\n<h1>Add a new order to ");
            EndContext();
            BeginContext(54, 10, false);
#line 5 "/Users/zakkreyshort/Desktop/Bakery-Orders.Solution/Bakery/Views/Orders/New.cshtml"
                  Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(64, 12, true);
            WriteLiteral("</h1>\n\n<form");
            EndContext();
            BeginWriteAttribute("aciton", " aciton=\"", 76, "\"", 110, 3);
            WriteAttributeValue("", 85, "/vendors/", 85, 9, true);
#line 7 "/Users/zakkreyshort/Desktop/Bakery-Orders.Solution/Bakery/Views/Orders/New.cshtml"
WriteAttributeValue("", 94, Model.Id, 94, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 103, "/orders", 103, 7, true);
            EndWriteAttribute();
            BeginContext(111, 70, true);
            WriteLiteral(" method=\"post\">\n    <input id=\"vendorId\" name=\"vendorId\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 181, "\"", 198, 1);
#line 8 "/Users/zakkreyshort/Desktop/Bakery-Orders.Solution/Bakery/Views/Orders/New.cshtml"
WriteAttributeValue("", 189, Model.Id, 189, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(199, 443, true);
            WriteLiteral(@">
    <label for=""name"">Order name</label>
    <input id=""name"" name=""name"" type=""text"">
    <label for=""description"">Order description</label>
    <input id=""description"" name=""description"" type=""text"">
    <label for=""price"">Order price</label>
    <input id=""price"" name=""price"" type=""int"">
    <label for=""date"">Order date (ddmmyy)</label>
    <input id=""date"" name=""date"" type=""text"">
    <button type=""submit"">Add order!</button>
</form>");
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
