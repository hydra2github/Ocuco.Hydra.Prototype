#pragma checksum "C:\OCUCO\OCUCOHUB\Ocuco.Hydra\WebApps\Ocuco.Hydra.WebMVC21.V2\Views\LuxRxoUI\CheckFrame.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56719d6e3395ec134da287d452a48bc0226c01d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LuxRxoUI_CheckFrame), @"mvc.1.0.view", @"/Views/LuxRxoUI/CheckFrame.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LuxRxoUI/CheckFrame.cshtml", typeof(AspNetCore.Views_LuxRxoUI_CheckFrame))]
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
#line 1 "C:\OCUCO\OCUCOHUB\Ocuco.Hydra\WebApps\Ocuco.Hydra.WebMVC21.V2\Views\_ViewImports.cshtml"
using Ocuco.Hydra.WebMVC21.V2.Controllers;

#line default
#line hidden
#line 2 "C:\OCUCO\OCUCOHUB\Ocuco.Hydra\WebApps\Ocuco.Hydra.WebMVC21.V2\Views\_ViewImports.cshtml"
using Ocuco.Hydra.WebMVC21.V2.ViewModels;

#line default
#line hidden
#line 3 "C:\OCUCO\OCUCOHUB\Ocuco.Hydra\WebApps\Ocuco.Hydra.WebMVC21.V2\Views\_ViewImports.cshtml"
using Ocuco.Application.Services.OcucoHub.LuxotticaRxoService.ViewModels;

#line default
#line hidden
#line 4 "C:\OCUCO\OCUCOHUB\Ocuco.Hydra\WebApps\Ocuco.Hydra.WebMVC21.V2\Views\_ViewImports.cshtml"
using Ocuco.DataModel.Hydradb.Entities;

#line default
#line hidden
#line 5 "C:\OCUCO\OCUCOHUB\Ocuco.Hydra\WebApps\Ocuco.Hydra.WebMVC21.V2\Views\_ViewImports.cshtml"
using Ocuco.Application.Services.OcucoHub.LuxotticaRxoAuditService.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56719d6e3395ec134da287d452a48bc0226c01d7", @"/Views/LuxRxoUI/CheckFrame.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b78f6de18a760b47616e761bfe916631e604e1b3", @"/Views/_ViewImports.cshtml")]
    public class Views_LuxRxoUI_CheckFrame : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RxoCheckFrameViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("DOOR_NUMBER"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("FRAME_UPC"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frmValidateFrame"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/imgapp/WaitingSpinner.06.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/node_modules/jquery-validation/dist/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/node_modules/jquery-validation-unobtrusive/dist/jquery.validate.unobtrusive.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\OCUCO\OCUCOHUB\Ocuco.Hydra\WebApps\Ocuco.Hydra.WebMVC21.V2\Views\LuxRxoUI\CheckFrame.cshtml"
  
    ViewBag.Title = "Luxottica RXO CheckFrame";

#line default
#line hidden
            BeginContext(87, 96, true);
            WriteLiteral("\r\n<div class=\"col-md-6 offset-md-3\">\r\n\r\n    <!--<div class=\"card card-body bg-light\">-->\r\n\r\n    ");
            EndContext();
            BeginContext(183, 3847, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6930537daf754785adcc52e96484373e", async() => {
                BeginContext(225, 261, true);
                WriteLiteral(@"

        <div class=""card"">

            <div class=""card-header"" style=""background-color: #ffffff;"">
                <h5 class=""card-title"">Validate Luxottica Frame</h5>

                <!--<div asp-validation-summary=""All""></div>-->
                ");
                EndContext();
                BeginContext(486, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e70b047ba1854bc69b675164653e11e4", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 18 "C:\OCUCO\OCUCOHUB\Ocuco.Hydra\WebApps\Ocuco.Hydra.WebMVC21.V2\Views\LuxRxoUI\CheckFrame.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(532, 66, true);
                WriteLiteral("\r\n\r\n                <div class=\"form-group\">\r\n                    ");
                EndContext();
                BeginContext(598, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90f687a6e6e74e20ad16b4dc1a80576f", async() => {
                    BeginContext(622, 12, true);
                    WriteLiteral("Door Number:");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 21 "C:\OCUCO\OCUCOHUB\Ocuco.Hydra\WebApps\Ocuco.Hydra.WebMVC21.V2\Views\LuxRxoUI\CheckFrame.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DoorNr);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(642, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(664, 76, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f02fbb9fd4984d5890d4235db95e0afe", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 22 "C:\OCUCO\OCUCOHUB\Ocuco.Hydra\WebApps\Ocuco.Hydra.WebMVC21.V2\Views\LuxRxoUI\CheckFrame.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DoorNr);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(740, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(762, 61, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0297892899444ba0905ae25301650192", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 23 "C:\OCUCO\OCUCOHUB\Ocuco.Hydra\WebApps\Ocuco.Hydra.WebMVC21.V2\Views\LuxRxoUI\CheckFrame.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DoorNr);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(823, 90, true);
                WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    ");
                EndContext();
                BeginContext(913, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03cb88abf115400cb876da56f5a2ba68", async() => {
                    BeginContext(939, 9, true);
                    WriteLiteral("FrameUpc:");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 27 "C:\OCUCO\OCUCOHUB\Ocuco.Hydra\WebApps\Ocuco.Hydra.WebMVC21.V2\Views\LuxRxoUI\CheckFrame.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FrameUpc);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(956, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(978, 88, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "36ea4a4b60c348a3bc4865692a42c539", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 28 "C:\OCUCO\OCUCOHUB\Ocuco.Hydra\WebApps\Ocuco.Hydra.WebMVC21.V2\Views\LuxRxoUI\CheckFrame.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FrameUpc);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1066, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1088, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8f1003c18474721b48cd3b29d1080a9", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 29 "C:\OCUCO\OCUCOHUB\Ocuco.Hydra\WebApps\Ocuco.Hydra.WebMVC21.V2\Views\LuxRxoUI\CheckFrame.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FrameUpc);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1151, 1748, true);
                WriteLiteral(@"
                </div>

            </div>

            <div class=""card-body"" style=""background-color: #ffffff;"">

                <label for=""DOOR_NUMBER"" class=""control-label"">Sample data for Door number</label>

                <div class=""col-xs-12 input-group DOOR_NUMBER"">
                    <div class=""btn-group btn-group-justified"" role=""group"" aria-label=""DoorNumber"">
                        <button type=""button"" class=""btn btn-primary defaultvalue"" value="""">Any value</button>
                        <button type=""button"" class=""btn btn-primary"" value=""0001026660"">0001026660</button>
                        <button type=""button"" class=""btn btn-primary"" value=""0001027218"">0001027218</button>
                    </div>
                </div>

                <label for=""FRAME_UPC"" class=""col-xs-3 control-label"">Sample data for UPC</label>

                <div class=""col-xs-12 input-group FRAME_UPC"">
                    <div class=""btn-group btn-group-justified"" role=""group"" aria-");
                WriteLiteral(@"label=""FrameUpc"">
                        <button type=""button"" class=""btn btn-primary defaultvalue"" value="""">Any value</button>
                        <button type=""button"" class=""btn btn-primary"" value=""805289270102"">805289270102</button>
                        <button type=""button"" class=""btn btn-primary"" value=""805289183082"">805289183082</button>
                    </div>
                </div>

            </div>

            <div class=""card-footer"" style=""background-color: #ffffff;"">

                <div class=""form-group"">
                    <button type=""submit"" class=""btn btn-primary btn-lg"" id=""ShowBusyIndicator""><i class=""fa fa-cogs""></i> Check Frame</button>
                </div>

");
                EndContext();
#line 64 "C:\OCUCO\OCUCOHUB\Ocuco.Hydra\WebApps\Ocuco.Hydra.WebMVC21.V2\Views\LuxRxoUI\CheckFrame.cshtml"
                 if (ViewBag.UserMessage != null)
                {
                    

#line default
#line hidden
#line 66 "C:\OCUCO\OCUCOHUB\Ocuco.Hydra\WebApps\Ocuco.Hydra.WebMVC21.V2\Views\LuxRxoUI\CheckFrame.cshtml"
                     if (ViewBag.UserMessage.ErrorCode != 0)
                    {

#line default
#line hidden
                BeginContext(3054, 212, true);
                WriteLiteral("                        <div class=\"alert alert-danger\" role=\"alert\">\r\n                            Luxottica RXO CheckFrame WS Error!\r\n                            <br />\r\n                            Error Code : ");
                EndContext();
                BeginContext(3267, 29, false);
#line 71 "C:\OCUCO\OCUCOHUB\Ocuco.Hydra\WebApps\Ocuco.Hydra.WebMVC21.V2\Views\LuxRxoUI\CheckFrame.cshtml"
                                    Write(ViewBag.UserMessage.ErrorCode);

#line default
#line hidden
                EndContext();
                BeginContext(3296, 86, true);
                WriteLiteral("\r\n                            <br />\r\n                            Error Description : ");
                EndContext();
                BeginContext(3383, 36, false);
#line 73 "C:\OCUCO\OCUCOHUB\Ocuco.Hydra\WebApps\Ocuco.Hydra.WebMVC21.V2\Views\LuxRxoUI\CheckFrame.cshtml"
                                           Write(ViewBag.UserMessage.ErrorDescription);

#line default
#line hidden
                EndContext();
                BeginContext(3419, 34, true);
                WriteLiteral("\r\n                        </div>\r\n");
                EndContext();
#line 75 "C:\OCUCO\OCUCOHUB\Ocuco.Hydra\WebApps\Ocuco.Hydra.WebMVC21.V2\Views\LuxRxoUI\CheckFrame.cshtml"
                    }
                    else
                    {

#line default
#line hidden
                BeginContext(3525, 227, true);
                WriteLiteral("                        <div class=\"alert alert-success\" role=\"alert\">\r\n                            Luxottica RXO CheckFrame Ok, Frame is validated!\r\n                            <br />\r\n                            Error Code : ");
                EndContext();
                BeginContext(3753, 29, false);
#line 81 "C:\OCUCO\OCUCOHUB\Ocuco.Hydra\WebApps\Ocuco.Hydra.WebMVC21.V2\Views\LuxRxoUI\CheckFrame.cshtml"
                                    Write(ViewBag.UserMessage.ErrorCode);

#line default
#line hidden
                EndContext();
                BeginContext(3782, 86, true);
                WriteLiteral("\r\n                            <br />\r\n                            Error Description : ");
                EndContext();
                BeginContext(3869, 36, false);
#line 83 "C:\OCUCO\OCUCOHUB\Ocuco.Hydra\WebApps\Ocuco.Hydra.WebMVC21.V2\Views\LuxRxoUI\CheckFrame.cshtml"
                                           Write(ViewBag.UserMessage.ErrorDescription);

#line default
#line hidden
                EndContext();
                BeginContext(3905, 34, true);
                WriteLiteral("\r\n                        </div>\r\n");
                EndContext();
#line 85 "C:\OCUCO\OCUCOHUB\Ocuco.Hydra\WebApps\Ocuco.Hydra.WebMVC21.V2\Views\LuxRxoUI\CheckFrame.cshtml"
                    }

#line default
#line hidden
#line 85 "C:\OCUCO\OCUCOHUB\Ocuco.Hydra\WebApps\Ocuco.Hydra.WebMVC21.V2\Views\LuxRxoUI\CheckFrame.cshtml"
                     
                }

#line default
#line hidden
                BeginContext(3981, 42, true);
                WriteLiteral("            </div>\r\n\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4030, 396, true);
            WriteLiteral(@"
</div>




<!---------------------------------------------
  --  Modal throbber (Spinning wheel)
  --------------------------------------------->

<div id=""pleaseWaitDialog"" class=""modal fade bd-example-modal-lg"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myLargeModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-body"">
            ");
            EndContext();
            BeginContext(4426, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "90bc5e827bf047a8b7f6a987e23ff79c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4491, 155, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"modal-footer\">\r\n            <h1>Contacting Luxottica Web Services...</h1>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4664, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(4672, 84, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc9c932529e645998141a703486a7ab5", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4756, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4762, 104, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbbb0529259f4a62934ef4612e7f8f1f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4866, 2372, true);
                WriteLiteral(@"

    <script type=""text/javascript"">
        $(document).ready(function () {
            //debugger;

            BtnGroup('DOOR_NUMBER');
            BtnGroup('FRAME_UPC');

            function BtnGroup(divid) {
                $('.' + divid + ' button').first().attr(""aria-pressed"", ""true"");
                $('.' + divid + ' button').first().addClass(""active"");
                $('#' + divid).attr('value', $('.' + divid + ' button.active').val());
                $('.' + divid + ' button').click(function () {
                    $('.' + divid + ' button').attr(""aria-pressed"", ""false"");
                    $('.' + divid + ' button').removeClass(""active"");
                    $(this).attr(""aria-pressed"", ""true"");
                    $(this).addClass(""active"");
                    $('#' + divid).attr('value', $('.' + divid + ' button.active').val());
                });
            }

            var $form = $(""#frmValidateFrame"");
            var $submitbutton = $(""#ShowBusyIndicator"");");
                WriteLiteral(@"

            $form.on(""blur"", ""input"", () => {
                if ($form.valid()) {
                    $submitbutton.removeAttr(""disabled"");
                } else {
                    $submitbutton.attr(""disabled"", ""disabled"");
                }
            });

            $('#ShowBusyIndicator').click(function () {

                var url = $(this).attr(""action"");
                var formData = $(this).serialize();

                //debugger;

                if ($form.valid()) {
                    // show modal
                    $(""#pleaseWaitDialog"").modal();
                } else {                    
                    return;
                }

                $.ajax({
                    url: url,
                    type: ""POST"",
                    //data: $(""#frmValidateFrame"").serialize()
                    data: formData
                }).done(function (data) {
                    //alert('done!');
                    $(""#pleaseWaitDialog"").modal('hide'");
                WriteLiteral(@");
                }).fail(function (jqXHR, textStatus) {
                    //alert('fail!');
                    //setTimeout('', 2000);
                    $(""#pleaseWaitDialog"").modal('hide');
                });

                
              
            });


           

        });
    </script>
");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RxoCheckFrameViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591