#pragma checksum "C:\Users\marda\Desktop\Code\asp.net\Layout-ViewStart-ViewImport-Models-ViewModels-FrontToBack\Layout-FrontToBack\Layout-FrontToBack\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da5f1c9a46292274a934c0aef33afd7016140518"
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
#line 1 "C:\Users\marda\Desktop\Code\asp.net\Layout-ViewStart-ViewImport-Models-ViewModels-FrontToBack\Layout-FrontToBack\Layout-FrontToBack\Views\_ViewImports.cshtml"
using Layout_FrontToBack;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\marda\Desktop\Code\asp.net\Layout-ViewStart-ViewImport-Models-ViewModels-FrontToBack\Layout-FrontToBack\Layout-FrontToBack\Views\_ViewImports.cshtml"
using Layout_FrontToBack.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da5f1c9a46292274a934c0aef33afd7016140518", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"419740b5eaa28e110fa5afce5a558bc40a8ea469", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
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
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da5f1c9a46292274a934c0aef33afd70161405183566", async() => {
                WriteLiteral(@"
    <title>Purple Buzz HTML Template with Bootstrap 5 Beta 1</title>
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""apple-touch-icon"" href=""assets/img/apple-icon.png"">
    <link rel=""shortcut icon"" type=""image/x-icon"" href=""assets/img/favicon.ico"">
    <!-- Load Require CSS -->
    <link href=""assets/css/bootstrap.min.css"" rel=""stylesheet"">
    <!-- Font CSS -->
    <link href=""assets/css/boxicon.min.css"" rel=""stylesheet"">
    <link href=""https://fonts.googleapis.com/css2?family=Open+Sans:wght@300;400;600&display=swap"" rel=""stylesheet"">
    <!-- Load Tempalte CSS -->
    <link rel=""stylesheet"" href=""assets/css/templatemo.css"">
    <!-- Custom CSS -->
    <link rel=""stylesheet"" href=""assets/css/custom.css"">
<!--
    
TemplateMo 561 Purple Buzz

https://templatemo.com/tm-561-purple-buzz

-->
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da5f1c9a46292274a934c0aef33afd70161405185461", async() => {
                WriteLiteral(@"
    <!-- Header -->
    <nav id=""main_nav"" class=""navbar navbar-expand-lg navbar-light bg-white shadow"">
        <div class=""container d-flex justify-content-between align-items-center"">
            <a class=""navbar-brand h1"" href=""index.html"">
                <i class='bx bx-buildings bx-sm text-dark'></i>
                <span class=""text-dark h4"">Purple</span> <span class=""text-primary h4"">Buzz</span>
            </a>
            <button class=""navbar-toggler border-0"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbar-toggler-success"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>

            <div class=""align-self-center collapse navbar-collapse flex-fill  d-lg-flex justify-content-lg-between"" id=""navbar-toggler-success"">
                <div class=""flex-fill mx-xl-5 mb-2"">
                    <ul class=""nav navbar-nav d-flex justify-content-between mx");
                WriteLiteral(@"-xl-5 text-center text-dark"">
                        <li class=""nav-item"">
                            <a class=""nav-link btn-outline-primary rounded-pill px-3"" href=""index.html"">Home</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link btn-outline-primary rounded-pill px-3"" href=""about.html"">About</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link btn-outline-primary rounded-pill px-3"" href=""work.html"">Work</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link btn-outline-primary rounded-pill px-3"" href=""pricing.html"">Pricing</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link btn-outline-primary rounded-pill px-3"" href=""contact.html"">Contact</a>
                        </li>
                    </u");
                WriteLiteral(@"l>
                </div>
                <div class=""navbar align-self-center d-flex"">
                    <a class=""nav-link"" href=""#""><i class='bx bx-bell bx-sm bx-tada-hover text-primary'></i></a>
                    <a class=""nav-link"" href=""#""><i class='bx bx-cog bx-sm text-primary'></i></a>
                    <a class=""nav-link"" href=""#""><i class='bx bx-user-circle bx-sm text-primary'></i></a>
                </div>
            </div>
        </div>
    </nav>
    <!-- Close Header -->
            ");
#nullable restore
#line 69 "C:\Users\marda\Desktop\Code\asp.net\Layout-ViewStart-ViewImport-Models-ViewModels-FrontToBack\Layout-FrontToBack\Layout-FrontToBack\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
       
   
    <!-- Start Footer -->
    <footer class=""bg-secondary pt-4"">
        <div class=""container"">
            <div class=""row py-4"">

                <div class=""col-lg-3 col-12 align-left"">
                    <a class=""navbar-brand"" href=""index.html"">
                        <i class='bx bx-buildings bx-sm text-light'></i>
                        <span class=""text-light h5"">Purple</span> <span class=""text-light h5 semi-bold-600"">Buzz</span>
                    </a>
                    <p class=""text-light my-lg-4 my-2"">
                        Lorem ipsum dolor sit amet, consectetur adipisicing elit,
                        sed do eiusmod tempor incididunt ut.
                    </p>
                    <ul class=""list-inline footer-icons light-300"">
                        <li class=""list-inline-item m-0"">
                            <a class=""text-light"" target=""_blank"" href=""http://facebook.com/"">
                                <i class='bx bxl-facebook-square bx-md'></i");
                WriteLiteral(@">
                            </a>
                        </li>
                        <li class=""list-inline-item m-0"">
                            <a class=""text-light"" target=""_blank"" href=""https://www.linkedin.com/"">
                                <i class='bx bxl-linkedin-square bx-md'></i>
                            </a>
                        </li>
                        <li class=""list-inline-item m-0"">
                            <a class=""text-light"" target=""_blank"" href=""https://www.whatsapp.com/"">
                                <i class='bx bxl-whatsapp-square bx-md'></i>
                            </a>
                        </li>
                        <li class=""list-inline-item m-0"">
                            <a class=""text-light"" target=""_blank"" href=""https://www.flickr.com/"">
                                <i class='bx bxl-flickr-square bx-md'></i>
                            </a>
                        </li>
                        <li class=""list-inline-item");
                WriteLiteral(@" m-0"">
                            <a class=""text-light"" target=""_blank"" href=""https://www.medium.com/"">
                                <i class='bx bxl-medium-square bx-md' ></i>
                            </a>
                        </li>
                    </ul>
                </div>

                <div class=""col-lg-3 col-md-4 my-sm-0 mt-4"">
                    <h3 class=""h4 pb-lg-3 text-light light-300"">Our Company</h2>
                        <ul class=""list-unstyled text-light light-300"">
                            <li class=""pb-2"">
                                <i class='bx-fw bx bxs-chevron-right bx-xs'></i><a class=""text-decoration-none text-light"" href=""index.html"">Home</a>
                            </li>
                            <li class=""pb-2"">
                                <i class='bx-fw bx bxs-chevron-right bx-xs'></i><a class=""text-decoration-none text-light py-1"" href=""about.html"">About Us</a>
                            </li>
                            <l");
                WriteLiteral(@"i class=""pb-2"">
                                <i class='bx-fw bx bxs-chevron-right bx-xs'></i><a class=""text-decoration-none text-light py-1"" href=""work.html"">Work</a>
                            </li>
                            <li class=""pb-2"">
                                <i class='bx-fw bx bxs-chevron-right bx-xs'></i></i><a class=""text-decoration-none text-light py-1"" href=""pricing.html"">Price</a>
                            </li>
                            <li class=""pb-2"">
                                <i class='bx-fw bx bxs-chevron-right bx-xs'></i><a class=""text-decoration-none text-light py-1"" href=""contact.html"">Contact</a>
                            </li>
                        </ul>
                </div>

                <div class=""col-lg-3 col-md-4 my-sm-0 mt-4"">
                    <h2 class=""h4 pb-lg-3 text-light light-300"">Our Works</h2>
                    <ul class=""list-unstyled text-light light-300"">
                        <li class=""pb-2"">
                  ");
                WriteLiteral(@"          <i class='bx-fw bx bxs-chevron-right bx-xs'></i><a class=""text-decoration-none text-light py-1"" href=""#"">Branding</a>
                        </li>
                        <li class=""pb-2"">
                            <i class='bx-fw bx bxs-chevron-right bx-xs'></i><a class=""text-decoration-none text-light py-1"" href=""#"">Business</a>
                        </li>
                        <li class=""pb-2"">
                            <i class='bx-fw bx bxs-chevron-right bx-xs'></i><a class=""text-decoration-none text-light py-1"" href=""#"">Marketing</a>
                        </li>
                        <li class=""pb-2"">
                            <i class='bx-fw bx bxs-chevron-right bx-xs'></i><a class=""text-decoration-none text-light py-1"" href=""#"">Social Media</a>
                        </li>
                        <li class=""pb-2"">
                            <i class='bx-fw bx bxs-chevron-right bx-xs'></i><a class=""text-decoration-none text-light py-1"" href=""#"">Digital Solution</a>");
                WriteLiteral(@"
                        </li>
                        <li class=""pb-2"">
                            <i class='bx-fw bx bxs-chevron-right bx-xs'></i><a class=""text-decoration-none text-light py-1"" href=""#"">Graphic</a>
                        </li>
                    </ul>
                </div>

                <div class=""col-lg-3 col-md-4 my-sm-0 mt-4"">
                    <h2 class=""h4 pb-lg-3 text-light light-300"">For Client</h2>
                    <ul class=""list-unstyled text-light light-300"">
                        <li class=""pb-2"">
                            <i class='bx-fw bx bx-phone bx-xs'></i><a class=""text-decoration-none text-light py-1"" href=""tel:010-020-0340"">010-020-0340</a>
                        </li>
                        <li class=""pb-2"">
                            <i class='bx-fw bx bx-mail-send bx-xs'></i><a class=""text-decoration-none text-light py-1"" href=""mailto:info@company.com"">info@company.com</a>
                        </li>
                    </ul>
  ");
                WriteLiteral(@"              </div>

            </div>
        </div>

        <div class=""w-100 bg-primary py-3"">
            <div class=""container"">
                <div class=""row pt-2"">
                    <div class=""col-lg-6 col-sm-12"">
                        <p class=""text-lg-start text-center text-light light-300"">
                            ?? Copyright 2021 Purple Buzz Company. All Rights Reserved.
                        </p>
                    </div>
                    <div class=""col-lg-6 col-sm-12"">
                        <p class=""text-lg-end text-center text-light light-300"">
                            Designed by <a rel=""sponsored"" class=""text-decoration-none text-light"" href=""https://templatemo.com/"" target=""_blank""><strong>TemplateMo</strong></a>
                        </p>
                    </div>
                </div>
            </div>
        </div>

    </footer>
    <!-- End Footer -->


    <!-- Bootstrap -->
    <script src=""assets/js/bootstrap.bundle.min.js""><");
                WriteLiteral(@"/script>
    <!-- Load jQuery require for isotope -->
    <script src=""assets/js/jquery.min.js""></script>
    <!-- Isotope -->
    <script src=""assets/js/isotope.pkgd.js""></script>
    <!-- Page Script -->
    <script>
        $(window).load(function() {
            // init Isotope
            var $projects = $('.projects').isotope({
                itemSelector: '.project',
                layoutMode: 'fitRows'
            });
            $("".filter-btn"").click(function() {
                var data_filter = $(this).attr(""data-filter"");
                $projects.isotope({
                    filter: data_filter
                });
                $("".filter-btn"").removeClass(""active"");
                $("".filter-btn"").removeClass(""shadow"");
                $(this).addClass(""active"");
                $(this).addClass(""shadow"");
                return false;
            });
        });
    </script>
    <!-- Templatemo -->
    <script src=""assets/js/templatemo.js""></script>
    <!-- ");
                WriteLiteral("Custom -->\r\n    <script src=\"assets/js/custom.js\"></script>\r\n\r\n");
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
            WriteLiteral("\r\n\r\n</html>");
        }
        #pragma warning restore 1998
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
