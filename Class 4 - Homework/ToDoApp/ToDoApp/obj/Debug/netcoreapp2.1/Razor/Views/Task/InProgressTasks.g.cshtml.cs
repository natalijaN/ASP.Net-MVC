#pragma checksum "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\InProgressTasks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4a6a7d0b5af5ed99cc58245254b85d9e9722ee1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_InProgressTasks), @"mvc.1.0.view", @"/Views/Task/InProgressTasks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Task/InProgressTasks.cshtml", typeof(AspNetCore.Views_Task_InProgressTasks))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4a6a7d0b5af5ed99cc58245254b85d9e9722ee1", @"/Views/Task/InProgressTasks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad94ebd304ea0255218e7201db901beaea2c820b", @"/Views/_ViewImports.cshtml")]
    public class Views_Task_InProgressTasks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InProgress>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\InProgressTasks.cshtml"
  
    ViewBag.Title = "InProgress Tasks";

#line default
#line hidden
            BeginContext(67, 29, true);
            WriteLiteral("<h1>InProgress Tasks</h1>\r\n\r\n");
            EndContext();
#line 7 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\InProgressTasks.cshtml"
 foreach (var todo in Model.InProgressTodos)
{

#line default
#line hidden
            BeginContext(145, 14, true);
            WriteLiteral("    <p>Title: ");
            EndContext();
            BeginContext(160, 10, false);
#line 9 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\InProgressTasks.cshtml"
         Write(todo.Title);

#line default
#line hidden
            EndContext();
            BeginContext(170, 26, true);
            WriteLiteral("</p>\r\n    <p>Description: ");
            EndContext();
            BeginContext(197, 15, false);
#line 10 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\InProgressTasks.cshtml"
               Write(todo.Descrition);

#line default
#line hidden
            EndContext();
            BeginContext(212, 33, true);
            WriteLiteral("</p>\r\n    <p>Importance Of ToDo: ");
            EndContext();
            BeginContext(246, 20, false);
#line 11 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\InProgressTasks.cshtml"
                      Write(todo.ImporanceOfTask);

#line default
#line hidden
            EndContext();
            BeginContext(266, 27, true);
            WriteLiteral("</p>\r\n    <p>Type Of ToDo: ");
            EndContext();
            BeginContext(294, 9, false);
#line 12 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\InProgressTasks.cshtml"
                Write(todo.Type);

#line default
#line hidden
            EndContext();
            BeginContext(303, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 13 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\InProgressTasks.cshtml"
}

#line default
#line hidden
            BeginContext(312, 266, true);
            WriteLiteral(@"
<table>
    <thead>
        <tr>
            <th>Title</th>
            <th>Description</th>
            <th>Importance Of ToDo</th>
            <th>Type Of ToDo</th>
            <th>SubTask`s</th>
        </tr>
    </thead>
    <tbody>
        <tr>

");
            EndContext();
#line 28 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\InProgressTasks.cshtml"
             foreach (var todo in Model.InProgressTodos)
            {

#line default
#line hidden
            BeginContext(651, 20, true);
            WriteLiteral("                <td>");
            EndContext();
            BeginContext(672, 10, false);
#line 30 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\InProgressTasks.cshtml"
               Write(todo.Title);

#line default
#line hidden
            EndContext();
            BeginContext(682, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(710, 15, false);
#line 31 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\InProgressTasks.cshtml"
               Write(todo.Descrition);

#line default
#line hidden
            EndContext();
            BeginContext(725, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(753, 20, false);
#line 32 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\InProgressTasks.cshtml"
               Write(todo.ImporanceOfTask);

#line default
#line hidden
            EndContext();
            BeginContext(773, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(801, 9, false);
#line 33 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\InProgressTasks.cshtml"
               Write(todo.Type);

#line default
#line hidden
            EndContext();
            BeginContext(810, 88, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <table>\r\n                        <tr>\r\n");
            EndContext();
#line 37 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\InProgressTasks.cshtml"
                             foreach (var subTodo in todo.SubTasks)
                            {

#line default
#line hidden
            BeginContext(998, 50, true);
            WriteLiteral("                                <td><b>Title:</b> ");
            EndContext();
            BeginContext(1049, 13, false);
#line 39 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\InProgressTasks.cshtml"
                                             Write(subTodo.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1062, 63, true);
            WriteLiteral("</td>\r\n                                <td><b>Description:</b> ");
            EndContext();
            BeginContext(1126, 18, false);
#line 40 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\InProgressTasks.cshtml"
                                                   Write(subTodo.Descrition);

#line default
#line hidden
            EndContext();
            BeginContext(1144, 69, true);
            WriteLiteral("</td>\r\n                                <td><b>Status of SubToDo:</b> ");
            EndContext();
            BeginContext(1214, 17, false);
#line 41 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\InProgressTasks.cshtml"
                                                         Write(subTodo.SubStatus);

#line default
#line hidden
            EndContext();
            BeginContext(1231, 50, true);
            WriteLiteral("</td>\r\n                                <tr></tr>\r\n");
            EndContext();
#line 43 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\InProgressTasks.cshtml"
                            }

#line default
#line hidden
            BeginContext(1312, 88, true);
            WriteLiteral("                         </tr>\r\n\r\n                    </table>\r\n                 </td>\r\n");
            EndContext();
#line 48 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\InProgressTasks.cshtml"
    }

#line default
#line hidden
            BeginContext(1407, 65, true);
            WriteLiteral("            </tr>\r\n            </tbody>\r\n            </table>\r\n\r\n");
            EndContext();
#line 53 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\InProgressTasks.cshtml"
             if (Model.InProgressTodos.Count() == 0)
            {

#line default
#line hidden
            BeginContext(1541, 63, true);
            WriteLiteral("                <td>Congradulation! All todo`s are done!</td>\r\n");
            EndContext();
#line 56 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\InProgressTasks.cshtml"
            }

#line default
#line hidden
            BeginContext(1619, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InProgress> Html { get; private set; }
    }
}
#pragma warning restore 1591