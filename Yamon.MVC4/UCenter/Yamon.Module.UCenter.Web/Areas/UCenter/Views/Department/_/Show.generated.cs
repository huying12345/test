﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Yamon.Framework.Common;
    using Yamon.Module.SiteManage.Entity;
    using Yamon.Module.UCenter;
    using Yamon.Module.UCenter.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/UCenter/Views/Department/_/Show.cshtml")]
    public partial class _Areas_UCenter_Views_Department___Show_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_UCenter_Views_Department___Show_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 2 "..\..\Areas\UCenter\Views\Department\_\Show.cshtml"
  
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由亚萌智能表单代码生成工具生成。
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。除非此项目不再使用代码生成器生成。
//     如果想修改此文件的内容，请复制一份到此文件的上级目录进行修改
//
//     如有问题联系zongeasy@qq.com
//</auto-generated>
//------------------------------------------------------------------------------

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" region=\"center\"");

WriteLiteral(" border=\"true\"");

WriteLiteral(" style=\"padding: 10px; background: #F6F6F6; border: 1px solid #ccc;\"");

WriteLiteral(">\r\n    <form");

WriteLiteral(" id=\"myForm\"");

WriteLiteral(" name=\"myForm\"");

WriteLiteral(" action=\"/api/UCenter/Department/Show\"");

WriteLiteral(" method=\"post\"");

WriteLiteral(">\r\n        <table");

WriteLiteral(" class=\"mytable\"");

WriteLiteral("  cellpadding=\"1\"");

WriteLiteral(" width=\"100%\"");

WriteLiteral(" cellspacing=\"0\"");

WriteLiteral(" align=\"center\"");

WriteLiteral(">\r\n<tr");

WriteLiteral(" id=\"Container_ParentID\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_ParentID\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">上级部门：</td><td>&nbsp;<span");

WriteLiteral(" id=\"ParentID\"");

WriteLiteral(">");

            
            #line 18 "..\..\Areas\UCenter\Views\Department\_\Show.cshtml"
                                                                                                        Write(Html.Raw(Model.ParentID_ShowValue));

            
            #line default
            #line hidden
WriteLiteral("</span></td></tr>\r\n<tr");

WriteLiteral(" id=\"Container_OrderID\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_OrderID\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">排序ID：</td><td>&nbsp;<span");

WriteLiteral(" id=\"OrderID\"");

WriteLiteral(">");

            
            #line 19 "..\..\Areas\UCenter\Views\Department\_\Show.cshtml"
                                                                                                     Write(Html.Raw(Model.OrderID));

            
            #line default
            #line hidden
WriteLiteral("</span></td></tr>\r\n<tr");

WriteLiteral(" id=\"Container_EmployeeNum\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_EmployeeNum\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">成员数量：</td><td>&nbsp;<span");

WriteLiteral(" id=\"EmployeeNum\"");

WriteLiteral(">");

            
            #line 20 "..\..\Areas\UCenter\Views\Department\_\Show.cshtml"
                                                                                                                 Write(Html.Raw(Model.EmployeeNum));

            
            #line default
            #line hidden
WriteLiteral("</span></td></tr>\r\n\r\n</table>\r\n\r\n");

WriteLiteral("        ");

            
            #line 24 "..\..\Areas\UCenter\Views\Department\_\Show.cshtml"
   Write(RenderPage("~/Areas/UCenter/Views/Department/Extend/Model_ViewHtml.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </form>\r\n</div>\r\n<div");

WriteLiteral(" region=\"south\"");

WriteLiteral(" border=\"false\"");

WriteLiteral(" style=\"text-align: right; background: #F6F6F6;height: 30px; line-height: 30px;\"");

WriteLiteral(">\r\n    <a");

WriteLiteral(" id=\"btnCancel\"");

WriteLiteral(" class=\"easyui-linkbutton\"");

WriteLiteral(" icon=\"icon-cancel\"");

WriteLiteral(" href=\"javascript:CloseDialog();\"");

WriteLiteral(">\r\n        关闭\r\n    </a>\r\n</div>\r\n");

            
            #line 32 "..\..\Areas\UCenter\Views\Department\_\Show.cshtml"
Write(RenderPage("~/Areas/UCenter/Views/Department/Extend/Model_ViewJs.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
