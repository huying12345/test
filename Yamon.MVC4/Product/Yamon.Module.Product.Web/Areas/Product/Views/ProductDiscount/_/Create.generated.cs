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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Product/Views/ProductDiscount/_/Create.cshtml")]
    public partial class _Areas_Product_Views_ProductDiscount___Create_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Product_Views_ProductDiscount___Create_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 2 "..\..\Areas\Product\Views\ProductDiscount\_\Create.cshtml"
  
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
    ViewBag.Title="新建商品折扣";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" region=\"center\"");

WriteLiteral(" border=\"true\"");

WriteLiteral(" style=\"padding: 10px; background: #FFFFFF; border: 1px solid #ccc;\"");

WriteLiteral(">\r\n    <form");

WriteLiteral(" id=\"myForm\"");

WriteLiteral(" name=\"myForm\"");

WriteLiteral(" action=\"/api/Product/ProductDiscount/Create\"");

WriteLiteral(" method=\"post\"");

WriteLiteral(">\r\n        <table");

WriteLiteral(" class=\"mytable\"");

WriteLiteral("  cellpadding=\"1\"");

WriteLiteral(" width=\"100%\"");

WriteLiteral(" cellspacing=\"0\"");

WriteLiteral(" align=\"center\"");

WriteLiteral(">\r\n<tr");

WriteLiteral(" id=\"Container_DiscountName\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_DiscountName\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">折扣名称：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"DiscountName\"");

WriteLiteral(" name=\"DiscountName\"");

WriteAttribute("value", Tuple.Create(" value=\"", 875), Tuple.Create("\"", 904)
            
            #line 21 "..\..\Areas\Product\Views\ProductDiscount\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 883), Tuple.Create<System.Object, System.Int32>(Model.DiscountName
            
            #line default
            #line hidden
, 883), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral(" required=\"true\"");

WriteLiteral("  maxlength=\"100\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td></tr>\r\n<tr");

WriteLiteral(" id=\"Container_IsDefault\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_IsDefault\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">是否默认：</td><td>&nbsp;\r\n\r\n");

            
            #line 25 "..\..\Areas\Product\Views\ProductDiscount\_\Create.cshtml"
Write(Html.Raw(MyHtmlHelper2.ShowRadio(ViewBag.DAL.NameValue_IsDefault, "IsDefault", Model.IsDefault, "&nbsp;&nbsp;")));

            
            #line default
            #line hidden
WriteLiteral("\r\n</td></tr>\r\n<tr");

WriteLiteral(" id=\"Container_DiscountPercent\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_DiscountPercent\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">折扣率：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"DiscountPercent\"");

WriteLiteral(" name=\"DiscountPercent\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1396), Tuple.Create("\"", 1428)
            
            #line 28 "..\..\Areas\Product\Views\ProductDiscount\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 1404), Tuple.Create<System.Object, System.Int32>(Model.DiscountPercent
            
            #line default
            #line hidden
, 1404), false)
);

WriteLiteral(" class=\"easyui-numberbox\"");

WriteLiteral(" min=\"0\"");

WriteLiteral(" max=\"1\"");

WriteLiteral("  precision=\"2\"");

WriteLiteral(" style=\"width:200px;\"");

WriteLiteral("/>\r\n</td></tr>\r\n<tr");

WriteLiteral(" id=\"Container_OrderID\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_OrderID\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">排序号：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"OrderID\"");

WriteLiteral(" name=\"OrderID\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1655), Tuple.Create("\"", 1679)
            
            #line 31 "..\..\Areas\Product\Views\ProductDiscount\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 1663), Tuple.Create<System.Object, System.Int32>(Model.OrderID
            
            #line default
            #line hidden
, 1663), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral(" required=\"true\"");

WriteLiteral("  maxlength=\"4\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td></tr>\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"Models\"");

WriteLiteral("  name=\"Models\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1830), Tuple.Create("\"", 1853)
            
            #line 33 "..\..\Areas\Product\Views\ProductDiscount\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 1838), Tuple.Create<System.Object, System.Int32>(Model.Models
            
            #line default
            #line hidden
, 1838), false)
);

WriteLiteral("/>\r\n</table>\r\n\r\n");

WriteLiteral("        ");

            
            #line 36 "..\..\Areas\Product\Views\ProductDiscount\_\Create.cshtml"
   Write(RenderPage("~/Areas/Product/Views/ProductDiscount/Extend/Model_FormHtml.cshtml"));

            
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

            
            #line 64 "..\..\Areas\Product\Views\ProductDiscount\_\Create.cshtml"
Write(RenderPage("~/Areas/Product/Views/ProductDiscount/Extend/Model_FormJs.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
