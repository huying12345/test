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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Product/Views/OrderRefund/_/Edit.cshtml")]
    public partial class _Areas_Product_Views_OrderRefund___Edit_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Product_Views_OrderRefund___Edit_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 2 "..\..\Areas\Product\Views\OrderRefund\_\Edit.cshtml"
  
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
    ViewBag.Title="编辑订单退票";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" region=\"center\"");

WriteLiteral(" border=\"true\"");

WriteLiteral(" style=\"padding: 10px; background: #FFFFFF; border: 1px solid #ccc;\"");

WriteLiteral(">\r\n    <form");

WriteLiteral(" id=\"myForm\"");

WriteLiteral(" name=\"myForm\"");

WriteLiteral(" action=\"/api/Product/OrderRefund/Edit\"");

WriteLiteral(" method=\"post\"");

WriteLiteral(">\r\n        <table");

WriteLiteral(" class=\"mytable\"");

WriteLiteral("  cellpadding=\"1\"");

WriteLiteral(" width=\"100%\"");

WriteLiteral(" cellspacing=\"0\"");

WriteLiteral(" align=\"center\"");

WriteLiteral(">\r\n<tr");

WriteLiteral(" id=\"Container_OrderID\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">订单编号：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"OrderID\"");

WriteLiteral(" name=\"OrderID\"");

WriteAttribute("value", Tuple.Create(" value=\"", 832), Tuple.Create("\"", 856)
            
            #line 22 "..\..\Areas\Product\Views\OrderRefund\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 840), Tuple.Create<System.Object, System.Int32>(Model.OrderID
            
            #line default
            #line hidden
, 840), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"50\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">订单明细编号：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"OrderDetailID\"");

WriteLiteral(" name=\"OrderDetailID\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1042), Tuple.Create("\"", 1072)
            
            #line 25 "..\..\Areas\Product\Views\OrderRefund\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 1050), Tuple.Create<System.Object, System.Int32>(Model.OrderDetailID
            
            #line default
            #line hidden
, 1050), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"50\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_RefundMoney\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">退单金额：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"RefundMoney\"");

WriteLiteral(" name=\"RefundMoney\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1292), Tuple.Create("\"", 1320)
            
            #line 30 "..\..\Areas\Product\Views\OrderRefund\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 1300), Tuple.Create<System.Object, System.Int32>(Model.RefundMoney
            
            #line default
            #line hidden
, 1300), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"8\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">退单时间：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"RefundTime\"");

WriteLiteral(" name=\"RefundTime\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1497), Tuple.Create("\"", 1524)
            
            #line 33 "..\..\Areas\Product\Views\OrderRefund\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 1505), Tuple.Create<System.Object, System.Int32>(Model.RefundTime
            
            #line default
            #line hidden
, 1505), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"8\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_RefundUserID\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">经办人：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"RefundUserID\"");

WriteLiteral(" name=\"RefundUserID\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1745), Tuple.Create("\"", 1774)
            
            #line 38 "..\..\Areas\Product\Views\OrderRefund\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 1753), Tuple.Create<System.Object, System.Int32>(Model.RefundUserID
            
            #line default
            #line hidden
, 1753), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"4\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">&nbsp;</td><td>&nbsp;</td>\r\n</tr>\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"RefundID\"");

WriteLiteral("  name=\"RefundID\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1963), Tuple.Create("\"", 1988)
            
            #line 42 "..\..\Areas\Product\Views\OrderRefund\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 1971), Tuple.Create<System.Object, System.Int32>(Model.RefundID
            
            #line default
            #line hidden
, 1971), false)
);

WriteLiteral("/>\r\n</table>\r\n\r\n");

WriteLiteral("        ");

            
            #line 45 "..\..\Areas\Product\Views\OrderRefund\_\Edit.cshtml"
   Write(RenderPage("~/Areas/Product/Views/OrderRefund/Extend/Model_FormHtml.cshtml"));

            
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

            
            #line 73 "..\..\Areas\Product\Views\OrderRefund\_\Edit.cshtml"
Write(RenderPage("~/Areas/Product/Views/OrderRefund/Extend/Model_FormJs.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
