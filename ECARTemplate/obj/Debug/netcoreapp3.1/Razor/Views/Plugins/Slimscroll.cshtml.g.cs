#pragma checksum "C:\Users\jagiraldo\source\repos\ECARTemplate\ECARTemplate\Views\Plugins\Slimscroll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc8dbc01ce9b2d3d59681b21a4e2275910a1c46f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Plugins_Slimscroll), @"mvc.1.0.view", @"/Views/Plugins/Slimscroll.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc8dbc01ce9b2d3d59681b21a4e2275910a1c46f", @"/Views/Plugins/Slimscroll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22b84b265c964a2253c53b091ac6b68388243f81", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Plugins_Slimscroll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("screen, print"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/theme-demo.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\jagiraldo\source\repos\ECARTemplate\ECARTemplate\Views\Plugins\Slimscroll.cshtml"
   
	ViewData["Title"] = "slimscroll";
	ViewData["PageName"] = "plugins_slimscroll";
	ViewData["Category1"] = "Core Plugins";
	ViewData["Heading"] = "<i class='subheader-icon fal fa-shield-alt'></i> SlimScroll <sup class='badge badge-success fw-500'>EXTENSION</sup>";
	ViewData["PageDescription"] = "slimScroll is a small (2.8KB) jQuery plugin that transforms any div into a scrollable area with a nice scrollbar - similar to the one Facebook and Google started using.";

#line default
#line hidden
#nullable disable
            DefineSection("HeadBlock", async() => {
                WriteLiteral("\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dc8dbc01ce9b2d3d59681b21a4e2275910a1c46f5145", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
            WriteLiteral(@"<div class=""alert alert-primary"">
	<div class=""d-flex flex-start w-100"">
		<div class=""mr-2 hidden-md-down"">
			<span class=""icon-stack icon-stack-lg"">
				<i class=""base base-6 icon-stack-3x opacity-100 color-primary-500""></i>
				<i class=""base base-10 icon-stack-2x opacity-100 color-primary-300 fa-flip-vertical""></i>
				<i");
            BeginWriteAttribute("class", " class=\"", 898, "\"", 984, 5);
#nullable restore
#line 17 "C:\Users\jagiraldo\source\repos\ECARTemplate\ECARTemplate\Views\Plugins\Slimscroll.cshtml"
WriteAttributeValue("", 906, Settings.Theme.IconPrefix, 906, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 934, "fa-i-cursor", 935, 12, true);
            WriteAttributeValue(" ", 946, "icon-stack-1x", 947, 14, true);
            WriteAttributeValue(" ", 960, "opacity-100", 961, 12, true);
            WriteAttributeValue(" ", 972, "color-white", 973, 12, true);
            EndWriteAttribute();
            WriteLiteral(@"></i>
			</span>
		</div>
		<div class=""d-flex flex-fill"">
			<div class=""flex-fill"">
				<span class=""h5"">About</span>
				<p>
				slimScroll is a small (4.6KB) jQuery plugin that transforms any div into a scrollable area with a nice scrollbar - similar to the one Facebook and Google started using in their products recently. slimScroll doesn't occupy any visual space as it only appears on a user initiated mouse-over. User can drag the scrollbar or use mouse-wheel to change the scroll value.</p>
				<p class=""m-0"">
					SlimScroll has been around for a long time, and it is very stable and extreamly lightweight. In all sense of the word it gets the job done efficiently. 
				</p>
			</div>
		</div>
	</div>
</div>
<div class=""row"">
	<div class=""col-xl-6"">
		<div id=""panel-1"" class=""panel"">
			<div class=""panel-hdr""> 
				<h2>
					Example for <span class=""fw-300""><i>Size, position and direction</i></span> 
				</h2>
				<div class=""panel-toolbar"">
					<button class=""btn btn-panel"" data-action=""panel-collapse"" ");
            WriteLiteral(@"data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Collapse""></button>
					<button class=""btn btn-panel"" data-action=""panel-fullscreen"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Fullscreen""></button>
					<button class=""btn btn-panel"" data-action=""panel-close"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Close""></button>
				</div>
			</div>
			<div class=""panel-container show"">
				<div class=""panel-content"">                                 
					<div class=""panel-tag"">
						The example below we use the following codes for <code>position: 'left'</code>, <code>height: '300px'</code>, <code>railVisible: true</code>, <code>alwaysVisible: true</code>
					</div>
					<div class=""demo-window rounded mb-g shadow-1 m-auto"" style=""max-width:550px"">
						<div class=""demo-window-content h-100"">
							<div id=""slimtest2"" class=""p-3"">
								<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed diam sem, imperdiet at mollis vestibulum, bibendum id purus. Ali");
            WriteLiteral(@"quam molestie, leo sed molestie condimentum, massa enim lobortis massa, in vulputate diam lorem quis justo. Nullam nec dignissim mi. In non varius nibh. Proin et eros nisi, eu vulputate libero. Suspendisse potenti. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Duis ultricies augue id risus dapibus blandit.</p>
								<p>Integer malesuada molestie dolor sit amet viverra. Mauris nec urna lorem. Integer commodo feugiat ligula eget fermentum. In in tellus a risus convallis pellentesque. Cras non faucibus est. Morbi sagittis risus mollis nisl mollis ac mattis mi volutpat. Vivamus ac rutrum elit. Suspendisse semper orci vitae sapien sollicitudin mattis.</p>
								<p>Integer malesuada molestie dolor sit amet viverra. Mauris nec urna lorem. Integer commodo feugiat ligula eget fermentum. In in tellus a risus convallis pellentesque. Cras non faucibus est. Morbi sagittis risus mollis nisl mollis ac mattis mi volutpat. Vivamus ac rutrum elit. Suspendisse semper orci vita");
            WriteLiteral(@"e sapien sollicitudin mattis.</p>
								<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed diam sem, imperdiet at mollis vestibulum, bibendum id purus. Aliquam molestie, leo sed molestie condimentum, massa enim lobortis massa, in vulputate diam lorem quis justo. Nullam nec dignissim mi. In non varius nibh. Proin et eros nisi, eu vulputate libero. Suspendisse potenti. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Duis ultricies augue id risus dapibus blandit.
								</p>
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>
	</div>
	<div class=""col-xl-6"">
		<div id=""panel-2"" class=""panel"">
			<div class=""panel-hdr""> 
				<h2>
					Example for <span class=""fw-300""><i>width and color</i></span> 
				</h2>
				<div class=""panel-toolbar"">
					<button class=""btn btn-panel"" data-action=""panel-collapse"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Collapse""></button>
					<button class=""btn btn-panel"" data-action=""panel-f");
            WriteLiteral(@"ullscreen"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Fullscreen""></button>
					<button class=""btn btn-panel"" data-action=""panel-close"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Close""></button>
				</div>
			</div>
			<div class=""panel-container show"">
				<div class=""panel-content"">                                 
					<div class=""panel-tag"">
						The example below we use <code>color: color.primary._700</code>, <code>size: '20px'</code>, <code>height: '300px'</code>, <code>alwaysVisible: true</code>             
					</div>
					<div class=""demo-window rounded mb-g shadow-1 m-auto"" style=""max-width:550px"">
						<div class=""demo-window-content h-100"">
							<div id=""slimtest3"" class=""p-3"">
								<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed diam sem, imperdiet at mollis vestibulum, bibendum id purus. Aliquam molestie, leo sed molestie condimentum, massa enim lobortis massa, in vulputate diam lorem quis justo. Nullam nec dignissim mi. In non vari");
            WriteLiteral(@"us nibh. Proin et eros nisi, eu vulputate libero. Suspendisse potenti. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Duis ultricies augue id risus dapibus blandit.</p>
								<p>Integer malesuada molestie dolor sit amet viverra. Mauris nec urna lorem. Integer commodo feugiat ligula eget fermentum. In in tellus a risus convallis pellentesque. Cras non faucibus est. Morbi sagittis risus mollis nisl mollis ac mattis mi volutpat. Vivamus ac rutrum elit. Suspendisse semper orci vitae sapien sollicitudin mattis.</p>
								<p>Integer malesuada molestie dolor sit amet viverra. Mauris nec urna lorem. Integer commodo feugiat ligula eget fermentum. In in tellus a risus convallis pellentesque. Cras non faucibus est. Morbi sagittis risus mollis nisl mollis ac mattis mi volutpat. Vivamus ac rutrum elit. Suspendisse semper orci vitae sapien sollicitudin mattis.</p>
								<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed diam sem, imperdiet at mollis vestibul");
            WriteLiteral(@"um, bibendum id purus. Aliquam molestie, leo sed molestie condimentum, massa enim lobortis massa, in vulputate diam lorem quis justo. Nullam nec dignissim mi. In non varius nibh. Proin et eros nisi, eu vulputate libero. Suspendisse potenti. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Duis ultricies augue id risus dapibus blandit.
								</p>
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>
	</div>
	<div class=""col-xl-12"">
		<div id=""panel-3"" class=""panel"">
			<div class=""panel-hdr""> 
				<h2>
					Scripts  <span class=""fw-300""><i>and config</i></span> 
				</h2>
				<div class=""panel-toolbar"">
					<button class=""btn btn-panel"" data-action=""panel-collapse"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Collapse""></button>
					<button class=""btn btn-panel"" data-action=""panel-fullscreen"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Fullscreen""></button>
					<button class=""btn btn-panel"" data-action=""panel-cl");
            WriteLiteral(@"ose"" data-toggle=""tooltip"" data-offset=""0,10"" data-original-title=""Close""></button>
				</div>
			</div>
			<div class=""panel-container show"">
				<div class=""panel-content"">     
					<h5 class=""frame-heading"">Config options</h5>
					<div class=""frame-wrap"">
		    			<div class=""table-responsive"">
							<table class=""table table-hover table-bordered mb-g"">
								<thead class=""thead-themed"">
									<tr>
										<th style=""width: 150px;"">
											code
										</th>
										<th>
											type
										</th>
										<th>
											what it does
										</th>
									</tr>
								</thead>
								<tbody>
									<tr>
										<td>
											<code>width</code>
										</td>
										<td>
											<span class=""fw-500 text-success"">string</span>
										</td>
										<td>
											Width in pixels of the visible scroll area. Stretch-to-parent if not set. Default: none
										</td>
									</tr>
									<tr>
										<td>
											<code>height</code>
										</td>
						");
            WriteLiteral(@"				<td>
											<span class=""fw-500 text-success"">string</span>
										</td>
										<td>
											Height in pixels of the visible scroll area. Also supports auto to set the height to same as parent container. Default: 250px
										</td>
									</tr>
									<tr>
										<td>
											<code>size</code>
										</td>
										<td>
											<span class=""fw-500 text-success"">string</span>
										</td>
										<td>
											Width in pixels of the scrollbar. Default: 7px
										</td>
									</tr>
									<tr>
										<td>    
											<code>position</code>
										</td>
										<td>
											<span class=""fw-500 text-success"">string</span>
										</td>
										<td>
											left or right. Sets the position of the scrollbar. Default: right
										</td>
									</tr>
									<tr>
										<td>
											<code>color</code>
										</td>
										<td>
											<span class=""fw-500 text-success"">string</span>
										</td>
										<td>
											Col");
            WriteLiteral(@"or in hex of the scrollbar. Default: #000000
										</td>
									</tr>
									<tr>
										<td>
											<code>alwaysVisible</code>
										</td>
										<td>
											<span class=""fw-500 text-info"">bool</span>
										</td>
										<td>
											Disables scrollbar hide. Default: false
										</td>
									</tr>
									<tr>
										<td>
											<code>distance</code>
										</td>   
										<td>
											<span class=""fw-500 text-success"">string</span>
										</td>
										<td>
											Distance in pixels from the edge of the parent element where scrollbar should appear. It is used together with position property. Default:1px
										</td>
									</tr>
									<tr>
										<td>
											<code>start</code>
										</td>
										<td>
											<span class=""fw-500 text-success"">string</span>
										</td>
										<td>
											top or bottom or $(selector) - defines initial position of the scrollbar. When set to bottom it automatically scrolls to t");
            WriteLiteral(@"he bottom of the scrollable container. When HTML element is passed, slimScroll defaults to offsetTop of this element. Default: top.
										</td>
									</tr>
									<tr>
										<td>
											<code>wheelStep</code>
										</td>
										<td>
											<span class=""fw-500 text-info"">integer</span>
										</td>
										<td>
											Integer value for mouse wheel delta. Default: 20
										</td>
									</tr>
									<tr>
										<td>
											<code>railVisible</code>
										</td>
										<td>
											<span class=""fw-500 text-info"">bool</span>
										</td>
										<td>
											Enables scrollbar rail. Default: false
										</td>
									</tr>
									<tr>
										<td>
											<code>railColor</code>
										</td>
										<td>
											<span class=""fw-500 text-success"">string</span>
										</td>
										<td>
											Sets scrollbar rail color, Default: #333333
										</td>
									</tr>
									<tr>
										<td>
											<code>railOpacit");
            WriteLiteral(@"y</code>
										</td>
										<td>
											<span class=""fw-500 text-info"">integer</span>
										</td>
										<td>
											Sets scrollbar rail opacity. Default: 0.2
										</td>
									</tr>
									<tr>
										<td>
											<code>allowPageScroll</code>
										</td>
										<td>
											<span class=""fw-500 text-info"">bool</span>
										</td>
										<td>
											Checks if mouse wheel should scroll page when bar reaches top or bottom of the container. When set to true is scrolls the page.Default: false
										</td>
									</tr>
									<tr>
										<td>
											<code>scrollTo</code>
										</td>
										<td>
											<span class=""fw-500 text-success"">string</span>
										</td>
										<td>
											Jumps to the specified scroll value. Can be called on any element with slimScroll already enabled. Example: $(element).slimScroll({ scrollTo: '50px' });
										</td>
									</tr>
									<tr>
										<td>
											<code>scrollBy</code>
			");
            WriteLiteral(@"							</td>
										<td>
											<span class=""fw-500 text-success"">string</span>
										</td>
										<td>
											Increases/decreases current scroll value by specified amount (positive or negative). Can be called on any element with slimScroll already enabled. Example: $(element).slimScroll({ scrollBy: '60px' });
										</td>
									</tr>
									<tr>
										<td>
											<code>disableFadeOut</code>
										</td>
										<td>
											<span class=""fw-500 text-info"">bool</span>
										</td>
										<td>
											Disables scrollbar auto fade. When set to true scrollbar doesn't disappear after some time when mouse is over the slimscroll div.Default: false
										</td>
									</tr>
									<tr>
										<td>
											<code>touchScrollStep</code>
										</td>
										<td>
											<span class=""fw-500 text-info"">integer</span>
										</td>
										<td>
											Allows to set different sensitivity for touch scroll events. Negative number inverts scroll di");
            WriteLiteral(@"rection.Default: 200
										</td>
									</tr>
								</tbody>
							</table>
						</div>
					</div>
					<h5 class=""frame-heading"">Initialize manually </h5>
					 <div class=""frame-wrap"">
						<pre class=""prettyprint"">
$('#slimscroll').slimScroll({
	position: 'left',
	height: '300px',
	railVisible: true,
	alwaysVisible: true
}); </pre>          </div>
					<h5 class=""frame-heading"">Initliza with data attributes </h5>
					 <div class=""frame-wrap"">
						<pre class=""prettyprint"">
&lt;div id=""slimscroll"" class=""custom-scroll"" style=""height:300px"" 
        data-scrollHeight=""300"" 
        data-scrollSize=""4px"" 
        data-scrollPosition=""right"" 
        data-scrollColor=""rgba(0,0,0,0.6)"" 
        data-alwaysVisible=""false"" 
        data-distance=""4px"" 
        data-railVisible=""false"" 
        data-railColor=""#fafafa"" &gt;
  &lt;div class=""p-3""&gt;
    ...
    content...
    ...
  &lt;/div&gt;
&lt;/div&gt;
</pre>          	</div>
					<h5 class=""frame-heading"">Destroy </h5>
					 <div class=""frame-w");
            WriteLiteral("rap\">\n\t\t\t\t\t\t<pre class=\"prettyprint\">\n$(\'#slimscroll\').slimScroll({ destroy: true });\n$(\'#slimscroll\').attr(\'style\', \'\');</pre>          \n\t    \t\t\t</div>\n\t\t\t\t</div>\n\t\t\t</div>\n\t\t</div>\n\t</div>\n</div>\n");
            DefineSection("ScriptsBlock", async() => {
                WriteLiteral(@"
	<script src=""https://cdn.rawgit.com/google/code-prettify/master/loader/run_prettify.js""></script>
	<script>
		$(document).ready(function () {
			$('#slimtest3').slimScroll({
				color: color.primary._700,
				size: '20px',
				height: '300px',
				alwaysVisible: true
			});
			$('#slimtest2').slimScroll({
				position: 'left',
				height: '300px',
				railVisible: true,
				alwaysVisible: true
			});
		});
	</script>
");
            }
            );
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
