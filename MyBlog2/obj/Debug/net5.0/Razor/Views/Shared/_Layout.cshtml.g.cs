#pragma checksum "C:\Users\USER\Desktop\Blog2\MyBlog2\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecdc390ea94cdf4401d5d54ef20870caca808ec2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\USER\Desktop\Blog2\MyBlog2\Views\_ViewImports.cshtml"
using MyBlog2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\Desktop\Blog2\MyBlog2\Views\_ViewImports.cshtml"
using MyBlog2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecdc390ea94cdf4401d5d54ef20870caca808ec2", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c76c2dd744884a480aecf9de8b1f4ae796aa3ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecdc390ea94cdf4401d5d54ef20870caca808ec23206", async() => {
                WriteLiteral("\r\n      <meta charset=\"utf-8\" />\r\n        <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\" />\r\n        <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 205, "\"", 215, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 248, "\"", 258, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
        <title>Clean Blog - Start Bootstrap Theme</title>
        <link rel=""icon"" type=""image/x-icon"" href=""assets/favicon.ico"" />
        <!-- Font Awesome icons (free version)-->
        <script src=""https://use.fontawesome.com/releases/v5.15.4/js/all.js"" crossorigin=""anonymous""></script>
        <!-- Google fonts-->
        <link href=""https://fonts.googleapis.com/css?family=Lora:400,700,400italic,700italic"" rel=""stylesheet"" type=""text/css"" />
        <link href=""https://fonts.googleapis.com/css?family=Open+Sans:300italic,400italic,600italic,700italic,800italic,400,300,600,700,800"" rel=""stylesheet"" type=""text/css"" />
        <!-- Core theme CSS (includes Bootstrap)-->
        <link href=""css/styles.css"" rel=""stylesheet"" />
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecdc390ea94cdf4401d5d54ef20870caca808ec25472", async() => {
                WriteLiteral(@"
    
        <!-- Navigation-->
        <nav class=""navbar navbar-expand-lg navbar-light"" id=""mainNav"">
            <div class=""container px-4 px-lg-5"">
                <a class=""navbar-brand"" href=""/Home/Index"">ADEM DEMİRKIRAN</a>
                <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarResponsive"" aria-controls=""navbarResponsive"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                    Menu
                    <i class=""fas fa-bars""></i>
                </button>
                <div class=""collapse navbar-collapse"" id=""navbarResponsive"">
                    <ul class=""navbar-nav ms-auto py-4 py-lg-0"">
                        <li class=""nav-item""><a class=""nav-link px-lg-3 py-3 py-lg-4"" href=""/Home/Index"">Home</a></li>
                        <li class=""nav-item""><a class=""nav-link px-lg-3 py-3 py-lg-4"" href=""/Home/About"">About</a></li>
                        <li class=""nav-item""><a class=""nav-link px-lg-3 py-3 py-lg-4"" hr");
                WriteLiteral("ef=\"/Home/Contact\">Contact</a></li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n        </nav>\r\n      \r\n   \r\n            ");
#nullable restore
#line 39 "C:\Users\USER\Desktop\Blog2\MyBlog2\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    

    <!-- Footer-->
        <footer class=""border-top"">
            <div class=""container px-4 px-lg-5"">
                <div class=""row gx-4 gx-lg-5 justify-content-center"">
                    <div class=""col-md-10 col-lg-8 col-xl-7"">
                        <ul class=""list-inline text-center"">
                            <li class=""list-inline-item"">
                                <a href=""#!"">
                                    <span class=""fa-stack fa-lg"">
                                        <i class=""fas fa-circle fa-stack-2x""></i>
                                        <i class=""fab fa-twitter fa-stack-1x fa-inverse""></i>
                                    </span>
                                </a>
                            </li>
                            <li class=""list-inline-item"">
                                <a href=""#!"">
                                    <span class=""fa-stack fa-lg"">
                                        <i class=""fas fa-circle fa-st");
                WriteLiteral(@"ack-2x""></i>
                                        <i class=""fab fa-facebook-f fa-stack-1x fa-inverse""></i>
                                    </span>
                                </a>
                            </li>
                            <li class=""list-inline-item"">
                                <a href=""#!"">
                                    <span class=""fa-stack fa-lg"">
                                        <i class=""fas fa-circle fa-stack-2x""></i>
                                        <i class=""fab fa-github fa-stack-1x fa-inverse""></i>
                                    </span>
                                </a>
                            </li>
                        </ul>
                        <div class=""small text-center text-muted fst-italic"">Copyright &copy; Your Website 2021</div>
                    </div>
                </div>
            </div>
        </footer>

    <!-- Bootstrap core JS-->
        <script src=""https://cdn.jsdelivr.net/npm/bo");
                WriteLiteral("otstrap@5.1.3/dist/js/bootstrap.bundle.min.js\"></script>\r\n        <!-- Core theme JS-->\r\n        <script src=\"js/scripts.js\"></script>\r\n    ");
#nullable restore
#line 83 "C:\Users\USER\Desktop\Blog2\MyBlog2\Views\Shared\_Layout.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
