#pragma checksum "C:\Users\MEXY\Documents\Visual Studio 2019\Projects\OnlineShopmanager\OnlineShopmanager\Views\SaleDetails\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc075305a961fa826503bab8deec0c04eda46e59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SaleDetails_Details), @"mvc.1.0.view", @"/Views/SaleDetails/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SaleDetails/Details.cshtml", typeof(AspNetCore.Views_SaleDetails_Details))]
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
#line 1 "C:\Users\MEXY\Documents\Visual Studio 2019\Projects\OnlineShopmanager\OnlineShopmanager\Views\_ViewImports.cshtml"
using OnlineShopmanager;

#line default
#line hidden
#line 2 "C:\Users\MEXY\Documents\Visual Studio 2019\Projects\OnlineShopmanager\OnlineShopmanager\Views\_ViewImports.cshtml"
using OnlineShopmanager.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc075305a961fa826503bab8deec0c04eda46e59", @"/Views/SaleDetails/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41514939234e88a1e5088a60e340aa77fa19c6d1", @"/Views/_ViewImports.cshtml")]
    public class Views_SaleDetails_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineShopmanager.Models.SaleDetail>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\MEXY\Documents\Visual Studio 2019\Projects\OnlineShopmanager\OnlineShopmanager\Views\SaleDetails\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(89, 179, true);
            WriteLiteral("\r\n<h1 class=\"textcolor\">Details</h1>\r\n\r\n<div>\r\n    <h4 class=\"tangerine\">SaleDetail</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2 tangerine\">\r\n            ");
            EndContext();
            BeginContext(269, 49, false);
#line 14 "C:\Users\MEXY\Documents\Visual Studio 2019\Projects\OnlineShopmanager\OnlineShopmanager\Views\SaleDetails\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TransactionID));

#line default
#line hidden
            EndContext();
            BeginContext(318, 73, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10 textcolor\">\r\n            ");
            EndContext();
            BeginContext(392, 45, false);
#line 17 "C:\Users\MEXY\Documents\Visual Studio 2019\Projects\OnlineShopmanager\OnlineShopmanager\Views\SaleDetails\Details.cshtml"
       Write(Html.DisplayFor(model => model.TransactionID));

#line default
#line hidden
            EndContext();
            BeginContext(437, 72, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2 tangerine\">\r\n            ");
            EndContext();
            BeginContext(510, 47, false);
#line 20 "C:\Users\MEXY\Documents\Visual Studio 2019\Projects\OnlineShopmanager\OnlineShopmanager\Views\SaleDetails\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(557, 73, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10 textcolor\">\r\n            ");
            EndContext();
            BeginContext(631, 43, false);
#line 23 "C:\Users\MEXY\Documents\Visual Studio 2019\Projects\OnlineShopmanager\OnlineShopmanager\Views\SaleDetails\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(674, 72, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2 tangerine\">\r\n            ");
            EndContext();
            BeginContext(747, 44, false);
#line 26 "C:\Users\MEXY\Documents\Visual Studio 2019\Projects\OnlineShopmanager\OnlineShopmanager\Views\SaleDetails\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(791, 73, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10 textcolor\">\r\n            ");
            EndContext();
            BeginContext(865, 40, false);
#line 29 "C:\Users\MEXY\Documents\Visual Studio 2019\Projects\OnlineShopmanager\OnlineShopmanager\Views\SaleDetails\Details.cshtml"
       Write(Html.DisplayFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(905, 72, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2 tangerine\">\r\n            ");
            EndContext();
            BeginContext(978, 42, false);
#line 32 "C:\Users\MEXY\Documents\Visual Studio 2019\Projects\OnlineShopmanager\OnlineShopmanager\Views\SaleDetails\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(1020, 73, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10 textcolor\">\r\n            ");
            EndContext();
            BeginContext(1094, 38, false);
#line 35 "C:\Users\MEXY\Documents\Visual Studio 2019\Projects\OnlineShopmanager\OnlineShopmanager\Views\SaleDetails\Details.cshtml"
       Write(Html.DisplayFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(1132, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1179, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc075305a961fa826503bab8deec0c04eda46e598260", async() => {
                BeginContext(1225, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 40 "C:\Users\MEXY\Documents\Visual Studio 2019\Projects\OnlineShopmanager\OnlineShopmanager\Views\SaleDetails\Details.cshtml"
                           WriteLiteral(Model.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1233, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1241, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc075305a961fa826503bab8deec0c04eda46e5910622", async() => {
                BeginContext(1263, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1279, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineShopmanager.Models.SaleDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
