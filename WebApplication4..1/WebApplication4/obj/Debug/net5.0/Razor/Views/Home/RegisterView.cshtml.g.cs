#pragma checksum "C:\Users\Gurbux\Source\Repos\MEGurbuz\MyProjec\WebApplication4..1\WebApplication4\Views\Home\RegisterView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b4cdf359c7c2a8331efe72c7a76c6a5c63ff979"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RegisterView), @"mvc.1.0.view", @"/Views/Home/RegisterView.cshtml")]
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
#line 1 "C:\Users\Gurbux\Source\Repos\MEGurbuz\MyProjec\WebApplication4..1\WebApplication4\Views\_ViewImports.cshtml"
using WebApplication4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gurbux\Source\Repos\MEGurbuz\MyProjec\WebApplication4..1\WebApplication4\Views\_ViewImports.cshtml"
using WebApplication4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b4cdf359c7c2a8331efe72c7a76c6a5c63ff979", @"/Views/Home/RegisterView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fff4eb847734ec2c3f91807e9b1a08bbda85e45", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_RegisterView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n   \r\n    ViewData[\"Title\"] = \"Register\";\r\n\r\n<h1>");
#nullable restore
#line 6 "C:\Users\Gurbux\Source\Repos\MEGurbuz\MyProjec\WebApplication4..1\WebApplication4\Views\Home\RegisterView.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Gurbux\Source\Repos\MEGurbuz\MyProjec\WebApplication4..1\WebApplication4\Views\Home\RegisterView.cshtml"
  
    ViewBag.Title = "RegisterPage"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>
    $(document).ready(function () {
        $('#CountrySelect').change(function () {
            //$('#SehirSecim').html("" "");
            var id = $('#CountrySelect').val();
            debugger
            $.ajax({
                url: '/Controllers/HomeController/CountryGet',
                data: { p: id },
                type: ""POST"",
                dataType: ""Json"",
                success: function (data) {
                    debugger
                    console.log(data);
                    /* $('#EyaletSecim').empty();*/
                    for (var i = 0; i < data.length; i++) {
                        $('#CountrySelect').append(""<option value ='"" + data
                        [i] + ""'>"" + data[i] + ""</option>"");
                    }
                }

            });
        });
    });




</script>
<script>
    //aynı scriptleri sehir ve state içinde yap 


</script>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b4cdf359c7c2a8331efe72c7a76c6a5c63ff9794935", async() => {
                WriteLiteral(@"
    <div class=""form-row"">
        <div class=""form-group col-md-6"">
            <label for=""Name"">Name</label>
            <input type=""text"" class=""form-control"" id=""inputEmail4"">
        </div>
        <div class=""form-row"">
            <div class=""form-group col-md-6"">
                <label for=""Surname"">Surname</label>
                <input type=""text"" class=""form-control"" id=""inputEmail4"">
            </div>
    <div class=""form-group"">
        <div class=""form-group col-md-6"">
            <label for=""inputEmail4"">Email</label>
            <input type=""email"" class=""form-control"" id=""inputEmail4"">
        </div>
       
    </div>
 
    
            <div class=""form-group col-md-4"">
                <label for=""inputCountry"">Country</label>
                ");
#nullable restore
#line 68 "C:\Users\Gurbux\Source\Repos\MEGurbuz\MyProjec\WebApplication4..1\WebApplication4\Views\Home\RegisterView.cshtml"
           Write(Html.DropDownList("CountrySelect",null,"Select-Country",new {@class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
               
                
            </div>
        <div class=""form-group col-md-4"">
                 <label for=""City""> <b>City</b></label>
        <select class=""form-control"" id=""CitySelect"" name=""CitySelect""></select>
        </div>
        <div class=""form-group col-md-2"">
            <label for=""inputZip"">Zip</label>
            <input type=""text"" class=""form-control"" id=""inputZip"">
        </div>
    </div>
    <div class=""form-group"">
            <label for=""State""> <b>State</b></label>
            <select class=""form-control"" id=""StateSelect"" name=""StateSelect""></select>
        </div>
    </div>
    <button type=""submit"" class=""btn btn-primary"">Sign in</button>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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