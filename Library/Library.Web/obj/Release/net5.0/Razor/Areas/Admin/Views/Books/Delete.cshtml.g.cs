#pragma checksum "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Areas\Admin\Views\Books\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5a565aff7cf0cfafff3dfb260a08690efdf4037"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Books_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/Books/Delete.cshtml")]
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
#line 1 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Library.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Library.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Library.Domain.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Areas\Admin\Views\Books\Delete.cshtml"
using Library.Domain.Convertor;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5a565aff7cf0cfafff3dfb260a08690efdf4037", @"/Areas/Admin/Views/Books/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09d795395945bc34601482a6d2f1ed5f1e4553ea", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Books_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Domain.Models.Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius col-md-2 col-sm-2 col-xs-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Areas\Admin\Views\Books\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>حذف</h2>\n\n<h3>آیا از حذف این صفحه مطمئن هستید؟</h3>\n<div class=\"col-md-12 col-sm-12 col-xs-12 pull-left\">\n    <hr />\n    <ul>\n        <p>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e5a565aff7cf0cfafff3dfb260a08690efdf40376018", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 320, "~/contents/BookImages/", 320, 22, true);
#nullable restore
#line 15 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Areas\Admin\Views\Books\Delete.cshtml"
AddHtmlAttributeValue("", 342, Model.ImageName, 342, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 15 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Areas\Admin\Views\Books\Delete.cshtml"
AddHtmlAttributeValue("", 365, Model.BookName, 365, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </p>\n        <p>\n            ");
#nullable restore
#line 18 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Areas\Admin\Views\Books\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BookName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 18 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Areas\Admin\Views\Books\Delete.cshtml"
                                                       Write(Html.DisplayFor(model => model.BookName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n        <p>\n            ");
#nullable restore
#line 21 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Areas\Admin\Views\Books\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ShortDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 21 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Areas\Admin\Views\Books\Delete.cshtml"
                                                               Write(Html.DisplayFor(model => model.ShortDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n        <p>\n            ");
#nullable restore
#line 24 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Areas\Admin\Views\Books\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 24 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Areas\Admin\Views\Books\Delete.cshtml"
                                                     Write(Html.DisplayFor(model => model.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n        <p>\n            ");
#nullable restore
#line 27 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Areas\Admin\Views\Books\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PublisherName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 27 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Areas\Admin\Views\Books\Delete.cshtml"
                                                            Write(Html.DisplayFor(model => model.PublisherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n        <p>\n            ");
#nullable restore
#line 30 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Areas\Admin\Views\Books\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ISBNNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 30 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Areas\Admin\Views\Books\Delete.cshtml"
                                                         Write(Html.DisplayFor(model => model.ISBNNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n        <p>\n            ");
#nullable restore
#line 33 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Areas\Admin\Views\Books\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 33 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Areas\Admin\Views\Books\Delete.cshtml"
                                                    Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n        <p>\n            ");
#nullable restore
#line 36 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Areas\Admin\Views\Books\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BookVisit));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 36 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Areas\Admin\Views\Books\Delete.cshtml"
                                                        Write(Html.DisplayFor(model => model.BookVisit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n        <p>\n            ");
#nullable restore
#line 39 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Areas\Admin\Views\Books\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ShowInSlider));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 39 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Areas\Admin\Views\Books\Delete.cshtml"
                                                           Write(Html.DisplayFor(model => model.ShowInSlider));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n        <p>\n            ");
#nullable restore
#line 42 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Areas\Admin\Views\Books\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PublishYear));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 42 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Areas\Admin\Views\Books\Delete.cshtml"
                                                          Write(Model.PublishYear.ToShamsi());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n    </ul>\n\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5a565aff7cf0cfafff3dfb260a08690efdf403714289", async() => {
                WriteLiteral("\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e5a565aff7cf0cfafff3dfb260a08690efdf403714554", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 47 "D:\Larn\University Eduction\001\مهندسی نرم افزار 2\Lib\Library\Library\Library.Web\Areas\Admin\Views\Books\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.BookID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        <input type=\"submit\" value=\"حذف\" class=\"btn btn-sm btn-warning\" />\n        <div>\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5a565aff7cf0cfafff3dfb260a08690efdf403716404", async() => {
                    WriteLiteral("بازگشت به لیست کتاب ها");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        </div>\n\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Domain.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
