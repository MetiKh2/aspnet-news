#pragma checksum "D:\پروژه سایت خبری (First Project In Asp.Net Core)\MyCms\EndPoint.Site\Areas\Admin\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d6378e39083af1747eab8e388610de3d436959e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/User/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d6378e39083af1747eab8e388610de3d436959e", @"/Areas/Admin/Views/User/Index.cshtml")]
    public class Areas_Admin_Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MyCms.Application.Services.User.Query.GetUsers.GetUsersDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/SweetAlert/sweetalert2.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/SweetAlert/sweetalert2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\پروژه سایت خبری (First Project In Asp.Net Core)\MyCms\EndPoint.Site\Areas\Admin\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""content-wrapper"">
    <div class=""container-fluid"">
        <!-- Zero configuration table -->
        <section id=""configuration"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""card"">
                        <div class=""card-header"">
                            <div class=""card-title-wrap bar-success"">
                                <h4 class=""card-title"">لیست کاربران</h4>
                            </div>
                        </div>
                        <div class=""card-body collapse show"">
                            <div class=""card-block card-dashboard"">
                                <p class=""card-text"">داده های جداول اغلب ویژگی های پیش فرض را فعال می کنند، بنابراین همه چیزهایی که باید برای استفاده از آن با استفاده از ables خود انجام دهید، تماس با تابع ساخت است: $ (). DataTable ()؛</p>
                                <div id=""DataTables_Table_0_wrapper"" class=""dataTables_wrapper container-fluid dt-bootstrap4"">");
            WriteLiteral("\r\n");
            WriteLiteral("r");
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d6378e39083af1747eab8e388610de3d436959e5534", async() => {
                WriteLiteral("    \r\n                                <input type=\"search\" name=\"SearchKey\" />\r\n                                        <input type=\"submit\" value=\"جستجو\"");
                BeginWriteAttribute("href", " href=\"", 2175, "\"", 2246, 2);
                WriteAttributeValue("", 2182, "~/Admin/user/index?searchKey=", 2182, 29, true);
#nullable restore
#line 29 "D:\پروژه سایت خبری (First Project In Asp.Net Core)\MyCms\EndPoint.Site\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 2211, Context.Request.Query["SearchKey"], 2211, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    ");
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
            WriteLiteral(@"
                                        <div class=""col-sm-12"">
                                            <table class=""table table-striped table-bordered zero-configuration dataTable"" id=""DataTables_Table_0"" role=""grid"" aria-describedby=""DataTables_Table_0_info"">
                                                <thead>
                                                    <tr role=""row"">
                                                        <th class=""sorting_asc"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""نام: activate to sort column descending"" style=""width: 222px;"">نام</th>
                                                        <th class=""sorting"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" aria-label=""ایمیل: activate to sort column ascending"" style=""width: 401px;"">ایمیل</th>
                                                        <th class=""sorting"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=");
            WriteLiteral(@"""1"" colspan=""1"" aria-label=""موبایل: activate to sort column ascending"" style=""width: 401px;"">موبایل</th>
                                                    </tr>
                                                </thead>
                                                <tbody>

");
#nullable restore
#line 42 "D:\پروژه سایت خبری (First Project In Asp.Net Core)\MyCms\EndPoint.Site\Areas\Admin\Views\User\Index.cshtml"
                                                     foreach (var item in Model)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <tr role=\"row\" class=\"odd\">\r\n                                                            <td class=\"sorting_1\">");
#nullable restore
#line 45 "D:\پروژه سایت خبری (First Project In Asp.Net Core)\MyCms\EndPoint.Site\Areas\Admin\Views\User\Index.cshtml"
                                                                             Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 46 "D:\پروژه سایت خبری (First Project In Asp.Net Core)\MyCms\EndPoint.Site\Areas\Admin\Views\User\Index.cshtml"
                                                           Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 47 "D:\پروژه سایت خبری (First Project In Asp.Net Core)\MyCms\EndPoint.Site\Areas\Admin\Views\User\Index.cshtml"
                                                           Write(item.Mobile);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>\r\n                                                                <button class=\"btn btn-info\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4249, "\"", 4355, 15);
            WriteAttributeValue("", 4259, "ShowModalEdituser(\'", 4259, 19, true);
#nullable restore
#line 49 "D:\پروژه سایت خبری (First Project In Asp.Net Core)\MyCms\EndPoint.Site\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 4278, item.ID, 4278, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4286, "\',", 4286, 2, true);
            WriteAttributeValue(" ", 4288, "\'", 4289, 2, true);
#nullable restore
#line 49 "D:\پروژه سایت خبری (First Project In Asp.Net Core)\MyCms\EndPoint.Site\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 4290, item.FullName, 4290, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4304, "\',", 4304, 2, true);
            WriteAttributeValue(" ", 4306, "\'", 4307, 2, true);
#nullable restore
#line 49 "D:\پروژه سایت خبری (First Project In Asp.Net Core)\MyCms\EndPoint.Site\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 4308, item.Email, 4308, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4319, "\',", 4319, 2, true);
            WriteAttributeValue(" ", 4321, "\'", 4322, 2, true);
#nullable restore
#line 49 "D:\پروژه سایت خبری (First Project In Asp.Net Core)\MyCms\EndPoint.Site\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 4323, item.Password, 4323, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4337, "\',", 4337, 2, true);
            WriteAttributeValue(" ", 4339, "\'", 4340, 2, true);
#nullable restore
#line 49 "D:\پروژه سایت خبری (First Project In Asp.Net Core)\MyCms\EndPoint.Site\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 4341, item.Mobile, 4341, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4353, "\')", 4353, 2, true);
            EndWriteAttribute();
            WriteLiteral(">ویرایش</button>\r\n                                                                <button class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4468, "\"", 4500, 3);
            WriteAttributeValue("", 4478, "DeleteUser(\'", 4478, 12, true);
#nullable restore
#line 50 "D:\پروژه سایت خبری (First Project In Asp.Net Core)\MyCms\EndPoint.Site\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 4490, item.ID, 4490, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4498, "\')", 4498, 2, true);
            EndWriteAttribute();
            WriteLiteral(">حذف</button>\r\n");
#nullable restore
#line 51 "D:\پروژه سایت خبری (First Project In Asp.Net Core)\MyCms\EndPoint.Site\Areas\Admin\Views\User\Index.cshtml"
                                                                 if (item.IsActive)
                                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                    <button class=\"btn btn-warning\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4767, "\"", 4804, 3);
            WriteAttributeValue("", 4777, "UserSatusChange(\'", 4777, 17, true);
#nullable restore
#line 53 "D:\پروژه سایت خبری (First Project In Asp.Net Core)\MyCms\EndPoint.Site\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 4794, item.ID, 4794, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4802, "\')", 4802, 2, true);
            EndWriteAttribute();
            WriteLiteral(">غیر فعال کن</button>\r\n");
#nullable restore
#line 54 "D:\پروژه سایت خبری (First Project In Asp.Net Core)\MyCms\EndPoint.Site\Areas\Admin\Views\User\Index.cshtml"
                                                                }
                                                                else
                                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                    <button class=\"btn btn-warning\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5131, "\"", 5168, 3);
            WriteAttributeValue("", 5141, "UserSatusChange(\'", 5141, 17, true);
#nullable restore
#line 57 "D:\پروژه سایت خبری (First Project In Asp.Net Core)\MyCms\EndPoint.Site\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 5158, item.ID, 5158, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5166, "\')", 5166, 2, true);
            EndWriteAttribute();
            WriteLiteral("> فعال کن</button>\r\n");
#nullable restore
#line 58 "D:\پروژه سایت خبری (First Project In Asp.Net Core)\MyCms\EndPoint.Site\Areas\Admin\Views\User\Index.cshtml"
                                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            </td>\r\n                                                        </tr>\r\n");
#nullable restore
#line 61 "D:\پروژه سایت خبری (First Project In Asp.Net Core)\MyCms\EndPoint.Site\Areas\Admin\Views\User\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n                                                </tbody>\r\n");
            WriteLiteral(@"                                            </table>
                                        </div>
                                    </div><div class=""row""><div class=""col-sm-12 col-md-5""><div class=""dataTables_info"" id=""DataTables_Table_0_info"" role=""status"" aria-live=""polite"">نمایش 1 تا 10 از 57 سطرها</div></div><div class=""col-sm-12 col-md-7""><div class=""dataTables_paginate paging_simple_numbers"" id=""DataTables_Table_0_paginate""><ul class=""pagination""><li class=""paginate_button page-item previous disabled"" id=""DataTables_Table_0_previous""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""0"" tabindex=""0"" class=""page-link"">قبلی</a></li><li class=""paginate_button page-item active""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""1"" tabindex=""0"" class=""page-link"">1</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""2"" tabindex=""0"" class=""page-link"">2</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""DataTa");
            WriteLiteral(@"bles_Table_0"" data-dt-idx=""3"" tabindex=""0"" class=""page-link"">3</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""4"" tabindex=""0"" class=""page-link"">4</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""5"" tabindex=""0"" class=""page-link"">5</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""6"" tabindex=""0"" class=""page-link"">6</a></li><li class=""paginate_button page-item next"" id=""DataTables_Table_0_next""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""7"" tabindex=""0"" class=""page-link"">بعدی</a></li></ul></div></div></div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>

    </div>
</div>
");
            DefineSection("Script", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4d6378e39083af1747eab8e388610de3d436959e18509", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d6378e39083af1747eab8e388610de3d436959e19688", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <script>

        function UserSatusChange(UserId) {
            swal.fire({
                title: 'تغییر وضعیت کاربر',
                text: ""کاربر گرامی از تغییر وضعیت کاربر مطمئن هستید؟"",
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#d33',
                cancelButtonColor: '#7cacbe',
                confirmButtonText: 'بله ، تغییر وضعیت انجام شود',
                cancelButtonText: 'خیر'
            }).then((result) => {
                if (result.value) {

                    var postData = {
                        'UserID': UserId,
                    };

                    $.ajax({
                        contentType: 'application/x-www-form-urlencoded',
                        dataType: 'json',
                        type: ""POST"",
                        url: ""/admin/user/ChangeUserStatus"",
                        data: postData,
                        success: function (data) {
                    ");
                WriteLiteral(@"        if (data.isSuccess == true) {
                                swal.fire(
                                    'موفق!',
                                    data.message,
                                    'success'
                                ).then(function (isConfirm) {
                                    location.reload();
                                });
                            }
                            else {

                                swal.fire(
                                    'هشدار!',
                                    data.message,
                                    'warning'
                                );

                            }
                        },
                        error: function (request, status, error) {
                            alert(request.responseText);
                        }

                    });

                }
            })
        }

        function DeleteUser(UserId) {
            swal.");
                WriteLiteral(@"fire({
                title: 'حذف کاربر',
                text: ""کاربر گرامی از حذف کاربر مطمئن هستید؟"",
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#d33',
                cancelButtonColor: '#7cacbe',
                confirmButtonText: 'بله ، کاربر حذف شود',
                cancelButtonText: 'خیر'
            }).then((result) => {
                if (result.value) {
                    var postData = {
                        'UserID': UserId,
                    };

                    $.ajax({
                        contentType: 'application/x-www-form-urlencoded',
                        dataType: 'json',
                        type: ""POST"",
                        url: ""/admin/user/Delete"",
                        data: postData,
                        success: function (data) {
                            if (data.isSuccess == true) {
                                swal.fire(
                                  ");
                WriteLiteral(@"  'موفق!',
                                    data.message,
                                    'success'
                                ).then(function (isConfirm) {
                                    location.reload();
                                });
                            }
                            else {

                                swal.fire(
                                    'هشدار!',
                                    data.message,
                                    'warning'
                                );

                            }
                        },
                        error: function (request, status, error) {
                            alert(request.responseText);
                        }

                    });

                }
            })
        }

        function Edituser() {

            var userId = $(""#Edit_UserId"").val();
            var fullName = $(""#Edit_FullName"").val();
            var email = $(""#Edit_E");
                WriteLiteral(@"mail"").val();
            var mobile = $(""#Edit_Mobile"").val();
            var password = $(""#Edit_Password"").val();

            var postData = {
                'userID': userId,
                'fullName': fullName,
                'email': email,
                'mobile': mobile,
                'password': password
            };


            $.ajax({
                contentType: 'application/x-www-form-urlencoded',
                dataType: 'json',
                type: ""POST"",
                url: ""/admin/user/Edit"",
                data: postData,
                success: function (data) {
                    if (data.isSuccess == true) {
                        swal.fire(
                            'موفق!',
                            data.message,
                            'success'
                        ).then(function (isConfirm) {
                            location.reload();
                        });
                    }
                    else {
       ");
                WriteLiteral(@"                 swal.fire(
                            'هشدار!',
                            data.message,
                            'warning'
                        );
                    }
                },
                error: function (request, status, error) {
                    alert(request.responseText);
                }
            });

            $('#EditUser').modal('hide');

        }



        function ShowModalEdituser(UserID, FullName, Email, Password, Mobile) {
            $('#Edit_FullName').val(FullName)
            $('#Edit_Email').val(Email)
            $('#Edit_UserId').val(UserID)
            //$('#Edit_Password').val(Password)
            $('#Edit_Mobile').val(Mobile)


            $('#EditUser').modal('show');

        }

    </script>
");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Modal", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@">

    <div class=""modal fade"" id=""EditUser"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">ویرایش</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d6378e39083af1747eab8e388610de3d436959e27774", async() => {
                    WriteLiteral(@"
                        <div class=""form-group"">

                            <input type=""hidden"" id=""Edit_UserId"" />
                        </div>

                        <div class=""form-group"">
                            <label for=""recipient-name"" class=""col-form-label"">نام و نام خانوادگی :</label>
                            <input type=""text"" class=""form-control"" id=""Edit_FullName"">
                        </div>
                        <div class=""form-group"">
                            <label for=""recipient-name"" class=""col-form-label"">ایمیل :</label>
                            <input type=""text"" class=""form-control"" id=""Edit_Email"">
                        </div>
                        <div class=""form-group"">
                            <label for=""recipient-name"" class=""col-form-label"">موبایل :</label>
                            <input type=""text"" class=""form-control"" id=""Edit_Mobile"">
                        </div>
                        <div class=""form-group"">
      ");
                    WriteLiteral("                      <label for=\"recipient-name\" class=\"col-form-label\">رمز عبور جدید :</label>\r\n                            <input type=\"text\" class=\"form-control\" id=\"Edit_Password\">\r\n                        </div>\r\n                    ");
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
                WriteLiteral(@"
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">لغو عملیات</button>
                    <button onclick=""Edituser()"" type=""button"" class=""btn btn-success "">ثبت</button>
                </div>
            </div>
        </div>
    </div>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MyCms.Application.Services.User.Query.GetUsers.GetUsersDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591