#pragma checksum "D:\PROGRAMMING\Besant Technologies\Project E Commerce\E-Tickets\E-Tickets\Views\Cinemas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b47659db2bf575eabce569c5bfb1e9330d3a5e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cinemas_Index), @"mvc.1.0.view", @"/Views/Cinemas/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cinemas/Index.cshtml", typeof(AspNetCore.Views_Cinemas_Index))]
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
#line 1 "D:\PROGRAMMING\Besant Technologies\Project E Commerce\E-Tickets\E-Tickets\Views\_ViewImports.cshtml"
using E_Tickets;

#line default
#line hidden
#line 2 "D:\PROGRAMMING\Besant Technologies\Project E Commerce\E-Tickets\E-Tickets\Views\_ViewImports.cshtml"
using E_Tickets.Models;

#line default
#line hidden
#line 1 "D:\PROGRAMMING\Besant Technologies\Project E Commerce\E-Tickets\E-Tickets\Views\Cinemas\Index.cshtml"
using eTickets.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b47659db2bf575eabce569c5bfb1e9330d3a5e3", @"/Views/Cinemas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48b8fd404121210681f1e7c90a1e30661fa5dd2c", @"/Views/_ViewImports.cshtml")]
    public class Views_Cinemas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Cinema>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "D:\PROGRAMMING\Besant Technologies\Project E Commerce\E-Tickets\E-Tickets\Views\Cinemas\Index.cshtml"
  
    ViewData["Title"] = "List of Cinemas";

#line default
#line hidden
            BeginContext(145, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(157, 181, true);
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-8 col-lg-offset-2\">\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr class=\"text-center\">\r\n                    <th>");
            EndContext();
            BeginContext(339, 40, false);
#line 16 "D:\PROGRAMMING\Besant Technologies\Project E Commerce\E-Tickets\E-Tickets\Views\Cinemas\Index.cshtml"
                   Write(Html.DisplayNameFor(Model => Model.Logo));

#line default
#line hidden
            EndContext();
            BeginContext(379, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(411, 40, false);
#line 17 "D:\PROGRAMMING\Besant Technologies\Project E Commerce\E-Tickets\E-Tickets\Views\Cinemas\Index.cshtml"
                   Write(Html.DisplayNameFor(Model => Model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(451, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(483, 47, false);
#line 18 "D:\PROGRAMMING\Besant Technologies\Project E Commerce\E-Tickets\E-Tickets\Views\Cinemas\Index.cshtml"
                   Write(Html.DisplayNameFor(Model => Model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(530, 111, true);
            WriteLiteral("</th>\r\n                    <th>Actions</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 23 "D:\PROGRAMMING\Besant Technologies\Project E Commerce\E-Tickets\E-Tickets\Views\Cinemas\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(706, 132, true);
            WriteLiteral("                    <tr>\r\n                        <td class=\"align-middle\">\r\n                            <img class=\"rounded-circle\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 838, "\"", 854, 1);
#line 27 "D:\PROGRAMMING\Besant Technologies\Project E Commerce\E-Tickets\E-Tickets\Views\Cinemas\Index.cshtml"
WriteAttributeValue("", 844, item.Logo, 844, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 855, "\"", 871, 1);
#line 27 "D:\PROGRAMMING\Besant Technologies\Project E Commerce\E-Tickets\E-Tickets\Views\Cinemas\Index.cshtml"
WriteAttributeValue("", 861, item.Name, 861, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(872, 138, true);
            WriteLiteral(" style=\"max-width: 150px\">\r\n                        </td>\r\n                        <td class=\"align-middle\">\r\n                            ");
            EndContext();
            BeginContext(1011, 43, false);
#line 30 "D:\PROGRAMMING\Besant Technologies\Project E Commerce\E-Tickets\E-Tickets\Views\Cinemas\Index.cshtml"
                       Write(Html.DisplayNameFor(ModelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1054, 112, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"align-middle\">\r\n                            ");
            EndContext();
            BeginContext(1167, 50, false);
#line 33 "D:\PROGRAMMING\Besant Technologies\Project E Commerce\E-Tickets\E-Tickets\Views\Cinemas\Index.cshtml"
                       Write(Html.DisplayNameFor(ModelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1217, 448, true);
            WriteLiteral(@"
                        </td>
                        <td class=""align-middle"">
                            <a class=""btn btn-outline-primary""><i class=""bi bi-pencil-square""> </i>Edit</a> |
                            <a class=""btn btn-outline-info""><i class=""bi bi-eye""> </i>Details</a> |
                            <a class=""btn btn-danger""><i class=""bi bi-trash""> </i>Delete</a>
                        </td>
                    </tr>
");
            EndContext();
#line 41 "D:\PROGRAMMING\Besant Technologies\Project E Commerce\E-Tickets\E-Tickets\Views\Cinemas\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1684, 70, true);
            WriteLiteral("            </tbody>\r\n\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Cinema>> Html { get; private set; }
    }
}
#pragma warning restore 1591