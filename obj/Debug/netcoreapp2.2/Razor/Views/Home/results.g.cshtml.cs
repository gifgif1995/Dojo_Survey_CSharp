#pragma checksum "/Users/ryan/Desktop/coding_dojo/C_Sharp/asp.net_core/dojo_survey/Views/Home/results.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d0535164c4d41fc657ee87146f0c99617fadaa0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_results), @"mvc.1.0.view", @"/Views/Home/results.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/results.cshtml", typeof(AspNetCore.Views_Home_results))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d0535164c4d41fc657ee87146f0c99617fadaa0", @"/Views/Home/results.cshtml")]
    public class Views_Home_results : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 33, true);
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            EndContext();
            BeginContext(33, 539, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d0535164c4d41fc657ee87146f0c99617fadaa02875", async() => {
                BeginContext(39, 526, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Results</title>
        <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
    <style>
.box{
    outline: 2px solid black;
    height: 400px;
    padding: 10px;
}
.comment{
    width: 500px;
    height: 150px;
    outline: 2px solid black;
}
</style>
");
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
            BeginContext(572, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(573, 364, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d0535164c4d41fc657ee87146f0c99617fadaa04572", async() => {
                BeginContext(579, 72, true);
                WriteLiteral("\n<div class=\"text-center\">\n    <div class=\"box\">\n        <h3>Your Name: ");
                EndContext();
                BeginContext(652, 12, false);
#line 24 "/Users/ryan/Desktop/coding_dojo/C_Sharp/asp.net_core/dojo_survey/Views/Home/results.cshtml"
                  Write(ViewBag.name);

#line default
#line hidden
                EndContext();
                BeginContext(664, 34, true);
                WriteLiteral(" </h3>\n        <h3>Dojo Location: ");
                EndContext();
                BeginContext(699, 16, false);
#line 25 "/Users/ryan/Desktop/coding_dojo/C_Sharp/asp.net_core/dojo_survey/Views/Home/results.cshtml"
                      Write(ViewBag.location);

#line default
#line hidden
                EndContext();
                BeginContext(715, 36, true);
                WriteLiteral("</h3>\n        <h3>Favorite Language:");
                EndContext();
                BeginContext(752, 16, false);
#line 26 "/Users/ryan/Desktop/coding_dojo/C_Sharp/asp.net_core/dojo_survey/Views/Home/results.cshtml"
                         Write(ViewBag.language);

#line default
#line hidden
                EndContext();
                BeginContext(768, 37, true);
                WriteLiteral("</h3>\n        <h3>Comment (optional):");
                EndContext();
                BeginContext(806, 16, false);
#line 27 "/Users/ryan/Desktop/coding_dojo/C_Sharp/asp.net_core/dojo_survey/Views/Home/results.cshtml"
                          Write(ViewBag.textarea);

#line default
#line hidden
                EndContext();
                BeginContext(822, 108, true);
                WriteLiteral("</h3>\n\n        <button class=\"btn btn-success\" onclick=\"window.location=\'/\';\">Go Back</button>\n\n\n    </div>\n");
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
            BeginContext(937, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
