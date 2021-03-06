#pragma checksum "D:\پروژه سایت خبری (First Project In Asp.Net Core)\MyCms\EndPoint.Site\Areas\Admin\Views\User\GetUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97bb67e5f625e2a0ebda1b3f2e315698a28ce596"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_GetUsers), @"mvc.1.0.view", @"/Areas/Admin/Views/User/GetUsers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97bb67e5f625e2a0ebda1b3f2e315698a28ce596", @"/Areas/Admin/Views/User/GetUsers.cshtml")]
    public class Areas_Admin_Views_User_GetUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MyCms.Application.Services.User.Query.GetUsersInRole.UserInRoleDto>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\پروژه سایت خبری (First Project In Asp.Net Core)\MyCms\EndPoint.Site\Areas\Admin\Views\User\GetUsers.cshtml"
  
    ViewData["Title"] = "GetUsers";
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
                                <div id=""DataTables_Table_0_wrapper"" class=""dataTables_wrapper container-fluid dt-bootstrap4"">
");
            WriteLiteral(@"                                    <div class=""row""><div class=""col-sm-12 col-md-6""><div class=""dataTables_length"" id=""DataTables_Table_0_length""><label>نمایش <select name=""DataTables_Table_0_length"" aria-controls=""DataTables_Table_0"" class=""form-control form-control-sm""><option value=""10"">10</option><option value=""25"">25</option><option value=""50"">50</option><option value=""100"">100</option></select> سطر</label></div></div><div class=""col-sm-12 col-md-6""><div id=""DataTables_Table_0_filter"" class=""dataTables_filter""><label>جستجو:<input type=""search"" onclick=""~/Admin/user / index ? searchKey = searchKey"" name=""searchKey"" class=""form-control form-control-sm""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 1879, "\"", 1893, 0);
            EndWriteAttribute();
            WriteLiteral(@" aria-controls=""DataTables_Table_0""></label></div></div></div><div class=""row"">
                                        <button class=""order-6"" onclick=""~/Admin/user / index ? searchKey = searchKey"">
                                            جستحو
                                        </button>
                                        <div class=""col-sm-12"">
                                            <table class=""table table-striped table-bordered zero-configuration dataTable"" id=""DataTables_Table_0"" role=""grid"" aria-describedby=""DataTables_Table_0_info"">
                                                <thead>
                                                    <tr role=""row"">
                                                        <th class=""sorting_asc"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""نام: activate to sort column descending"" style=""width: 222px;"">نام</th>
                                                        <th class=");
            WriteLiteral(@"""sorting"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" aria-label=""ایمیل: activate to sort column ascending"" style=""width: 401px;"">ایمیل</th>
                                                        <th class=""sorting"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" aria-label=""موبایل: activate to sort column ascending"" style=""width: 401px;"">موبایل</th>
                                                    </tr>
                                                </thead>
                                                <tbody>

");
#nullable restore
#line 40 "D:\پروژه سایت خبری (First Project In Asp.Net Core)\MyCms\EndPoint.Site\Areas\Admin\Views\User\GetUsers.cshtml"
                                                     foreach (var item in Model)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <tr role=\"row\" class=\"odd\">\r\n                                                            <td class=\"sorting_1\">");
#nullable restore
#line 43 "D:\پروژه سایت خبری (First Project In Asp.Net Core)\MyCms\EndPoint.Site\Areas\Admin\Views\User\GetUsers.cshtml"
                                                                             Write(item.User.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 44 "D:\پروژه سایت خبری (First Project In Asp.Net Core)\MyCms\EndPoint.Site\Areas\Admin\Views\User\GetUsers.cshtml"
                                                           Write(item.User.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 45 "D:\پروژه سایت خبری (First Project In Asp.Net Core)\MyCms\EndPoint.Site\Areas\Admin\Views\User\GetUsers.cshtml"
                                                           Write(item.User.Mobile);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>\r\n                                                                <button class=\"btn btn-info\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4165, "\"", 4295, 15);
            WriteAttributeValue("", 4175, "ShowModalEdituser(\'", 4175, 19, true);
#nullable restore
#line 47 "D:\پروژه سایت خبری (First Project In Asp.Net Core)\MyCms\EndPoint.Site\Areas\Admin\Views\User\GetUsers.cshtml"
WriteAttributeValue("", 4194, item.UserID, 4194, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4206, "\',", 4206, 2, true);
            WriteAttributeValue(" ", 4208, "\'", 4209, 2, true);
#nullable restore
#line 47 "D:\پروژه سایت خبری (First Project In Asp.Net Core)\MyCms\EndPoint.Site\Areas\Admin\Views\User\GetUsers.cshtml"
WriteAttributeValue("", 4210, item.User.FullName, 4210, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4229, "\',", 4229, 2, true);
            WriteAttributeValue(" ", 4231, "\'", 4232, 2, true);
#nullable restore
#line 47 "D:\پروژه سایت خبری (First Project In Asp.Net Core)\MyCms\EndPoint.Site\Areas\Admin\Views\User\GetUsers.cshtml"
WriteAttributeValue("", 4233, item.User.Email, 4233, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4249, "\',", 4249, 2, true);
            WriteAttributeValue(" ", 4251, "\'", 4252, 2, true);
#nullable restore
#line 47 "D:\پروژه سایت خبری (First Project In Asp.Net Core)\MyCms\EndPoint.Site\Areas\Admin\Views\User\GetUsers.cshtml"
WriteAttributeValue("", 4253, item.User.Password, 4253, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4272, "\',", 4272, 2, true);
            WriteAttributeValue(" ", 4274, "\'", 4275, 2, true);
#nullable restore
#line 47 "D:\پروژه سایت خبری (First Project In Asp.Net Core)\MyCms\EndPoint.Site\Areas\Admin\Views\User\GetUsers.cshtml"
WriteAttributeValue("", 4276, item.User.Mobile, 4276, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4293, "\')", 4293, 2, true);
            EndWriteAttribute();
            WriteLiteral(">ویرایش</button>\r\n                                                                <button class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4408, "\"", 4444, 3);
            WriteAttributeValue("", 4418, "DeleteUser(\'", 4418, 12, true);
#nullable restore
#line 48 "D:\پروژه سایت خبری (First Project In Asp.Net Core)\MyCms\EndPoint.Site\Areas\Admin\Views\User\GetUsers.cshtml"
WriteAttributeValue("", 4430, item.UserID, 4430, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4442, "\')", 4442, 2, true);
            EndWriteAttribute();
            WriteLiteral(">حذف</button>\r\n");
#nullable restore
#line 49 "D:\پروژه سایت خبری (First Project In Asp.Net Core)\MyCms\EndPoint.Site\Areas\Admin\Views\User\GetUsers.cshtml"
                                                                 if (item.User.IsActive)
                                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                    <button class=\"btn btn-warning\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4716, "\"", 4757, 3);
            WriteAttributeValue("", 4726, "UserSatusChange(\'", 4726, 17, true);
#nullable restore
#line 51 "D:\پروژه سایت خبری (First Project In Asp.Net Core)\MyCms\EndPoint.Site\Areas\Admin\Views\User\GetUsers.cshtml"
WriteAttributeValue("", 4743, item.UserID, 4743, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4755, "\')", 4755, 2, true);
            EndWriteAttribute();
            WriteLiteral(">غیر فعال کن</button>\r\n");
#nullable restore
#line 52 "D:\پروژه سایت خبری (First Project In Asp.Net Core)\MyCms\EndPoint.Site\Areas\Admin\Views\User\GetUsers.cshtml"
                                                                }
                                                                else
                                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                    <button class=\"btn btn-warning\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5084, "\"", 5125, 3);
            WriteAttributeValue("", 5094, "UserSatusChange(\'", 5094, 17, true);
#nullable restore
#line 55 "D:\پروژه سایت خبری (First Project In Asp.Net Core)\MyCms\EndPoint.Site\Areas\Admin\Views\User\GetUsers.cshtml"
WriteAttributeValue("", 5111, item.UserID, 5111, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5123, "\')", 5123, 2, true);
            EndWriteAttribute();
            WriteLiteral("> فعال کن</button>\r\n");
#nullable restore
#line 56 "D:\پروژه سایت خبری (First Project In Asp.Net Core)\MyCms\EndPoint.Site\Areas\Admin\Views\User\GetUsers.cshtml"
                                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            </td>\r\n                                                        </tr>\r\n");
#nullable restore
#line 59 "D:\پروژه سایت خبری (First Project In Asp.Net Core)\MyCms\EndPoint.Site\Areas\Admin\Views\User\GetUsers.cshtml"
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "97bb67e5f625e2a0ebda1b3f2e315698a28ce59617474", async() => {
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
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97bb67e5f625e2a0ebda1b3f2e315698a28ce59618657", async() => {
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



        function DeleteUser(UserId) {
            swal.fire({
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
");
                WriteLiteral(@"                                swal.fire(
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


        function Edituser() {

            var userId = $(""#Edit_UserId"").val();
         ");
                WriteLiteral(@"   var fullName = $(""#Edit_FullName"").val();
            var email = $(""#Edit_Email"").val();
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
       ");
                WriteLiteral(@"                 });
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



        function UserSatusChange(UserId) {
            swal.fire({
                title: 'تغییر وضعیت کاربر',
                text: ""کاربر ");
                WriteLiteral(@"گرامی از تغییر وضعیت کاربر مطمئن هستید؟"",
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
                            if (data.isSuccess == true) {
                                swal.fire(
                                    'موفق!',
                                  ");
                WriteLiteral(@"  data.message,
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
                    <form>
                        <div class=""form-group"">

                            <input type=""hidden"" id=""Edit_UserId"" />
                        </div>

                        <div class=""form-group"">
                            <label for=""recipient-name"" class=""col-form-label"">نام و نام خانوادگی :</label>
                            <input type=""text"" class=""form-control"" id=""");
                WriteLiteral(@"Edit_FullName"">
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
                            <label for=""recipient-name"" class=""col-form-label"">رمز عبور جدید :</label>
                            <input type=""text"" class=""form-control"" id=""Edit_Password"">
                        </div>
                    </form>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-danger"" data-dis");
                WriteLiteral("miss=\"modal\">لغو عملیات</button>\r\n                    <button onclick=\"Edituser()\" type=\"button\" class=\"btn btn-success \">ثبت</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MyCms.Application.Services.User.Query.GetUsersInRole.UserInRoleDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
