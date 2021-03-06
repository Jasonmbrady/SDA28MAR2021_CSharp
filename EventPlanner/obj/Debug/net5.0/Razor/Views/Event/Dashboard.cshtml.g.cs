#pragma checksum "/Users/jasonbrady/EventPlanner/Views/Event/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8befc4a01805f78b4fd5a4c2793b33376f1851f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_Dashboard), @"mvc.1.0.view", @"/Views/Event/Dashboard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8befc4a01805f78b4fd5a4c2793b33376f1851f", @"/Views/Event/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47976d187ef792a6bd67e762406e39b75f4ef0cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Event>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/jasonbrady/EventPlanner/Views/Event/Dashboard.cshtml"
  
    int UserID = (int)Context.Session.GetInt32("uid");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""header"">
    <h3>Welcome to the Event Planner</h3>
    <p><a href=""/logout"">Log Out</a></p>
</div>
<div class=""content"">
    <table class=""table table-striped"">
        <thead>
            <tr>
                <td>Event</td>
                <td>Date</td>
                <td>Attendees</td>
                <td>Action</td>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 20 "/Users/jasonbrady/EventPlanner/Views/Event/Dashboard.cshtml"
              
                foreach (Event e in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 596, "\"", 620, 2);
            WriteAttributeValue("", 603, "/event/", 603, 7, true);
#nullable restore
#line 24 "/Users/jasonbrady/EventPlanner/Views/Event/Dashboard.cshtml"
WriteAttributeValue("", 610, e.EventId, 610, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 24 "/Users/jasonbrady/EventPlanner/Views/Event/Dashboard.cshtml"
                                                   Write(e.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\n                        <td>");
#nullable restore
#line 25 "/Users/jasonbrady/EventPlanner/Views/Event/Dashboard.cshtml"
                       Write(e.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 26 "/Users/jasonbrady/EventPlanner/Views/Event/Dashboard.cshtml"
                       Write(e.Attendees.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>\n");
#nullable restore
#line 28 "/Users/jasonbrady/EventPlanner/Views/Event/Dashboard.cshtml"
                              
                                // if this user is creator, delete button
                                if (e.Creator.UserId == UserID)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a");
            BeginWriteAttribute("href", " href=\"", 1003, "\"", 1034, 2);
            WriteAttributeValue("", 1010, "/event/delete/", 1010, 14, true);
#nullable restore
#line 32 "/Users/jasonbrady/EventPlanner/Views/Event/Dashboard.cshtml"
WriteAttributeValue("", 1024, e.EventId, 1024, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button>Delete</button></a>\n");
#nullable restore
#line 33 "/Users/jasonbrady/EventPlanner/Views/Event/Dashboard.cshtml"
                                }
                                else if (e.Attendees.Any( a => a.UserId == UserID))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a");
            BeginWriteAttribute("href", " href=\"", 1254, "\"", 1284, 2);
            WriteAttributeValue("", 1261, "/event/leave/", 1261, 13, true);
#nullable restore
#line 36 "/Users/jasonbrady/EventPlanner/Views/Event/Dashboard.cshtml"
WriteAttributeValue("", 1274, e.EventId, 1274, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button>Leave</button></a>\n");
#nullable restore
#line 37 "/Users/jasonbrady/EventPlanner/Views/Event/Dashboard.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a");
            BeginWriteAttribute("href", " href=\"", 1456, "\"", 1485, 2);
            WriteAttributeValue("", 1463, "/event/join/", 1463, 12, true);
#nullable restore
#line 40 "/Users/jasonbrady/EventPlanner/Views/Event/Dashboard.cshtml"
WriteAttributeValue("", 1475, e.EventId, 1475, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button>Join</button></a>\n");
#nullable restore
#line 41 "/Users/jasonbrady/EventPlanner/Views/Event/Dashboard.cshtml"
                                }
                                // else if joined, unjoin, and vice versa
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\n                    </tr>\n");
#nullable restore
#line 46 "/Users/jasonbrady/EventPlanner/Views/Event/Dashboard.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n</div>\n<div class=\"footer\">\n    <a href=\"/event/new\"><button>New Event</button></a>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Event>> Html { get; private set; }
    }
}
#pragma warning restore 1591
