#pragma checksum "C:\Users\User\Desktop\backend projec 2\New folder\AP204_Pronia\Areas\proniaadmin\Views\Color\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4567ac59e6bde9402a409ed6a0671ac9b120d3de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_proniaadmin_Views_Color_Detail), @"mvc.1.0.view", @"/Areas/proniaadmin/Views/Color/Detail.cshtml")]
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
#line 1 "C:\Users\User\Desktop\backend projec 2\New folder\AP204_Pronia\Areas\proniaadmin\Views\_ViewImports.cshtml"
using AP204_Pronia.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\backend projec 2\New folder\AP204_Pronia\Areas\proniaadmin\Views\_ViewImports.cshtml"
using AP204_Pronia.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4567ac59e6bde9402a409ed6a0671ac9b120d3de", @"/Areas/proniaadmin/Views/Color/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87b9109567c1dc3986dd74402b28ac3a0f68a1d3", @"/Areas/proniaadmin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_proniaadmin_Views_Color_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Color>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\backend projec 2\New folder\AP204_Pronia\Areas\proniaadmin\Views\Color\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n   <div>\r\n       <h4>Id</h4>\r\n       <p>\r\n           ");
#nullable restore
#line 10 "C:\Users\User\Desktop\backend projec 2\New folder\AP204_Pronia\Areas\proniaadmin\Views\Color\Detail.cshtml"
      Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n       </p>\r\n   </div>\r\n   <div>\r\n        <h4>Name</h4>\r\n       <p>\r\n           ");
#nullable restore
#line 16 "C:\Users\User\Desktop\backend projec 2\New folder\AP204_Pronia\Areas\proniaadmin\Views\Color\Detail.cshtml"
      Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n       </p>\r\n   </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Color> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
