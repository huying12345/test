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
    using System.Data;
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
    using Yamon.Module.SiteManage;
    using Yamon.Module.SiteManage.Entity;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/SiteManage/Views/Menu/_/ImportFromExcel.cshtml")]
    public partial class _Areas_SiteManage_Views_Menu___ImportFromExcel_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_SiteManage_Views_Menu___ImportFromExcel_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 2 "..\..\Areas\SiteManage\Views\Menu\_\ImportFromExcel.cshtml"
  
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

WriteLiteral(" action=\"/api/SiteManage/Menu/ImportFromExcel\"");

WriteLiteral(" method=\"post\"");

WriteLiteral(">\r\n        <table");

WriteLiteral(" width=\'100%\'");

WriteLiteral(" border=\'0\'");

WriteLiteral(" align=\'center\'");

WriteLiteral(" cellpadding=\'1\'");

WriteLiteral(" cellspacing=\'1\'");

WriteLiteral(" class=\'mytable\'");

WriteLiteral(">\r\n            <tr>\r\n                <td");

WriteLiteral(" class=\'trbg3\'");

WriteLiteral(" align=\"right\"");

WriteLiteral(">\r\n                    选择Excel路径：\r\n                </td>\r\n                <td");

WriteLiteral(" class=\'trbg1\'");

WriteLiteral(">\r\n                    <input");

WriteLiteral(" type=\"file\"");

WriteLiteral(" id=\"ExcelFile\"");

WriteLiteral(" name=\"ExcelFile\"");

WriteLiteral(" />\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                " +
"<td");

WriteLiteral(" class=\'trbg3\'");

WriteLiteral(" align=\"right\"");

WriteLiteral(">\r\n                    模板下载：\r\n                </td>\r\n                <td");

WriteLiteral(" class=\'trbg1\'");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" href=\"/Static/SiteManage/template/菜单导入模板.xls\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">下载</a>\r\n                </td>\r\n            </tr>\r\n        </table>\r\n    </form>\r" +
"\n</div>\r\n<div");

WriteLiteral(" region=\"south\"");

WriteLiteral(" border=\"false\"");

WriteLiteral(" style=\"text-align: right; background: #F6F6F6;\r\n        height: 30px; line-heigh" +
"t: 30px;\"");

WriteLiteral(">\r\n    <a");

WriteLiteral(" id=\"btnSubmit\"");

WriteLiteral(" class=\"easyui-linkbutton\"");

WriteLiteral(" icon=\"icon-ok\"");

WriteLiteral(" href=\"\"");

WriteLiteral(">导 入</a>\r\n    <a");

WriteLiteral(" id=\"btnCancel\"");

WriteLiteral(" class=\"easyui-linkbutton\"");

WriteLiteral(" icon=\"icon-cancel\"");

WriteLiteral(" href=\"javascript:CloseDialog();\"");

WriteLiteral(">\r\n        取消\r\n    </a>\r\n</div>\r\n");

DefineSection("scripts", () => {

WriteLiteral("\r\n    <script");

WriteLiteral(" src=\"/Resources/JsLib/jquery.form.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/Static/v1/js/form.js\"");

WriteLiteral("></script>\r\n");

});

        }
    }
}
#pragma warning restore 1591
