#pragma checksum "/Users/patrickdelaney/Desktop/Pierre.solution/Pierre/Views/Flavors/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bd95edcd8725e406221e5a7159199b30222aa2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flavors_Delete), @"mvc.1.0.view", @"/Views/Flavors/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Flavors/Delete.cshtml", typeof(AspNetCore.Views_Flavors_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bd95edcd8725e406221e5a7159199b30222aa2b", @"/Views/Flavors/Delete.cshtml")]
    public class Views_Flavors_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pierre.Models.Flavor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/patrickdelaney/Desktop/Pierre.solution/Pierre/Views/Flavors/Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(56, 49, true);
            WriteLiteral("\n<h2>Are you sure you want to delete this?</h2>\n\n");
            EndContext();
            BeginContext(106, 46, false);
#line 9 "/Users/patrickdelaney/Desktop/Pierre.solution/Pierre/Views/Flavors/Delete.cshtml"
Write(Html.DisplayNameFor(model => model.FlavorName));

#line default
#line hidden
            EndContext();
            BeginContext(152, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(155, 42, false);
#line 9 "/Users/patrickdelaney/Desktop/Pierre.solution/Pierre/Views/Flavors/Delete.cshtml"
                                            Write(Html.DisplayFor(model => model.FlavorName));

#line default
#line hidden
            EndContext();
            BeginContext(197, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 10 "/Users/patrickdelaney/Desktop/Pierre.solution/Pierre/Views/Flavors/Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(226, 41, true);
            WriteLiteral("  <input type=\"submit\" value=\"Delete\" />\n");
            EndContext();
#line 13 "/Users/patrickdelaney/Desktop/Pierre.solution/Pierre/Views/Flavors/Delete.cshtml"
}

#line default
#line hidden
            BeginContext(270, 40, false);
#line 14 "/Users/patrickdelaney/Desktop/Pierre.solution/Pierre/Views/Flavors/Delete.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pierre.Models.Flavor> Html { get; private set; }
    }
}
#pragma warning restore 1591
