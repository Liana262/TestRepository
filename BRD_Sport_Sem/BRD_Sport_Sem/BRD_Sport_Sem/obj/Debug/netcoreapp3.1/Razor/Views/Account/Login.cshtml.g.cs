#pragma checksum "C:\Users\liana\Documents\GitHub\KraduVashiRepi\BRD_Sport_Sem\BRD_Sport_Sem\BRD_Sport_Sem\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a908309f26c27519918a01e759df19e5dbb549cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(History.Pages.Account.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
namespace History.Pages.Account
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
#line 1 "C:\Users\liana\Documents\GitHub\KraduVashiRepi\BRD_Sport_Sem\BRD_Sport_Sem\BRD_Sport_Sem\Views\_ViewImports.cshtml"
using History;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a908309f26c27519918a01e759df19e5dbb549cf", @"/Views/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f4bf134e83ba23676578814d9c34a135c1fbcae", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("on"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bgtext col-lg-6 textcontent unselectable form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"

<div class=""column"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-5""></div>
            <div class=""col-lg-2 logo""></div>
            <div class=""col-lg-5""></div>
        </div>
    </div>

    <div class=""w-100 row unselectable"" style=""color: #0E86CA""> kostyly</div>
    <div class=""w-100 row unselectable"" style=""color: #0E86CA""> pravda</div>
    <div class=""w-100 row unselectable"" style=""color: #0E86CA""> otvechau</div>


    <div");
            BeginWriteAttribute("class", " class=\"", 492, "\"", 500, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""container"">
            <div class=""row"">
                <div class=""buttonsMoi bgtexttitle col-lg-6"" style=""font-size: 32px"">Авторизация</div>
                <div class=""w-100 row unselectable""></div>


                <div class=""w-100 row unselectable""></div>
                <!--Форма входа-->
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a908309f26c27519918a01e759df19e5dbb549cf5518", async() => {
                WriteLiteral(@"
                    <p>
                        <div>Ваша почта</div>
                        <input class=""form-control inputfield textcontent col-lg-12"" name=""Email"" required=""required"" type=""text"" placeholder=""mymail@mail.com"" />
                    </p>
                    <p>
                        <div>Ваш пароль</div>
                        <input class=""form-control inputfield textcontent col-lg-12"" name=""Password"" required=""required"" type=""password"" placeholder=""qqqqqqqq1"" />
                    </p>
                    <p class=""buttonsMoi"">
                        <input type=""checkbox"" name=""loginkeeping"" value=""loginkeeping"" class="" col-lg-1 "" />
                        <label for=""loginkeeping"">Запомнить меня</label>
                    </p>
                    <p");
                BeginWriteAttribute("class", " class=\"", 1760, "\"", 1768, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"submit\" class=\"form-control textcontent inputfield\" value=\"Войти\" />\r\n                    </p>\r\n                    <p class=\"change_link\">\r\n                        Ещё не с нами?\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 2016, "\"", 2057, 1);
#nullable restore
#line 44 "C:\Users\liana\Documents\GitHub\KraduVashiRepi\BRD_Sport_Sem\BRD_Sport_Sem\BRD_Sport_Sem\Views\Account\Login.cshtml"
WriteAttributeValue("", 2023, Url.Content("~/Account/Register"), 2023, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"to_subscribe\">Зарегистрироваться</a>\r\n                    </p>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                <div class=""w-100 row unselectable"" style=""color: #0E86CA""> Den</div>
                <div class=""w-100 row unselectable"" style=""color: #0E86CA""> nikogda</div>
                <div class=""w-100 row unselectable"" style=""color: #0E86CA""> ne</div>
                <div class=""w-100 row unselectable"" style=""color: #0E86CA""> ispolzuet</div>
                <div class=""w-100 row unselectable"" style=""color: #0E86CA""> kostyly</div>
                <div class=""w-100 row unselectable"" style=""color: #0E86CA""> pravda</div>
                <div class=""w-100 row unselectable"" style=""color: #0E86CA""> otvechau</div>
                <div class=""w-100 row unselectable"" style=""color: #0E86CA""> Unlucky</div>
                <div class=""w-100 row unselectable"" style=""color: #0E86CA""> Den</div>
            </div>
        </div>
    </div>
</div>");
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
