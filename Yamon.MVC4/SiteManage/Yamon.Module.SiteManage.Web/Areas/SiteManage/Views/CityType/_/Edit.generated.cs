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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/SiteManage/Views/CityType/_/Edit.cshtml")]
    public partial class _Areas_SiteManage_Views_CityType___Edit_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_SiteManage_Views_CityType___Edit_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 2 "..\..\Areas\SiteManage\Views\CityType\_\Edit.cshtml"
  
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
    ViewBag.Title="编辑站点类型";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" region=\"center\"");

WriteLiteral(" border=\"true\"");

WriteLiteral(" style=\"padding: 10px; background: #F6F6F6; border: 1px solid #ccc;\"");

WriteLiteral(">\r\n    <form");

WriteLiteral(" id=\"myForm\"");

WriteLiteral(" name=\"myForm\"");

WriteLiteral(" action=\"/SiteManage/CityType/EditAction\"");

WriteLiteral(" method=\"post\"");

WriteLiteral(">\r\n        <table");

WriteLiteral(" class=\"mytable\"");

WriteLiteral("  cellpadding=\"1\"");

WriteLiteral(" width=\"100%\"");

WriteLiteral(" cellspacing=\"0\"");

WriteLiteral(" align=\"center\"");

WriteLiteral(">\r\n<tr");

WriteLiteral(" id=\"Container_CityTypeID\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_CityTypeID\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">ID：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"CityTypeID\"");

WriteLiteral(" name=\"CityTypeID\"");

WriteAttribute("value", Tuple.Create(" value=\"", 861), Tuple.Create("\"", 888)
            
            #line 21 "..\..\Areas\SiteManage\Views\CityType\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 869), Tuple.Create<System.Object, System.Int32>(Model.CityTypeID
            
            #line default
            #line hidden
, 869), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral(" required=\"true\"");

WriteLiteral("  maxlength=\"20\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td></tr>\r\n<tr");

WriteLiteral(" id=\"Container_CityTypeName\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_CityTypeName\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">站点类型名称：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"CityTypeName\"");

WriteLiteral(" name=\"CityTypeName\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1149), Tuple.Create("\"", 1178)
            
            #line 24 "..\..\Areas\SiteManage\Views\CityType\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 1157), Tuple.Create<System.Object, System.Int32>(Model.CityTypeName
            
            #line default
            #line hidden
, 1157), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral(" required=\"true\"");

WriteLiteral("  maxlength=\"50\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td></tr>\r\n<tr");

WriteLiteral(" id=\"Container_Description\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_Description\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">描述：</td><td>&nbsp;\r\n<textarea");

WriteLiteral(" id=\"Description\"");

WriteLiteral(" name=\"Description\"");

WriteLiteral(" class=\"easyui-validatebox\"");

WriteLiteral("  style=\"width:300px;height:40px\"");

WriteLiteral(">");

            
            #line 27 "..\..\Areas\SiteManage\Views\CityType\_\Edit.cshtml"
                                                                                                      Write(Model.Description);

            
            #line default
            #line hidden
WriteLiteral("</textarea>\r\n</td></tr>\r\n<tr");

WriteLiteral(" id=\"Container_OrderID\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_OrderID\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">排序：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"OrderID\"");

WriteLiteral(" name=\"OrderID\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1660), Tuple.Create("\"", 1684)
            
            #line 30 "..\..\Areas\SiteManage\Views\CityType\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 1668), Tuple.Create<System.Object, System.Int32>(Model.OrderID
            
            #line default
            #line hidden
, 1668), false)
);

WriteLiteral(" class=\"easyui-numberbox\"");

WriteLiteral(" min=\"0\"");

WriteLiteral(" max=\"1000\"");

WriteLiteral("  style=\"width:200px;\"");

WriteLiteral("/>\r\n</td></tr>\r\n\r\n</table>\r\n\r\n");

WriteLiteral("        ");

            
            #line 35 "..\..\Areas\SiteManage\Views\CityType\_\Edit.cshtml"
   Write(RenderPage("~/Areas/SiteManage/Views/CityType/Extend/Model_FormHtml.cshtml"));

            
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
        jQuery(function () {
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

});

WriteLiteral(";\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
