#pragma checksum "/Users/patrickdelaney/Pierre.Solution/Pierre/Views/Treats/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "864c3beade57781aeeec1763e3f035d1498385e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Treats_Delete), @"mvc.1.0.view", @"/Views/Treats/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Treats/Delete.cshtml", typeof(AspNetCore.Views_Treats_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"864c3beade57781aeeec1763e3f035d1498385e4", @"/Views/Treats/Delete.cshtml")]
    public class Views_Treats_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pierre.Models.Treat>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/patrickdelaney/Pierre.Solution/Pierre/Views/Treats/Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(55, 49, true);
            WriteLiteral("\n<h2>Are you sure you want to delete this?</h2>\n\n");
            EndContext();
            BeginContext(105, 45, false);
#line 9 "/Users/patrickdelaney/Pierre.Solution/Pierre/Views/Treats/Delete.cshtml"
Write(Html.DisplayNameFor(model => model.TreatName));

#line default
#line hidden
            EndContext();
            BeginContext(150, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(153, 41, false);
#line 9 "/Users/patrickdelaney/Pierre.Solution/Pierre/Views/Treats/Delete.cshtml"
                                           Write(Html.DisplayFor(model => model.TreatName));

#line default
#line hidden
            EndContext();
            BeginContext(194, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 10 "/Users/patrickdelaney/Pierre.Solution/Pierre/Views/Treats/Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(223, 43, true);
            WriteLiteral("    <input type=\"submit\" value=\"Delete\" />\n");
            EndContext();
#line 13 "/Users/patrickdelaney/Pierre.Solution/Pierre/Views/Treats/Delete.cshtml"
}

#line default
#line hidden
            BeginContext(269, 42, false);
#line 14 "/Users/patrickdelaney/Pierre.Solution/Pierre/Views/Treats/Delete.cshtml"
Write(Html.ActionLink("Back to treats", "Index"));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pierre.Models.Treat> Html { get; private set; }
    }
}
#pragma warning restore 1591
