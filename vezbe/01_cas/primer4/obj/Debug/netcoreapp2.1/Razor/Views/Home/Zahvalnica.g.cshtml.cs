#pragma checksum "/home/danijela/Documents/Razvoj softvera 2/primer4/Views/Home/Zahvalnica.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74127c44be34807f4a575d63e700782df0ebe672"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Zahvalnica), @"mvc.1.0.view", @"/Views/Home/Zahvalnica.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Zahvalnica.cshtml", typeof(AspNetCore.Views_Home_Zahvalnica))]
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
#line 1 "/home/danijela/Documents/Razvoj softvera 2/primer4/Views/_ViewImports.cshtml"
using primer4;

#line default
#line hidden
#line 2 "/home/danijela/Documents/Razvoj softvera 2/primer4/Views/_ViewImports.cshtml"
using primer4.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74127c44be34807f4a575d63e700782df0ebe672", @"/Views/Home/Zahvalnica.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67c5c748444e45360853224d92553284d616a9b6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Zahvalnica : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<primer4.Models.Gosti>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SpisakGostiju", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/home/danijela/Documents/Razvoj softvera 2/primer4/Views/Home/Zahvalnica.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(53, 25, true);
            WriteLiteral("\n<!DOCTYPE html>\n\n<html>\n");
            EndContext();
            BeginContext(78, 144, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f125ee25c694dffaf95092f7175eed2", async() => {
                BeginContext(84, 131, true);
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />  <!-- omogucava skaliranje web strane -->\n    <title>Zahvalnica</title>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(222, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(223, 294, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e8d72a88ff442a992c863ef41d0f59a", async() => {
                BeginContext(229, 15, true);
                WriteLiteral("\n    <h1>Hvala ");
                EndContext();
                BeginContext(245, 9, false);
#line 15 "/home/danijela/Documents/Razvoj softvera 2/primer4/Views/Home/Zahvalnica.cshtml"
         Write(Model.Ime);

#line default
#line hidden
                EndContext();
                BeginContext(254, 16, true);
                WriteLiteral("!</h1>\n\n    <p>\n");
                EndContext();
#line 18 "/home/danijela/Documents/Razvoj softvera 2/primer4/Views/Home/Zahvalnica.cshtml"
     if (Model.DolaziNaZurku == true)
    {

#line default
#line hidden
                BeginContext(314, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(324, 18, true);
                WriteLiteral("Super! Vidimo se!\n");
                EndContext();
#line 21 "/home/danijela/Documents/Razvoj softvera 2/primer4/Views/Home/Zahvalnica.cshtml"
    }
    else
    {

#line default
#line hidden
                BeginContext(363, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(373, 46, true);
                WriteLiteral("Zao mi je da to cujem! Vidimo se sledeci put!\n");
                EndContext();
#line 25 "/home/danijela/Documents/Razvoj softvera 2/primer4/Views/Home/Zahvalnica.cshtml"
    }

#line default
#line hidden
                BeginContext(425, 25, true);
                WriteLiteral("    </p>\n    <p>Pogledaj ");
                EndContext();
                BeginContext(450, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2f3923d04d94f998e054f078854f2b2", async() => {
                    BeginContext(480, 6, true);
                    WriteLiteral("Spisak");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(490, 20, true);
                WriteLiteral(" svih gostiju.</p>\n\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(517, 8, true);
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<primer4.Models.Gosti> Html { get; private set; }
    }
}
#pragma warning restore 1591
