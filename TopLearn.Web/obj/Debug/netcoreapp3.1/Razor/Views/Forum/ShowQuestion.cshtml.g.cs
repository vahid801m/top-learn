#pragma checksum "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\ShowQuestion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b162dfc3ac1ad0b3c8f3b542ed730276108fdbbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Forum_ShowQuestion), @"mvc.1.0.view", @"/Views/Forum/ShowQuestion.cshtml")]
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
#line 2 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\ShowQuestion.cshtml"
using TopLearn.Core.Convertors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\ShowQuestion.cshtml"
using TopLearn.Core.Services.Interfaces;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b162dfc3ac1ad0b3c8f3b542ed730276108fdbbb", @"/Views/Forum/ShowQuestion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Forum_ShowQuestion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TopLearn.Core.DTOs.Question.ShowQuestionVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width: 50px; border-radius: 20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width: 40px; border-radius: 20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success pull-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SelectIsTrueAnswer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Answer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\ShowQuestion.cshtml"
  
    ViewData["Title"] = "پرسش " + Model.Question.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    .IsTrue{\r\n      border:2px solid ;\r\n      border-color:green;      \r\n    }\r\n</style>\r\n  \r\n\r\n");
            WriteLiteral(@"



<div class=""container"">
    <nav aria-label=""breadcrumb"">
        <ul class=""breadcrumb"">
            <li class=""breadcrumb-item""><a href=""/""> تاپ لرن </a></li>
            <li class=""breadcrumb-item""><a href=""/Forum/Questions""> پرسش و پاسخ </a></li>
            <li class=""breadcrumb-item active"" aria-current=""page""> ");
#nullable restore
#line 28 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\ShowQuestion.cshtml"
                                                               Write(Model.Question.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </li>
        </ul>
    </nav>
</div>

<div class=""container"">
    <div class=""row"">
        <div class=""col-md-12 col-sm-12 col-xs-12"">
            <div class=""inner"">
                <div class=""panel"">
                    <div class=""panel-heading"">
                        <h1>");
#nullable restore
#line 39 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\ShowQuestion.cshtml"
                       Write(Model.Question.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    </div>\r\n                    <div class=\"panel-body\">\r\n                        ");
#nullable restore
#line 42 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\ShowQuestion.cshtml"
                   Write(Html.Raw(Model.Question.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"panel-footer\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b162dfc3ac1ad0b3c8f3b542ed730276108fdbbb7433", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1288, "~/UserAvatar/", 1288, 13, true);
#nullable restore
#line 45 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\ShowQuestion.cshtml"
AddHtmlAttributeValue("", 1301, Model.Question.User.UserAvatar, 1301, 31, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
#nullable restore
#line 46 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\ShowQuestion.cshtml"
                   Write(Model.Question.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 46 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\ShowQuestion.cshtml"
                                                   Write(Model.Question.CreateQuestion.ToShamsi());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n\r\n\r\n            <div class=\"inner\" style=\"margin-top: 25px;\">\r\n");
#nullable restore
#line 54 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\ShowQuestion.cshtml"
                 foreach (var answer in Model.Answers)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("class", " class=\"", 1719, "\"", 1764, 2);
            WriteAttributeValue("", 1727, "panel", 1727, 5, true);
#nullable restore
#line 56 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\ShowQuestion.cshtml"
WriteAttributeValue("  ", 1732, (answer.IsTrue)?"IsTrue":"", 1734, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"panel-heading\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b162dfc3ac1ad0b3c8f3b542ed730276108fdbbb10570", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1859, "~/UserAvatar/", 1859, 13, true);
#nullable restore
#line 58 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\ShowQuestion.cshtml"
AddHtmlAttributeValue("", 1872, answer.User.UserAvatar, 1872, 23, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
#nullable restore
#line 59 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\ShowQuestion.cshtml"
                       Write(answer.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 59 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\ShowQuestion.cshtml"
                                               Write(answer.CreateDate.ToShamsi());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"panel-body\">\r\n                            ");
#nullable restore
#line 62 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\ShowQuestion.cshtml"
                       Write(Html.Raw(answer.BodyAnswer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 64 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\ShowQuestion.cshtml"
                             if(User.Identity.IsAuthenticated && Model.Question.UserId==_userService.GetUserIdByUsername(User.Identity.Name))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b162dfc3ac1ad0b3c8f3b542ed730276108fdbbb13514", async() => {
                WriteLiteral("\r\n                                        پاسخ صحیح\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-questionId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\ShowQuestion.cshtml"
                                                                                                                    WriteLiteral(Model.Question.QuestionId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["questionId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-questionId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["questionId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\ShowQuestion.cshtml"
                                                                                                                                                                    WriteLiteral(answer.AnswerId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["answerId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-answerId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["answerId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </p>\r\n");
#nullable restore
#line 71 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\ShowQuestion.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 74 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\ShowQuestion.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n");
#nullable restore
#line 77 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\ShowQuestion.cshtml"
             if (User.Identity.IsAuthenticated)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""inner"" style=""margin-top: 25px;"">
                    <div class=""panel"">
                        <div class=""panel-heading"">
                            <h1 style=""font-size: 18px;"" class=""text-success text-muted"">افزودن پاسخ جدید</h1>
                        </div>
                        <div class=""panel-body"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b162dfc3ac1ad0b3c8f3b542ed730276108fdbbb18013", async() => {
                WriteLiteral("\r\n                                <div class=\"form-group\">\r\n                                    <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 3439, "\"", 3473, 1);
#nullable restore
#line 87 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\ShowQuestion.cshtml"
WriteAttributeValue("", 3447, Model.Question.QuestionId, 3447, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                    <textarea name=""Body""></textarea>
                                    <button class=""btn btn-block btn-success"" style=""margin-top: 20px; height: 50px; font-size:15px;"" type=""submit"">ثبت پاسخ شما</button>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 95 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\ShowQuestion.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("             <div class=\"alert alert-danger\">برای درج سوال ابتدا باید وارد سایت شوید </div>\r\n");
#nullable restore
#line 99 "D:\Dev\TopLearn.Web\TopLearn.Web\TopLearn.Web\Views\Forum\ShowQuestion.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n<script src=\"https://cdn.ckeditor.com/4.15.1/standard/ckeditor.js\"></script>\r\n<script>\r\n\r\n    CKEDITOR.replace(\'Body\', {\r\n        customConfig: \'/js/Config.js\'\r\n    });\r\n\r\n</script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IUserService _userService { get; private set; } = default!;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TopLearn.Core.DTOs.Question.ShowQuestionVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
