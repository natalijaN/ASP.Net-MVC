#pragma checksum "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 3 - Homework\SEDC.PizzApp\SEDC.App\Views\Order\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45d68beac6baf77e17ac1637dd1bfc4bfe7f761b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Details), @"mvc.1.0.view", @"/Views/Order/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Details.cshtml", typeof(AspNetCore.Views_Order_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45d68beac6baf77e17ac1637dd1bfc4bfe7f761b", @"/Views/Order/Details.cshtml")]
    public class Views_Order_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SEDC.App.Models.DomainModels.Order>
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
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 3 - Homework\SEDC.PizzApp\SEDC.App\Views\Order\Details.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(72, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(101, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53c26f92464249778bf58fc866feec03", async() => {
                BeginContext(107, 89, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Details</title>\r\n");
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
            BeginContext(203, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(205, 307, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a0a5f9a2f9248a8bd44b6bf13056583", async() => {
                BeginContext(211, 10, true);
                WriteLiteral("\r\n    <h1>");
                EndContext();
                BeginContext(222, 17, false);
#line 15 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 3 - Homework\SEDC.PizzApp\SEDC.App\Views\Order\Details.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(239, 35, true);
                WriteLiteral("</h1>\r\n    <ul>\r\n        <li>Name: ");
                EndContext();
                BeginContext(275, 20, false);
#line 17 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 3 - Homework\SEDC.PizzApp\SEDC.App\Views\Order\Details.cshtml"
             Write(Model.User.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(295, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(297, 19, false);
#line 17 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 3 - Homework\SEDC.PizzApp\SEDC.App\Views\Order\Details.cshtml"
                                   Write(Model.User.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(316, 28, true);
                WriteLiteral("</li>\r\n        <li>Address: ");
                EndContext();
                BeginContext(345, 18, false);
#line 18 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 3 - Homework\SEDC.PizzApp\SEDC.App\Views\Order\Details.cshtml"
                Write(Model.User.Address);

#line default
#line hidden
                EndContext();
                BeginContext(363, 26, true);
                WriteLiteral("</li>\r\n        <li>Phone: ");
                EndContext();
                BeginContext(390, 16, false);
#line 19 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 3 - Homework\SEDC.PizzApp\SEDC.App\Views\Order\Details.cshtml"
              Write(Model.User.Phone);

#line default
#line hidden
                EndContext();
                BeginContext(406, 26, true);
                WriteLiteral("</li>\r\n        <li>Pizza: ");
                EndContext();
                BeginContext(433, 16, false);
#line 20 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 3 - Homework\SEDC.PizzApp\SEDC.App\Views\Order\Details.cshtml"
              Write(Model.Pizza.Name);

#line default
#line hidden
                EndContext();
                BeginContext(449, 26, true);
                WriteLiteral("</li>\r\n        <li>Price: ");
                EndContext();
                BeginContext(476, 11, false);
#line 21 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 3 - Homework\SEDC.PizzApp\SEDC.App\Views\Order\Details.cshtml"
              Write(Model.Price);

#line default
#line hidden
                EndContext();
                BeginContext(487, 18, true);
                WriteLiteral("</li>\r\n    </ul>\r\n");
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
            BeginContext(512, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SEDC.App.Models.DomainModels.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591