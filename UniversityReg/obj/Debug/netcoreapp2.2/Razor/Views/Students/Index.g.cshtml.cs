#pragma checksum "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c2706c549880cd42053eab2c49719381c637738"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Index), @"mvc.1.0.view", @"/Views/Students/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Students/Index.cshtml", typeof(AspNetCore.Views_Students_Index))]
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
#line 5 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Index.cshtml"
using UniversityReg.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c2706c549880cd42053eab2c49719381c637738", @"/Views/Students/Index.cshtml")]
    public class Views_Students_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UniversityReg.Models.Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(100, 20, true);
            WriteLiteral("\n<h1>Students</h1>\n\n");
            EndContext();
#line 10 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(146, 44, true);
            WriteLiteral("  <h3>No students have been added yet!</h3>\n");
            EndContext();
#line 13 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Index.cshtml"
} 

#line default
#line hidden
            BeginContext(193, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 15 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Index.cshtml"
 foreach (Student student in Model)
{

#line default
#line hidden
            BeginContext(232, 6, true);
            WriteLiteral("  <li>");
            EndContext();
            BeginContext(239, 77, false);
#line 17 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Index.cshtml"
 Write(Html.ActionLink($"{student.Name}", "Details", new { id = student.StudentId }));

#line default
#line hidden
            EndContext();
            BeginContext(316, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 18 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Index.cshtml"
}

#line default
#line hidden
            BeginContext(324, 40, true);
            WriteLiteral("<input type=\"button\" value=\"Add Student\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 364, "\"", 424, 3);
            WriteAttributeValue("", 374, "location.href=\'", 374, 15, true);
#line 19 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Index.cshtml"
WriteAttributeValue("", 389, Url.Action("Create", "Students"), 389, 33, false);

#line default
#line hidden
            WriteAttributeValue("", 422, "\';", 422, 2, true);
            EndWriteAttribute();
            BeginContext(425, 68, true);
            WriteLiteral(" class=\"btn btn-primary\" />\n<input type=\"button\" value=\"Return Home\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 493, "\"", 548, 3);
            WriteAttributeValue("", 503, "location.href=\'", 503, 15, true);
#line 20 "/Users/iangregg/Desktop/UniversityRegistrar.solution/UniversityReg/Views/Students/Index.cshtml"
WriteAttributeValue("", 518, Url.Action("Index", "Home"), 518, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 546, "\';", 546, 2, true);
            EndWriteAttribute();
            BeginContext(549, 27, true);
            WriteLiteral(" class=\"btn btn-primary\" />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UniversityReg.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591