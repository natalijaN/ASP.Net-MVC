#pragma checksum "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\NotDoneTasks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28435de4d54ee728a10ae5dde630c5bcb131c34c"
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
#line 1 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\_ViewImports.cshtml"
using ToDoApp.Models.DomainModels;

#line default
#line hidden
#line 3 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\_ViewImports.cshtml"
using ToDoApp.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28435de4d54ee728a10ae5dde630c5bcb131c34c", @"/Views/Task/NotDoneTasks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad94ebd304ea0255218e7201db901beaea2c820b", @"/Views/_ViewImports.cshtml")]
    public class Views_Task_NotDoneTasks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NotDone>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\NotDoneTasks.cshtml"
  
    ViewBag.Title = "Not Done ToDo";

#line default
#line hidden
            BeginContext(61, 292, true);
            WriteLiteral(@"<h1>Not Done ToDo`s</h1>

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
#line 20 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\NotDoneTasks.cshtml"
             foreach (var todo in Model.NotDoneTodos)
            {

#line default
#line hidden
            BeginContext(423, 20, true);
            WriteLiteral("                <td>");
            EndContext();
            BeginContext(444, 10, false);
#line 22 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\NotDoneTasks.cshtml"
               Write(todo.Title);

#line default
#line hidden
            EndContext();
            BeginContext(454, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(482, 15, false);
#line 23 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\NotDoneTasks.cshtml"
               Write(todo.Descrition);

#line default
#line hidden
            EndContext();
            BeginContext(497, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(525, 20, false);
#line 24 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\NotDoneTasks.cshtml"
               Write(todo.ImporanceOfTask);

#line default
#line hidden
            EndContext();
            BeginContext(545, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(573, 9, false);
#line 25 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\NotDoneTasks.cshtml"
               Write(todo.Type);

#line default
#line hidden
            EndContext();
            BeginContext(582, 88, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <table>\r\n                        <tr>\r\n");
            EndContext();
#line 29 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\NotDoneTasks.cshtml"
                             foreach (var subTodo in todo.SubTasks)
                            {

#line default
#line hidden
            BeginContext(770, 50, true);
            WriteLiteral("                                <td><b>Title:</b> ");
            EndContext();
            BeginContext(821, 13, false);
#line 31 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\NotDoneTasks.cshtml"
                                             Write(subTodo.Title);

#line default
#line hidden
            EndContext();
            BeginContext(834, 63, true);
            WriteLiteral("</td>\r\n                                <td><b>Description:</b> ");
            EndContext();
            BeginContext(898, 18, false);
#line 32 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\NotDoneTasks.cshtml"
                                                   Write(subTodo.Descrition);

#line default
#line hidden
            EndContext();
            BeginContext(916, 69, true);
            WriteLiteral("</td>\r\n                                <td><b>Status of SubToDo:</b> ");
            EndContext();
            BeginContext(986, 17, false);
#line 33 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\NotDoneTasks.cshtml"
                                                         Write(subTodo.SubStatus);

#line default
#line hidden
            EndContext();
            BeginContext(1003, 46, true);
            WriteLiteral("</td>\r\n                            <tr></tr>\r\n");
            EndContext();
#line 35 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\NotDoneTasks.cshtml"
                        }

#line default
#line hidden
            BeginContext(1076, 58, true);
            WriteLiteral("                </tr>\r\n\r\n        </table>\r\n        </td>\r\n");
            EndContext();
#line 40 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\NotDoneTasks.cshtml"
    }

#line default
#line hidden
            BeginContext(1141, 31, true);
            WriteLiteral("  </tr>\r\n</tbody>\r\n</table>\r\n\r\n");
            EndContext();
#line 45 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\NotDoneTasks.cshtml"
     if(Model.NotDoneTodos.Count() == 0)
        {

#line default
#line hidden
            BeginContext(1225, 59, true);
            WriteLiteral("            <td>Congradulation! All todo`s are done!</td>\r\n");
            EndContext();
#line 48 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 4 - Homework\ToDoApp\ToDoApp\Views\Task\NotDoneTasks.cshtml"
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
