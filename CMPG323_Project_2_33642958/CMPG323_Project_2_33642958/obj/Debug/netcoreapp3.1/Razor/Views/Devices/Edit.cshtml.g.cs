#pragma checksum "C:\Users\Franco\Desktop\Local repo\Franky-Dee\CMPG-323-Project-2-33642958\CMPG323_Project_2_33642958\CMPG323_Project_2_33642958\Views\Devices\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1703dee7c38cfbaeccd3541341a6bf480a0d697e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Devices_Edit), @"mvc.1.0.view", @"/Views/Devices/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1703dee7c38cfbaeccd3541341a6bf480a0d697e", @"/Views/Devices/Edit.cshtml")]
    public class Views_Devices_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CMPG323_Project_2_33642958.Models.Device>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Franco\Desktop\Local repo\Franky-Dee\CMPG-323-Project-2-33642958\CMPG323_Project_2_33642958\CMPG323_Project_2_33642958\Views\Devices\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "deviceController";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Device</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""DeviceId"" />
            <div class=""form-group"">
                <label asp-for=""DeviceName"" class=""control-label""></label>
                <input asp-for=""DeviceName"" class=""form-control"" />
                <span asp-validation-for=""DeviceName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CategoryId"" class=""control-label""></label>
                <input asp-for=""CategoryId"" class=""form-control"" />
                <span asp-validation-for=""CategoryId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ZoneId"" class=""control-label""></label>
                <input asp-for=""ZoneId"" class=""form-control"" />
                ");
            WriteLiteral(@"<span asp-validation-for=""ZoneId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Status"" class=""control-label""></label>
                <input asp-for=""Status"" class=""form-control"" />
                <span asp-validation-for=""Status"" class=""text-danger""></span>
            </div>
            <div class=""form-group form-check"">
                <label class=""form-check-label"">
                    <input class=""form-check-input"" asp-for=""IsActvie"" /> ");
#nullable restore
#line 39 "C:\Users\Franco\Desktop\Local repo\Franky-Dee\CMPG-323-Project-2-33642958\CMPG323_Project_2_33642958\CMPG323_Project_2_33642958\Views\Devices\Edit.cshtml"
                                                                     Write(Html.DisplayNameFor(model => model.IsActvie));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </label>
            </div>
            <div class=""form-group"">
                <label asp-for=""DateCreated"" class=""control-label""></label>
                <input asp-for=""DateCreated"" class=""form-control"" />
                <span asp-validation-for=""DateCreated"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 59 "C:\Users\Franco\Desktop\Local repo\Franky-Dee\CMPG-323-Project-2-33642958\CMPG323_Project_2_33642958\CMPG323_Project_2_33642958\Views\Devices\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CMPG323_Project_2_33642958.Models.Device> Html { get; private set; }
    }
}
#pragma warning restore 1591
