#pragma checksum "C:\Users\MEXY\Documents\Visual Studio 2019\Projects\OnlineShopmanager\OnlineShopmanager\Views\Sales\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c98740ff3f4885cefea45ea0bef3766b7c54628"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sales_Index), @"mvc.1.0.view", @"/Views/Sales/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sales/Index.cshtml", typeof(AspNetCore.Views_Sales_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c98740ff3f4885cefea45ea0bef3766b7c54628", @"/Views/Sales/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41514939234e88a1e5088a60e340aa77fa19c6d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Sales_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlineShopmanager.Models.Sale>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "SaleDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\MEXY\Documents\Visual Studio 2019\Projects\OnlineShopmanager\OnlineShopmanager\Views\Sales\Index.cshtml"
  
    ViewData["Title"] = "Sales";

#line default
#line hidden
            BeginContext(94, 154, true);
            WriteLiteral("\r\n<h1 class=\"text-center textcolor\">Sales</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th class=\"tangerine\">\r\n                ");
            EndContext();
            BeginContext(249, 49, false);
#line 14 "C:\Users\MEXY\Documents\Visual Studio 2019\Projects\OnlineShopmanager\OnlineShopmanager\Views\Sales\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TransactionID));

#line default
#line hidden
            EndContext();
            BeginContext(298, 74, true);
            WriteLiteral("\r\n            </th>\r\n            <th  class=\"tangerine\">\r\n                ");
            EndContext();
            BeginContext(373, 40, false);
#line 17 "C:\Users\MEXY\Documents\Visual Studio 2019\Projects\OnlineShopmanager\OnlineShopmanager\Views\Sales\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(413, 74, true);
            WriteLiteral("\r\n            </th>\r\n            <th  class=\"tangerine\">\r\n                ");
            EndContext();
            BeginContext(488, 48, false);
#line 20 "C:\Users\MEXY\Documents\Visual Studio 2019\Projects\OnlineShopmanager\OnlineShopmanager\Views\Sales\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(536, 74, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"tangerine\" >\r\n                ");
            EndContext();
            BeginContext(611, 47, false);
#line 23 "C:\Users\MEXY\Documents\Visual Studio 2019\Projects\OnlineShopmanager\OnlineShopmanager\Views\Sales\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalAmount));

#line default
#line hidden
            EndContext();
            BeginContext(658, 73, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"tangerine\">\r\n                ");
            EndContext();
            BeginContext(732, 46, false);
#line 26 "C:\Users\MEXY\Documents\Visual Studio 2019\Projects\OnlineShopmanager\OnlineShopmanager\Views\Sales\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Amountpaid));

#line default
#line hidden
            EndContext();
            BeginContext(778, 73, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"tangerine\">\r\n                ");
            EndContext();
            BeginContext(852, 43, false);
#line 29 "C:\Users\MEXY\Documents\Visual Studio 2019\Projects\OnlineShopmanager\OnlineShopmanager\Views\Sales\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Balance));

#line default
#line hidden
            EndContext();
            BeginContext(895, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 35 "C:\Users\MEXY\Documents\Visual Studio 2019\Projects\OnlineShopmanager\OnlineShopmanager\Views\Sales\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1013, 66, true);
            WriteLiteral("        <tr>\r\n            <td class=\"textcolor\">\r\n                ");
            EndContext();
            BeginContext(1080, 48, false);
#line 38 "C:\Users\MEXY\Documents\Visual Studio 2019\Projects\OnlineShopmanager\OnlineShopmanager\Views\Sales\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TransactionID));

#line default
#line hidden
            EndContext();
            BeginContext(1128, 73, true);
            WriteLiteral("\r\n            </td>\r\n            <td class=\"textcolor\">\r\n                ");
            EndContext();
            BeginContext(1202, 39, false);
#line 41 "C:\Users\MEXY\Documents\Visual Studio 2019\Projects\OnlineShopmanager\OnlineShopmanager\Views\Sales\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1241, 73, true);
            WriteLiteral("\r\n            </td>\r\n            <td class=\"textcolor\">\r\n                ");
            EndContext();
            BeginContext(1315, 47, false);
#line 44 "C:\Users\MEXY\Documents\Visual Studio 2019\Projects\OnlineShopmanager\OnlineShopmanager\Views\Sales\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(1362, 73, true);
            WriteLiteral("\r\n            </td>\r\n            <td class=\"textcolor\">\r\n                ");
            EndContext();
            BeginContext(1436, 46, false);
#line 47 "C:\Users\MEXY\Documents\Visual Studio 2019\Projects\OnlineShopmanager\OnlineShopmanager\Views\Sales\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TotalAmount));

#line default
#line hidden
            EndContext();
            BeginContext(1482, 73, true);
            WriteLiteral("\r\n            </td>\r\n            <td class=\"textcolor\">\r\n                ");
            EndContext();
            BeginContext(1556, 45, false);
#line 50 "C:\Users\MEXY\Documents\Visual Studio 2019\Projects\OnlineShopmanager\OnlineShopmanager\Views\Sales\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Amountpaid));

#line default
#line hidden
            EndContext();
            BeginContext(1601, 73, true);
            WriteLiteral("\r\n            </td>\r\n            <td class=\"textcolor\">\r\n                ");
            EndContext();
            BeginContext(1675, 42, false);
#line 53 "C:\Users\MEXY\Documents\Visual Studio 2019\Projects\OnlineShopmanager\OnlineShopmanager\Views\Sales\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Balance));

#line default
#line hidden
            EndContext();
            BeginContext(1717, 39, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            EndContext();
            BeginContext(1833, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1849, 120, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c98740ff3f4885cefea45ea0bef3766b7c5462811150", async() => {
                BeginContext(1958, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-transactionid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 57 "C:\Users\MEXY\Documents\Visual Studio 2019\Projects\OnlineShopmanager\OnlineShopmanager\Views\Sales\Index.cshtml"
                                                                                            WriteLiteral(item.TransactionID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["transactionid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-transactionid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["transactionid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1969, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1989, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c98740ff3f4885cefea45ea0bef3766b7c5462814046", async() => {
                BeginContext(2036, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 58 "C:\Users\MEXY\Documents\Visual Studio 2019\Projects\OnlineShopmanager\OnlineShopmanager\Views\Sales\Index.cshtml"
                                         WriteLiteral(item.ID);

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
            BeginContext(2046, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 61 "C:\Users\MEXY\Documents\Visual Studio 2019\Projects\OnlineShopmanager\OnlineShopmanager\Views\Sales\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2085, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnlineShopmanager.Models.Sale>> Html { get; private set; }
    }
}
#pragma warning restore 1591