#pragma checksum "C:\Users\Vlad\source\repos\AspNetCore3\02 SimpleApp\SimpleApp\Views\Products\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "044f837ffcd78fd0c75583c1cf9aaf40949d4e26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_List), @"mvc.1.0.view", @"/Views/Products/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/List.cshtml", typeof(AspNetCore.Views_Products_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"044f837ffcd78fd0c75583c1cf9aaf40949d4e26", @"/Views/Products/List.cshtml")]
    public class Views_Products_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/styles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(301, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 8 "C:\Users\Vlad\source\repos\AspNetCore3\02 SimpleApp\SimpleApp\Views\Products\List.cshtml"
  
    Layout = null; // не использовать компоновку.
                   // Компоновки необходимы для создания страниц по шаблону. Будут рассмотрены в следующих уроках

#line default
#line hidden
            BeginContext(478, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(507, 150, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "044f837ffcd78fd0c75583c1cf9aaf40949d4e264268", async() => {
                BeginContext(513, 90, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>List</title>\r\n    ");
                EndContext();
                BeginContext(603, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "044f837ffcd78fd0c75583c1cf9aaf40949d4e264746", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(648, 2, true);
                WriteLiteral("\r\n");
                EndContext();
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
            EndContext();
            BeginContext(657, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(659, 1555, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "044f837ffcd78fd0c75583c1cf9aaf40949d4e266875", async() => {
                BeginContext(665, 46, true);
                WriteLiteral("\r\n    <h2>Список продуктов</h2>\r\n    <table>\r\n");
                EndContext();
#line 29 "C:\Users\Vlad\source\repos\AspNetCore3\02 SimpleApp\SimpleApp\Views\Products\List.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
                BeginContext(1161, 38, true);
                WriteLiteral("            <tr>\r\n                <td>");
                EndContext();
                BeginContext(1200, 7, false);
#line 33 "C:\Users\Vlad\source\repos\AspNetCore3\02 SimpleApp\SimpleApp\Views\Products\List.cshtml"
               Write(item.Id);

#line default
#line hidden
                EndContext();
                BeginContext(1207, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(1235, 9, false);
#line 34 "C:\Users\Vlad\source\repos\AspNetCore3\02 SimpleApp\SimpleApp\Views\Products\List.cshtml"
               Write(item.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1244, 51, true);
                WriteLiteral("</td>\r\n                <td>\r\n                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1295, "\"", 1328, 2);
                WriteAttributeValue("", 1302, "/Products/Details/", 1302, 18, true);
#line 36 "C:\Users\Vlad\source\repos\AspNetCore3\02 SimpleApp\SimpleApp\Views\Products\List.cshtml"
WriteAttributeValue("", 1320, item.Id, 1320, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1329, 42, true);
                WriteLiteral(">Подробнее...</a>\r\n                </td>\r\n");
                EndContext();
#line 38 "C:\Users\Vlad\source\repos\AspNetCore3\02 SimpleApp\SimpleApp\Views\Products\List.cshtml"
                 if (item.Qty <= 0)
                {

#line default
#line hidden
                BeginContext(1427, 88, true);
                WriteLiteral("                <td>\r\n                        нет в наличии\r\n                    </td>\r\n");
                EndContext();
#line 43 "C:\Users\Vlad\source\repos\AspNetCore3\02 SimpleApp\SimpleApp\Views\Products\List.cshtml"
}
                else if (item.Qty >= 0 && item.Qty <= 5)
                {

#line default
#line hidden
                BeginContext(1595, 92, true);
                WriteLiteral("                    <td>\r\n                        заканчивается\r\n                    </td>\r\n");
                EndContext();
#line 49 "C:\Users\Vlad\source\repos\AspNetCore3\02 SimpleApp\SimpleApp\Views\Products\List.cshtml"
                }
                else
                {

#line default
#line hidden
                BeginContext(1747, 88, true);
                WriteLiteral("                    <td>\r\n                        в наличии\r\n                    </td>\r\n");
                EndContext();
#line 55 "C:\Users\Vlad\source\repos\AspNetCore3\02 SimpleApp\SimpleApp\Views\Products\List.cshtml"
                }

#line default
#line hidden
                BeginContext(1854, 19, true);
                WriteLiteral("            </tr>\r\n");
                EndContext();
#line 57 "C:\Users\Vlad\source\repos\AspNetCore3\02 SimpleApp\SimpleApp\Views\Products\List.cshtml"

        }

#line default
#line hidden
                BeginContext(1886, 14, true);
                WriteLiteral("    </table>\r\n");
                EndContext();
#line 64 "C:\Users\Vlad\source\repos\AspNetCore3\02 SimpleApp\SimpleApp\Views\Products\List.cshtml"
     if (Model.Count != 0)
    {

#line default
#line hidden
                BeginContext(2063, 32, true);
                WriteLiteral("        <p>\r\n            Всего: ");
                EndContext();
                BeginContext(2096, 11, false);
#line 67 "C:\Users\Vlad\source\repos\AspNetCore3\02 SimpleApp\SimpleApp\Views\Products\List.cshtml"
              Write(Model.Count);

#line default
#line hidden
                EndContext();
                BeginContext(2107, 16, true);
                WriteLiteral("\r\n        </p>\r\n");
                EndContext();
#line 69 "C:\Users\Vlad\source\repos\AspNetCore3\02 SimpleApp\SimpleApp\Views\Products\List.cshtml"
    }
    else
    {

#line default
#line hidden
                BeginContext(2147, 53, true);
                WriteLiteral("        <p>\r\n            Список пуст.\r\n        </p>\r\n");
                EndContext();
#line 75 "C:\Users\Vlad\source\repos\AspNetCore3\02 SimpleApp\SimpleApp\Views\Products\List.cshtml"
    }

#line default
#line hidden
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
            EndContext();
            BeginContext(2214, 15, true);
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
