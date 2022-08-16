#pragma checksum "D:\.NET\HR_Management\HR_Management\Views\Project\History.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce5ce74965b08339825dcc23ce5d578dc39232cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_History), @"mvc.1.0.view", @"/Views/Project/History.cshtml")]
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
#nullable restore
#line 1 "D:\.NET\HR_Management\HR_Management\Views\_ViewImports.cshtml"
using HR_Management;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.NET\HR_Management\HR_Management\Views\_ViewImports.cshtml"
using HR_Management.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\.NET\HR_Management\HR_Management\Views\_ViewImports.cshtml"
using HR_Management.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\.NET\HR_Management\HR_Management\Views\_ViewImports.cshtml"
using HR_Management.ViewModels.Authentication;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce5ce74965b08339825dcc23ce5d578dc39232cf", @"/Views/Project/History.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06e9ff844df84e1ca927f096d6adb896ea008787", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_History : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Project>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Team", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("success mb-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Description", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("in-progress mb-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\.NET\HR_Management\HR_Management\Views\Project\History.cshtml"
  
    ViewData["Title"] = "History";
    int count = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!--Index start-->
<section class=""pr-project"">
    <div class=""dashboard-wrapper"">
        <div class=""dashboard-header"">
            <div class=""left-header"">
                <button class=""navbar-toggler"">
                    <svg xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink""
                         width=""34px"" height=""34px"" viewBox=""0 0 24 24"" version=""1.1"">
                        <g stroke=""none"" stroke-width=""1"" fill=""#d0d3d6"" fill-rule=""evenodd"">
                            <rect x=""0"" y=""0"" width=""24"" height=""24""></rect>
                            <rect fill=""#3445e5"" x=""4"" y=""4"" width=""7"" height=""7"" rx=""1.5""></rect>
                            <path d=""M5.5,13 L9.5,13 C10.3284271,13 11,13.6715729 11,14.5 L11,18.5 C11,19.3284271 10.3284271,20 9.5,20 L5.5,20 C4.67157288,20 4,19.3284271 4,18.5 L4,14.5 C4,13.6715729 4.67157288,13 5.5,13 Z M14.5,4 L18.5,4 C19.3284271,4 20,4.67157288 20,5.5 L20,9.5 C20,10.3284271 19.3284271,11 18.5,11 L14.5,11 C13.6715729,");
            WriteLiteral(@"11 13,10.3284271 13,9.5 L13,5.5 C13,4.67157288 13.6715729,4 14.5,4 Z M14.5,13 L18.5,13 C19.3284271,13 20,13.6715729 20,14.5 L20,18.5 C20,19.3284271 19.3284271,20 18.5,20 L14.5,20 C13.6715729,20 13,19.3284271 13,18.5 L13,14.5 C13,13.6715729 13.6715729,13 14.5,13 Z""
                                  fill=""#3445e5"" opacity=""0.3""></path>
                        </g>
                    </svg>
                </button>
                <h3>Project History</h3>
            </div>
        </div>
        <div class=""dashboard-content"">
            <div class=""row"">
                <div class=""dl-table table-responsive col-12"">
                    <table class=""table"" id=""sortTable"">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>Project Name</th>
                                <th>Start Date</th>
                                <th>Deadline</th>
                                <td>Status</td>
          ");
            WriteLiteral("                      <th>Team</th>\r\n                                <th>Description</th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 43 "D:\.NET\HR_Management\HR_Management\Views\Project\History.cshtml"
                             if (Model.Count() > 0)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "D:\.NET\HR_Management\HR_Management\Views\Project\History.cshtml"
                                 foreach (var pr in @Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 48 "D:\.NET\HR_Management\HR_Management\Views\Project\History.cshtml"
                                       Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 49 "D:\.NET\HR_Management\HR_Management\Views\Project\History.cshtml"
                                       Write(pr.ProjectName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 50 "D:\.NET\HR_Management\HR_Management\Views\Project\History.cshtml"
                                       Write(pr.StartDate.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 51 "D:\.NET\HR_Management\HR_Management\Views\Project\History.cshtml"
                                       Write(pr.EndDate.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 52 "D:\.NET\HR_Management\HR_Management\Views\Project\History.cshtml"
                                         if (pr.IsSuccesfull == true)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td style=\"color: #2dbaa5\">Succesfuly Completed</td>\r\n");
#nullable restore
#line 55 "D:\.NET\HR_Management\HR_Management\Views\Project\History.cshtml"
                                        }
                                        else if(pr.IsSuccesfull == false)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td style=\"color: #ffaf8a\">Project Delayed</td>\r\n");
#nullable restore
#line 59 "D:\.NET\HR_Management\HR_Management\Views\Project\History.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td class=\"actions\">\r\n                                            <div class=\"green d-inline m-1\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce5ce74965b08339825dcc23ce5d578dc39232cf10332", async() => {
                WriteLiteral(@"
                                                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" fill=""currentColor"" class=""bi bi-people-fill"" viewBox=""0 0 16 16"">
                                                        <path d=""M7 14s-1 0-1-1 1-4 5-4 5 3 5 4-1 1-1 1H7zm4-6a3 3 0 1 0 0-6 3 3 0 0 0 0 6z"" />
                                                        <path fill-rule=""evenodd"" d=""M5.216 14A2.238 2.238 0 0 1 5 13c0-1.355.68-2.75 1.936-3.72A6.325 6.325 0 0 0 5 9c-4 0-5 3-5 4s1 1 1 1h4.216z"" />
                                                        <path d=""M4.5 8a2.5 2.5 0 1 0 0-5 2.5 2.5 0 0 0 0 5z"" />
                                                    </svg>
                                                    Team
                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "D:\.NET\HR_Management\HR_Management\Views\Project\History.cshtml"
                                                                       WriteLiteral(pr.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </div>
                                        </td>
                                        <td class=""actions"">
                                            <div class=""yellow d-inline m-1"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce5ce74965b08339825dcc23ce5d578dc39232cf13696", async() => {
                WriteLiteral("\r\n                                                    Description\r\n                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "D:\.NET\HR_Management\HR_Management\Views\Project\History.cshtml"
                                                                              WriteLiteral(pr.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </div>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 80 "D:\.NET\HR_Management\HR_Management\Views\Project\History.cshtml"
                                    count++;
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "D:\.NET\HR_Management\HR_Management\Views\Project\History.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!--Index end-->\r\n");
            DefineSection("CssProject", async() => {
                WriteLiteral("\r\n<!--Bootstrap links for Data Table-->\r\n<link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css\">\r\n<link rel=\"stylesheet\" href=\"https://cdn.datatables.net/1.10.22/css/dataTables.bootstrap4.min.css\">\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("ScriptProject", async() => {
                WriteLiteral(@"
<!--vendor JS-->
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"">
</script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"">
</script>
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"">
</script>
<!--Data tables-->
<script src=""https://cdn.datatables.net/1.10.22/js/jquery.dataTables.min.js"">
</script>
<script src=""https://cdn.datatables.net/1.10.22/js/dataTables.bootstrap4.min.js"">
</script>
<script>
    $('#sortTable').DataTable();
</script>
");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Project>> Html { get; private set; }
    }
}
#pragma warning restore 1591