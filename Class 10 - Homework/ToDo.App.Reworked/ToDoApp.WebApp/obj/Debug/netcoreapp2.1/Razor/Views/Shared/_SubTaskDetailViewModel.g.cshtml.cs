#pragma checksum "E:\web development\ASP.Net MVC\homework\ASP.Net-MVC\Class 6 - Homework\ToDo.App.Reworked\ToDoApp.WebApp\Views\Shared\_SubTaskDetailViewModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2970898e64eb8b6333220905297f5346bce8f73f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SubTaskDetailViewModel), @"mvc.1.0.view", @"/Views/Shared/_SubTaskDetailViewModel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_SubTaskDetailViewModel.cshtml", typeof(AspNetCore.Views_Shared__SubTaskDetailViewModel))]
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
#line 1 "E:\web development\ASP.Net MVC\homework\ASP.Net-MVC\Class 6 - Homework\ToDo.App.Reworked\ToDoApp.WebApp\Views\_ViewImports.cshtml"
using ToDoApp.WebApp;

#line default
#line hidden
#line 2 "E:\web development\ASP.Net MVC\homework\ASP.Net-MVC\Class 6 - Homework\ToDo.App.Reworked\ToDoApp.WebApp\Views\_ViewImports.cshtml"
using ToDoApp.WebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2970898e64eb8b6333220905297f5346bce8f73f", @"/Views/Shared/_SubTaskDetailViewModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf342e78b7f2139607b84513ec8ecaa6147d6eb8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__SubTaskDetailViewModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SubTaskViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 29, true);
            WriteLiteral("\r\n\r\n<div class=\"jumbotron\">\r\n");
            EndContext();
#line 5 "E:\web development\ASP.Net MVC\homework\ASP.Net-MVC\Class 6 - Homework\ToDo.App.Reworked\ToDoApp.WebApp\Views\Shared\_SubTaskDetailViewModel.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
            BeginContext(92, 74, true);
            WriteLiteral("        <div class=\"hidden\">\r\n            <span class=\"input-group-addon\">");
            EndContext();
            BeginContext(167, 35, false);
#line 8 "E:\web development\ASP.Net MVC\homework\ASP.Net-MVC\Class 6 - Homework\ToDo.App.Reworked\ToDoApp.WebApp\Views\Shared\_SubTaskDetailViewModel.cshtml"
                                       Write(Html.Label(expression: $"model.Id"));

#line default
#line hidden
            EndContext();
            BeginContext(202, 21, true);
            WriteLiteral("</span>\r\n            ");
            EndContext();
            BeginContext(224, 74, false);
#line 9 "E:\web development\ASP.Net MVC\homework\ASP.Net-MVC\Class 6 - Homework\ToDo.App.Reworked\ToDoApp.WebApp\Views\Shared\_SubTaskDetailViewModel.cshtml"
       Write(Html.TextBox($"model.Id", Model.Id, null, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(298, 58, true);
            WriteLiteral("\r\n        </div>\r\n        <span class=\"input-group-addon\">");
            EndContext();
            BeginContext(357, 38, false);
#line 11 "E:\web development\ASP.Net MVC\homework\ASP.Net-MVC\Class 6 - Homework\ToDo.App.Reworked\ToDoApp.WebApp\Views\Shared\_SubTaskDetailViewModel.cshtml"
                                   Write(Html.Label(expression: $"model.Title"));

#line default
#line hidden
            EndContext();
            BeginContext(395, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
            BeginContext(413, 80, false);
#line 12 "E:\web development\ASP.Net MVC\homework\ASP.Net-MVC\Class 6 - Homework\ToDo.App.Reworked\ToDoApp.WebApp\Views\Shared\_SubTaskDetailViewModel.cshtml"
   Write(Html.TextBox($"model.Title", Model.Title, null, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(497, 40, true);
            WriteLiteral("        <span class=\"input-group-addon\">");
            EndContext();
            BeginContext(538, 43, false);
#line 14 "E:\web development\ASP.Net MVC\homework\ASP.Net-MVC\Class 6 - Homework\ToDo.App.Reworked\ToDoApp.WebApp\Views\Shared\_SubTaskDetailViewModel.cshtml"
                                   Write(Html.Label(expression: $"model.Descrition"));

#line default
#line hidden
            EndContext();
            BeginContext(581, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
            BeginContext(599, 90, false);
#line 15 "E:\web development\ASP.Net MVC\homework\ASP.Net-MVC\Class 6 - Homework\ToDo.App.Reworked\ToDoApp.WebApp\Views\Shared\_SubTaskDetailViewModel.cshtml"
   Write(Html.TextBox($"model.Descrition", Model.Descrition, null, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(693, 40, true);
            WriteLiteral("        <span class=\"input-group-addon\">");
            EndContext();
            BeginContext(734, 50, false);
#line 17 "E:\web development\ASP.Net MVC\homework\ASP.Net-MVC\Class 6 - Homework\ToDo.App.Reworked\ToDoApp.WebApp\Views\Shared\_SubTaskDetailViewModel.cshtml"
                                   Write(Html.Label(expression: $"model.Status of SubTask"));

#line default
#line hidden
            EndContext();
            BeginContext(784, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
            BeginContext(802, 138, false);
#line 18 "E:\web development\ASP.Net MVC\homework\ASP.Net-MVC\Class 6 - Homework\ToDo.App.Reworked\ToDoApp.WebApp\Views\Shared\_SubTaskDetailViewModel.cshtml"
   Write(Html.DropDownList($"model.SubStatus", Html.GetEnumSelectList(Model.SubStatus.GetType()), new { Model.SubStatus, @class = "form-control" }));

#line default
#line hidden
            EndContext();
#line 18 "E:\web development\ASP.Net MVC\homework\ASP.Net-MVC\Class 6 - Homework\ToDo.App.Reworked\ToDoApp.WebApp\Views\Shared\_SubTaskDetailViewModel.cshtml"
                                                                                                                                                   
    }

#line default
#line hidden
            BeginContext(949, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SubTaskViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
