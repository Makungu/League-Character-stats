#pragma checksum "C:\Users\makun\Documents\01\WORK\leagueChampionStats\Views\Champions\Champions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b58c5d06e685a0e995e8cae1cc9c29191189da3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Champions_Champions), @"mvc.1.0.view", @"/Views/Champions/Champions.cshtml")]
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
#line 1 "C:\Users\makun\Documents\01\WORK\leagueChampionStats\Views\_ViewImports.cshtml"
using leagueChampionStats;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\makun\Documents\01\WORK\leagueChampionStats\Views\_ViewImports.cshtml"
using leagueChampionStats.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b58c5d06e685a0e995e8cae1cc9c29191189da3", @"/Views/Champions/Champions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23956eea67e77d3187aafaa97968ac2456b3151b", @"/Views/_ViewImports.cshtml")]
    public class Views_Champions_Champions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<leagueChampionStats.DataAccessLayer.championsContext>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\makun\Documents\01\WORK\leagueChampionStats\Views\Champions\Champions.cshtml"
  
    ViewData["Title"] = "Champions";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n   <!-- ");
#nullable restore
#line 7 "C:\Users\makun\Documents\01\WORK\leagueChampionStats\Views\Champions\Champions.cshtml"
         foreach ( var champion in Model.champions)
    {
        //do some html magic 
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(" -->\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<leagueChampionStats.DataAccessLayer.championsContext> Html { get; private set; }
    }
}
#pragma warning restore 1591
