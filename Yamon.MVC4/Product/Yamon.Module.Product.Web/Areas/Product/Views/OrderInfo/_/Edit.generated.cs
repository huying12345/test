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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Product/Views/OrderInfo/_/Edit.cshtml")]
    public partial class _Areas_Product_Views_OrderInfo___Edit_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Product_Views_OrderInfo___Edit_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 2 "..\..\Areas\Product\Views\OrderInfo\_\Edit.cshtml"
  
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
    ViewBag.Title="编辑订单";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" region=\"center\"");

WriteLiteral(" border=\"true\"");

WriteLiteral(" style=\"padding: 10px; background: #FFFFFF; border: 1px solid #ccc;\"");

WriteLiteral(">\r\n    <form");

WriteLiteral(" id=\"myForm\"");

WriteLiteral(" name=\"myForm\"");

WriteLiteral(" action=\"/api/Product/OrderInfo/Edit\"");

WriteLiteral(" method=\"post\"");

WriteLiteral(">\r\n        <table");

WriteLiteral(" class=\"mytable\"");

WriteLiteral("  cellpadding=\"1\"");

WriteLiteral(" width=\"100%\"");

WriteLiteral(" cellspacing=\"0\"");

WriteLiteral(" align=\"center\"");

WriteLiteral(">\r\n<tr");

WriteLiteral(" id=\"Container_MemberID\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">会员：</td><td>&nbsp;\r\n<select");

WriteLiteral(" id=\"MemberID\"");

WriteLiteral(" class=\"easyui-combobox\"");

WriteLiteral(" name=\"MemberID\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(">\r\n<option");

WriteLiteral(" value=\"\"");

WriteLiteral(">请选择</option>\r\n");

            
            #line 24 "..\..\Areas\Product\Views\OrderInfo\_\Edit.cshtml"
Write(Html.Raw(MyHtmlHelper2.ShowSelectOptions(ViewBag.DAL.NameValue_MemberID, Model.MemberID)));

            
            #line default
            #line hidden
WriteLiteral("\r\n</select></td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">创建时间：</td><td>&nbsp;    <input");

WriteLiteral(" class=\"Wdate\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" onClick=\"WdatePicker({dateFmt:\'yyyy-MM-dd HH:mm:ss\'})\"");

WriteLiteral(" id=\"CreateTime\"");

WriteLiteral(" name=\"CreateTime\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1169), Tuple.Create("\"", 1254)
            
            #line 26 "..\..\Areas\Product\Views\OrderInfo\_\Edit.cshtml"
                                                                                              , Tuple.Create(Tuple.Create("", 1177), Tuple.Create<System.Object, System.Int32>(Model.CreateTime==null?"":Model.CreateTime.ToString("yyyy-MM-dd HH:mm:ss")
            
            #line default
            #line hidden
, 1177), false)
);

WriteLiteral(" style=\"width:135px;\"");

WriteLiteral(">\r\n</td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_TotalMoney\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">总金额：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"TotalMoney\"");

WriteLiteral(" name=\"TotalMoney\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1418), Tuple.Create("\"", 1445)
            
            #line 31 "..\..\Areas\Product\Views\OrderInfo\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 1426), Tuple.Create<System.Object, System.Int32>(Model.TotalMoney
            
            #line default
            #line hidden
, 1426), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"8\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">备注：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"Comment\"");

WriteLiteral(" name=\"Comment\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1614), Tuple.Create("\"", 1638)
            
            #line 34 "..\..\Areas\Product\Views\OrderInfo\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 1622), Tuple.Create<System.Object, System.Int32>(Model.Comment
            
            #line default
            #line hidden
, 1622), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"500\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_Models\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">模型：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"Models\"");

WriteLiteral(" name=\"Models\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1842), Tuple.Create("\"", 1865)
            
            #line 39 "..\..\Areas\Product\Views\OrderInfo\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 1850), Tuple.Create<System.Object, System.Int32>(Model.Models
            
            #line default
            #line hidden
, 1850), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"30\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">支付状态：</td><td>&nbsp;\r\n");

            
            #line 42 "..\..\Areas\Product\Views\OrderInfo\_\Edit.cshtml"
Write(Html.Raw(MyHtmlHelper2.ShowRadio(ViewBag.DAL.NameValue_PayStatus, "PayStatus", Model.PayStatus, "&nbsp;&nbsp;")));

            
            #line default
            #line hidden
WriteLiteral("\r\n</td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_PayType\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">支付类型：</td><td>&nbsp;\r\n<select");

WriteLiteral(" id=\"PayType\"");

WriteLiteral(" class=\"easyui-combobox\"");

WriteLiteral(" name=\"PayType\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(">\r\n<option");

WriteLiteral(" value=\"\"");

WriteLiteral(">请选择</option>\r\n");

            
            #line 49 "..\..\Areas\Product\Views\OrderInfo\_\Edit.cshtml"
Write(Html.Raw(MyHtmlHelper2.ShowSelectOptions(ViewBag.DAL.NameValue_PayType, Model.PayType)));

            
            #line default
            #line hidden
WriteLiteral("\r\n</select></td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">&nbsp;</td><td>&nbsp;</td>\r\n</tr>\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"OrderID\"");

WriteLiteral("  name=\"OrderID\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2514), Tuple.Create("\"", 2538)
            
            #line 53 "..\..\Areas\Product\Views\OrderInfo\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 2522), Tuple.Create<System.Object, System.Int32>(Model.OrderID
            
            #line default
            #line hidden
, 2522), false)
);

WriteLiteral("/><input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"CreateUserID\"");

WriteLiteral("  name=\"CreateUserID\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2600), Tuple.Create("\"", 2629)
            
            #line 53 "..\..\Areas\Product\Views\OrderInfo\_\Edit.cshtml"
                                                                , Tuple.Create(Tuple.Create("", 2608), Tuple.Create<System.Object, System.Int32>(Model.CreateUserID
            
            #line default
            #line hidden
, 2608), false)
);

WriteLiteral("/><input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"UpdateTime\"");

WriteLiteral("  name=\"UpdateTime\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2687), Tuple.Create("\"", 2714)
            
            #line 53 "..\..\Areas\Product\Views\OrderInfo\_\Edit.cshtml"
                                                                                                                                                       , Tuple.Create(Tuple.Create("", 2695), Tuple.Create<System.Object, System.Int32>(Model.UpdateTime
            
            #line default
            #line hidden
, 2695), false)
);

WriteLiteral("/>\r\n</table>\r\n\r\n");

WriteLiteral("        ");

            
            #line 56 "..\..\Areas\Product\Views\OrderInfo\_\Edit.cshtml"
   Write(RenderPage("~/Areas/Product/Views/OrderInfo/Extend/Model_FormHtml.cshtml"));

            
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

            
            #line 84 "..\..\Areas\Product\Views\OrderInfo\_\Edit.cshtml"
Write(RenderPage("~/Areas/Product/Views/OrderInfo/Extend/Model_FormJs.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
