#pragma checksum "E:\iti3months\DR.Greiche Taskinterview\SampleMiniProject\SampleMiniProject\Views\RecievedSample\_TableSamples.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58b133444951970ec0df8544629c2566ecb23ec6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RecievedSample__TableSamples), @"mvc.1.0.view", @"/Views/RecievedSample/_TableSamples.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\iti3months\DR.Greiche Taskinterview\SampleMiniProject\SampleMiniProject\Views\_ViewImports.cshtml"
using SampleMiniProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\iti3months\DR.Greiche Taskinterview\SampleMiniProject\SampleMiniProject\Views\_ViewImports.cshtml"
using SampleMiniProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\iti3months\DR.Greiche Taskinterview\SampleMiniProject\SampleMiniProject\Views\_ViewImports.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\iti3months\DR.Greiche Taskinterview\SampleMiniProject\SampleMiniProject\Views\_ViewImports.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58b133444951970ec0df8544629c2566ecb23ec6", @"/Views/RecievedSample/_TableSamples.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7050a8c2d0cbbfd91caf9136ddc418966fd0f86", @"/Views/_ViewImports.cshtml")]
    public class Views_RecievedSample__TableSamples : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ReceivedSample>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=col-sm-12>
        <table class=""table table-striped table-bordered table-sm align-middle border border-dark  table-hover"" id=""dtBasicExample"" cellspacing=""0"" width=""100%"">
            <thead >
                <tr>
                    <th class=""text-center text-nowrap"" scope=""col"" colspan=""2""></th>
                    <th  class=""text-center text-nowrap"" scope=""col"" colspan=""2"">حاله العينه </th>
                    <th  class=""text-center text-nowrap"" scope=""col"" colspan=""2"">عدد العينات</th>
                    <th  class=""text-center text-nowrap"" scope=""col"" colspan=""2"">وصف العينه</th>
                    <th  class=""text-center text-nowrap"" scope=""col"" colspan=""4"">مرفقات العميل</th>
                    <th  class=""text-center text-nowrap"" scope=""col"" colspan=""2"">تاريخ الاستلام</th>
                    <th  class=""text-center text-nowrap"" scope=""col"" colspan=""2"">جهه الاستلام </th>
                    <th  class=""text-center text-nowrap"" scope=""col"" colspan=""3"">أسم العميل</th>
        ");
            WriteLiteral("            <th  class=\"text-center text-nowrap\" scope=\"col\" colspan=\"2\">أسم العينه</th>\r\n            \r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 19 "E:\iti3months\DR.Greiche Taskinterview\SampleMiniProject\SampleMiniProject\Views\RecievedSample\_TableSamples.cshtml"
                 foreach(var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"text-center text-nowrap\" colspan=\"2\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1418, "\"", 1454, 2);
            WriteAttributeValue("", 1425, "/RecievedSample/Edit/", 1425, 21, true);
#nullable restore
#line 23 "E:\iti3months\DR.Greiche Taskinterview\SampleMiniProject\SampleMiniProject\Views\RecievedSample\_TableSamples.cshtml"
WriteAttributeValue("", 1446, item.ID, 1446, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">تعديل </a>|<a class=\"text-danger\" href=\"\\RecievedSample\\Delete\"> حذف</a>\r\n                        </td>\r\n                        <td class=\"text-right\" colspan=\"2\">");
#nullable restore
#line 25 "E:\iti3months\DR.Greiche Taskinterview\SampleMiniProject\SampleMiniProject\Views\RecievedSample\_TableSamples.cshtml"
                                                      Write(item.SampleStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-right\" colspan=\"2\">");
#nullable restore
#line 26 "E:\iti3months\DR.Greiche Taskinterview\SampleMiniProject\SampleMiniProject\Views\RecievedSample\_TableSamples.cshtml"
                                                      Write(item.NumOfSamples);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-right\" colspan=\"2\">");
#nullable restore
#line 27 "E:\iti3months\DR.Greiche Taskinterview\SampleMiniProject\SampleMiniProject\Views\RecievedSample\_TableSamples.cshtml"
                                                      Write(item.SampleDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-right\" colspan=\"4\">\r\n                            <table>\r\n                                <tbody>\r\n                                    <tr>\r\n");
#nullable restore
#line 32 "E:\iti3months\DR.Greiche Taskinterview\SampleMiniProject\SampleMiniProject\Views\RecievedSample\_TableSamples.cshtml"
                                         foreach(var file in ViewBag.Attachments)
                                        {
                                            if (file.ReceivedSampleID == item.ID)
                                            {       

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr>\r\n                                                    <td class=\"text-right\">");
#nullable restore
#line 37 "E:\iti3months\DR.Greiche Taskinterview\SampleMiniProject\SampleMiniProject\Views\RecievedSample\_TableSamples.cshtml"
                                                                      Write(file.FileName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 38 "E:\iti3months\DR.Greiche Taskinterview\SampleMiniProject\SampleMiniProject\Views\RecievedSample\_TableSamples.cshtml"
                                                   Write(Html.ActionLink("Download","DownloadFile",new {fileName=file.FileName}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>    \r\n                                                </tr>\r\n");
#nullable restore
#line 40 "E:\iti3months\DR.Greiche Taskinterview\SampleMiniProject\SampleMiniProject\Views\RecievedSample\_TableSamples.cshtml"
                                            }
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </tr>\r\n                                </tbody>\r\n                            </table>\r\n                        </td>\r\n                        <td class=\"text-right\" colspan=\"2\">");
#nullable restore
#line 46 "E:\iti3months\DR.Greiche Taskinterview\SampleMiniProject\SampleMiniProject\Views\RecievedSample\_TableSamples.cshtml"
                                                      Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-right\" colspan=\"2\">");
#nullable restore
#line 47 "E:\iti3months\DR.Greiche Taskinterview\SampleMiniProject\SampleMiniProject\Views\RecievedSample\_TableSamples.cshtml"
                                                      Write(item.ReceivingSide);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-right\" colspan=\"3\">");
#nullable restore
#line 48 "E:\iti3months\DR.Greiche Taskinterview\SampleMiniProject\SampleMiniProject\Views\RecievedSample\_TableSamples.cshtml"
                                                      Write(item.Client.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-right\" colspan=\"2\">");
#nullable restore
#line 49 "E:\iti3months\DR.Greiche Taskinterview\SampleMiniProject\SampleMiniProject\Views\RecievedSample\_TableSamples.cshtml"
                                                      Write(item.SampleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>               \r\n                    </tr>   \r\n");
#nullable restore
#line 51 "E:\iti3months\DR.Greiche Taskinterview\SampleMiniProject\SampleMiniProject\Views\RecievedSample\_TableSamples.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>          ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ReceivedSample>> Html { get; private set; }
    }
}
#pragma warning restore 1591
