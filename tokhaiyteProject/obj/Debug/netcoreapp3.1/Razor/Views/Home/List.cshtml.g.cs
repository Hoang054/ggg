#pragma checksum "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fb6c01a7789c25bb3929fecf0e930a8e54666c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_List), @"mvc.1.0.view", @"/Views/Home/List.cshtml")]
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
#line 1 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\_ViewImports.cshtml"
using tokhaiyteProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\_ViewImports.cshtml"
using tokhaiyteProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fb6c01a7789c25bb3929fecf0e930a8e54666c8", @"/Views/Home/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab2e20b29e04fefc78b0308a17aaa47207dceae3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<tokhaiyteProject.Models.ViewModels.ListToKhai>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootbox.js/bootbox.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/list.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
  ViewBag.Title = "Danh Sách Tờ Khai";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div>
    <h1>Danh Sách Tờ Khai</h1>
    <table class=""table table-active"">
        <thead>
            <tr>
                <th>Id</th>
                <th>Cửa Khẩu</th>
                <th>Họ và tên</th>
                <th>Năm Sinh</th>
                <th>Giới Tính</th>
                <th>Quốc Tịch</th>
                <th>Số Hộ Chiếu</th>
                <th>Di chuyển bằng tàu bay</th>
                <th>Di chuyển bằng Tàu Thuyển</th>
                <th>Di chuyển bằng Ô Tô</th>
                <th>Di chuyển bằng phương tiện khác</th>
                <th>Số Hiệu Phương tiện</th>
                <th>Số Ghế</th>
                <th>Ngày Khởi hành</th>
                <th>Ngày Nhập Cảnh</th>
                <th>Địa Điểm Khởi hành</th>
                <th>Địa Điểm Nơi Đến</th>
                <th>Di chuyển trong 24h</th>
                <th>Tỉnh Thành</th>
                <th>Quận/ Huyện</th>
                <th>Phường Xã</th>
                <th>Address</th>
                <th>");
            WriteLiteral(@"Phone</th>
                <th>Email</th>
                <th>Sốt</th>
                <th>Ho</th>
                <th>Khó Thở</th>
                <th>Đau Họng</th>
                <th>Nôn/ Buồn Nôn</th>
                <th>Tiêu Chảy</th>
                <th>Xuất Huyết Ngoài da</th>
                <th>Nổi Ban</th>
                <th>danh sách vacxin, sinh phẩm</th>
                <th>Đến trang trại, tiếp xúc động vật</th>
                <th>Tiếp xúc người bệnh hô hấp</th>
                <th>Thao Tac</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 49 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 52 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                   Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 53 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                   Write(item.Gate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 54 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                   Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 55 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                   Write(item.BirthYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 56 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                   Write(item.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 57 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                   Write(item.VietNam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 58 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                   Write(item.HoChieu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 59 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                   Write(item.tauBay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 60 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                   Write(item.tauThuyen);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 61 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                   Write(item.oTo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 62 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                   Write(item.other);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 63 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                   Write(item.Sohieu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 64 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                   Write(item.SoGhet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 65 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                   Write(item.startDay);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 65 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                                  Write(item.startMonth);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 65 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                                                   Write(item.startYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 66 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                   Write(item.entryDay);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 66 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                                  Write(item.entryMonth);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 66 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                                                   Write(item.entryYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 67 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                   Write(item.VietNam_s);

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                                  Write(item.Tinhs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 68 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                   Write(item.VietNam_e);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 68 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                                   Write(item.Tihhe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 69 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                   Write(item.denquocgia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 70 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                   Write(item.Province);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 71 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                   Write(item.District);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 72 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                   Write(item.Ward);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 73 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                   Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 74 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                   Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 75 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                   Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 76 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                   Write(item.Sot);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 77 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                   Write(item.Ho);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 78 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                   Write(item.Khotho);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 79 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                   Write(item.Dauhong);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 80 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                   Write(item.Non);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 81 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                   Write(item.Tieuchay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 82 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                   Write(item.xuatHuyet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 83 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                   Write(item.NoiBan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 84 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                   Write(item.vacxin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 85 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                   Write(item.dongvat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 86 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                   Write(item.tiepxuc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a href=\"javascript:void(0)\" class=\"text-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3538, "\"", 3572, 3);
            WriteAttributeValue("", 3548, "toKhais.delete(", 3548, 15, true);
#nullable restore
#line 88 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
WriteAttributeValue("", 3563, item.id, 3563, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3571, ")", 3571, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-trash\"></i></a>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fb6c01a7789c25bb3929fecf0e930a8e54666c818001", async() => {
                WriteLiteral("<i class=\"fas fa-edit\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 89 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
                                                                     WriteLiteral(item.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 92 "D:\module3\tokhaiyteProject\tokhaiyteProject\Views\Home\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fb6c01a7789c25bb3929fecf0e930a8e54666c820874", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fb6c01a7789c25bb3929fecf0e930a8e54666c821974", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public tokhaiyteDbContext context { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<tokhaiyteProject.Models.ViewModels.ListToKhai>> Html { get; private set; }
    }
}
#pragma warning restore 1591
