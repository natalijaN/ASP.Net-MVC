#pragma checksum "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\DoneTasks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "480916bfa65deff68d13d72515e83dc13d44e1f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_DoneTasks), @"mvc.1.0.view", @"/Views/Task/DoneTasks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Task/DoneTasks.cshtml", typeof(AspNetCore.Views_Task_DoneTasks))]
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
#line 1 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\_ViewImports.cshtml"
using ToDoApp.Models.DomainModels;

#line default
#line hidden
#line 3 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\_ViewImports.cshtml"
using ToDoApp.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"480916bfa65deff68d13d72515e83dc13d44e1f2", @"/Views/Task/DoneTasks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad94ebd304ea0255218e7201db901beaea2c820b", @"/Views/_ViewImports.cshtml")]
    public class Views_Task_DoneTasks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Done>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\DoneTasks.cshtml"
  
    ViewBag.Title = "Done Tasks";

#line default
#line hidden
            BeginContext(55, 23, true);
            WriteLiteral("<h1>Done Tasks</h1>\r\n\r\n");
            EndContext();
#line 7 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\DoneTasks.cshtml"
 foreach (var todo in Model.DoneTodos)
{

#line default
#line hidden
            BeginContext(121, 14, true);
            WriteLiteral("    <p>Title: ");
            EndContext();
            BeginContext(136, 10, false);
#line 9 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\DoneTasks.cshtml"
         Write(todo.Title);

#line default
#line hidden
            EndContext();
            BeginContext(146, 26, true);
            WriteLiteral("</p>\r\n    <p>Description: ");
            EndContext();
            BeginContext(173, 15, false);
#line 10 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\DoneTasks.cshtml"
               Write(todo.Descrition);

#line default
#line hidden
            EndContext();
            BeginContext(188, 33, true);
            WriteLiteral("</p>\r\n    <p>Importance Of ToDo: ");
            EndContext();
            BeginContext(222, 20, false);
#line 11 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\DoneTasks.cshtml"
                      Write(todo.ImporanceOfTask);

#line default
#line hidden
            EndContext();
            BeginContext(242, 27, true);
            WriteLiteral("</p>\r\n    <p>Type Of ToDo: ");
            EndContext();
            BeginContext(270, 9, false);
#line 12 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\DoneTasks.cshtml"
                Write(todo.Type);

#line default
#line hidden
            EndContext();
            BeginContext(279, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 13 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\DoneTasks.cshtml"
}

#line default
#line hidden
            BeginContext(288, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Done> Html { get; private set; }
    }
}
#pragma warning restore 1591
