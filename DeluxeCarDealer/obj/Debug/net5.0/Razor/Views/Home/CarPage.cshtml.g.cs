#pragma checksum "D:\github_projects\CarSale\DeluxeCarDealer\Views\Home\CarPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef7bac6382c0ba6e5eb5ddf2d22a490770fa9f18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CarPage), @"mvc.1.0.view", @"/Views/Home/CarPage.cshtml")]
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
#line 1 "D:\github_projects\CarSale\DeluxeCarDealer\Views\_ViewImports.cshtml"
using DeluxeCarDealer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\github_projects\CarSale\DeluxeCarDealer\Views\_ViewImports.cshtml"
using Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef7bac6382c0ba6e5eb5ddf2d22a490770fa9f18", @"/Views/Home/CarPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fcf05ca57d89c8ad97d674e48faa93b82fc4ef0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_CarPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.ViewModels.CarViewModel>
    #nullable disable
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\github_projects\CarSale\DeluxeCarDealer\Views\Home\CarPage.cshtml"
  
    Layout = "~/Views/Shared/_CarPageLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\github_projects\CarSale\DeluxeCarDealer\Views\Home\CarPage.cshtml"
  
    ViewData["Title"] = "CarPage";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 11 "D:\github_projects\CarSale\DeluxeCarDealer\Views\Home\CarPage.cshtml"
  var imageSource1 = $"/Content/{Model.Model}.jpg";
    var imageSource2 = $"/Content/{Model.Model}2.jpg";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    header {
        position: sticky;
        top: 0;
        z-index: 999;
    }

    .custom-btn {
        width: 130px;
        height: 40px;
        color: #fff;
        border-radius: 5px;
        padding: 10px 25px;
        font-family: 'Lato', sans-serif;
        font-weight: 500;
        background: transparent;
        cursor: pointer;
        transition: all 0.3s ease;
        position: relative;
        display: inline-block;
        box-shadow: inset 2px 2px 2px 0px rgba(255,255,255,.5), 7px 7px 20px 0px rgba(0,0,0,.1), 4px 4px 5px 0px rgba(0,0,0,.1);
        outline: none;
    }
    /* 3 */
    .btn-3 {
        position: relative;
        top: 200px;
        margin: 0 auto;
        display: block;
        font-family: 'Century Gothic';
        font-size: 20pt;
        background: rgb(0,172,238);
        background: linear-gradient(0deg, rgba(0,172,238,1) 0%, rgba(2,126,251,1) 100%);
        width: 250px;
        height: 50px;
        line-height: 42px;");
            WriteLiteral(@"
        padding: 0;
        border: none;
        z-index: 109;
    }

        .btn-3 span {
            position: relative;
            display: block;
            width: 100%;
            height: 100%;
        }

        .btn-3:before,
        .btn-3:after {
            position: absolute;
            content: """";
            right: 0;
            top: 0;
            background: rgba(2,126,251,1);
            transition: all 0.3s ease;
        }

        .btn-3:before {
            height: 0%;
            width: 2px;
        }

        .btn-3:after {
            width: 0%;
            height: 2px;
        }

        .btn-3:hover {
            background: transparent;
            box-shadow: none;
        }

            .btn-3:hover:before {
                height: 100%;
            }

            .btn-3:hover:after {
                width: 100%;
            }

        .btn-3 span:hover {
            color: rgba(2,126,251,1);
        }

        .btn-3 span:be");
            WriteLiteral(@"fore,
        .btn-3 span:after {
            position: absolute;
            content: """";
            left: 0;
            bottom: 0;
            background: rgba(2,126,251,1);
            transition: all 0.3s ease;
        }

        .btn-3 span:before {
            width: 2px;
            height: 0%;
        }

        .btn-3 span:after {
            width: 0%;
            height: 2px;
        }

        .btn-3 span:hover:before {
            height: 100%;
        }

        .btn-3 span:hover:after {
            width: 100%;
        }

    table {
        width: 80%; /* Ширина таблицы */
        /*border: 1px solid green;*/ /* Рамка вокруг таблицы */
        margin: auto; /* Выравниваем таблицу по центру окна  */
    }

    .slider {
        position: relative;
        max-width: 1000px;
        margin: /*50px */auto;
        box-shadow: 0 10px 20px -5px rgba(0, 0, 0, 0.75);
    }


        .slider input[name=""switch""] {
            display: none;
        }

  ");
            WriteLiteral(@"  .switch {
        position: absolute;
        left: 0;
        bottom: 40px;
        text-align: center;
        width: 100%;
        z-index: 90;
    }

    table.newtable {
        position: absolute;
        width: 40%; /* Ширина таблицы */
        left:25%;
        right:25%;
        color: white;
        z-index: 85;
        bottom: -20%;
    }

    table.newtable2 {
        position: absolute;
        width: 50%; /* Ширина таблицы */
        left: 25%;
        right: 25%;
        color: black;
        z-index: 85;
        bottom: -22%;
    }

    .gradient {
        position: absolute;
        text-align: center;
        top: 600px;
        width: 100%;
        height: 30%;
        z-index: 2;
        background: linear-gradient(rgba(0, 0, 0, 0), 10%, black);
    }

    .switch label {
        display: inline-block;
        width: 8px;
        height: 8px;
        cursor: pointer;
        margin: 0 3px;
        box-shadow: 0 0 2px 0 rgba(0, 0, 0, .8);
    ");
            WriteLiteral(@"    border-radius: 50%;
        border: 0px solid #2f363c;
        background-color: white;/*#738290;*/
    }

    #btn1:checked ~ .switch label[for=""btn1""] {
        background-color: red;
    }

    #btn2:checked ~ .switch label[for=""btn2""] {
        background-color: red;
    }

    #btn3:checked ~ .switch label[for=""btn3""] {
        background-color: red;
    }

    .slider-inner {
        overflow: hidden;
    }

    .slides {
        display: flex;
        width: 100%;
        transition: all 0.5s;
    }

        .slides img {
            width: 100%;
            flex-shrink: 0;
        }

    #btn1:checked ~ slider-inner slides {
        transform: translate(0);
    }

    #btn2:checked ~ .slider-inner .slides {
        transform: translateX(-100%);
    }

    #btn3:checked ~ .slider-inner .slides {
        transform: translateX(-200%);
    }

    .credit {
        position: relative;
        margin: 25% auto;
    }
</style>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef7bac6382c0ba6e5eb5ddf2d22a490770fa9f189100", async() => {
                WriteLiteral("\r\n    <table class=\"table\">\r\n        <tr>\r\n            <td align=\"left\" width=20%>\r\n                <h3>");
#nullable restore
#line 243 "D:\github_projects\CarSale\DeluxeCarDealer\Views\Home\CarPage.cshtml"
               Write(Html.DisplayFor(modelItem => Model.Mark));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 243 "D:\github_projects\CarSale\DeluxeCarDealer\Views\Home\CarPage.cshtml"
                                                         Write(Html.DisplayFor(modelItem => Model.Model));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n\r\n            </td>\r\n            <td align=\"right\" width=15%>\r\n                <h3>от ");
#nullable restore
#line 247 "D:\github_projects\CarSale\DeluxeCarDealer\Views\Home\CarPage.cshtml"
                  Write(Html.DisplayFor(modelItem => Model.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" ₽</h3>
            </td>
        </tr>
    </table>


    <div class=""slider"">
        <input type=""radio"" name=""switch"" id=""btn1"" checked>
        <input type=""radio"" name=""switch"" id=""btn2"">

        <div class=""switch"">
            <label for=""btn1""></label>
            <label for=""btn2""></label>
        </div>

");
                WriteLiteral("        <table class=\"newtable2\">\r\n");
                WriteLiteral("            <tr>\r\n                <td align=\"left\">\r\n                    Мощность\r\n                </td>\r\n                <td align=\"right\">");
#nullable restore
#line 269 "D:\github_projects\CarSale\DeluxeCarDealer\Views\Home\CarPage.cshtml"
                             Write(Html.DisplayFor(modelItem => Model.Hp));

#line default
#line hidden
#nullable disable
                WriteLiteral(" л/с </td>\r\n            </tr>\r\n");
                WriteLiteral("            <tr>\r\n                <td align=\"left\">\r\n                    Крутящий момент\r\n                </td>\r\n                <td align=\"right\">\r\n                    ");
#nullable restore
#line 277 "D:\github_projects\CarSale\DeluxeCarDealer\Views\Home\CarPage.cshtml"
               Write(Html.DisplayFor(modelItem => Model.RPM));

#line default
#line hidden
#nullable disable
                WriteLiteral(" об/мин\r\n                </td>\r\n            </tr>\r\n");
                WriteLiteral("            <tr>\r\n                <td align=\"left\">\r\n                    Максимальная скорость\r\n                </td>\r\n                <td align=\"right\">\r\n                    ");
#nullable restore
#line 286 "D:\github_projects\CarSale\DeluxeCarDealer\Views\Home\CarPage.cshtml"
               Write(Html.DisplayFor(modelItem => Model.MaxSpeed));

#line default
#line hidden
#nullable disable
                WriteLiteral(" км/ч\r\n                </td>\r\n            </tr>\r\n");
                WriteLiteral("            <tr>\r\n                <td align=\"left\">\r\n                    Разгон до 100 км/ч\r\n                </td>\r\n                <td align=\"right\">\r\n                    ");
#nullable restore
#line 295 "D:\github_projects\CarSale\DeluxeCarDealer\Views\Home\CarPage.cshtml"
               Write(Html.DisplayFor(modelItem => Model.TimeTo100));

#line default
#line hidden
#nullable disable
                WriteLiteral(" с\r\n                </td>\r\n            </tr>\r\n");
                WriteLiteral("            <tr>\r\n                <td align=\"left\">\r\n                    Цвет\r\n                </td>\r\n                <td align=\"right\">\r\n                    ");
#nullable restore
#line 304 "D:\github_projects\CarSale\DeluxeCarDealer\Views\Home\CarPage.cshtml"
               Write(Html.DisplayFor(modelItem => Model.Color));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        </table>\r\n        <div class=\"slider-inner\">\r\n            <div class=\"slides\">\r\n                <img");
                BeginWriteAttribute("src", " src=\"", 7637, "\"", 7656, 1);
#nullable restore
#line 310 "D:\github_projects\CarSale\DeluxeCarDealer\Views\Home\CarPage.cshtml"
WriteAttributeValue("", 7643, imageSource1, 7643, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <img");
                BeginWriteAttribute("src", " src=\"", 7682, "\"", 7701, 1);
#nullable restore
#line 311 "D:\github_projects\CarSale\DeluxeCarDealer\Views\Home\CarPage.cshtml"
WriteAttributeValue("", 7688, imageSource2, 7688, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n    <a");
                BeginWriteAttribute("href", " href=\"", 7763, "\"", 7833, 1);
#nullable restore
#line 316 "D:\github_projects\CarSale\DeluxeCarDealer\Views\Home\CarPage.cshtml"
WriteAttributeValue("", 7770, Url.Action("SellingPage", "Home", new { CarId = Model.CarId }), 7770, 63, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        <button class=\"custom-btn btn-3\"><span>Приобрести</span></button>\r\n    </a>\r\n    \r\n");
                WriteLiteral("    <br /><br /><br /><br /><br />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.ViewModels.CarViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
