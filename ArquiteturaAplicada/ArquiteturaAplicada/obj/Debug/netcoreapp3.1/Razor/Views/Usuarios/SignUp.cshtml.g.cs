#pragma checksum "C:\Users\User\source\repos\ArquiteturaAplicada\ArquiteturaAplicada\Views\Usuarios\SignUp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "473eb219ffdee862492c754fd294f7d73f95a3c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_SignUp), @"mvc.1.0.view", @"/Views/Usuarios/SignUp.cshtml")]
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
#line 1 "C:\Users\User\source\repos\ArquiteturaAplicada\ArquiteturaAplicada\Views\_ViewImports.cshtml"
using ArquiteturaAplicada;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\ArquiteturaAplicada\ArquiteturaAplicada\Views\_ViewImports.cshtml"
using ArquiteturaAplicada.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"473eb219ffdee862492c754fd294f7d73f95a3c2", @"/Views/Usuarios/SignUp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4277bcfb2c4c1d3e6d9e18b848b153324c70ba28", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_SignUp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mx-1 mx-md-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\User\source\repos\ArquiteturaAplicada\ArquiteturaAplicada\Views\Usuarios\SignUp.cshtml"
  
    ViewData["Title"] = "Registrar Usuários";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 4 "C:\Users\User\source\repos\ArquiteturaAplicada\ArquiteturaAplicada\Views\Usuarios\SignUp.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<section class=""vh-100"" style=""background-color: #eee;"">
  <div class=""container h-100"">
    <div class=""row d-flex justify-content-center align-items-center h-100"">
      <div class=""col-lg-12 col-xl-11"">
        <div class=""card text-black"" style=""border-radius: 25px;"">
          <div class=""card-body p-md-5"">
            <div class=""row justify-content-center"">
              <div class=""col-md-10 col-lg-6 col-xl-5 order-2 order-lg-1"">

                <p class=""text-center h1 fw-bold mb-5 mx-1 mx-md-4 mt-4"">Sign up</p>

                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "473eb219ffdee862492c754fd294f7d73f95a3c25786", async() => {
                WriteLiteral(@"

                  <div class=""d-flex flex-row align-items-center mb-4"">
                    <i class=""fas fa-user fa-lg me-3 fa-fw""></i>
                    <div class=""form-outline flex-fill mb-0"">
                      <input type=""text"" id=""form3Example1c"" class=""form-control"" />
                      <label class=""form-label"" for=""form3Example1c"">Your Name</label>
                    </div>
                  </div>

                  <div class=""d-flex flex-row align-items-center mb-4"">
                    <i class=""fas fa-envelope fa-lg me-3 fa-fw""></i>
                    <div class=""form-outline flex-fill mb-0"">
                      <input type=""email"" id=""form3Example3c"" class=""form-control"" />
                      <label class=""form-label"" for=""form3Example3c"">Your Email</label>
                    </div>
                  </div>

                  <div class=""d-flex flex-row align-items-center mb-4"">
                    <i class=""fas fa-lock fa-lg me-3 fa-fw""></i>
           ");
                WriteLiteral(@"         <div class=""form-outline flex-fill mb-0"">
                      <input type=""password"" id=""form3Example4c"" class=""form-control"" />
                      <label class=""form-label"" for=""form3Example4c"">Password</label>
                    </div>
                  </div>

                  <div class=""d-flex flex-row align-items-center mb-4"">
                    <i class=""fas fa-key fa-lg me-3 fa-fw""></i>
                    <div class=""form-outline flex-fill mb-0"">
                      <input type=""password"" id=""form3Example4cd"" class=""form-control"" />
                      <label class=""form-label"" for=""form3Example4cd"">Repeat your password</label>
                    </div>
                  </div>

                  <div class=""form-check d-flex justify-content-center mb-5"">
                    
            
                  </div>

                  <div class=""d-flex justify-content-center mx-4 mb-3 mb-lg-4"">
                    <button type=""button"" class=""btn btn-primary bt");
                WriteLiteral("n-lg\">Register</button>\r\n                  </div>\r\n                  ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "473eb219ffdee862492c754fd294f7d73f95a3c28305", async() => {
                    WriteLiteral("Voltar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

              </div>
              <div class=""col-md-10 col-lg-6 col-xl-7 d-flex align-items-center order-1 order-lg-2"">

                <img src=""https://mdbcdn.b-cdn.net/img/Photos/new-templates/bootstrap-registration/draw1.webp"" class=""img-fluid"" alt=""Sample image"">

              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591