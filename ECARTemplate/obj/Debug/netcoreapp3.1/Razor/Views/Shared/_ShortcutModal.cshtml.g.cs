#pragma checksum "C:\Users\jagiraldo\source\repos\ECARTemplate\ECARTemplate\Views\Shared\_ShortcutModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c57dd5e24ae684b7476c8f4694d8280db88270b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ShortcutModal), @"mvc.1.0.view", @"/Views/Shared/_ShortcutModal.cshtml")]
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
#line 1 "C:\Users\jagiraldo\source\repos\ECARTemplate\ECARTemplate\Views\_ViewImports.cshtml"
using ECARTemplate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jagiraldo\source\repos\ECARTemplate\ECARTemplate\Views\_ViewImports.cshtml"
using ECARTemplate.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jagiraldo\source\repos\ECARTemplate\ECARTemplate\Views\_ViewImports.cshtml"
using ECARTemplate.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c57dd5e24ae684b7476c8f4694d8280db88270b", @"/Views/Shared/_ShortcutModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22b84b265c964a2253c53b091ac6b68388243f81", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__ShortcutModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\jagiraldo\source\repos\ECARTemplate\ECARTemplate\Views\Shared\_ShortcutModal.cshtml"
 if (ViewBag.AppShortcutModal?.Length > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""modal fade modal-backdrop-transparent"" id=""modal-shortcut"" tabindex=""-1"" role=""dialog"" aria-labelledby=""modal-shortcut"" aria-hidden=""true"">
	<div class=""modal-dialog modal-dialog-top modal-transparent"" role=""document"">
		<div class=""modal-content"">
			<div class=""modal-body"">
				<ul class=""app-list w-auto h-auto p-0 text-left"">
					<li>
						<a href=""/intel/introduction"" class=""app-list-item text-white border-0 m-0"">
							<div class=""icon-stack"">
								<i class=""base base-7 icon-stack-3x opacity-100 color-primary-500 ""></i> 
								<i class=""base base-7 icon-stack-2x opacity-100 color-primary-300 ""></i> 
								<i");
            BeginWriteAttribute("class", " class=\"", 687, "\"", 769, 5);
#nullable restore
#line 13 "C:\Users\jagiraldo\source\repos\ECARTemplate\ECARTemplate\Views\Shared\_ShortcutModal.cshtml"
WriteAttributeValue("", 695, Settings.Theme.IconPrefix, 695, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 723, "fa-home", 724, 8, true);
            WriteAttributeValue(" ", 731, "icon-stack-1x", 732, 14, true);
            WriteAttributeValue(" ", 745, "opacity-100", 746, 12, true);
            WriteAttributeValue(" ", 757, "color-white", 758, 12, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
							</div>
							<span class=""app-list-name"">
							Home
							</span>
						</a>
					</li>
					<li>
						<a href=""/page/inboxgeneral"" class=""app-list-item text-white border-0 m-0"">
							<div class=""icon-stack"">
								<i class=""base base-7 icon-stack-3x opacity-100 color-success-500 ""></i> 
								<i class=""base base-7 icon-stack-2x opacity-100 color-success-300 ""></i> 
								<i class=""ni ni-envelope icon-stack-1x text-white""></i>   
							</div>
							<span class=""app-list-name"">
							Inbox
							</span>
						</a>
					</li>
					<li>
						<a href=""/intel/introduction"" class=""app-list-item text-white border-0 m-0"">
							<div class=""icon-stack"">
								<i class=""base base-7 icon-stack-2x opacity-100 color-primary-300 ""></i> 
								<i");
            BeginWriteAttribute("class", " class=\"", 1547, "\"", 1629, 5);
#nullable restore
#line 36 "C:\Users\jagiraldo\source\repos\ECARTemplate\ECARTemplate\Views\Shared\_ShortcutModal.cshtml"
WriteAttributeValue("", 1555, Settings.Theme.IconPrefix, 1555, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1583, "fa-plus", 1584, 8, true);
            WriteAttributeValue(" ", 1591, "icon-stack-1x", 1592, 14, true);
            WriteAttributeValue(" ", 1605, "opacity-100", 1606, 12, true);
            WriteAttributeValue(" ", 1617, "color-white", 1618, 12, true);
            EndWriteAttribute();
            WriteLiteral("></i>\n\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t<span class=\"app-list-name\">\n\t\t\t\t\t\t\tAdd More\n\t\t\t\t\t\t\t</span>\n\t\t\t\t\t\t</a>\n\t\t\t\t\t</li>\n\t\t\t\t</ul>\n\t\t\t</div>\n\t\t</div>\n\t</div>\n</div>\n");
#nullable restore
#line 48 "C:\Users\jagiraldo\source\repos\ECARTemplate\ECARTemplate\Views\Shared\_ShortcutModal.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SmartSettings Settings { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
