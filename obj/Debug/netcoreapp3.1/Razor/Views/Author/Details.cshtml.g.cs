#pragma checksum "C:\Users\rchri\OneDrive\Classes\Murach_Exercises\aspnet_core_mvc\book_apps\Ch16Bookstore\Bookstore\Views\Author\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "fbd6cc2ffa89a37dc824c3457a52c48c95c3dea1d0ce8bb999e52eac7ba0d5f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Author_Details), @"mvc.1.0.view", @"/Views/Author/Details.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\rchri\OneDrive\Classes\Murach_Exercises\aspnet_core_mvc\book_apps\Ch16Bookstore\Bookstore\Views\_ViewImports.cshtml"
using Bookstore

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\rchri\OneDrive\Classes\Murach_Exercises\aspnet_core_mvc\book_apps\Ch16Bookstore\Bookstore\Views\_ViewImports.cshtml"
using Bookstore.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"fbd6cc2ffa89a37dc824c3457a52c48c95c3dea1d0ce8bb999e52eac7ba0d5f3", @"/Views/Author/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6c368059e88d5bc501ee7133485f6d71041b69aee4cfb08d5426c0bb9092629e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Author_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Author>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\rchri\OneDrive\Classes\Murach_Exercises\aspnet_core_mvc\book_apps\Ch16Bookstore\Bookstore\Views\Author\Details.cshtml"
  
    ViewData["Title"] = " | Author";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<h1>Author</h1>\r\n\r\n<table class=\"table table-bordered table-sm\">\r\n    <thead>\r\n        <tr class=\"thead-dark\">\r\n            <th>");
            Write(
#nullable restore
#line 12 "C:\Users\rchri\OneDrive\Classes\Murach_Exercises\aspnet_core_mvc\book_apps\Ch16Bookstore\Bookstore\Views\Author\Details.cshtml"
                 Model.FullName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n        <tr>\r\n            <td>\r\n");
#nullable restore
#line 18 "C:\Users\rchri\OneDrive\Classes\Murach_Exercises\aspnet_core_mvc\book_apps\Ch16Bookstore\Bookstore\Views\Author\Details.cshtml"
                 foreach (var ba in Model.BookAuthors)
                {

#line default
#line hidden
#nullable disable

            WriteLiteral("                    <p>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbd6cc2ffa89a37dc824c3457a52c48c95c3dea1d0ce8bb999e52eac7ba0d5f35176", async() => {
                WriteLiteral("\r\n                            ");
                Write(
#nullable restore
#line 24 "C:\Users\rchri\OneDrive\Classes\Murach_Exercises\aspnet_core_mvc\book_apps\Ch16Bookstore\Bookstore\Views\Author\Details.cshtml"
                             ba.Book.Title

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 22 "C:\Users\rchri\OneDrive\Classes\Murach_Exercises\aspnet_core_mvc\book_apps\Ch16Bookstore\Bookstore\Views\Author\Details.cshtml"
                                          ba.BookId

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 23 "C:\Users\rchri\OneDrive\Classes\Murach_Exercises\aspnet_core_mvc\book_apps\Ch16Bookstore\Bookstore\Views\Author\Details.cshtml"
                                            ba.Book.Title.Slug()

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["slug"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-slug", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["slug"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </p>\r\n");
#nullable restore
#line 27 "C:\Users\rchri\OneDrive\Classes\Murach_Exercises\aspnet_core_mvc\book_apps\Ch16Bookstore\Bookstore\Views\Author\Details.cshtml"
                }

#line default
#line hidden
#nullable disable

            WriteLiteral("            </td>\r\n        </tr>\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Author> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
