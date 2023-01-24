#pragma checksum "C:\Users\ob185032\OneDrive - NCR Corporation\Desktop\GithubRepositorySearchProject\GitHubRepositorySearch\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12a7f638b0b846c2884ae790dd515a00574a1530"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\ob185032\OneDrive - NCR Corporation\Desktop\GithubRepositorySearchProject\GitHubRepositorySearch\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "C:\Users\ob185032\OneDrive - NCR Corporation\Desktop\GithubRepositorySearchProject\GitHubRepositorySearch\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12a7f638b0b846c2884ae790dd515a00574a1530", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"637209e7eeedf13d00f2cccd93a350b795d01eb6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\ob185032\OneDrive - NCR Corporation\Desktop\GithubRepositorySearchProject\GitHubRepositorySearch\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(42, 1075, true);
            WriteLiteral(@"


<div ng-app=""myApp"" ng-controller=""myCtrl"">
    <div class=""text-center"">
        <h1 class=""display-4"">Search Github Repository</h1>
        <div class=""row d-flex justify-content-center mt-3"">
            <input type=""text"" class=""form-control col-lg-4 col-md-7"" ng-model=""userSearch"" />
            <button class=""btn btn-primary"" ng-click=""searchGithubRepository()"">Search</button>
        </div>
    </div>

    <div class=""row mt-4"">
        <div class=""col-lg-2 col-md-3 col-sm-4 repository"" ng-repeat=""repo in allGithubRepository""
             ng-class=""{shadow: hover}""
             ng-mouseenter=""hover = true""
             ng-mouseleave=""hover = false"">
            <h5 class=""w-100 text-center repository-name"">{{repo.name}}</h5>
            <img src=""{{repo.avatar}}"" class=""mx-auto d-block"" width=""50px"" height=""50px"" />
            <span class=""fa fa-star w-100 text-center p-3 ""
                  ng-class=""{checked: repo.isSavedRepository == 'true'}""
                  ng-click=""changeFavorite($event, re");
            WriteLiteral("po)\"></span>\n        </div>\n\n    </div>\n\n\n\n\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591