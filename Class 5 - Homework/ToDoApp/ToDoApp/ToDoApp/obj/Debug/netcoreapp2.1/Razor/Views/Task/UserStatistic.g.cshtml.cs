#pragma checksum "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\UserStatistic.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a4611dc0314942be3f4c7708a9b6cd325fb21bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_UserStatistic), @"mvc.1.0.view", @"/Views/Task/UserStatistic.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Task/UserStatistic.cshtml", typeof(AspNetCore.Views_Task_UserStatistic))]
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
#line 1 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\_ViewImports.cshtml"
using ToDoApp.Models.DomainModels;

#line default
#line hidden
#line 3 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\_ViewImports.cshtml"
using ToDoApp.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a4611dc0314942be3f4c7708a9b6cd325fb21bf", @"/Views/Task/UserStatistic.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad94ebd304ea0255218e7201db901beaea2c820b", @"/Views/_ViewImports.cshtml")]
    public class Views_Task_UserStatistic : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\UserStatistic.cshtml"
  
    ViewBag.Title = "User Statistic";

#line default
#line hidden
            BeginContext(61, 54, true);
            WriteLiteral("<h1>User Statistic</h1>\r\n\r\n<div>\r\n\r\n    <p>First Name:");
            EndContext();
            BeginContext(116, 15, false);
#line 10 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\UserStatistic.cshtml"
             Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(131, 24, true);
            WriteLiteral(" </p>\r\n    <p>Last Name:");
            EndContext();
            BeginContext(156, 14, false);
#line 11 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\UserStatistic.cshtml"
            Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(170, 27, true);
            WriteLiteral(" </p>\r\n    <p>Average Time:");
            EndContext();
            BeginContext(198, 21, false);
#line 12 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\UserStatistic.cshtml"
               Write(Model.AverageFreeTime);

#line default
#line hidden
            EndContext();
            BeginContext(219, 20, true);
            WriteLiteral(" hours</p>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
