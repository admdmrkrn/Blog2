#pragma checksum "C:\Users\USER\Desktop\Blog2\AdminBlog2\Views\Home\Author.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0fe81b856b203777dc012f43bde6fb4ca3a2b16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Author), @"mvc.1.0.view", @"/Views/Home/Author.cshtml")]
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
#line 1 "C:\Users\USER\Desktop\Blog2\AdminBlog2\Views\_ViewImports.cshtml"
using AdminBlog2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\Desktop\Blog2\AdminBlog2\Views\_ViewImports.cshtml"
using AdminBlog2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0fe81b856b203777dc012f43bde6fb4ca3a2b16", @"/Views/Home/Author.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6563eb4d3438752c62aec2a494403e45ec07acc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Author : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AdminBlog2.Models.Author>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteAuthor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/AddAuthor"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\USER\Desktop\Blog2\AdminBlog2\Views\Home\Author.cshtml"
  
    ViewData["Title"] = "Author";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<button type=""button"" onclick=""$('#AuthorModal').modal('show')"" class=""btn btn-primary"" >Kategori Ekle</button>

<table class=""table table-hover"">
    <thead>
        <tr>
            <th scope=""col"">Id</th>
            <th scope=""col"">Name</th>
              <th scope=""col"">Surname</th>
            <th scope=""col"">Email</th>
            <th scope=""col"">Parola</th>
            <th scope=""col""></th>
        </tr>
        
    </thead>
    <tbody>
");
#nullable restore
#line 21 "C:\Users\USER\Desktop\Blog2\AdminBlog2\Views\Home\Author.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("           <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 24 "C:\Users\USER\Desktop\Blog2\AdminBlog2\Views\Home\Author.cshtml"
                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\USER\Desktop\Blog2\AdminBlog2\Views\Home\Author.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\USER\Desktop\Blog2\AdminBlog2\Views\Home\Author.cshtml"
               Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\USER\Desktop\Blog2\AdminBlog2\Views\Home\Author.cshtml"
               Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\USER\Desktop\Blog2\AdminBlog2\Views\Home\Author.cshtml"
               Write(item.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n               <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0fe81b856b203777dc012f43bde6fb4ca3a2b167189", async() => {
                WriteLiteral("Sil");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\USER\Desktop\Blog2\AdminBlog2\Views\Home\Author.cshtml"
                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n               <button class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 975, "\"", 1005, 3);
            WriteAttributeValue("", 985, "updateForm(", 985, 11, true);
#nullable restore
#line 31 "C:\Users\USER\Desktop\Blog2\AdminBlog2\Views\Home\Author.cshtml"
WriteAttributeValue("", 996, item.Id, 996, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1004, ")", 1004, 1, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" >Güncelle</button>\r\n               </td>\r\n           </tr> \r\n");
#nullable restore
#line 34 "C:\Users\USER\Desktop\Blog2\AdminBlog2\Views\Home\Author.cshtml"
            
        }   

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<div class=""modal"" id=""AuthorModal"" tabindex=""-1"">
  <div class=""modal-dialog"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"">Yazar</h5>
        <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
      </div>

    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0fe81b856b203777dc012f43bde6fb4ca3a2b1610591", async() => {
                WriteLiteral(@"
        <div class=""modal-body"">
            <div class=""form-group"">
                <input type=""hidden"" name=""Id"" id=""Id"" placeholder=""Id"" class=""form-control"">
                <input type=""text"" name=""Name"" id=""Name"" placeholder=""Name:"" class=""form-control"">
            </div>

            <div class=""form-group"">
                <input type=""text"" name=""Surname"" id=""Surname"" placeholder=""Surname;"" class=""form-control"">
            </div>

             <div class=""form-group"">
                <input type=""text"" name=""Email"" id=""Email"" placeholder=""Email;"" class=""form-control"">
            </div>

             <div class=""form-group"">
                <input type=""text"" name=""Password"" id=""Password"" placeholder=""Password"" class=""form-control"">
            </div>

            
            
        </div>
        <div class=""modal-footer"">
            <button type=""button"" class=""btn btn-secondary"" onclick=""clearForm()"" data-bs-dismiss=""modal"">Kapat</button>
            <button type=""");
                WriteLiteral("Submit\" id=\"saveBtn\" class=\"btn btn-primary\">Ekle</button>\r\n            <button type=\"Submit\" id=\"updateBtn\" class=\"btn btn-primary\">Güncelle</button>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n  </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>

        $(() => clearForm()) ////////// Her sayfa açıldığında başlangıç olarak çağırılmasını sağlıyor.
        function updateForm(Id)
        {
            fetch('/Home/AuthorDetails?Id='+Id)
            .then(res => res.json())
            .then(res =>
            
               {   
                $('#Id').val(res.id)
                $('#Name').val(res.name)
                $('#Surname').val(res.surname)
                $('#Password').val(res.password)
                $('#Email').val(res.email)
                
               } 
            )
            
            $('#saveBtn').hide();
             $('updateBtn').show();
            $('#AuthorModal').modal('show');

        }
       /////////////////////   CLEAR  ////////////////////////////////////////
       function clearForm()
        {
            $('#Id').val(null)
            $('#Name').val(null)
            $('#Surname').val(null)
            $('#Password').val(null)
            $('#Email').val(nu");
                WriteLiteral("ll)\r\n\r\n            $(\'#saveBtn\').show();\r\n            $(\'updateBtn\').hide();\r\n       }\r\n\r\n\r\n    </script>\r\n\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AdminBlog2.Models.Author>> Html { get; private set; }
    }
}
#pragma warning restore 1591
