#pragma checksum "D:\NewsSite\Frontend\Views\_RssFeeds.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5cf0dc4bbdad7c0cd600e232aa8fe8fe3541b7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views__RssFeeds), @"mvc.1.0.view", @"/Views/_RssFeeds.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/_RssFeeds.cshtml", typeof(AspNetCore.Views__RssFeeds))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5cf0dc4bbdad7c0cd600e232aa8fe8fe3541b7e", @"/Views/_RssFeeds.cshtml")]
    public class Views__RssFeeds : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Frontend.Models.RssFeedsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 8, true);
            WriteLiteral("\r\n<ul>\r\n");
            EndContext();
#line 4 "D:\NewsSite\Frontend\Views\_RssFeeds.cshtml"
     foreach(var RssFeed in Model.RssFeeds)
    {

#line default
#line hidden
            BeginContext(102, 81, true);
            WriteLiteral("        <li>\r\n            <a href=\"https://localhost:44329/NewsSiteApi/RssFeed/\">");
            EndContext();
            BeginContext(184, 13, false);
#line 7 "D:\NewsSite\Frontend\Views\_RssFeeds.cshtml"
                                                              Write(RssFeed.Title);

#line default
#line hidden
            EndContext();
            BeginContext(197, 21, true);
            WriteLiteral("</a>\r\n        </li>\r\n");
            EndContext();
#line 9 "D:\NewsSite\Frontend\Views\_RssFeeds.cshtml"
    }

#line default
#line hidden
            BeginContext(225, 7, true);
            WriteLiteral("</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Frontend.Models.RssFeedsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591