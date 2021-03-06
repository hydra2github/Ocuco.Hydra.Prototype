#pragma checksum "C:\OCUCO\OCUCOHUB\Ocuco.Hydra\WebApps\Ocuco.Hydra.WebMVC21.V2\Views\LuxRxoUI\AuditDashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "964d413ebe856d3deb202b05dca3639e4843f28a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LuxRxoUI_AuditDashboard), @"mvc.1.0.view", @"/Views/LuxRxoUI/AuditDashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LuxRxoUI/AuditDashboard.cshtml", typeof(AspNetCore.Views_LuxRxoUI_AuditDashboard))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"964d413ebe856d3deb202b05dca3639e4843f28a", @"/Views/LuxRxoUI/AuditDashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b78f6de18a760b47616e761bfe916631e604e1b3", @"/Views/_ViewImports.cshtml")]
    public class Views_LuxRxoUI_AuditDashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RxoAuditSummary>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\OCUCO\OCUCOHUB\Ocuco.Hydra\WebApps\Ocuco.Hydra.WebMVC21.V2\Views\LuxRxoUI\AuditDashboard.cshtml"
  
    ViewBag.Title = "Luxottica RXO Orders Audit";

#line default
#line hidden
            BeginContext(82, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(101, 1650, true);
                WriteLiteral(@"
    <style type=""text/css"">
        .card-counter {
            box-shadow: 2px 2px 10px #DADADA;
            margin: 5px;
            padding: 20px 10px;
            background-color: #fff;
            height: 100px;
            border-radius: 5px;
            transition: .3s linear all;
        }

            .card-counter:hover {
                box-shadow: 4px 4px 20px #DADADA;
                transition: .3s linear all;
            }

            .card-counter.primary {
                background-color: #007bff;
                color: #FFF;
            }

            .card-counter.danger {
                background-color: #ef5350;
                color: #FFF;
            }

            .card-counter.success {
                background-color: #66bb6a;
                color: #FFF;
            }

            .card-counter.info {
                background-color: #26c6da;
                color: #FFF;
            }

            .card-counter i {
                font-si");
                WriteLiteral(@"ze: 5em;
                opacity: 0.2;
            }

            .card-counter .count-numbers {
                position: absolute;
                right: 35px;
                top: 20px;
                font-size: 32px;
                display: block;
            }

            .card-counter .count-name {
                position: absolute;
                right: 35px;
                top: 65px;
                font-style: italic;
                text-transform: capitalize;
                opacity: 0.5;
                display: block;
                font-size: 18px;
            }
    </style>
");
                EndContext();
            }
            );
            BeginContext(1754, 267, true);
            WriteLiteral(@"
<h2>Dashboard</h2>

<div class=""container"">
    <div class=""row"">
        <div class=""col-md-4"">
            <div class=""card-counter primary"">
                <i class=""fa fa-code-fork""></i>
                <span class=""count-numbers"">
                    ");
            EndContext();
            BeginContext(2022, 58, false);
#line 77 "C:\OCUCO\OCUCOHUB\Ocuco.Hydra\WebApps\Ocuco.Hydra.WebMVC21.V2\Views\LuxRxoUI\AuditDashboard.cshtml"
               Write(Html.DisplayFor(model => model.RxoCheckFrameTotalRequests));

#line default
#line hidden
            EndContext();
            BeginContext(2080, 324, true);
            WriteLiteral(@"
                </span>
                <span class=""count-name"">CheckFrame Requests</span>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""card-counter primary"">
                <i class=""fa fa-ticket""></i>
                <span class=""count-numbers"">
                    ");
            EndContext();
            BeginContext(2405, 58, false);
#line 86 "C:\OCUCO\OCUCOHUB\Ocuco.Hydra\WebApps\Ocuco.Hydra.WebMVC21.V2\Views\LuxRxoUI\AuditDashboard.cshtml"
               Write(Html.DisplayFor(model => model.RxoCheckOrderTotalRequests));

#line default
#line hidden
            EndContext();
            BeginContext(2463, 326, true);
            WriteLiteral(@"
                </span>
                <span class=""count-name"">CheckOrder Requests</span>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""card-counter primary"">
                <i class=""fa fa-database""></i>
                <span class=""count-numbers"">
                    ");
            EndContext();
            BeginContext(2790, 57, false);
#line 95 "C:\OCUCO\OCUCOHUB\Ocuco.Hydra\WebApps\Ocuco.Hydra.WebMVC21.V2\Views\LuxRxoUI\AuditDashboard.cshtml"
               Write(Html.DisplayFor(model => model.RxoSendOrderTotalRequests));

#line default
#line hidden
            EndContext();
            BeginContext(2847, 372, true);
            WriteLiteral(@"
                </span>
                <span class=""count-name"">SendOrder Requests</span>
            </div>
        </div>
    </div>
    <hr />
    <div class=""row"">
        <div class=""col-md-4"">
            <div class=""card-counter danger"">
                <i class=""fa fa-code-fork""></i>
                <span class=""count-numbers"">
                    ");
            EndContext();
            BeginContext(3220, 56, false);
#line 107 "C:\OCUCO\OCUCOHUB\Ocuco.Hydra\WebApps\Ocuco.Hydra.WebMVC21.V2\Views\LuxRxoUI\AuditDashboard.cshtml"
               Write(Html.DisplayFor(model => model.RxoCheckFrameErrRequests));

#line default
#line hidden
            EndContext();
            BeginContext(3276, 321, true);
            WriteLiteral(@"
                </span>
                <span class=""count-name"">CheckFrame Errors</span>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""card-counter danger"">
                <i class=""fa fa-ticket""></i>
                <span class=""count-numbers"">
                    ");
            EndContext();
            BeginContext(3598, 56, false);
#line 116 "C:\OCUCO\OCUCOHUB\Ocuco.Hydra\WebApps\Ocuco.Hydra.WebMVC21.V2\Views\LuxRxoUI\AuditDashboard.cshtml"
               Write(Html.DisplayFor(model => model.RxoCheckOrderErrRequests));

#line default
#line hidden
            EndContext();
            BeginContext(3654, 323, true);
            WriteLiteral(@"
                </span>
                <span class=""count-name"">CheckOrder Errors</span>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""card-counter danger"">
                <i class=""fa fa-database""></i>
                <span class=""count-numbers"">
                    ");
            EndContext();
            BeginContext(3978, 55, false);
#line 125 "C:\OCUCO\OCUCOHUB\Ocuco.Hydra\WebApps\Ocuco.Hydra.WebMVC21.V2\Views\LuxRxoUI\AuditDashboard.cshtml"
               Write(Html.DisplayFor(model => model.RxoSendOrderErrRequests));

#line default
#line hidden
            EndContext();
            BeginContext(4033, 419, true);
            WriteLiteral(@"
                </span>
                <span class=""count-name"">SendOrder Errors</span>
            </div>
        </div>
    </div>
    <hr />
    <div class=""row"" style=""display: flex; justify-content: flex-end"">
        <div class=""col-md-4"">
            <div class=""card-counter success"">
                <i class=""fa fa-database""></i>
                <span class=""count-numbers"">
                    ");
            EndContext();
            BeginContext(4453, 55, false);
#line 137 "C:\OCUCO\OCUCOHUB\Ocuco.Hydra\WebApps\Ocuco.Hydra.WebMVC21.V2\Views\LuxRxoUI\AuditDashboard.cshtml"
               Write(Html.DisplayFor(model => model.RxoSendOrderErrRequests));

#line default
#line hidden
            EndContext();
            BeginContext(4508, 272, true);
            WriteLiteral(@"
                </span>
                <span class=""count-name"">Sent Orders</span>
            </div>
        </div>
    </div>
    <hr />
    <div>
        <span class=""input-group-btn"">
            <button class=""btn btn-info"" type=""button"" id=""addressSearch""");
            EndContext();
            BeginWriteAttribute("onclick", "  onclick=\"", 4780, "\"", 4843, 3);
            WriteAttributeValue("", 4791, "location.href=\'", 4791, 15, true);
#line 146 "C:\OCUCO\OCUCOHUB\Ocuco.Hydra\WebApps\Ocuco.Hydra.WebMVC21.V2\Views\LuxRxoUI\AuditDashboard.cshtml"
WriteAttributeValue("", 4806, Url.Action("AuditGrid", "LuxRxoUI"), 4806, 36, false);

#line default
#line hidden
            WriteAttributeValue("", 4842, "\'", 4842, 1, true);
            EndWriteAttribute();
            BeginContext(4844, 103, true);
            WriteLiteral(">\r\n                Audit data\r\n            </button>\r\n        </span>\r\n    </div>\r\n    <hr />\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RxoAuditSummary> Html { get; private set; }
    }
}
#pragma warning restore 1591
