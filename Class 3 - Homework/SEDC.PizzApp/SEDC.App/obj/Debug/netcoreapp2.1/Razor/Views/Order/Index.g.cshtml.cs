#pragma checksum "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 3 - Homework\SEDC.PizzApp\SEDC.App\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fa3694fb29895eb2991feb9fc5f89b9579f2665"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Index.cshtml", typeof(AspNetCore.Views_Order_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fa3694fb29895eb2991feb9fc5f89b9579f2665", @"/Views/Order/Index.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SEDC.App.Models.ViewModels.OrderViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 3 - Homework\SEDC.PizzApp\SEDC.App\Views\Order\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(79, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(108, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df87c30fc63b4aec891385dedb26d074", async() => {
                BeginContext(114, 88, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Orders</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(209, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(211, 614, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "795ab9abfbc842539a71e613d2221d18", async() => {
                BeginContext(217, 10, true);
                WriteLiteral("\r\n    <h1>");
                EndContext();
                BeginContext(228, 17, false);
#line 15 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 3 - Homework\SEDC.PizzApp\SEDC.App\Views\Order\Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(245, 119, true);
                WriteLiteral("</h1>\r\n        <p>This is the orders page!</p>\r\n        <h3>Our first Pizza ever to be delivered was:</h3>\r\n        <p>");
                EndContext();
                BeginContext(365, 16, false);
#line 18 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 3 - Homework\SEDC.PizzApp\SEDC.App\Views\Order\Index.cshtml"
      Write(Model.FirstPizza);

#line default
#line hidden
                EndContext();
                BeginContext(381, 58, true);
                WriteLiteral("</p>\r\n        <h3>Our first customer is:</h3>\r\n        <p>");
                EndContext();
                BeginContext(440, 21, false);
#line 20 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 3 - Homework\SEDC.PizzApp\SEDC.App\Views\Order\Index.cshtml"
      Write(Model.FirstPersonName);

#line default
#line hidden
                EndContext();
                BeginContext(461, 77, true);
                WriteLiteral("</p>\r\n        <h3>Total orders since we started delivering:</h3>\r\n        <p>");
                EndContext();
                BeginContext(539, 20, false);
#line 22 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 3 - Homework\SEDC.PizzApp\SEDC.App\Views\Order\Index.cshtml"
      Write(Model.NumberOfOrders);

#line default
#line hidden
                EndContext();
                BeginContext(559, 8, true);
                WriteLiteral("</p>\r\n\r\n");
                EndContext();
#line 24 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 3 - Homework\SEDC.PizzApp\SEDC.App\Views\Order\Index.cshtml"
     foreach (var order in Model.NewOrder)
    {

#line default
#line hidden
                BeginContext(618, 23, true);
                WriteLiteral("        <h4>User name: ");
                EndContext();
                BeginContext(642, 20, false);
#line 26 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 3 - Homework\SEDC.PizzApp\SEDC.App\Views\Order\Index.cshtml"
                  Write(order.User.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(662, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(664, 19, false);
#line 26 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 3 - Homework\SEDC.PizzApp\SEDC.App\Views\Order\Index.cshtml"
                                        Write(order.User.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(683, 27, true);
                WriteLiteral("</h4>\r\n        <div>Pizza: ");
                EndContext();
                BeginContext(711, 16, false);
#line 27 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 3 - Homework\SEDC.PizzApp\SEDC.App\Views\Order\Index.cshtml"
               Write(order.Pizza.Name);

#line default
#line hidden
                EndContext();
                BeginContext(727, 28, true);
                WriteLiteral("</div>\r\n        <div>Price: ");
                EndContext();
                BeginContext(756, 17, false);
#line 28 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 3 - Homework\SEDC.PizzApp\SEDC.App\Views\Order\Index.cshtml"
               Write(order.Pizza.Price);

#line default
#line hidden
                EndContext();
                BeginContext(773, 24, true);
                WriteLiteral("</div>\r\n        <br />\r\n");
                EndContext();
#line 30 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 3 - Homework\SEDC.PizzApp\SEDC.App\Views\Order\Index.cshtml"
        
    }

#line default
#line hidden
                BeginContext(814, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
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
            EndContext();
            BeginContext(825, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SEDC.App.Models.ViewModels.OrderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
