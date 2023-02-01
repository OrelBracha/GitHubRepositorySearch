#pragma checksum "C:\Users\pc_1\source\repos\PheonixProjectSolution\PheonixProject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05567f3ede95cac3d0c32fe369d19a02abf894fe"
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
#line 1 "C:\Users\pc_1\source\repos\PheonixProjectSolution\PheonixProject\Views\_ViewImports.cshtml"
using PheonixProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pc_1\source\repos\PheonixProjectSolution\PheonixProject\Views\_ViewImports.cshtml"
using PheonixProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05567f3ede95cac3d0c32fe369d19a02abf894fe", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1f090815475ff64b27e84e7c007507ecb2d762d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\pc_1\source\repos\PheonixProjectSolution\PheonixProject\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
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
                  ng-click=""chan");
            WriteLiteral("geFavorite($event, repo)\"></span>\r\n        </div>\r\n\r\n    </div>\r\n\r\n\r\n\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
