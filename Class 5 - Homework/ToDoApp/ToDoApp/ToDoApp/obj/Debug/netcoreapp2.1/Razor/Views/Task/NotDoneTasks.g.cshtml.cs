#pragma checksum "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\NotDoneTasks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a32eb730f46a3988634f034a86042b3f21e9d24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_NotDoneTasks), @"mvc.1.0.view", @"/Views/Task/NotDoneTasks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Task/NotDoneTasks.cshtml", typeof(AspNetCore.Views_Task_NotDoneTasks))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a32eb730f46a3988634f034a86042b3f21e9d24", @"/Views/Task/NotDoneTasks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad94ebd304ea0255218e7201db901beaea2c820b", @"/Views/_ViewImports.cshtml")]
    public class Views_Task_NotDoneTasks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NotDone>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\NotDoneTasks.cshtml"
  
    ViewBag.Title = "Not Done ToDo";

#line default
#line hidden
            BeginContext(61, 240, true);
            WriteLiteral("<style>\r\n    td {\r\n        border: 1px solid black;\r\n        text-align:center;\r\n    }\r\n\r\n    .btn {\r\n       margin-bottom: 5px;\r\n    }\r\n    table {\r\n        margin: 10px;\r\n    }\r\n</style>\r\n\r\n<h1>Not Done ToDo`s</h1>\r\n\r\n<button class=\"btn\">");
            EndContext();
            BeginContext(302, 46, false);
#line 21 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\NotDoneTasks.cshtml"
               Write(Html.ActionLink("Add Task", "AddTask", "Task"));

#line default
#line hidden
            EndContext();
            BeginContext(348, 259, true);
            WriteLiteral(@"</button>
<table>
    <thead>
        <tr>
            <td>Title</td>
            <td>Description</td>
            <td>Importance of ToDo</td>
            <td>Type of ToDo</td>
            <td>SubTask`s</td>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 33 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\NotDoneTasks.cshtml"
         foreach (var todo in Model.NotDoneTodos)
        {

#line default
#line hidden
            BeginContext(669, 48, true);
            WriteLiteral("            <tr>\r\n                <td id=\"data\">");
            EndContext();
            BeginContext(718, 10, false);
#line 36 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\NotDoneTasks.cshtml"
                         Write(todo.Title);

#line default
#line hidden
            EndContext();
            BeginContext(728, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(756, 15, false);
#line 37 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\NotDoneTasks.cshtml"
               Write(todo.Descrition);

#line default
#line hidden
            EndContext();
            BeginContext(771, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(799, 20, false);
#line 38 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\NotDoneTasks.cshtml"
               Write(todo.ImporanceOfTask);

#line default
#line hidden
            EndContext();
            BeginContext(819, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(847, 9, false);
#line 39 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\NotDoneTasks.cshtml"
               Write(todo.Type);

#line default
#line hidden
            EndContext();
            BeginContext(856, 29, true);
            WriteLiteral("</td>\r\n                <td>\r\n");
            EndContext();
#line 41 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\NotDoneTasks.cshtml"
                     if (todo.SubTasks == null)
                    {

#line default
#line hidden
            BeginContext(957, 44, true);
            WriteLiteral("                        <p>No SubTasks</p>\r\n");
            EndContext();
#line 44 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\NotDoneTasks.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
#line 47 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\NotDoneTasks.cshtml"
                         for (int i = 0; i < todo.SubTasks.Count; i++)
                        {
                            

#line default
#line hidden
            BeginContext(1201, 68, false);
#line 49 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\NotDoneTasks.cshtml"
                       Write(Html.Partial("~/Views/Shared/_SubTaskView.cshtml", todo.SubTasks[i]));

#line default
#line hidden
            EndContext();
#line 49 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\NotDoneTasks.cshtml"
                                                                                                 ;
                        }

#line default
#line hidden
#line 50 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\NotDoneTasks.cshtml"
                         
                    }

#line default
#line hidden
            BeginContext(1322, 42, true);
            WriteLiteral("                </td>\r\n            </tr>\r\n");
            EndContext();
#line 54 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\NotDoneTasks.cshtml"
        }

#line default
#line hidden
            BeginContext(1375, 28, true);
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
#line 59 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\NotDoneTasks.cshtml"
 if (Model.NotDoneTodos.Count() == 0)
{

#line default
#line hidden
            BeginContext(1445, 53, true);
            WriteLiteral("    <p>Congratulations! All to todo`s are done!</p>\r\n");
            EndContext();
#line 62 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\NotDoneTasks.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NotDone> Html { get; private set; }
    }
}
#pragma warning restore 1591
