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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/UCenter/Views/Department/_/Edit.cshtml")]
    public partial class _Areas_UCenter_Views_Department___Edit_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_UCenter_Views_Department___Edit_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 2 "..\..\Areas\UCenter\Views\Department\_\Edit.cshtml"
  
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
    ViewBag.Title="编辑部门";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" region=\"center\"");

WriteLiteral(" border=\"true\"");

WriteLiteral(" style=\"padding: 10px; background: #FFFFFF; border: 1px solid #ccc;\"");

WriteLiteral(">\r\n    <form");

WriteLiteral(" id=\"myForm\"");

WriteLiteral(" name=\"myForm\"");

WriteLiteral(" action=\"/api/UCenter/Department/Edit\"");

WriteLiteral(" method=\"post\"");

WriteLiteral(">\r\n        <table");

WriteLiteral(" class=\"mytable\"");

WriteLiteral("  cellpadding=\"1\"");

WriteLiteral(" width=\"100%\"");

WriteLiteral(" cellspacing=\"0\"");

WriteLiteral(" align=\"center\"");

WriteLiteral(">\r\n<tr");

WriteLiteral(" id=\"Container_DepartmentID\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_DepartmentID\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">部门ID：</td><td>&nbsp;<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"DepartmentID\"");

WriteLiteral("  name=\"DepartmentID\"");

WriteAttribute("value", Tuple.Create(" value=\"", 867), Tuple.Create("\"", 896)
            
            #line 20 "..\..\Areas\UCenter\Views\Department\_\Edit.cshtml"
                                                                                     , Tuple.Create(Tuple.Create("", 875), Tuple.Create<System.Object, System.Int32>(Model.DepartmentID
            
            #line default
            #line hidden
, 875), false)
);

WriteLiteral("/><span");

WriteLiteral(" id=\"DepartmentID_ShowValue\"");

WriteLiteral(">");

            
            #line 20 "..\..\Areas\UCenter\Views\Department\_\Edit.cshtml"
                                                                                                                                                                                                                         Write(Model.DepartmentID);

            
            #line default
            #line hidden
WriteLiteral("</span></td></tr>\r\n<tr");

WriteLiteral(" id=\"Container_DepartmentName\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_DepartmentName\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">部门名称：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"DepartmentName\"");

WriteLiteral(" name=\"DepartmentName\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1135), Tuple.Create("\"", 1166)
            
            #line 22 "..\..\Areas\UCenter\Views\Department\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 1143), Tuple.Create<System.Object, System.Int32>(Model.DepartmentName
            
            #line default
            #line hidden
, 1143), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral(" required=\"true\"");

WriteLiteral("  maxlength=\"30\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td></tr>\r\n<tr");

WriteLiteral(" id=\"Container_ParentID\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_ParentID\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">上级部门：</td><td>&nbsp;\r\n\r\n<input");

WriteLiteral(" id=\"ParentID\"");

WriteLiteral(" name=\"ParentID\"");

WriteAttribute("url", Tuple.Create(" url=\"", 1399), Tuple.Create("\"", 1472)
, Tuple.Create(Tuple.Create("", 1405), Tuple.Create("/api/UCenter/Department/EditTree?&iscombo=1&Value=", 1405), true)
            
            #line 26 "..\..\Areas\UCenter\Views\Department\_\Edit.cshtml"
             , Tuple.Create(Tuple.Create("", 1455), Tuple.Create<System.Object, System.Int32>(Model.ParentID
            
            #line default
            #line hidden
, 1455), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 1473), Tuple.Create("\"", 1498)
            
            #line 26 "..\..\Areas\UCenter\Views\Department\_\Edit.cshtml"
                                       , Tuple.Create(Tuple.Create("", 1481), Tuple.Create<System.Object, System.Int32>(Model.ParentID
            
            #line default
            #line hidden
, 1481), false)
);

WriteLiteral(" style=\"width: 200px\"");

WriteLiteral(" />\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n    var ParentID_Value = \'");

            
            #line 28 "..\..\Areas\UCenter\Views\Department\_\Edit.cshtml"
                      Write(Model.ParentID);

            
            #line default
            #line hidden
WriteLiteral(@"';
    jQuery(function() {
        jQuery('#ParentID').combotree(
        {
            onLoadSuccess:function(node, data) {
                jQuery('#ParentID').combotree('setValue',ParentID_Value);
            }
        });
    });
</script>
</td></tr>
<tr");

WriteLiteral(" id=\"Container_OrderID\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_OrderID\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">排序ID：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"OrderID\"");

WriteLiteral(" name=\"OrderID\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2000), Tuple.Create("\"", 2024)
            
            #line 40 "..\..\Areas\UCenter\Views\Department\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 2008), Tuple.Create<System.Object, System.Int32>(Model.OrderID
            
            #line default
            #line hidden
, 2008), false)
);

WriteLiteral(" class=\"easyui-numberbox\"");

WriteLiteral(" min=\"0\"");

WriteLiteral(" max=\"10000\"");

WriteLiteral("  style=\"width:200px;\"");

WriteLiteral("/>\r\n</td></tr>\r\n<tr");

WriteLiteral(" id=\"Container_ContactName\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_ContactName\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">联系人：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"ContactName\"");

WriteLiteral(" name=\"ContactName\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2257), Tuple.Create("\"", 2285)
            
            #line 43 "..\..\Areas\UCenter\Views\Department\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 2265), Tuple.Create<System.Object, System.Int32>(Model.ContactName
            
            #line default
            #line hidden
, 2265), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"30\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td></tr>\r\n<tr");

WriteLiteral(" id=\"Container_Phone\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_Phone\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">联系方式：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"Phone\"");

WriteLiteral(" name=\"Phone\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2500), Tuple.Create("\"", 2522)
            
            #line 46 "..\..\Areas\UCenter\Views\Department\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 2508), Tuple.Create<System.Object, System.Int32>(Model.Phone
            
            #line default
            #line hidden
, 2508), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral(" validType=\"phone\"");

WriteLiteral("  [\'/\\^\\[1-9]d\\{5}\\$/\'] maxlength=\"30\" style=\"width:200px\" />\r\n</td></tr>\r\n<tr");

WriteLiteral(" id=\"Container_Tips\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_Tips\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">备注：</td><td>&nbsp;\r\n<textarea");

WriteLiteral(" id=\"Tips\"");

WriteLiteral(" name=\"Tips\"");

WriteLiteral(" class=\"easyui-validatebox\"");

WriteLiteral("  style=\"width:180px;height:100px\"");

WriteLiteral(">");

            
            #line 49 "..\..\Areas\UCenter\Views\Department\_\Edit.cshtml"
                                                                                         Write(Model.Tips);

            
            #line default
            #line hidden
WriteLiteral("</textarea>\r\n</td></tr>\r\n\r\n</table>\r\n\r\n");

WriteLiteral("        ");

            
            #line 54 "..\..\Areas\UCenter\Views\Department\_\Edit.cshtml"
   Write(RenderPage("~/Areas/UCenter/Views/Department/Extend/Model_FormHtml.cshtml"));

            
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

            
            #line 82 "..\..\Areas\UCenter\Views\Department\_\Edit.cshtml"
Write(RenderPage("~/Areas/UCenter/Views/Department/Extend/Model_FormJs.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
