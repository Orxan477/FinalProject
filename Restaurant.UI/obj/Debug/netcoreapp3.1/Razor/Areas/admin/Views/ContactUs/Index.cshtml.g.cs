#pragma checksum "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\ContactUs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d9c3b4135e217b902035ce8802ab5a85f997234"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_admin_Views_ContactUs_Index), @"mvc.1.0.view", @"/Areas/admin/Views/ContactUs/Index.cshtml")]
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
#line 1 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\_ViewImports.cshtml"
using Restaurant.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\_ViewImports.cshtml"
using Restaurant.Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\_ViewImports.cshtml"
using Restaurant.Business.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\_ViewImports.cshtml"
using Restaurant.Business.ViewModels.Footer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\_ViewImports.cshtml"
using Restaurant.Business.ViewModels.Reservation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\_ViewImports.cshtml"
using Restaurant.Business.ViewModels.Menu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\_ViewImports.cshtml"
using Restaurant.Business.ViewModels.Team;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\_ViewImports.cshtml"
using Restaurant.Business.ViewModels.Position;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\_ViewImports.cshtml"
using Restaurant.Business.ViewModels.Home.HomeIntro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\_ViewImports.cshtml"
using Restaurant.Business.ViewModels.Home.About;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\_ViewImports.cshtml"
using Restaurant.Business.ViewModels.Home.Choose;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\_ViewImports.cshtml"
using Restaurant.Business.ViewModels.Home.Gallery;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\_ViewImports.cshtml"
using Restaurant.Business.ViewModels.Home.Feedback;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\_ViewImports.cshtml"
using Restaurant.Business.ViewModels.Home.Special;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\_ViewImports.cshtml"
using Restaurant.Business.ViewModels.Home.ContactUs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\_ViewImports.cshtml"
using Restaurant.Business.ViewModels.Setting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\_ViewImports.cshtml"
using Restaurant.Business.ViewModels.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d9c3b4135e217b902035ce8802ab5a85f997234", @"/Areas/admin/Views/ContactUs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c971379740ab012161ef949c96c5555444a3d51d", @"/Areas/admin/Views/_ViewImports.cshtml")]
    public class Areas_admin_Views_ContactUs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Paginate<ContactUsListVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Check", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-page", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\ContactUs\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int count = ViewBag.TakeCount;
    int page = Model.PageCount;
    int productNum = ((Model.CurrentPage - 1) * count) + 1;
    int previous = Model.CurrentPage - 1;
    int next = Model.CurrentPage + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-lg-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Contact Us</h4>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th>No</th>
                                <th>Name</th>
                                <th>Email</th>
                                <th>Subject</th>
                                <th>Message</th>
                                <th>Sent Date</th>
                                <th>Setting</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 31 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\ContactUs\Index.cshtml"
                             foreach (var contact in Model.Items)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 34 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\ContactUs\Index.cshtml"
                                   Write(productNum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 35 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\ContactUs\Index.cshtml"
                                   Write(contact.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 36 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\ContactUs\Index.cshtml"
                                   Write(contact.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 37 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\ContactUs\Index.cshtml"
                                   Write(contact.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 38 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\ContactUs\Index.cshtml"
                                   Write(contact.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 39 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\ContactUs\Index.cshtml"
                                   Write(contact.SentDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d9c3b4135e217b902035ce8802ab5a85f99723412540", async() => {
                WriteLiteral("\r\n                                            <button type=\"submit\" class=\"btn btn-success\"><i class=\"mdi mdi-check-circle-outline\"></i></button>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\ContactUs\Index.cshtml"
                                                                                    WriteLiteral(contact.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 46 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\ContactUs\Index.cshtml"
                                productNum++;
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n");
#nullable restore
#line 50 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\ContactUs\Index.cshtml"
                      if (Model.PageCount!=1)
                      {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                           <div class=""col-lg-12 grid-margin stretch-card justify-content-center mt-4 mb-0"">
                                <nav aria-label=""..."">
                                    <ul class=""pagination pagination-md"">
                                        <li");
            BeginWriteAttribute("class", " class=\"", 2533, "\"", 2585, 2);
            WriteAttributeValue("", 2541, "page-item", 2541, 9, true);
#nullable restore
#line 55 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\ContactUs\Index.cshtml"
WriteAttributeValue(" ", 2550, Model.CurrentPage<3?"d-none":"", 2551, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d9c3b4135e217b902035ce8802ab5a85f99723417072", async() => {
                WriteLiteral("First");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </li>\r\n                                        <li");
            BeginWriteAttribute("class", " class=\"", 2793, "\"", 2849, 2);
            WriteAttributeValue("", 2801, "page-item", 2801, 9, true);
#nullable restore
#line 58 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\ContactUs\Index.cshtml"
WriteAttributeValue(" ", 2810, Model.CurrentPage==1   ?"d-none":"", 2811, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d9c3b4135e217b902035ce8802ab5a85f99723419453", async() => {
                WriteLiteral("Previous");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\ContactUs\Index.cshtml"
                                                                                        WriteLiteral(previous);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </li>\r\n\r\n");
#nullable restore
#line 62 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\ContactUs\Index.cshtml"
                                         if (Model.CurrentPage >= 2 && Model.CurrentPage < Model.PageCount)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\ContactUs\Index.cshtml"
                                             for (int i = Model.CurrentPage - 1; i <= Model.CurrentPage + 1; i++)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li");
            BeginWriteAttribute("class", " class=\"", 3392, "\"", 3447, 2);
            WriteAttributeValue("", 3400, "page-item", 3400, 9, true);
#nullable restore
#line 66 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\ContactUs\Index.cshtml"
WriteAttributeValue(" ", 3409, Model.CurrentPage==i?"disabled":"", 3410, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d9c3b4135e217b902035ce8802ab5a85f99723423185", async() => {
#nullable restore
#line 67 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\ContactUs\Index.cshtml"
                                                                                                           Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\ContactUs\Index.cshtml"
                                                                                                WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                </li>\r\n");
#nullable restore
#line 69 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\ContactUs\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\ContactUs\Index.cshtml"
                                             
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li");
            BeginWriteAttribute("class", " class=\"", 3759, "\"", 3826, 2);
            WriteAttributeValue("", 3767, "page-item", 3767, 9, true);
#nullable restore
#line 71 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\ContactUs\Index.cshtml"
WriteAttributeValue(" ", 3776, Model.CurrentPage==Model.PageCount?"d-none":"", 3777, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d9c3b4135e217b902035ce8802ab5a85f99723426957", async() => {
                WriteLiteral("Next >");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\ContactUs\Index.cshtml"
                                                                                        WriteLiteral(next);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </li>\r\n                                        <li");
            BeginWriteAttribute("class", " class=\"", 4039, "\"", 4106, 2);
            WriteAttributeValue("", 4047, "page-item", 4047, 9, true);
#nullable restore
#line 74 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\ContactUs\Index.cshtml"
WriteAttributeValue(" ", 4056, Model.CurrentPage==Model.PageCount?"d-none":"", 4057, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d9c3b4135e217b902035ce8802ab5a85f99723429910", async() => {
                WriteLiteral("Last");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 75 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\ContactUs\Index.cshtml"
                                                                                        WriteLiteral(Model.PageCount);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </li>\r\n                                    </ul>\r\n                                </nav>\r\n                            </div>  \r\n");
#nullable restore
#line 80 "D:\HP\Documents\Private\Code Academy\FinallProject\Restaurant.UI\Areas\admin\Views\ContactUs\Index.cshtml"
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Paginate<ContactUsListVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
