#pragma checksum "C:\Users\fever\Desktop\Unishit\11st\1670 Application Development\Assm1670\Demo\Views\Author\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "450bf59dc929bb00bf4e1a8ebae5acf52a76b66a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Author_Detail), @"mvc.1.0.view", @"/Views/Author/Detail.cshtml")]
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
#nullable restore
#line 1 "C:\Users\fever\Desktop\Unishit\11st\1670 Application Development\Assm1670\Demo\Views\_ViewImports.cshtml"
using Demo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fever\Desktop\Unishit\11st\1670 Application Development\Assm1670\Demo\Views\_ViewImports.cshtml"
using Demo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"450bf59dc929bb00bf4e1a8ebae5acf52a76b66a", @"/Views/Author/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e18407c5b9dabc62761fc6cdd8f67817f22bc556", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Author_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Demo.Models.Author>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container col-md-10 text-center mt-3\">\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n");
#nullable restore
#line 80 "C:\Users\fever\Desktop\Unishit\11st\1670 Application Development\Assm1670\Demo\Views\Author\Detail.cshtml"
             if (User.Identity.IsAuthenticated && (User.IsInRole("Admin")||User.IsInRole("Staff")))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <table class=""table table-bordered"">
                    <tr>
                        <th colspan=""2"" class=""h3 bg-light text-success"">Author Admin Info</th>
                    </tr>

                    <tr>
                        <th>Author Id</th>
                        <th>
                                <p>");
#nullable restore
#line 90 "C:\Users\fever\Desktop\Unishit\11st\1670 Application Development\Assm1670\Demo\Views\Author\Detail.cshtml"
                              Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </th>\r\n                    </tr>\r\n                </table>\r\n");
#nullable restore
#line 94 "C:\Users\fever\Desktop\Unishit\11st\1670 Application Development\Assm1670\Demo\Views\Author\Detail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <div class=""col"">
            <table class=""table table-bordered"">
                <tr>
                    <th colspan=""2"" class=""h3 bg-light text-success"">Author Info</th>
                </tr>

                <tr>
                    <th>Author Name</th>
                    <th>
                            <p>");
#nullable restore
#line 105 "C:\Users\fever\Desktop\Unishit\11st\1670 Application Development\Assm1670\Demo\Views\Author\Detail.cshtml"
                          Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </th>\r\n                </tr>\r\n                <tr>\r\n                    <th>Author Email</th>\r\n                    <th>\r\n                            <p>");
#nullable restore
#line 111 "C:\Users\fever\Desktop\Unishit\11st\1670 Application Development\Assm1670\Demo\Views\Author\Detail.cshtml"
                          Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </th>\r\n                </tr>\r\n                <tr>\r\n                    <th>Author Age</th>\r\n                    <th>\r\n                            <p>");
#nullable restore
#line 117 "C:\Users\fever\Desktop\Unishit\11st\1670 Application Development\Assm1670\Demo\Views\Author\Detail.cshtml"
                          Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </th>\r\n                </tr>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Demo.Models.Author> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
