#pragma checksum "C:\Users\Genceli\Desktop\Academy-Backend\Academy-Backend\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13bfa1e625e9d3dfa504ee5e547893ba5cc85f58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Genceli\Desktop\Academy-Backend\Academy-Backend\Views\_ViewImports.cshtml"
using Academy_Backend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Genceli\Desktop\Academy-Backend\Academy-Backend\Views\_ViewImports.cshtml"
using Academy_Backend.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Genceli\Desktop\Academy-Backend\Academy-Backend\Views\_ViewImports.cshtml"
using Academy_Backend.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13bfa1e625e9d3dfa504ee5e547893ba5cc85f58", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec5765cad3dcede307ad4e36989542762fac71f8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("subscribe-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Genceli\Desktop\Academy-Backend\Academy-Backend\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"hero-wrap\"");
            BeginWriteAttribute("style", " style=\"", 97, "\"", 163, 3);
            WriteAttributeValue("", 105, "background-image:url(../images/", 105, 31, true);
#nullable restore
#line 7 "C:\Users\Genceli\Desktop\Academy-Backend\Academy-Backend\Views\Home\Index.cshtml"
WriteAttributeValue("", 136, Model.Heros.First().Image, 136, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 162, ")", 162, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
    <div class=""overlay""></div>
    <div class=""container"">
        <div class=""row no-gutters slider-text align-items-center"">
            <div class=""col-lg-5"">
                <div class=""text mt-5 pt-5"" data-aos=""fade-up"" data-aos-delay=""300"" data-aos-duration=""1000"">
                    <span class=""subheading"">Welcome to Academia</span>
                    <h1 class=""mb-4"">");
#nullable restore
#line 14 "C:\Users\Genceli\Desktop\Academy-Backend\Academy-Backend\Views\Home\Index.cshtml"
                                Write(Model.Heros.First().Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n                    <p class=\"mb-4\">");
#nullable restore
#line 15 "C:\Users\Genceli\Desktop\Academy-Backend\Academy-Backend\Views\Home\Index.cshtml"
                               Write(Model.Heros.First().Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><a");
            BeginWriteAttribute("href", " href=\"", 681, "\"", 720, 1);
#nullable restore
#line 16 "C:\Users\Genceli\Desktop\Academy-Backend\Academy-Backend\Views\Home\Index.cshtml"
WriteAttributeValue("", 688, Model.Heros.First().RedirectUrl, 688, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary p-4 py-3\">Get Started Now! <span class=\"ion-ios-arrow-round-forward\"></span></a> <a");
            BeginWriteAttribute("href", " href=\"", 828, "\"", 873, 1);
#nullable restore
#line 16 "C:\Users\Genceli\Desktop\Academy-Backend\Academy-Backend\Views\Home\Index.cshtml"
WriteAttributeValue("", 835, Model.Heros.First().RedirectUrlSecond, 835, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-white p-4 py-3"">View Course <span class=""ion-ios-arrow-round-forward""></span></a></p>
                </div>
            </div>
        </div>
    </div>
</section>
<section class=""ftco-section ftco-no-pt ftco-no-pb"">
    <div class=""container-xl"">
        <div class=""row g-xl-5"">
            <div class=""col-md-6 d-flex align-items-stretch"" data-aos=""fade-up"" data-aos-delay=""100"" data-aos-duration=""1000"">
                <div class=""img w-100""");
            BeginWriteAttribute("style", " style=\"", 1347, "\"", 1415, 3);
            WriteAttributeValue("", 1355, "background-image:url(../images/", 1355, 31, true);
#nullable restore
#line 26 "C:\Users\Genceli\Desktop\Academy-Backend\Academy-Backend\Views\Home\Index.cshtml"
WriteAttributeValue("", 1386, Model.Benefit.First().Image, 1386, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1414, ")", 1414, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>
            </div>
            <div class=""col-md-6 heading-section d-flex align-items-center"" data-aos=""fade-up"" data-aos-delay=""200"" data-aos-duration=""1000"">
                <div class=""mt-0 my-lg-5 py-5"">
                    <span class=""subheading"">Learn Anything</span>
                    <h2 class=""mb-2"">");
#nullable restore
#line 32 "C:\Users\Genceli\Desktop\Academy-Backend\Academy-Backend\Views\Home\Index.cshtml"
                                Write(Model.Benefit.First().Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <div class=\"row mt-4 g-lg-2\">\r\n\r\n");
#nullable restore
#line 35 "C:\Users\Genceli\Desktop\Academy-Backend\Academy-Backend\Views\Home\Index.cshtml"
                         for (int i = 0; i < Model.BenefitCard.Count; i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-lg-12 d-flex align-items-stretch services-wrap\">\r\n                                <div class=\"services d-flex\">\r\n                                    <div class=\"icon\">");
#nullable restore
#line 39 "C:\Users\Genceli\Desktop\Academy-Backend\Academy-Backend\Views\Home\Index.cshtml"
                                                 Write(Html.Raw(Model.BenefitCard[i].Icon));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                    <div class=\"text\">\r\n                                        <h2>");
#nullable restore
#line 41 "C:\Users\Genceli\Desktop\Academy-Backend\Academy-Backend\Views\Home\Index.cshtml"
                                       Write(Model.BenefitCard[i].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                        <p class=\"mb-0\">");
#nullable restore
#line 42 "C:\Users\Genceli\Desktop\Academy-Backend\Academy-Backend\Views\Home\Index.cshtml"
                                                   Write(Model.BenefitCard[i].Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 46 "C:\Users\Genceli\Desktop\Academy-Backend\Academy-Backend\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<section class=""ftco-section-counter img"" style=""background-image:url(../images/xbg_3.jpg.pagespeed.ic.z_ltqRZXRc.jpg)"">
    <div class=""overlay""></div>
    <div class=""container"">
        <div class=""row section-counter"">

");
#nullable restore
#line 58 "C:\Users\Genceli\Desktop\Academy-Backend\Academy-Backend\Views\Home\Index.cshtml"
             for (int i = 0; i < Model.Counters.Count; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-sm-6 col-md-6 col-lg-3 d-flex align-items-stretch"">
                    <div class=""counter-wrap-2 d-flex"" data-aos=""fade-up"" data-aos-delay=""100"" data-aos-duration=""1000"">
                        <div class=""icon"">
                            ");
#nullable restore
#line 63 "C:\Users\Genceli\Desktop\Academy-Backend\Academy-Backend\Views\Home\Index.cshtml"
                       Write(Html.Raw(Model.Counters[i].Icon));

#line default
#line hidden
#nullable disable
            WriteLiteral("   \r\n                        </div>\r\n                        <div class=\"text\">\r\n                            <h2 class=\"number\"><span class=\"countup\">");
#nullable restore
#line 66 "C:\Users\Genceli\Desktop\Academy-Backend\Academy-Backend\Views\Home\Index.cshtml"
                                                                Write(Model.Counters[i].CountDigit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h2>\r\n                            <span class=\"caption\">");
#nullable restore
#line 67 "C:\Users\Genceli\Desktop\Academy-Backend\Academy-Backend\Views\Home\Index.cshtml"
                                             Write(Model.Counters[i].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 71 "C:\Users\Genceli\Desktop\Academy-Backend\Academy-Backend\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</section>
<section class=""ftco-section courses-section ftco-no-pb"">
    <div class=""container"">
        <div class=""row justify-content-center pb-4"">
            <div class=""col-md-10 text-center heading-section"" data-aos=""fade-up"">
                <span class=""subheading"">Our Courses</span>
                <h2 class=""mb-5"">Explore Our Popular Online Courses</h2>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-12"" data-aos=""fade-up"" data-aos-delay=""100"" data-aos-duration=""1000"">
                <div class=""carousel-courses"">

");
#nullable restore
#line 87 "C:\Users\Genceli\Desktop\Academy-Backend\Academy-Backend\Views\Home\Index.cshtml"
                     for (int i = 0; i < Model.Cource.Count; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"item\">\r\n                            <div class=\"courses\">\r\n                                <div class=\"d-flex\">\r\n                                    <div class=\"icon\">");
#nullable restore
#line 92 "C:\Users\Genceli\Desktop\Academy-Backend\Academy-Backend\Views\Home\Index.cshtml"
                                                 Write(Html.Raw(Model.Cource[i].Logo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                    <div class=\"text\">\r\n                                        <h2>");
#nullable restore
#line 94 "C:\Users\Genceli\Desktop\Academy-Backend\Academy-Backend\Views\Home\Index.cshtml"
                                       Write(Model.Cource[i].Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                        <p class=\"rate\">\r\n\r\n                                            ");
#nullable restore
#line 97 "C:\Users\Genceli\Desktop\Academy-Backend\Academy-Backend\Views\Home\Index.cshtml"
                                       Write(Html.Raw(Model.Cource[i].Stars));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                             
                                            
                                        </p>
                                        <div class=""author-wrap d-flex align-items-center"">
                                            <div class=""img""");
            BeginWriteAttribute("style", " style=\"", 5186, "\"", 5246, 3);
            WriteAttributeValue("", 5194, "background-image:url(../images/", 5194, 31, true);
#nullable restore
#line 102 "C:\Users\Genceli\Desktop\Academy-Backend\Academy-Backend\Views\Home\Index.cshtml"
WriteAttributeValue("", 5225, Model.Cource[i].Img, 5225, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5245, ")", 5245, 1, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                                            <span class=\"author\">");
#nullable restore
#line 103 "C:\Users\Genceli\Desktop\Academy-Backend\Academy-Backend\Views\Home\Index.cshtml"
                                                            Write(Model.Cource[i].Teacher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        </div>\r\n                                        <p class=\"lec\"><a href=\"#\">");
#nullable restore
#line 105 "C:\Users\Genceli\Desktop\Academy-Backend\Academy-Backend\Views\Home\Index.cshtml"
                                                              Write(Model.Cource[i].LectureTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"text-center bg-light rounded py-2 my-3\">\r\n                                    <p class=\"course-price mb-0\">");
#nullable restore
#line 109 "C:\Users\Genceli\Desktop\Academy-Backend\Academy-Backend\Views\Home\Index.cshtml"
                                                            Write(Html.Raw(Model.Cource[i].Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                                <div class=\"text-center\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 5917, "\"", 5952, 1);
#nullable restore
#line 112 "C:\Users\Genceli\Desktop\Academy-Backend\Academy-Backend\Views\Home\Index.cshtml"
WriteAttributeValue("", 5924, Model.Cource[i].RedirectUrl, 5924, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn d-block btn-primary btn-outline-primary py-3\">Enroll Now!</a>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 116 "C:\Users\Genceli\Desktop\Academy-Backend\Academy-Backend\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                </div>
            </div>
        </div>
    </div>
</section>
<section class=""ftco-section"">
    <div class=""container-xl"">
        <div class=""row justify-content-center"">
            <div class=""col-md-8 heading-section text-center mb-5"" data-aos=""fade-up"" data-aos-duration=""1000"">
                <span class=""subheading"">Courses</span>
                <h2 class=""mb-4"">Browse Our Online Courses</h2>
            </div>
        </div>
        <div class=""row g-lg-2 justify-content-center"">

");
#nullable restore
#line 134 "C:\Users\Genceli\Desktop\Academy-Backend\Academy-Backend\Views\Home\Index.cshtml"
             for (int i = 0; i < Model.OnlineCource.Count; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-3 col-xl-2 text-center d-flex align-items-stretch\" data-aos=\"fade-up\" data-aos-delay=\"100\" data-aos-duration=\"1000\">\r\n                    <a href=\"#\" class=\"services-2\">\r\n                        <div class=\"icon\">");
#nullable restore
#line 138 "C:\Users\Genceli\Desktop\Academy-Backend\Academy-Backend\Views\Home\Index.cshtml"
                                     Write(Html.Raw(Model.OnlineCource[i].Logo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"text\">\r\n                            <h2>");
#nullable restore
#line 140 "C:\Users\Genceli\Desktop\Academy-Backend\Academy-Backend\Views\Home\Index.cshtml"
                           Write(Model.OnlineCource[i].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <span>");
#nullable restore
#line 141 "C:\Users\Genceli\Desktop\Academy-Backend\Academy-Backend\Views\Home\Index.cshtml"
                             Write(Model.OnlineCource[i].Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                    </a>\r\n                </div>\r\n");
#nullable restore
#line 145 "C:\Users\Genceli\Desktop\Academy-Backend\Academy-Backend\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</section>
<section class=""ftco-section testimony-section bg-light"">
    <div class=""container-xl"">
        <div class=""row justify-content-center pb-4"">
            <div class=""col-md-7 text-center heading-section"" data-aos=""fade-up"" data-aos-duration=""1000"">
                <span class=""subheading"">Testimonial</span>
                <h2 class=""mb-5"">Our Successful Students</h2>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-12"" data-aos=""fade-up"" data-aos-duration=""1000"" data-aos-delay=""100"">
                <div class=""carousel-testimony"">
                    <div class=""item"">
                        <div class=""testimony-wrap"">
                            <div class=""text"">
                                <div class=""d-flex align-items-center mb-4"">
                                    <div class=""user-img"" style=""background-image:url(../images/xperson_1.jpg.pagespeed.ic.P4pHl6glbj.jpg)"">
                             ");
            WriteLiteral(@"           <div class=""icon d-flex align-items-center justify-content-center""><span class=""fa fa-quote-left""></div>
                                    </div>
                                    <div class=""ps-3 tx"">
                                        <p class=""name"">Roger Scott</p>
                                        <span class=""position"">Marketing Manager</span>
                                    </div>
                                </div>
                                <p class=""mb-4 msg"">Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.</p>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""testimony-wrap"">
                            <div class=""text"">
                                <div class=""d-flex align-items-center mb-4"">
                                    <div class=""user-img"" style=""bac");
            WriteLiteral(@"kground-image:url(../images/xperson_2.jpg.pagespeed.ic.yyrmjBH91b.jpg)"">
                                        <div class=""icon d-flex align-items-center justify-content-center""><span class=""fa fa-quote-left""></div>
                                    </div>
                                    <div class=""ps-3 tx"">
                                        <p class=""name"">Roger Scott</p>
                                        <span class=""position"">Marketing Manager</span>
                                    </div>
                                </div>
                                <p class=""mb-4 msg"">Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.</p>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""testimony-wrap"">
                            <div class=""text"">
                                <div class=");
            WriteLiteral(@"""d-flex align-items-center mb-4"">
                                    <div class=""user-img"" style=""background-image:url(../images/person_3.jpg)"">
                                        <div class=""icon d-flex align-items-center justify-content-center""><span class=""fa fa-quote-left""></div>
                                    </div>
                                    <div class=""ps-3 tx"">
                                        <p class=""name"">Roger Scott</p>
                                        <span class=""position"">Marketing Manager</span>
                                    </div>
                                </div>
                                <p class=""mb-4 msg"">Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.</p>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""testimony-wrap"">
                 ");
            WriteLiteral(@"           <div class=""text"">
                                <div class=""d-flex align-items-center mb-4"">
                                    <div class=""user-img"" style=""background-image:url(../images/xperson_1.jpg.pagespeed.ic.P4pHl6glbj.jpg)"">
                                        <div class=""icon d-flex align-items-center justify-content-center""><span class=""fa fa-quote-left""></div>
                                    </div>
                                    <div class=""ps-3 tx"">
                                        <p class=""name"">Roger Scott</p>
                                        <span class=""position"">Marketing Manager</span>
                                    </div>
                                </div>
                                <p class=""mb-4 msg"">Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.</p>
                            </div>
                        </div>
                    </div>
        ");
            WriteLiteral(@"            <div class=""item"">
                        <div class=""testimony-wrap"">
                            <div class=""text"">
                                <div class=""d-flex align-items-center mb-4"">
                                    <div class=""user-img"" style=""background-image:url(../images/xperson_2.jpg.pagespeed.ic.yyrmjBH91b.jpg)"">
                                        <div class=""icon d-flex align-items-center justify-content-center""><span class=""fa fa-quote-left""></div>
                                    </div>
                                    <div class=""ps-3 tx"">
                                        <p class=""name"">Roger Scott</p>
                                        <span class=""position"">Marketing Manager</span>
                                    </div>
                                </div>
                                <p class=""mb-4 msg"">Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.</p>
 ");
            WriteLiteral(@"                           </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<section class=""ftco-section bg-light ftco-no-pt"">
    <div class=""container-xl"">
        <div class=""row justify-content-center mb-5"">
            <div class=""col-md-7 heading-section text-center"" data-aos=""fade-up"" data-aos-duration=""1000"">
                <span class=""subheading"">Our Blog</span>
                <h2>Recent From Blog</h2>
            </div>
        </div>
        <div class=""row justify-content-center"">
            <div class=""col-md-6 col-lg-4 d-flex"">
                <div class=""blog-entry justify-content-end"" data-aos=""fade-up"" data-aos-duration=""1000"" data-aos-delay=""100"">
                    <a href=""blog-single.html"" class=""block-20 img"" style=""background-image:url(../images/ximage_1.jpg.pagespeed.ic.UgmmPhXrdT.jpg)"">
                    </a>
                    <div class=""text"">
               ");
            WriteLiteral(@"         <p class=""meta""><span><i class=""fa fa-user me-1""></i>Admin</span> <span><i class=""fa fa-calendar me-1""></i>Jan. 18, 2021</span> <span><a href=""#""><i class=""fa fa-comment me-1""></i> 3 Comments</a></span></p>
                        <h3 class=""heading mb-3""><a href=""#"">Build your Dream Software &amp; Engineering Career</a></h3>
                        <p>A small river named Duden flows by their place and supplies it with the necessary regelialia.</p>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 col-lg-4 d-flex"">
                <div class=""blog-entry justify-content-end"" data-aos=""fade-up"" data-aos-duration=""1000"" data-aos-delay=""100"">
                    <a href=""blog-single.html"" class=""block-20 img"" style=""background-image:url(../images/ximage_2.jpg.pagespeed.ic.VzEAApnz9L.jpg)"">
                    </a>
                    <div class=""text"">
                        <p class=""meta""><span><i class=""fa fa-user me-1""></i>Admin</span> <");
            WriteLiteral(@"span><i class=""fa fa-calendar me-1""></i>Jan. 18, 2021</span> <span><a href=""#""><i class=""fa fa-comment me-1""></i> 3 Comments</a></span></p>
                        <h3 class=""heading mb-3""><a href=""#"">Build your Dream Software &amp; Engineering Career</a></h3>
                        <p>A small river named Duden flows by their place and supplies it with the necessary regelialia.</p>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 col-lg-4 d-flex"">
                <div class=""blog-entry justify-content-end"" data-aos=""fade-up"" data-aos-duration=""1000"" data-aos-delay=""100"">
                    <a href=""blog-single.html"" class=""block-20 img"" style=""background-image:url(../images/ximage_3.jpg.pagespeed.ic.uT3vqkYLiY.jpg)"">
                    </a>
                    <div class=""text"">
                        <p class=""meta""><span><i class=""fa fa-user me-1""></i>Admin</span> <span><i class=""fa fa-calendar me-1""></i>Jan. 18, 2021</span> <span><a href=""");
            WriteLiteral(@"#""><i class=""fa fa-comment me-1""></i> 3 Comments</a></span></p>
                        <h3 class=""heading mb-3""><a href=""#"">Build your Dream Software &amp; Engineering Career</a></h3>
                        <p>A small river named Duden flows by their place and supplies it with the necessary regelialia.</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<section class=""ftco-section ftco-no-pt"">
    <div class=""container"">
        <div class=""row justify-content-center pb-5"">
            <div class=""col-md-7 text-center heading-section"" data-aos=""fade-up"" data-aos-duration=""1000"">
                <span class=""subheading"">Our Pricing</span>
                <h2 class=""mb-3"">Pricing &amp; <span>Packages</span></h2>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-6 col-lg-3"" data-aos=""fade-up"" data-aos-duration=""1000"" data-aos-delay=""100"">
                <div class=""block-7"">
                ");
            WriteLiteral(@"    <div class=""text-center"">
                        <span class=""excerpt d-block"">Basic Plan</span>
                        <span class=""price""><sup>$</sup> <span class=""number"">49K</span></span>
                        <div class=""p-4 px-lg-5"">
                            <p>Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.</p>
                        </div>
                        <a href=""#"" class=""btn btn-primary btn-outline-primary d-block px-2 py-3"">Get Started</a>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 col-lg-3"" data-aos=""fade-up"" data-aos-duration=""1000"" data-aos-delay=""200"">
                <div class=""block-7"">
                    <div class=""text-center"">
                        <span class=""excerpt d-block"">Beginner Plan</span>
                        <span class=""price""><sup>$</sup> <span class=""number"">79K</span></span>
                        <div cl");
            WriteLiteral(@"ass=""p-4 px-lg-5"">
                            <p>Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.</p>
                        </div>
                        <a href=""#"" class=""btn btn-primary btn-outline-primary d-block px-2 py-3"">Get Started</a>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 col-lg-3"" data-aos=""fade-up"" data-aos-duration=""1000"" data-aos-delay=""300"">
                <div class=""block-7"">
                    <div class=""text-center"">
                        <span class=""excerpt d-block"">Premium Plan</span>
                        <span class=""price""><sup>$</sup> <span class=""number"">109K</span></span>
                        <div class=""p-4 px-lg-5"">
                            <p>Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.</p>
                        </div>
                        <a ");
            WriteLiteral(@"href=""#"" class=""btn btn-primary btn-outline-primary d-block px-2 py-3"">Get Started</a>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 col-lg-3"" data-aos=""fade-up"" data-aos-duration=""1000"" data-aos-delay=""400"">
                <div class=""block-7"">
                    <div class=""text-center"">
                        <span class=""excerpt d-block"">Ultimate Plan</span>
                        <span class=""price""><sup>$</sup> <span class=""number"">149K</span></span>
                        <div class=""p-4 px-lg-5"">
                            <p>Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.</p>
                        </div>
                        <a href=""#"" class=""btn btn-primary btn-outline-primary d-block px-2 py-3"">Get Started</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<section class=""ftco-intro py-5");
            WriteLiteral(@" bg-primary"">
    <div class=""container"">
        <div class=""row d-flex justify-content-center"">
            <div class=""col-lg-10"">
                <div class=""row g-lg-5"">
                    <div class=""col-md-7 text-lg-right"">
                        <h2 class=""mb-0"">Newsletter - Stay tune and get the latest update</h2>
                        <p>Far far away, behind the word mountains</p>
                    </div>
                    <div class=""col-md-5 border-left d-flex align-items-center"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13bfa1e625e9d3dfa504ee5e547893ba5cc85f5834996", async() => {
                WriteLiteral(@"
                            <div class=""form-group d-flex align-items-center"">
                                <input type=""text"" class=""form-control"" placeholder=""Enter email address"">
                                <a href=""#"" class=""btn-icon""><span class=""fa fa-paper-plane""></span></a>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591