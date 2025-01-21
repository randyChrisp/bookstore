#pragma checksum "C:\Users\rchri\OneDrive\Classes\Murach_Exercises\aspnet_core_mvc\book_apps\Ch16Bookstore\Bookstore\Views\Author\List.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "bfc56dd389e8d3c2bf4cbfff5791d542822831ff8d5161b7e1b976881d051244"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Author_List), @"mvc.1.0.view", @"/Views/Author/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"bfc56dd389e8d3c2bf4cbfff5791d542822831ff8d5161b7e1b976881d051244", @"/Views/Author/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6c368059e88d5bc501ee7133485f6d71041b69aee4cfb08d5426c0bb9092629e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Author_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AuthorListViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\rchri\OneDrive\Classes\Murach_Exercises\aspnet_core_mvc\book_apps\Ch16Bookstore\Bookstore\Views\Author\List.cshtml"
  
    ViewData["Title"] = " | Author Catalog";

    // aliases to make paging and sorting code shorter
    RouteDictionary current = Model.CurrentRoute;
    RouteDictionary routes = Model.CurrentRoute.Clone();

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<h1>Author Catalog</h1>\r\n\r\n<table class=\"table table-bordered table-striped table-sm\">\r\n");
            WriteLiteral("    <thead class=\"thead-dark\">\r\n        <tr>\r\n            <th>\r\n");
#nullable restore
#line 18 "C:\Users\rchri\OneDrive\Classes\Murach_Exercises\aspnet_core_mvc\book_apps\Ch16Bookstore\Bookstore\Views\Author\List.cshtml"
                   routes.SetSortAndDirection(nameof(Author.FirstName), current); 

#line default
#line hidden
#nullable disable

            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bfc56dd389e8d3c2bf4cbfff5791d542822831ff8d5161b7e1b976881d0512445587", async() => {
                WriteLiteral("First Name");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues = 
#nullable restore
#line 19 "C:\Users\rchri\OneDrive\Classes\Murach_Exercises\aspnet_core_mvc\book_apps\Ch16Bookstore\Bookstore\Views\Author\List.cshtml"
                                                          routes

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-all-route-data", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n");
#nullable restore
#line 23 "C:\Users\rchri\OneDrive\Classes\Murach_Exercises\aspnet_core_mvc\book_apps\Ch16Bookstore\Bookstore\Views\Author\List.cshtml"
                   routes.SetSortAndDirection(nameof(Author.LastName), current); 

#line default
#line hidden
#nullable disable

            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bfc56dd389e8d3c2bf4cbfff5791d542822831ff8d5161b7e1b976881d0512447836", async() => {
                WriteLiteral("Last Name");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues = 
#nullable restore
#line 24 "C:\Users\rchri\OneDrive\Classes\Murach_Exercises\aspnet_core_mvc\book_apps\Ch16Bookstore\Bookstore\Views\Author\List.cshtml"
                                                          routes

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-all-route-data", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </th>\r\n            <th>Book(s)</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\rchri\OneDrive\Classes\Murach_Exercises\aspnet_core_mvc\book_apps\Ch16Bookstore\Bookstore\Views\Author\List.cshtml"
         foreach (Author author in Model.Authors)
        {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bfc56dd389e8d3c2bf4cbfff5791d542822831ff8d5161b7e1b976881d05124410159", async() => {
                WriteLiteral("\r\n                    ");
                Write(
#nullable restore
#line 37 "C:\Users\rchri\OneDrive\Classes\Murach_Exercises\aspnet_core_mvc\book_apps\Ch16Bookstore\Bookstore\Views\Author\List.cshtml"
                     author.FirstName

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 35 "C:\Users\rchri\OneDrive\Classes\Murach_Exercises\aspnet_core_mvc\book_apps\Ch16Bookstore\Bookstore\Views\Author\List.cshtml"
                                                       author.AuthorId

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
#line 36 "C:\Users\rchri\OneDrive\Classes\Murach_Exercises\aspnet_core_mvc\book_apps\Ch16Bookstore\Bookstore\Views\Author\List.cshtml"
                                    author.FullName.Slug()

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
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bfc56dd389e8d3c2bf4cbfff5791d542822831ff8d5161b7e1b976881d05124413634", async() => {
                WriteLiteral("\r\n                    ");
                Write(
#nullable restore
#line 43 "C:\Users\rchri\OneDrive\Classes\Murach_Exercises\aspnet_core_mvc\book_apps\Ch16Bookstore\Bookstore\Views\Author\List.cshtml"
                     author.LastName

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 41 "C:\Users\rchri\OneDrive\Classes\Murach_Exercises\aspnet_core_mvc\book_apps\Ch16Bookstore\Bookstore\Views\Author\List.cshtml"
                                                       author.AuthorId

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
#line 42 "C:\Users\rchri\OneDrive\Classes\Murach_Exercises\aspnet_core_mvc\book_apps\Ch16Bookstore\Bookstore\Views\Author\List.cshtml"
                                    author.FullName.Slug()

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
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 47 "C:\Users\rchri\OneDrive\Classes\Murach_Exercises\aspnet_core_mvc\book_apps\Ch16Bookstore\Bookstore\Views\Author\List.cshtml"
                 foreach (var ba in author.BookAuthors)
                {

#line default
#line hidden
#nullable disable

            WriteLiteral("                    <p>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bfc56dd389e8d3c2bf4cbfff5791d542822831ff8d5161b7e1b976881d05124417457", async() => {
                WriteLiteral("\r\n                            ");
                Write(
#nullable restore
#line 53 "C:\Users\rchri\OneDrive\Classes\Murach_Exercises\aspnet_core_mvc\book_apps\Ch16Bookstore\Bookstore\Views\Author\List.cshtml"
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 51 "C:\Users\rchri\OneDrive\Classes\Murach_Exercises\aspnet_core_mvc\book_apps\Ch16Bookstore\Bookstore\Views\Author\List.cshtml"
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
#line 52 "C:\Users\rchri\OneDrive\Classes\Murach_Exercises\aspnet_core_mvc\book_apps\Ch16Bookstore\Bookstore\Views\Author\List.cshtml"
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
#line 56 "C:\Users\rchri\OneDrive\Classes\Murach_Exercises\aspnet_core_mvc\book_apps\Ch16Bookstore\Bookstore\Views\Author\List.cshtml"
                }

#line default
#line hidden
#nullable disable

            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 59 "C:\Users\rchri\OneDrive\Classes\Murach_Exercises\aspnet_core_mvc\book_apps\Ch16Bookstore\Bookstore\Views\Author\List.cshtml"
        }

#line default
#line hidden
#nullable disable

            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
#nullable restore
#line 67 "C:\Users\rchri\OneDrive\Classes\Murach_Exercises\aspnet_core_mvc\book_apps\Ch16Bookstore\Bookstore\Views\Author\List.cshtml"
                                                        
    routes = Model.CurrentRoute.Clone();

    

#line default
#line hidden
#nullable disable

#nullable restore
#line 71 "C:\Users\rchri\OneDrive\Classes\Murach_Exercises\aspnet_core_mvc\book_apps\Ch16Bookstore\Bookstore\Views\Author\List.cshtml"
                                                                             
    for (int i = 1; i <= Model.TotalPages; i++)
    {
        routes.PageNumber = i;

#line default
#line hidden
#nullable disable

            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bfc56dd389e8d3c2bf4cbfff5791d542822831ff8d5161b7e1b976881d05124422421", async() => {
                Write(
#nullable restore
#line 76 "C:\Users\rchri\OneDrive\Classes\Murach_Exercises\aspnet_core_mvc\book_apps\Ch16Bookstore\Bookstore\Views\Author\List.cshtml"
                                                                               i

#line default
#line hidden
#nullable disable
                );
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues = 
#nullable restore
#line 75 "C:\Users\rchri\OneDrive\Classes\Murach_Exercises\aspnet_core_mvc\book_apps\Ch16Bookstore\Bookstore\Views\Author\List.cshtml"
                                                  routes

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-all-route-data", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2784, "btn", 2784, 3, true);
            AddHtmlAttributeValue(" ", 2787, "btn-outline-primary", 2788, 20, true);
            AddHtmlAttributeValue(" ", 2807, 
#nullable restore
#line 76 "C:\Users\rchri\OneDrive\Classes\Murach_Exercises\aspnet_core_mvc\book_apps\Ch16Bookstore\Bookstore\Views\Author\List.cshtml"
                                           Nav.Active(i, current.PageNumber)

#line default
#line hidden
#nullable disable
            , 2808, 34, false);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 77 "C:\Users\rchri\OneDrive\Classes\Murach_Exercises\aspnet_core_mvc\book_apps\Ch16Bookstore\Bookstore\Views\Author\List.cshtml"
    }

#line default
#line hidden
#nullable disable

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AuthorListViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
