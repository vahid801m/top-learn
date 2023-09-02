#pragma checksum "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2df91efc6bdf2c8631c90f3e240cdcfdc60f2230"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Forum_Index), @"mvc.1.0.view", @"/Views/Forum/Index.cshtml")]
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
#line 1 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\Index.cshtml"
using TopLearn.Core.Convertors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\Index.cshtml"
using TopLearn.Core.Services.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\Index.cshtml"
using TopLearn.DataLeyer.Entities.Question;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2df91efc6bdf2c8631c90f3e240cdcfdc60f2230", @"/Views/Forum/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Forum_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Question>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateQuestion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 9 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\Index.cshtml"
  
    ViewData["Title"] = "Index";
    var course = ViewBag.CourseId;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n<div class=\"row\">\r\n<div class=\"col-md-12 col-sm-12 col-xs-12\">\r\n    <div class=\"inner\" style=\"padding: 8px\">\r\n        <div class=\"panel\">\r\n");
#nullable restore
#line 19 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\Index.cshtml"
            if (ViewBag.CourseId != null)
           {
               if (User.Identity.IsAuthenticated)
               {
                   if (course.CoursePrice==0 || _orderService.IsUserInCourse(User.Identity.Name,ViewBag.CourseId))
                   {

#line default
#line hidden
#nullable disable
            WriteLiteral("                       ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2df91efc6bdf2c8631c90f3e240cdcfdc60f22306137", async() => {
                WriteLiteral("\r\n                           پرسیدن سوال\r\n                       ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\Index.cshtml"
                                                        WriteLiteral(ViewBag.CourseId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 28 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\Index.cshtml"
                   }
                   else
                   {

#line default
#line hidden
#nullable disable
            WriteLiteral("                       <div class=\"alert alert-danger\">\r\n                           شما این دوره را خریداری نکردید\r\n                       </div>\r\n");
#nullable restore
#line 34 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\Index.cshtml"
                   }
               }
               else
               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                   <div class=\"alert alert-danger\">\r\n                       برای پرسیدن سوال باید وارد سایت شوید\r\n                   </div>\r\n");
#nullable restore
#line 41 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\Index.cshtml"
               }
           }

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2df91efc6bdf2c8631c90f3e240cdcfdc60f22309494", async() => {
                WriteLiteral(@"
                <input type=""text"" placeholder=""عبارت را وارد کنید"" class=""form-control"" name=""filter""/>
                <button type=""submit"" class=""btn btn-success"">
                    بیاب
                </button>
                <input type=""hidden"" name=""courseId""");
                BeginWriteAttribute("value", " value=\"", 1736, "\"", 1761, 1);
#nullable restore
#line 48 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\Index.cshtml"
WriteAttributeValue("", 1744, ViewBag.CourseId, 1744, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 51 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"panel\">\r\n                    <div class=\"panel-heading\">\r\n                        <h1>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2006, "\"", 2049, 2);
            WriteAttributeValue("", 2013, "/Forum/ShowQuestion/", 2013, 20, true);
#nullable restore
#line 56 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\Index.cshtml"
WriteAttributeValue("", 2033, item.QuestionId, 2033, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 56 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\Index.cshtml"
                                                                      Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </h1>\r\n                        <p class=\"text-muted\" style=\"margin: 10px\">\r\n                            <a>");
#nullable restore
#line 59 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\Index.cshtml"
                          Write(item.Course.CourseTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> |\r\n                            <span class=\"label label-default\">");
#nullable restore
#line 60 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\Index.cshtml"
                                                         Write(item.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> |\r\n                            <span class=\"label label-warning\">\r\n                                ");
#nullable restore
#line 62 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\Index.cshtml"
                           Write(item.CreateQuestion.ToShamsi());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </span>\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 67 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n</div>\r\n</div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOrderService _orderService { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ICourseService _courseService { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Question>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591