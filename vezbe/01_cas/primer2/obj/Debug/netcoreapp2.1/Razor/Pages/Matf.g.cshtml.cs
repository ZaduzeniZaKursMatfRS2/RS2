#pragma checksum "/home/danijela/Documents/Razvoj softvera 2/vezbe/01_cas/primer2/Pages/Matf.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24972a36d85c7874554f55cf1903732cc3314744"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Matf), @"mvc.1.0.razor-page", @"/Pages/Matf.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Matf.cshtml", typeof(AspNetCore.Pages_Matf), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24972a36d85c7874554f55cf1903732cc3314744", @"/Pages/Matf.cshtml")]
    public class Pages_Matf : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(6, 55, true);
            WriteLiteral("\n<p>MATF Beogradski univerzitet</p>\n\n<p>Datum i vreme: ");
            EndContext();
            BeginContext(62, 12, false);
#line 5 "/home/danijela/Documents/Razvoj softvera 2/vezbe/01_cas/primer2/Pages/Matf.cshtml"
             Write(DateTime.Now);

#line default
#line hidden
            EndContext();
            BeginContext(74, 5, true);
            WriteLiteral(" </p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Matf> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Matf> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Matf>)PageContext?.ViewData;
        public Pages_Matf Model => ViewData.Model;
    }
}
#pragma warning restore 1591
