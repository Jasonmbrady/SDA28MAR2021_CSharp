#pragma checksum "/Users/jasonbrady/EventPlanner/Views/Event/LogError.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9a0d231bfe23fee080d44a0ececa281667e082d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_LogError), @"mvc.1.0.view", @"/Views/Event/LogError.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/jasonbrady/EventPlanner/Views/_ViewImports.cshtml"
using EventPlanner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/jasonbrady/EventPlanner/Views/_ViewImports.cshtml"
using EventPlanner.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/jasonbrady/EventPlanner/Views/_ViewImports.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/jasonbrady/EventPlanner/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9a0d231bfe23fee080d44a0ececa281667e082d", @"/Views/Event/LogError.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47976d187ef792a6bd67e762406e39b75f4ef0cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_LogError : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2 class=\"text-danger\">You must be logged in to view that page!</h2>\n<p><a href=\"/\">Click Here</a> to return to the login page.</p>");
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
