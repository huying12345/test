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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Product/Views/OrderDetail/_/Create.cshtml")]
    public partial class _Areas_Product_Views_OrderDetail___Create_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Product_Views_OrderDetail___Create_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 2 "..\..\Areas\Product\Views\OrderDetail\_\Create.cshtml"
  
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
    ViewBag.Title="新建订单明细";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" region=\"center\"");

WriteLiteral(" border=\"true\"");

WriteLiteral(" style=\"padding: 10px; background: #FFFFFF; border: 1px solid #ccc;\"");

WriteLiteral(">\r\n    <form");

WriteLiteral(" id=\"myForm\"");

WriteLiteral(" name=\"myForm\"");

WriteLiteral(" action=\"/api/Product/OrderDetail/Create\"");

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

WriteAttribute("value", Tuple.Create(" value=\"", 834), Tuple.Create("\"", 858)
            
            #line 22 "..\..\Areas\Product\Views\OrderDetail\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 842), Tuple.Create<System.Object, System.Int32>(Model.OrderID
            
            #line default
            #line hidden
, 842), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"50\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">商品编号：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"ProductID\"");

WriteLiteral(" name=\"ProductID\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1034), Tuple.Create("\"", 1060)
            
            #line 25 "..\..\Areas\Product\Views\OrderDetail\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 1042), Tuple.Create<System.Object, System.Int32>(Model.ProductID
            
            #line default
            #line hidden
, 1042), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"4\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_ProductNo\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">商品条码：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"ProductNo\"");

WriteLiteral(" name=\"ProductNo\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1273), Tuple.Create("\"", 1299)
            
            #line 30 "..\..\Areas\Product\Views\OrderDetail\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 1281), Tuple.Create<System.Object, System.Int32>(Model.ProductNo
            
            #line default
            #line hidden
, 1281), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"50\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">原价：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"Price\"");

WriteLiteral(" name=\"Price\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1465), Tuple.Create("\"", 1487)
            
            #line 33 "..\..\Areas\Product\Views\OrderDetail\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 1473), Tuple.Create<System.Object, System.Int32>(Model.Price
            
            #line default
            #line hidden
, 1473), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"8\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_Num\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">数量：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"Num\"");

WriteLiteral(" name=\"Num\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1680), Tuple.Create("\"", 1700)
            
            #line 38 "..\..\Areas\Product\Views\OrderDetail\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 1688), Tuple.Create<System.Object, System.Int32>(Model.Num
            
            #line default
            #line hidden
, 1688), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"8\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">销售价格：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"SalePrice\"");

WriteLiteral(" name=\"SalePrice\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1875), Tuple.Create("\"", 1901)
            
            #line 41 "..\..\Areas\Product\Views\OrderDetail\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 1883), Tuple.Create<System.Object, System.Int32>(Model.SalePrice
            
            #line default
            #line hidden
, 1883), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"8\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_TotalMoney\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">总金额：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"TotalMoney\"");

WriteLiteral(" name=\"TotalMoney\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2116), Tuple.Create("\"", 2143)
            
            #line 46 "..\..\Areas\Product\Views\OrderDetail\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 2124), Tuple.Create<System.Object, System.Int32>(Model.TotalMoney
            
            #line default
            #line hidden
, 2124), false)
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

WriteAttribute("value", Tuple.Create(" value=\"", 2312), Tuple.Create("\"", 2336)
            
            #line 49 "..\..\Areas\Product\Views\OrderDetail\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 2320), Tuple.Create<System.Object, System.Int32>(Model.Comment
            
            #line default
            #line hidden
, 2320), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"500\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_BackField1\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">备用字段1：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"BackField1\"");

WriteLiteral(" name=\"BackField1\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2555), Tuple.Create("\"", 2582)
            
            #line 54 "..\..\Areas\Product\Views\OrderDetail\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 2563), Tuple.Create<System.Object, System.Int32>(Model.BackField1
            
            #line default
            #line hidden
, 2563), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"50\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">备用字段2：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"BackField2\"");

WriteLiteral(" name=\"BackField2\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2761), Tuple.Create("\"", 2788)
            
            #line 57 "..\..\Areas\Product\Views\OrderDetail\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 2769), Tuple.Create<System.Object, System.Int32>(Model.BackField2
            
            #line default
            #line hidden
, 2769), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"50\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_Status\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">状态：</td><td>&nbsp;\r\n<select");

WriteLiteral(" id=\"Status\"");

WriteLiteral(" class=\"easyui-combobox\"");

WriteLiteral(" name=\"Status\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(">\r\n<option");

WriteLiteral(" value=\"\"");

WriteLiteral(">请选择</option>\r\n");

            
            #line 64 "..\..\Areas\Product\Views\OrderDetail\_\Create.cshtml"
Write(Html.Raw(MyHtmlHelper2.ShowSelectOptions(ViewBag.DAL.NameValue_Status, Model.Status)));

            
            #line default
            #line hidden
WriteLiteral("\r\n</select></td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">&nbsp;</td><td>&nbsp;</td>\r\n</tr>\r\n\r\n</table>\r\n\r\n");

WriteLiteral("        ");

            
            #line 71 "..\..\Areas\Product\Views\OrderDetail\_\Create.cshtml"
   Write(RenderPage("~/Areas/Product/Views/OrderDetail/Extend/Model_FormHtml.cshtml"));

            
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

            
            #line 99 "..\..\Areas\Product\Views\OrderDetail\_\Create.cshtml"
Write(RenderPage("~/Areas/Product/Views/OrderDetail/Extend/Model_FormJs.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591