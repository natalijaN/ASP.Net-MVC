#pragma checksum "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\AddTask.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "462303bc55279dcae738c927ab12667213449e6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_AddTask), @"mvc.1.0.view", @"/Views/Task/AddTask.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Task/AddTask.cshtml", typeof(AspNetCore.Views_Task_AddTask))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"462303bc55279dcae738c927ab12667213449e6a", @"/Views/Task/AddTask.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad94ebd304ea0255218e7201db901beaea2c820b", @"/Views/_ViewImports.cshtml")]
    public class Views_Task_AddTask : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AddTaskModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\AddTask.cshtml"
  
    ViewBag.Title = "Add Task";

#line default
#line hidden
            BeginContext(61, 43, true);
            WriteLiteral("\r\n<h1>Add Task</h1>\r\n<h4 style=\"color:red\">");
            EndContext();
            BeginContext(105, 13, false);
#line 7 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\AddTask.cshtml"
                 Write(ViewBag.Error);

#line default
#line hidden
            EndContext();
            BeginContext(118, 52, true);
            WriteLiteral("</h4>\r\n<p>Please enter the data to add task.</p>\r\n\r\n");
            EndContext();
#line 10 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\AddTask.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(205, 27, false);
#line 12 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\AddTask.cshtml"
Write(Html.LabelFor(x => x.Title));

#line default
#line hidden
            EndContext();
            BeginContext(239, 29, false);
#line 13 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\AddTask.cshtml"
Write(Html.TextBoxFor(x => x.Title));

#line default
#line hidden
            EndContext();
            BeginContext(268, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
            BeginContext(283, 33, false);
#line 15 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\AddTask.cshtml"
Write(Html.LabelFor(x => x.Description));

#line default
#line hidden
            EndContext();
            BeginContext(323, 35, false);
#line 16 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\AddTask.cshtml"
Write(Html.TextBoxFor(x => x.Description));

#line default
#line hidden
            EndContext();
            BeginContext(358, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
            BeginContext(373, 37, false);
#line 18 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\AddTask.cshtml"
Write(Html.LabelFor(x => x.ImporanceOfTask));

#line default
#line hidden
            EndContext();
            BeginContext(417, 101, false);
#line 19 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\AddTask.cshtml"
Write(Html.DropDownListFor(x => x.ImporanceOfTask, Html.GetEnumSelectList(Model.ImporanceOfTask.GetType())));

#line default
#line hidden
            EndContext();
            BeginContext(518, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
            BeginContext(533, 26, false);
#line 21 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\AddTask.cshtml"
Write(Html.LabelFor(x => x.Type));

#line default
#line hidden
            EndContext();
            BeginContext(566, 79, false);
#line 22 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\AddTask.cshtml"
Write(Html.DropDownListFor(x => x.Type, Html.GetEnumSelectList(Model.Type.GetType())));

#line default
#line hidden
            EndContext();
            BeginContext(645, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
            BeginContext(660, 34, false);
#line 24 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\AddTask.cshtml"
Write(Html.LabelFor(x => x.SubTaskTitle));

#line default
#line hidden
            EndContext();
            BeginContext(701, 36, false);
#line 25 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\AddTask.cshtml"
Write(Html.TextBoxFor(x => x.SubTaskTitle));

#line default
#line hidden
            EndContext();
            BeginContext(737, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
            BeginContext(752, 39, false);
#line 27 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\AddTask.cshtml"
Write(Html.LabelFor(x => x.SubTaskDescrition));

#line default
#line hidden
            EndContext();
            BeginContext(798, 41, false);
#line 28 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\AddTask.cshtml"
Write(Html.TextBoxFor(x => x.SubTaskDescrition));

#line default
#line hidden
            EndContext();
            BeginContext(839, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
            BeginContext(854, 31, false);
#line 30 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\AddTask.cshtml"
Write(Html.LabelFor(x => x.SubStatus));

#line default
#line hidden
            EndContext();
            BeginContext(892, 89, false);
#line 31 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\AddTask.cshtml"
Write(Html.DropDownListFor(x => x.SubStatus, Html.GetEnumSelectList(Model.SubStatus.GetType())));

#line default
#line hidden
            EndContext();
            BeginContext(981, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
            BeginContext(991, 65, true);
            WriteLiteral("    <br /><br />\r\n    <button type=\"submit\"> Add task </button>\r\n");
            EndContext();
#line 35 "C:\Users\Natalija\Documents\GitHub\ASP.Net-MVC\Class 5 - Homework\ToDoApp\ToDoApp\ToDoApp\Views\Task\AddTask.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AddTaskModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
