#pragma checksum "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 6 - Homework\ToDo.App.Reworked\ToDoApp.WebApp\Views\Task\DoneTodos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89171f6d59579d7ceccfaf21b4e6537a48d3b904"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_DoneTodos), @"mvc.1.0.view", @"/Views/Task/DoneTodos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Task/DoneTodos.cshtml", typeof(AspNetCore.Views_Task_DoneTodos))]
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
#line 1 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 6 - Homework\ToDo.App.Reworked\ToDoApp.WebApp\Views\_ViewImports.cshtml"
using ToDoApp.WebApp;

#line default
#line hidden
#line 2 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 6 - Homework\ToDo.App.Reworked\ToDoApp.WebApp\Views\_ViewImports.cshtml"
using ToDoApp.WebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89171f6d59579d7ceccfaf21b4e6537a48d3b904", @"/Views/Task/DoneTodos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf342e78b7f2139607b84513ec8ecaa6147d6eb8", @"/Views/_ViewImports.cshtml")]
    public class Views_Task_DoneTodos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoneViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 6 - Homework\ToDo.App.Reworked\ToDoApp.WebApp\Views\Task\DoneTodos.cshtml"
  
    ViewData["Title"] = "Done ToDo`s";

#line default
#line hidden
            BeginContext(69, 487, true);
            WriteLiteral(@"
<div class=""jumbotron "">
    <h2>Done ToDo`s</h2>

    <table class=""table table-dark"">
        <thead>
            <tr>
                <th scope=""col"">Title</th>
                <th scope=""col"">Description</th>
                <th scope=""col"">Importance of ToDo</th>
                <th scope=""col"">Type of ToDo</th>
                <th scope=""col"">SubTask`s</th>
                <th scope=""col"">Details of ToDo</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 21 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 6 - Homework\ToDo.App.Reworked\ToDoApp.WebApp\Views\Task\DoneTodos.cshtml"
             foreach (var todo in Model.DoneTasks)
            {

#line default
#line hidden
            BeginContext(623, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(662, 10, false);
#line 24 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 6 - Homework\ToDo.App.Reworked\ToDoApp.WebApp\Views\Task\DoneTodos.cshtml"
               Write(todo.Title);

#line default
#line hidden
            EndContext();
            BeginContext(672, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(700, 15, false);
#line 25 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 6 - Homework\ToDo.App.Reworked\ToDoApp.WebApp\Views\Task\DoneTodos.cshtml"
               Write(todo.Descrition);

#line default
#line hidden
            EndContext();
            BeginContext(715, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(743, 20, false);
#line 26 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 6 - Homework\ToDo.App.Reworked\ToDoApp.WebApp\Views\Task\DoneTodos.cshtml"
               Write(todo.ImporanceOfTask);

#line default
#line hidden
            EndContext();
            BeginContext(763, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(791, 15, false);
#line 27 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 6 - Homework\ToDo.App.Reworked\ToDoApp.WebApp\Views\Task\DoneTodos.cshtml"
               Write(todo.TypeOfTodo);

#line default
#line hidden
            EndContext();
            BeginContext(806, 29, true);
            WriteLiteral("</td>\r\n                <td>\r\n");
            EndContext();
#line 29 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 6 - Homework\ToDo.App.Reworked\ToDoApp.WebApp\Views\Task\DoneTodos.cshtml"
                     if (todo.SubTasks == null)
                    {

#line default
#line hidden
            BeginContext(907, 44, true);
            WriteLiteral("                        <p>No SubTasks</p>\r\n");
            EndContext();
#line 32 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 6 - Homework\ToDo.App.Reworked\ToDoApp.WebApp\Views\Task\DoneTodos.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
#line 35 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 6 - Homework\ToDo.App.Reworked\ToDoApp.WebApp\Views\Task\DoneTodos.cshtml"
                         for (int i = 0; i < todo.SubTasks.Count; i++)
                        {

                            

#line default
#line hidden
            BeginContext(1153, 73, false);
#line 38 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 6 - Homework\ToDo.App.Reworked\ToDoApp.WebApp\Views\Task\DoneTodos.cshtml"
                       Write(Html.Partial("~/Views/Shared/_SubTaskViewModel.cshtml", todo.SubTasks[i]));

#line default
#line hidden
            EndContext();
#line 38 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 6 - Homework\ToDo.App.Reworked\ToDoApp.WebApp\Views\Task\DoneTodos.cshtml"
                                                                                                      ;
                        }

#line default
#line hidden
#line 39 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 6 - Homework\ToDo.App.Reworked\ToDoApp.WebApp\Views\Task\DoneTodos.cshtml"
                         
                    }

#line default
#line hidden
            BeginContext(1279, 97, true);
            WriteLiteral("                </td>\r\n                <td>\r\n                    <button class=\"btn btn-success\">");
            EndContext();
            BeginContext(1377, 77, false);
#line 43 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 6 - Homework\ToDo.App.Reworked\ToDoApp.WebApp\Views\Task\DoneTodos.cshtml"
                                               Write(Html.ActionLink("Go to details", "TaskDetails", "Task", new { id = todo.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1454, 53, true);
            WriteLiteral("</button>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 46 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 6 - Homework\ToDo.App.Reworked\ToDoApp.WebApp\Views\Task\DoneTodos.cshtml"
            }

#line default
#line hidden
            BeginContext(1522, 46, true);
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoneViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
