#pragma checksum "E:\Asp.Net\TourismManagementSystem\TourismManagementSystem\Views\Userview\UserProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b9f1b1c4979ccc9e49afb4d86cfe9dcb667b244"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Userview_UserProfile), @"mvc.1.0.view", @"/Views/Userview/UserProfile.cshtml")]
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
#line 1 "E:\Asp.Net\TourismManagementSystem\TourismManagementSystem\Views\_ViewImports.cshtml"
using TourismManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Asp.Net\TourismManagementSystem\TourismManagementSystem\Views\_ViewImports.cshtml"
using TourismManagementSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b9f1b1c4979ccc9e49afb4d86cfe9dcb667b244", @"/Views/Userview/UserProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6818b599652b0f709fe9f903e0979c6959db931e", @"/Views/_ViewImports.cshtml")]
    public class Views_Userview_UserProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TourismManagementSystem.Models.IdentityModels.ApplicationUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Image/avater_user.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Userview", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditUserProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Cancel Booking"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("tooltip"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Reject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Asp.Net\TourismManagementSystem\TourismManagementSystem\Views\Userview\UserProfile.cshtml"
  
    ViewData["Title"] = "Userprofile1";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container emp-profile\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b9f1b1c4979ccc9e49afb4d86cfe9dcb667b2447731", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b9f1b1c4979ccc9e49afb4d86cfe9dcb667b2447997", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 9 "E:\Asp.Net\TourismManagementSystem\TourismManagementSystem\Views\Userview\UserProfile.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <div class=\"row\">\r\n            <div class=\"col-md-4\">\r\n                <div class=\"profile-img\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8b9f1b1c4979ccc9e49afb4d86cfe9dcb667b2449814", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <div class=\"file btn btn-lg btn-primary\">\r\n");
                WriteLiteral(@"                        <input type=""file"" name=""file"" />
                    </div>
                </div>
            </div>

            <div class=""col-md-6"">
                <div class=""profile-head"">
                    <h5>
                        User Profile
                    </h5>
                    <br />
                    <h6 class=""profile-head"">
                        ");
#nullable restore
#line 28 "E:\Asp.Net\TourismManagementSystem\TourismManagementSystem\Views\Userview\UserProfile.cshtml"
                   Write(Html.DisplayFor(model => model.FullName));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </h6>
                    <br />
                    <ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" id=""home-tab"" data-toggle=""tab"" href=""#home"" role=""tab"" aria-controls=""home"" aria-selected=""true"">Account Information</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""profile-tab"" data-toggle=""tab"" href=""#profile"" role=""tab"" aria-controls=""profile"" aria-selected=""false"">Booking History</a>
                        </li>
                    </ul>
                </div>
            </div>
            <div class=""col-md-2"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b9f1b1c4979ccc9e49afb4d86cfe9dcb667b24412586", async() => {
                    WriteLiteral("\r\n                    <input type=\"button\" class=\"btn btn-primary\" name=\"btnAddMore\" value=\"Update Profile\" />\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-4"">
            </div>
            <div class=""col-md-8"">
                <div class=""tab-content profile-tab"" id=""myTabContent"">
                    <div class=""tab-pane fade show active"" id=""home"" role=""tabpanel"" aria-labelledby=""home-tab"">
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <label>First Name</label>
                            </div>
                            <div class=""col-md-6"">
                                <p> ");
#nullable restore
#line 58 "E:\Asp.Net\TourismManagementSystem\TourismManagementSystem\Views\Userview\UserProfile.cshtml"
                               Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <label>Last Name</label>
                            </div>
                            <div class=""col-md-6"">
                                <p> ");
#nullable restore
#line 66 "E:\Asp.Net\TourismManagementSystem\TourismManagementSystem\Views\Userview\UserProfile.cshtml"
                               Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <label>Email</label>
                            </div>
                            <div class=""col-md-6"">
                                <p> ");
#nullable restore
#line 74 "E:\Asp.Net\TourismManagementSystem\TourismManagementSystem\Views\Userview\UserProfile.cshtml"
                               Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <label>Phone Number</label>
                            </div>
                            <div class=""col-md-6"">
                                <p> ");
#nullable restore
#line 82 "E:\Asp.Net\TourismManagementSystem\TourismManagementSystem\Views\Userview\UserProfile.cshtml"
                               Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <label>Gender</label>
                            </div>
                            <div class=""col-md-6"">
                                <p> ");
#nullable restore
#line 90 "E:\Asp.Net\TourismManagementSystem\TourismManagementSystem\Views\Userview\UserProfile.cshtml"
                               Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                            </div>
                        </div>

                    </div>
                    <div class=""tab-pane fade"" id=""profile"" role=""tabpanel"" aria-labelledby=""profile-tab"">
                        <div class=""container"">
                            <div class=""table-responsive"">
                                <div class=""table-wrapper"">
                                    <table class=""table table-striped table-hover table-bordered"">
                                        <thead>
                                            <tr>
                                                <th>
                                                    Destination
                                                </th>
                                                <th>
                                                    Check-In Date
                                                </th>
                                                <th>
                                       ");
                WriteLiteral(@"             Check-out Date
                                                </th>
                                                <th>
                                                    Booking Date
                                                </th>
                                                <th>
                                                    Status
                                                </th>
                                                <th>
                                                    Action
                                                </th>w
                                            </tr>
                                        </thead>
                                        <tbody>
");
#nullable restore
#line 123 "E:\Asp.Net\TourismManagementSystem\TourismManagementSystem\Views\Userview\UserProfile.cshtml"
                                             foreach (var item in ViewBag.UserBookings)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <tr>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 127 "E:\Asp.Net\TourismManagementSystem\TourismManagementSystem\Views\Userview\UserProfile.cshtml"
                                                   Write(item.Destination);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 130 "E:\Asp.Net\TourismManagementSystem\TourismManagementSystem\Views\Userview\UserProfile.cshtml"
                                                   Write(String.Format("{0:dd-MM-yyyy}", item.CheckIn));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 133 "E:\Asp.Net\TourismManagementSystem\TourismManagementSystem\Views\Userview\UserProfile.cshtml"
                                                   Write(String.Format("{0:dd-MM-yyyy}", item.CheckOut));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 136 "E:\Asp.Net\TourismManagementSystem\TourismManagementSystem\Views\Userview\UserProfile.cshtml"
                                                   Write(String.Format("{0:dd-MM-yyyy}", item.Date));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 139 "E:\Asp.Net\TourismManagementSystem\TourismManagementSystem\Views\Userview\UserProfile.cshtml"
                                                   Write(item.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b9f1b1c4979ccc9e49afb4d86cfe9dcb667b24422645", async() => {
                    WriteLiteral("<i class=\"material-icons\">&#xE872;</i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 142 "E:\Asp.Net\TourismManagementSystem\TourismManagementSystem\Views\Userview\UserProfile.cshtml"
                                                                                                                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                    </td>\r\n                                                </tr>\r\n");
#nullable restore
#line 145 "E:\Asp.Net\TourismManagementSystem\TourismManagementSystem\Views\Userview\UserProfile.cshtml"
                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TourismManagementSystem.Models.IdentityModels.ApplicationUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
