#pragma checksum "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Shared\_SubTaskView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c04bde2cf27d0460c302a211252659f3817b2d07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SubTaskView), @"mvc.1.0.view", @"/Views/Shared/_SubTaskView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_SubTaskView.cshtml", typeof(AspNetCore.Views_Shared__SubTaskView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c04bde2cf27d0460c302a211252659f3817b2d07", @"/Views/Shared/_SubTaskView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad94ebd304ea0255218e7201db901beaea2c820b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__SubTaskView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SubTask>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 12, true);
            WriteLiteral("\r\n<p>Title: ");
            EndContext();
            BeginContext(29, 11, false);
#line 3 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Shared\_SubTaskView.cshtml"
     Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(40, 22, true);
            WriteLiteral("</p>\r\n<p>Description: ");
            EndContext();
            BeginContext(63, 16, false);
#line 4 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Shared\_SubTaskView.cshtml"
           Write(Model.Descrition);

#line default
#line hidden
            EndContext();
            BeginContext(79, 28, true);
            WriteLiteral("</p>\r\n<p>Status of SubTask: ");
            EndContext();
            BeginContext(108, 15, false);
#line 5 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Shared\_SubTaskView.cshtml"
                 Write(Model.SubStatus);

#line default
#line hidden
            EndContext();
            BeginContext(123, 8, true);
            WriteLiteral("</p>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SubTask> Html { get; private set; }
    }
}
#pragma warning restore 1591