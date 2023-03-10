#pragma checksum "C:\Users\cbron\Documents\source\CentralControl\CentralControl\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddad82bbad78c92c0753ce6b3251b1ebff2cd30e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\cbron\Documents\source\CentralControl\CentralControl\Views\_ViewImports.cshtml"
using CentralControl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\cbron\Documents\source\CentralControl\CentralControl\Views\Home\Index.cshtml"
using CentralControl.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddad82bbad78c92c0753ce6b3251b1ebff2cd30e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb891a656c0a27a4ce912e0d2105d164c31d41ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::CentralControl.TagHelpers.TileHelper __CentralControl_TagHelpers_TileHelper;
        private global::CentralControl.TagHelpers.BoldTagHelper __CentralControl_TagHelpers_BoldTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\cbron\Documents\source\CentralControl\CentralControl\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

    var i = 1;

    List<NewsItemViewModel> articleList = (List<NewsItemViewModel>)ViewData["News"];
    NewsItemViewModel featuredNewsItem = articleList[0];
    var articleCount = articleList.Count;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"hero is-halfheight has-background is-bold is-dark\">\r\n    <img class=\"hero-background is-transparent\"");
            BeginWriteAttribute("src", " src=\"", 396, "\"", 447, 2);
#nullable restore
#line 13 "C:\Users\cbron\Documents\source\CentralControl\CentralControl\Views\Home\Index.cshtml"
WriteAttributeValue("", 402, featuredNewsItem.Image.Thumbnail.ContentUrl, 402, 44, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 446, "?", 446, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 448, "\"", 476, 1);
#nullable restore
#line 13 "C:\Users\cbron\Documents\source\CentralControl\CentralControl\Views\Home\Index.cshtml"
WriteAttributeValue("", 454, featuredNewsItem.Name, 454, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <div class=\"hero-body\">\r\n        <div class=\"container\">\r\n");
#nullable restore
#line 16 "C:\Users\cbron\Documents\source\CentralControl\CentralControl\Views\Home\Index.cshtml"
             if (ViewBag.Message == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h1 class=\"title\">\r\n                ");
#nullable restore
#line 19 "C:\Users\cbron\Documents\source\CentralControl\CentralControl\Views\Home\Index.cshtml"
           Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h1>\r\n");
#nullable restore
#line 21 "C:\Users\cbron\Documents\source\CentralControl\CentralControl\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h1 class=\"title\">\r\n                ");
#nullable restore
#line 23 "C:\Users\cbron\Documents\source\CentralControl\CentralControl\Views\Home\Index.cshtml"
           Write(featuredNewsItem.DatePublished.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 23 "C:\Users\cbron\Documents\source\CentralControl\CentralControl\Views\Home\Index.cshtml"
                                                                    Write(featuredNewsItem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h1>\r\n            <h3 class=\"subtitle\">\r\n                ");
#nullable restore
#line 26 "C:\Users\cbron\Documents\source\CentralControl\CentralControl\Views\Home\Index.cshtml"
           Write(featuredNewsItem.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h3>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 965, "\"", 996, 1);
#nullable restore
#line 28 "C:\Users\cbron\Documents\source\CentralControl\CentralControl\Views\Home\Index.cshtml"
WriteAttributeValue("", 972, featuredNewsItem.AmpUrl, 972, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" class=\"button\">Read More</a>\r\n            <div class=\"level-right\">\r\n                <p class=\"level-item\"><strong>");
#nullable restore
#line 30 "C:\Users\cbron\Documents\source\CentralControl\CentralControl\Views\Home\Index.cshtml"
                                         Write(featuredNewsItem.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n                <p class=\"level-item\">");
#nullable restore
#line 31 "C:\Users\cbron\Documents\source\CentralControl\CentralControl\Views\Home\Index.cshtml"
                                 Write(featuredNewsItem.Provider.First().Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            </div>
        </div>
    </div>
</div>
<div class=""container is-widescreen is-fluid"">
    <main role=""main"">
       <section class=""section"">
            <div class=""container"">
                <h1 class=""title"">Latest News</h1>
                <div class=""tile is-ancestor"">
");
#nullable restore
#line 42 "C:\Users\cbron\Documents\source\CentralControl\CentralControl\Views\Home\Index.cshtml"
                     foreach (NewsItemViewModel item in articleList)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddad82bbad78c92c0753ce6b3251b1ebff2cd30e8112", async() => {
                WriteLiteral("\r\n                            <div class=\"tile is-parent\">\r\n                                <article class=\"tile is-child box\">\r\n                                    <h3 class=\"title\">\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("bold", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddad82bbad78c92c0753ce6b3251b1ebff2cd30e8604", async() => {
#nullable restore
#line 48 "C:\Users\cbron\Documents\source\CentralControl\CentralControl\Views\Home\Index.cshtml"
                                         Write(item.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __CentralControl_TagHelpers_BoldTagHelper = CreateTagHelper<global::CentralControl.TagHelpers.BoldTagHelper>();
                __tagHelperExecutionContext.Add(__CentralControl_TagHelpers_BoldTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    </h3>\r\n                                    <p class=\"subtitle\">");
#nullable restore
#line 50 "C:\Users\cbron\Documents\source\CentralControl\CentralControl\Views\Home\Index.cshtml"
                                                   Write(item.DatePublished.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                    <div class=\"content\">\r\n                                        ");
#nullable restore
#line 52 "C:\Users\cbron\Documents\source\CentralControl\CentralControl\Views\Home\Index.cshtml"
                                   Write(item.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        <a");
                BeginWriteAttribute("href", " href=\"", 2255, "\"", 2274, 1);
#nullable restore
#line 53 "C:\Users\cbron\Documents\source\CentralControl\CentralControl\Views\Home\Index.cshtml"
WriteAttributeValue("", 2262, item.AmpUrl, 2262, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" target=\"_blank\">Read More</a>\r\n                                    </div>\r\n                                    <figure class=\"image\">\r\n                                        <img");
                BeginWriteAttribute("src", " src=\"", 2455, "\"", 2494, 2);
#nullable restore
#line 56 "C:\Users\cbron\Documents\source\CentralControl\CentralControl\Views\Home\Index.cshtml"
WriteAttributeValue("", 2461, item.Image.Thumbnail.ContentUrl, 2461, 32, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2493, "?", 2493, 1, true);
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 2495, "\"", 2511, 1);
#nullable restore
#line 56 "C:\Users\cbron\Documents\source\CentralControl\CentralControl\Views\Home\Index.cshtml"
WriteAttributeValue("", 2501, item.Name, 2501, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    </figure>\r\n                                </article>\r\n                            </div>\r\n                        ");
            }
            );
            __CentralControl_TagHelpers_TileHelper = CreateTagHelper<global::CentralControl.TagHelpers.TileHelper>();
            __tagHelperExecutionContext.Add(__CentralControl_TagHelpers_TileHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("formatter", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 44 "C:\Users\cbron\Documents\source\CentralControl\CentralControl\Views\Home\Index.cshtml"
__CentralControl_TagHelpers_TileHelper.Sequence = i;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("sequence", __CentralControl_TagHelpers_TileHelper.Sequence, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 61 "C:\Users\cbron\Documents\source\CentralControl\CentralControl\Views\Home\Index.cshtml"
                        if (i % 3 == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            WriteLiteral("</div><div class=\"tile is-ancestor\">\r\n");
#nullable restore
#line 64 "C:\Users\cbron\Documents\source\CentralControl\CentralControl\Views\Home\Index.cshtml"
                        }
                        i++;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </section>\r\n    </main>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
