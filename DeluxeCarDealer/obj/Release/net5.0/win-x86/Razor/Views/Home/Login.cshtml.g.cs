#pragma checksum "D:\github_projects\DeluxeCarDealer\DeluxeCarDealer\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa4712a0a8b009c046397414bb717793fbfbfd10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
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
#line 1 "D:\github_projects\DeluxeCarDealer\DeluxeCarDealer\Views\_ViewImports.cshtml"
using DeluxeCarDealer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\github_projects\DeluxeCarDealer\DeluxeCarDealer\Views\_ViewImports.cshtml"
using Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa4712a0a8b009c046397414bb717793fbfbfd10", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fcf05ca57d89c8ad97d674e48faa93b82fc4ef0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Models.RoleModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\github_projects\DeluxeCarDealer\DeluxeCarDealer\Views\Home\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Войти в систему</h1>\r\n");
#nullable restore
#line 32 "D:\github_projects\DeluxeCarDealer\DeluxeCarDealer\Views\Home\Login.cshtml"
 using (Html.BeginForm("GetRole", "Home", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table>
        <tr>
            <td><p>Логин</p></td>
            <td><input type=""text"" name=""login"" /></td>
        </tr>
        <tr>
            <td><p>Пароль</p></td>
            <td><input type=""text"" name=""password"" /></td>
        </tr>
        <tr>
            <td><input type=""submit"" value=""Ок"" /></td>
            <td></td>
        </tr>
    </table>
");
#nullable restore
#line 48 "D:\github_projects\DeluxeCarDealer\DeluxeCarDealer\Views\Home\Login.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Models.RoleModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
