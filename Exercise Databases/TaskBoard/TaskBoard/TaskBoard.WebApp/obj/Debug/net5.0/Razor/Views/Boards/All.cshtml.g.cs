#pragma checksum "D:\SOFTWARE\_SoftUni-QA\02_QA Fundamentals and Manual Testing - June_2023\13_Exercise Databases\TaskBoard\TaskBoard\TaskBoard.WebApp\Views\Boards\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "451db0e21a334ed6c54957657c007b0765dfbe53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Boards_All), @"mvc.1.0.view", @"/Views/Boards/All.cshtml")]
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
#line 1 "D:\SOFTWARE\_SoftUni-QA\02_QA Fundamentals and Manual Testing - June_2023\13_Exercise Databases\TaskBoard\TaskBoard\TaskBoard.WebApp\Views\_ViewImports.cshtml"
using TaskBoard.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SOFTWARE\_SoftUni-QA\02_QA Fundamentals and Manual Testing - June_2023\13_Exercise Databases\TaskBoard\TaskBoard\TaskBoard.WebApp\Views\_ViewImports.cshtml"
using TaskBoard.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\SOFTWARE\_SoftUni-QA\02_QA Fundamentals and Manual Testing - June_2023\13_Exercise Databases\TaskBoard\TaskBoard\TaskBoard.WebApp\Views\_ViewImports.cshtml"
using TaskBoard.WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\SOFTWARE\_SoftUni-QA\02_QA Fundamentals and Manual Testing - June_2023\13_Exercise Databases\TaskBoard\TaskBoard\TaskBoard.WebApp\Views\_ViewImports.cshtml"
using TaskBoard.WebApp.Models.Task;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"451db0e21a334ed6c54957657c007b0765dfbe53", @"/Views/Boards/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a71fac8c1cc1e9be08de9f723e4247cd50f6ad94", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Boards_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BoardViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\SOFTWARE\_SoftUni-QA\02_QA Fundamentals and Manual Testing - June_2023\13_Exercise Databases\TaskBoard\TaskBoard\TaskBoard.WebApp\Views\Boards\All.cshtml"
  
    ViewData["Title"] = "Task Board";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "451db0e21a334ed6c54957657c007b0765dfbe535304", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<h2 class=\"text-center\">");
#nullable restore
#line 9 "D:\SOFTWARE\_SoftUni-QA\02_QA Fundamentals and Manual Testing - June_2023\13_Exercise Databases\TaskBoard\TaskBoard\TaskBoard.WebApp\Views\Boards\All.cshtml"
                   Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<hr/>\r\n\r\n<div class=\"tasks-grid\">\r\n");
#nullable restore
#line 13 "D:\SOFTWARE\_SoftUni-QA\02_QA Fundamentals and Manual Testing - June_2023\13_Exercise Databases\TaskBoard\TaskBoard\TaskBoard.WebApp\Views\Boards\All.cshtml"
     if (!Model.Any())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 class=\"text-center\">No tasks yet!</h3>\r\n");
#nullable restore
#line 16 "D:\SOFTWARE\_SoftUni-QA\02_QA Fundamentals and Manual Testing - June_2023\13_Exercise Databases\TaskBoard\TaskBoard\TaskBoard.WebApp\Views\Boards\All.cshtml"
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\SOFTWARE\_SoftUni-QA\02_QA Fundamentals and Manual Testing - June_2023\13_Exercise Databases\TaskBoard\TaskBoard\TaskBoard.WebApp\Views\Boards\All.cshtml"
         foreach (var board in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"task\">\r\n                <h1>");
#nullable restore
#line 22 "D:\SOFTWARE\_SoftUni-QA\02_QA Fundamentals and Manual Testing - June_2023\13_Exercise Databases\TaskBoard\TaskBoard\TaskBoard.WebApp\Views\Boards\All.cshtml"
               Write(board.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 23 "D:\SOFTWARE\_SoftUni-QA\02_QA Fundamentals and Manual Testing - June_2023\13_Exercise Databases\TaskBoard\TaskBoard\TaskBoard.WebApp\Views\Boards\All.cshtml"
                 if (board.Tasks.Any())
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\SOFTWARE\_SoftUni-QA\02_QA Fundamentals and Manual Testing - June_2023\13_Exercise Databases\TaskBoard\TaskBoard\TaskBoard.WebApp\Views\Boards\All.cshtml"
               Write(await Html.PartialAsync("~/Views/Shared/_TaskPartial.cshtml", board.Tasks));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\SOFTWARE\_SoftUni-QA\02_QA Fundamentals and Manual Testing - June_2023\13_Exercise Databases\TaskBoard\TaskBoard\TaskBoard.WebApp\Views\Boards\All.cshtml"
                                                                                               
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 28 "D:\SOFTWARE\_SoftUni-QA\02_QA Fundamentals and Manual Testing - June_2023\13_Exercise Databases\TaskBoard\TaskBoard\TaskBoard.WebApp\Views\Boards\All.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\SOFTWARE\_SoftUni-QA\02_QA Fundamentals and Manual Testing - June_2023\13_Exercise Databases\TaskBoard\TaskBoard\TaskBoard.WebApp\Views\Boards\All.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BoardViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
