#pragma checksum "/Users/franco/coding_dojo/c#/ORMs/BeltExam/BrightIdeas/Views/Home/Feed.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cb8ba22dc6c3fcd799ffbc1f4d9c8453fecccee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Feed), @"mvc.1.0.view", @"/Views/Home/Feed.cshtml")]
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
#line 1 "/Users/franco/coding_dojo/c#/ORMs/BeltExam/BrightIdeas/Views/_ViewImports.cshtml"
using BrightIdeas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/franco/coding_dojo/c#/ORMs/BeltExam/BrightIdeas/Views/_ViewImports.cshtml"
using BrightIdeas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cb8ba22dc6c3fcd799ffbc1f4d9c8453fecccee", @"/Views/Home/Feed.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3089d01e8107546353dc71acbeb0ef609963fe45", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Feed : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "NewIdeaPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<br>\n\n<h1>Hi ");
#nullable restore
#line 5 "/Users/franco/coding_dojo/c#/ORMs/BeltExam/BrightIdeas/Views/Home/Feed.cshtml"
  Write(ViewBag.LoggedUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</h1>\n<div class=\"col text-right\" style=\"text-decoration: underline;\">\n<a href=\"/logout\">Log Out</a>\n</div>\n\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2cb8ba22dc6c3fcd799ffbc1f4d9c8453fecccee3666", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n\n<hr>\n<br>\n<div>\n    \n");
#nullable restore
#line 18 "/Users/franco/coding_dojo/c#/ORMs/BeltExam/BrightIdeas/Views/Home/Feed.cshtml"
      
        foreach (Idea idea in ViewBag.AllIdeas)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h5> <a");
            BeginWriteAttribute("href", " href=\"", 308, "\"", 340, 2);
            WriteAttributeValue("", 315, "user/", 315, 5, true);
#nullable restore
#line 21 "/Users/franco/coding_dojo/c#/ORMs/BeltExam/BrightIdeas/Views/Home/Feed.cshtml"
WriteAttributeValue("", 320, idea.Creator.UserId, 320, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 21 "/Users/franco/coding_dojo/c#/ORMs/BeltExam/BrightIdeas/Views/Home/Feed.cshtml"
                                            Write(idea.Creator.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>  says: </h5> \n        <p class=\"ideaBox\"> ");
#nullable restore
#line 22 "/Users/franco/coding_dojo/c#/ORMs/BeltExam/BrightIdeas/Views/Home/Feed.cshtml"
                       Write(idea.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\n        <div class=\"ideaNext\">\n        <a");
            BeginWriteAttribute("href", " href=\"", 465, "\"", 496, 3);
            WriteAttributeValue("", 472, "/ideas/", 472, 7, true);
#nullable restore
#line 24 "/Users/franco/coding_dojo/c#/ORMs/BeltExam/BrightIdeas/Views/Home/Feed.cshtml"
WriteAttributeValue("", 479, idea.IdeaId, 479, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 491, "/like", 491, 5, true);
            EndWriteAttribute();
            WriteLiteral("> Like </a> | <a");
            BeginWriteAttribute("href", " href=\"", 513, "\"", 539, 2);
            WriteAttributeValue("", 520, "/ideas/", 520, 7, true);
#nullable restore
#line 24 "/Users/franco/coding_dojo/c#/ORMs/BeltExam/BrightIdeas/Views/Home/Feed.cshtml"
WriteAttributeValue("", 527, idea.IdeaId, 527, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 24 "/Users/franco/coding_dojo/c#/ORMs/BeltExam/BrightIdeas/Views/Home/Feed.cshtml"
                                                                                  Write(idea.Likes.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" people </a>  <span> Like this. </span> \n");
#nullable restore
#line 25 "/Users/franco/coding_dojo/c#/ORMs/BeltExam/BrightIdeas/Views/Home/Feed.cshtml"
         if(ViewBag.LoggedUser.UserId == idea.UserId)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 678, "\"", 708, 3);
            WriteAttributeValue("", 685, "/idea/", 685, 6, true);
#nullable restore
#line 27 "/Users/franco/coding_dojo/c#/ORMs/BeltExam/BrightIdeas/Views/Home/Feed.cshtml"
WriteAttributeValue("", 691, idea.IdeaId, 691, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 703, "/edit", 703, 5, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"col text-right\">Edit</a>\n            <a");
            BeginWriteAttribute("href", " href=\"", 756, "\"", 788, 3);
            WriteAttributeValue("", 763, "/idea/", 763, 6, true);
#nullable restore
#line 28 "/Users/franco/coding_dojo/c#/ORMs/BeltExam/BrightIdeas/Views/Home/Feed.cshtml"
WriteAttributeValue("", 769, idea.IdeaId, 769, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 781, "/delete", 781, 7, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"col text-right text-danger\">Delete</a>\n");
#nullable restore
#line 29 "/Users/franco/coding_dojo/c#/ORMs/BeltExam/BrightIdeas/Views/Home/Feed.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n");
#nullable restore
#line 31 "/Users/franco/coding_dojo/c#/ORMs/BeltExam/BrightIdeas/Views/Home/Feed.cshtml"
    }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
