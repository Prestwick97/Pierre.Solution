#pragma checksum "/Users/patrickdelaney/Pierre.Solution/Pierre/Views/Treats/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7db307efb19329793338bc08221b810988e8958"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Treats_Edit), @"mvc.1.0.view", @"/Views/Treats/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Treats/Edit.cshtml", typeof(AspNetCore.Views_Treats_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7db307efb19329793338bc08221b810988e8958", @"/Views/Treats/Edit.cshtml")]
    public class Views_Treats_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pierre.Models.Treat>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/patrickdelaney/Pierre.Solution/Pierre/Views/Treats/Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(55, 37, true);
            WriteLiteral("\n<h2>Edit</h2>\n\n<h4>Edit this treat: ");
            EndContext();
            BeginContext(93, 41, false);
#line 9 "/Users/patrickdelaney/Pierre.Solution/Pierre/Views/Treats/Edit.cshtml"
                Write(Html.DisplayFor(model => model.TreatName));

#line default
#line hidden
            EndContext();
            BeginContext(134, 7, true);
            WriteLiteral("</h4>\n\n");
            EndContext();
#line 11 "/Users/patrickdelaney/Pierre.Solution/Pierre/Views/Treats/Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(174, 38, false);
#line 13 "/Users/patrickdelaney/Pierre.Solution/Pierre/Views/Treats/Edit.cshtml"
Write(Html.HiddenFor(model => model.TreatId));

#line default
#line hidden
            EndContext();
            BeginContext(219, 39, false);
#line 15 "/Users/patrickdelaney/Pierre.Solution/Pierre/Views/Treats/Edit.cshtml"
Write(Html.LabelFor(model => model.TreatName));

#line default
#line hidden
            EndContext();
            BeginContext(264, 40, false);
#line 16 "/Users/patrickdelaney/Pierre.Solution/Pierre/Views/Treats/Edit.cshtml"
Write(Html.EditorFor(model => model.TreatName));

#line default
#line hidden
            EndContext();
            BeginContext(306, 41, true);
            WriteLiteral("    <input type=\"submit\" value=\"Save\" />\n");
            EndContext();
#line 19 "/Users/patrickdelaney/Pierre.Solution/Pierre/Views/Treats/Edit.cshtml"
}

#line default
#line hidden
            BeginContext(349, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(353, 42, false);
#line 20 "/Users/patrickdelaney/Pierre.Solution/Pierre/Views/Treats/Edit.cshtml"
Write(Html.ActionLink("Back to treats", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(395, 4, true);
            WriteLiteral("</p>");
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
