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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/SiteManage/Views/VersionInfo/_/Create.cshtml")]
    public partial class _Areas_SiteManage_Views_VersionInfo___Create_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_SiteManage_Views_VersionInfo___Create_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 2 "..\..\Areas\SiteManage\Views\VersionInfo\_\Create.cshtml"
  
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
    ViewBag.Title="新建版本记录";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" region=\"center\"");

WriteLiteral(" border=\"true\"");

WriteLiteral(" style=\"padding: 10px; background: #FFFFFF; border: 1px solid #ccc;\"");

WriteLiteral(">\r\n    <form");

WriteLiteral(" id=\"myForm\"");

WriteLiteral(" name=\"myForm\"");

WriteLiteral(" action=\"/api/SiteManage/VersionInfo/Create\"");

WriteLiteral(" method=\"post\"");

WriteLiteral(">\r\n        <table");

WriteLiteral(" class=\"mytable\"");

WriteLiteral("  cellpadding=\"1\"");

WriteLiteral(" width=\"100%\"");

WriteLiteral(" cellspacing=\"0\"");

WriteLiteral(" align=\"center\"");

WriteLiteral(">\r\n<tr");

WriteLiteral(" id=\"Container_Major\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">主版本号：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"Major\"");

WriteLiteral(" name=\"Major\"");

WriteAttribute("value", Tuple.Create(" value=\"", 831), Tuple.Create("\"", 853)
            
            #line 22 "..\..\Areas\SiteManage\Views\VersionInfo\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 839), Tuple.Create<System.Object, System.Int32>(Model.Major
            
            #line default
            #line hidden
, 839), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"4\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">次版本号：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"Minor\"");

WriteLiteral(" name=\"Minor\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1020), Tuple.Create("\"", 1042)
            
            #line 25 "..\..\Areas\SiteManage\Views\VersionInfo\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 1028), Tuple.Create<System.Object, System.Int32>(Model.Minor
            
            #line default
            #line hidden
, 1028), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"4\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_Build\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">内部版本号：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"Build\"");

WriteLiteral(" name=\"Build\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1244), Tuple.Create("\"", 1266)
            
            #line 30 "..\..\Areas\SiteManage\Views\VersionInfo\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 1252), Tuple.Create<System.Object, System.Int32>(Model.Build
            
            #line default
            #line hidden
, 1252), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"4\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">修订版本号：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"Revision\"");

WriteLiteral(" name=\"Revision\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1440), Tuple.Create("\"", 1465)
            
            #line 33 "..\..\Areas\SiteManage\Views\VersionInfo\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 1448), Tuple.Create<System.Object, System.Int32>(Model.Revision
            
            #line default
            #line hidden
, 1448), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"4\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_CreatedDate\"");

WriteLiteral(">\r\n<td");

WriteLiteral("  class=\"labeltd\"");

WriteLiteral(">创建日期：</td><td");

WriteLiteral("  colspan=\"3\"");

WriteLiteral(" >&nbsp;    <input");

WriteLiteral(" class=\"Wdate\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" onClick=\"WdatePicker({dateFmt:\'yyyy-MM-dd HH:mm:ss\'})\"");

WriteLiteral(" id=\"CreatedDate\"");

WriteLiteral(" name=\"CreatedDate\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1770), Tuple.Create("\"", 1857)
            
            #line 37 "..\..\Areas\SiteManage\Views\VersionInfo\_\Create.cshtml"
                                                                                                               , Tuple.Create(Tuple.Create("", 1778), Tuple.Create<System.Object, System.Int32>(Model.CreatedDate==null?"":Model.CreatedDate.ToString("yyyy-MM-dd HH:mm:ss")
            
            #line default
            #line hidden
, 1778), false)
);

WriteLiteral(" style=\"width:135px;\"");

WriteLiteral(">\r\n</td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_ChangeLog\"");

WriteLiteral(">\r\n<td");

WriteLiteral("  class=\"labeltd\"");

WriteLiteral(">更新日志：</td><td");

WriteLiteral("  colspan=\"3\"");

WriteLiteral(" >&nbsp;\r\n<textarea");

WriteLiteral(" id=\"ChangeLog\"");

WriteLiteral(" name=\"ChangeLog\"");

WriteLiteral(" class=\"easyui-validatebox\"");

WriteLiteral("  style=\"width:95%;height:200px\"");

WriteLiteral(">");

            
            #line 42 "..\..\Areas\SiteManage\Views\VersionInfo\_\Create.cshtml"
                                                                                                 Write(Model.ChangeLog);

            
            #line default
            #line hidden
WriteLiteral("</textarea>\r\n</td>\r\n</tr>\r\n\r\n</table>\r\n\r\n");

WriteLiteral("        ");

            
            #line 48 "..\..\Areas\SiteManage\Views\VersionInfo\_\Create.cshtml"
   Write(RenderPage("~/Areas/SiteManage/Views/VersionInfo/Extend/Model_FormHtml.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </form>\r\n</div>\r\n<div");

WriteLiteral(" region=\"south\"");

WriteLiteral(" border=\"false\"");

WriteLiteral(" style=\"text-align: right; background: #F6F6F6;height: 30px; line-height: 30px;\"");

WriteLiteral(">\r\n    <a");

WriteLiteral(" id=\"btnSubmit\"");

WriteLiteral(" class=\"easyui-linkbutton\"");

WriteLiteral(" icon=\"icon-ok\"");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(">确定</a>\r\n    <a");

WriteLiteral(" id=\"btnCancel\"");

WriteLiteral(" class=\"easyui-linkbutton\"");

WriteLiteral(" icon=\"icon-cancel\"");

WriteLiteral(" href=\"javascript:CloseDialog();\"");

WriteLiteral(">\r\n        取消\r\n    </a>\r\n</div>\r\n");

DefineSection("scripts", () => {

WriteLiteral("\r\n    <script");

WriteLiteral(" src=\"/Resources/JsLib/jquery.form.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/Resources/JsLib/My97DatePicker/WdatePicker.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/Static/v1/js/Utils.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/Static/v1/js/form.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
        jQuery(function() {
            CheckConditions();
function CheckConditions(){
jQuery('fieldset').show(); 
jQuery(""fieldset"").each(function(){ 
if(jQuery('tr',this).length>0){
if(jQuery('tr:visible',this).length>0){jQuery(this).show()} else{jQuery(this).hide()}
}
});
}
;
        });
    </script>
");

WriteLiteral("    ");

            
            #line 76 "..\..\Areas\SiteManage\Views\VersionInfo\_\Create.cshtml"
Write(RenderPage("~/Areas/SiteManage/Views/VersionInfo/Extend/Model_FormJs.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591