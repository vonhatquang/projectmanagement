#pragma checksum "C:\Users\nhatq\OneDrive\Documents\TPP\aw\WebApp\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc000184f9d1e44ab656e905cfe0ea34f1b13df2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Login.cshtml", typeof(AspNetCore.Views_Account_Login))]
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
#line 1 "C:\Users\nhatq\OneDrive\Documents\TPP\aw\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#line 1 "C:\Users\nhatq\OneDrive\Documents\TPP\aw\WebApp\Views\Account\Login.cshtml"
using WebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc000184f9d1e44ab656e905cfe0ea34f1b13df2", @"/Views/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45a7c4825f1d7ea148b1094c1e6f044f3bc042fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginUserModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("input100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Enter username"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Enter password"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("login100-form validate-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\nhatq\OneDrive\Documents\TPP\aw\WebApp\Views\Account\Login.cshtml"
  
    ViewData["Title"] = "Login Page View";
	string action = ViewContext.RouteData.Values["action"].ToString().ToLower();

#line default
#line hidden
            BeginContext(176, 99, true);
            WriteLiteral("\r\n<!--<div><form asp-controller=\"Account\" asp-action=\"UserLogin\" method=\"post\" asp-route-returnurl=");
            EndContext();
            BeginContext(276, 17, false);
#line 8 "C:\Users\nhatq\OneDrive\Documents\TPP\aw\WebApp\Views\Account\Login.cshtml"
                                                                                            Write(ViewBag.ReturnUrl);

#line default
#line hidden
            EndContext();
            BeginContext(293, 871, true);
            WriteLiteral(@">
    User Name:  <input asp-for=""UserName"" /> <br />
    Password: <input asp-for=""Password"" /><br />
    <button type=""submit"">Login</button>
</form>
</div>-->
<!--<div class=""container"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""pr-wrap"">
                <div class=""pass-reset"">
                    <label>
                        Enter the email you signed up with</label>
                    <input type=""email"" placeholder=""Email"" />
                    <input type=""submit"" value=""Submit"" class=""pass-reset-submit btn btn-success btn-sm"" />
                </div>
            </div>
            <div class=""wrap"">
                <p class=""form-title"">
                    Sign In</p>                
				<form class=""login"" asp-controller=""Account"" asp-action=""UserLogin"" method=""post"" asp-route-returnurl=");
            EndContext();
            BeginContext(1165, 17, false);
#line 28 "C:\Users\nhatq\OneDrive\Documents\TPP\aw\WebApp\Views\Account\Login.cshtml"
                                                                                                                 Write(ViewBag.ReturnUrl);

#line default
#line hidden
            EndContext();
            BeginContext(1182, 1333, true);
            WriteLiteral(@">                
				<input asp-for=""UserName"" placeholder=""UserName""  />
				<input asp-for=""Password"" placeholder=""Password"" />
                <input type=""submit"" value=""Sign In"" class=""btn btn-success btn-sm"" />
                <div class=""remember-forgot"">
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""checkbox"">
                                <label>
                                    <input type=""checkbox"" />
                                    Remember Me
                                </label>
                            </div>
                        </div>
                        <div class=""col-md-6 forgot-pass-content"">
                            <a href=""javascription:void(0)"" class=""forgot-pass"">Forgot Password</a>
                        </div>
                    </div>
                </div>
                </form>
            </div>
        </div>
    </div>
</div>-->
<div class=""limi");
            WriteLiteral(@"ter"">
		<div class=""container-login100"">
			<div class=""wrap-login100"">
				<div class=""login100-form-title"" style=""background-image: url(/images/bg-01.jpg);"">
					<span class=""login100-form-title-1"">
						Sign In
					</span>
				</div>

				<!--<form class=""login100-form validate-form"">-->
				");
            EndContext();
            BeginContext(2515, 1500, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc000184f9d1e44ab656e905cfe0ea34f1b13df29377", async() => {
                BeginContext(2658, 129, true);
                WriteLiteral("\r\n\t\t\t\t\t<div class=\"wrap-input100 validate-input m-b-26\" data-validate=\"Username is required\">\r\n\t\t\t\t\t\t<span class=\"label-input100\"");
                EndContext();
                BeginWriteAttribute("resource", " resource=\"", 2787, "\"", 2817, 2);
                WriteAttributeValue("", 2798, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                    PushWriter(__razor_attribute_value_writer);
                                                                                     
                    BeginContext(2801, 6, false);
#line 64 "C:\Users\nhatq\OneDrive\Documents\TPP\aw\WebApp\Views\Account\Login.cshtml"
                                                            Write(action);

#line default
#line hidden
                    EndContext();
                                                                                            
                    PopWriter();
                }
                ), 2798, 10, false);
                WriteAttributeValue("", 2808, "_username", 2808, 9, true);
                EndWriteAttribute();
                BeginContext(2818, 120, true);
                WriteLiteral(">Username</span>\r\n\t\t\t\t\t\t<!--<input class=\"input100\" type=\"text\" name=\"username\" placeholder=\"Enter username\">-->\r\n\t\t\t\t\t\t");
                EndContext();
                BeginContext(2938, 74, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dc000184f9d1e44ab656e905cfe0ea34f1b13df211122", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 66 "C:\Users\nhatq\OneDrive\Documents\TPP\aw\WebApp\Views\Account\Login.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserName);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3012, 310, true);
                WriteLiteral(@"
						<span class=""focus-input100""></span>
					</div>

					<div class=""wrap-input100 validate-input m-b-18"" data-validate = ""Password is required"">
						<span class=""label-input100"">Password</span>
						<!--<input class=""input100"" type=""password"" name=""pass"" placeholder=""Enter password"">-->
						");
                EndContext();
                BeginContext(3322, 74, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dc000184f9d1e44ab656e905cfe0ea34f1b13df213222", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 73 "C:\Users\nhatq\OneDrive\Documents\TPP\aw\WebApp\Views\Account\Login.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Password);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3396, 612, true);
                WriteLiteral(@"
						<span class=""focus-input100""></span>
					</div>

					<div class=""flex-sb-m w-full p-b-30"">
						<div class=""contact100-form-checkbox"">
							<input class=""input-checkbox100"" id=""ckb1"" type=""checkbox"" name=""remember-me"">
							<label class=""label-checkbox100"" for=""ckb1"">
								Remember me
							</label>
						</div>

						<div>
							<a href=""#"" class=""txt1"">
								Forgot Password?
							</a>
						</div>
					</div>

					<div class=""container-login100-form-btn"">
						<button class=""login100-form-btn"" type=""submit"">
							Login
						</button>
					</div>
				");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnurl", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 62 "C:\Users\nhatq\OneDrive\Documents\TPP\aw\WebApp\Views\Account\Login.cshtml"
                                                                                                                                WriteLiteral(ViewBag.ReturnUrl);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnurl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnurl", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnurl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4015, 32, true);
            WriteLiteral("\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginUserModel> Html { get; private set; }
    }
}
#pragma warning restore 1591