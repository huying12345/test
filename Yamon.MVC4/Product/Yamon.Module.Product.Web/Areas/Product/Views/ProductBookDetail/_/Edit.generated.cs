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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Product/Views/ProductBookDetail/_/Edit.cshtml")]
    public partial class _Areas_Product_Views_ProductBookDetail___Edit_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Product_Views_ProductBookDetail___Edit_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 2 "..\..\Areas\Product\Views\ProductBookDetail\_\Edit.cshtml"
  
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
    ViewBag.Title="编辑预约明细";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" region=\"center\"");

WriteLiteral(" border=\"true\"");

WriteLiteral(" style=\"padding: 10px; background: #FFFFFF; border: 1px solid #ccc;\"");

WriteLiteral(">\r\n    <form");

WriteLiteral(" id=\"myForm\"");

WriteLiteral(" name=\"myForm\"");

WriteLiteral(" action=\"/api/Product/ProductBookDetail/Edit\"");

WriteLiteral(" method=\"post\"");

WriteLiteral(">\r\n        <table");

WriteLiteral(" class=\"mytable\"");

WriteLiteral("  cellpadding=\"1\"");

WriteLiteral(" width=\"100%\"");

WriteLiteral(" cellspacing=\"0\"");

WriteLiteral(" align=\"center\"");

WriteLiteral(">\r\n<tr");

WriteLiteral(" id=\"Container_MakeTime\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">预约时间：</td><td>&nbsp;    <input");

WriteLiteral(" class=\"Wdate\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" onClick=\"WdatePicker({dateFmt:\'yyyy-MM-dd HH:mm:ss\'})\"");

WriteLiteral(" id=\"MakeTime\"");

WriteLiteral(" name=\"MakeTime\"");

WriteAttribute("value", Tuple.Create(" value=\"", 912), Tuple.Create("\"", 993)
            
            #line 21 "..\..\Areas\Product\Views\ProductBookDetail\_\Edit.cshtml"
                                                                                           , Tuple.Create(Tuple.Create("", 920), Tuple.Create<System.Object, System.Int32>(Model.MakeTime==null?"":Model.MakeTime.ToString("yyyy-MM-dd HH:mm:ss")
            
            #line default
            #line hidden
, 920), false)
);

WriteLiteral(" style=\"width:135px;\"");

WriteLiteral(">\r\n</td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">订单编号：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"ProductBookID\"");

WriteLiteral(" name=\"ProductBookID\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1125), Tuple.Create("\"", 1155)
            
            #line 24 "..\..\Areas\Product\Views\ProductBookDetail\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 1133), Tuple.Create<System.Object, System.Int32>(Model.ProductBookID
            
            #line default
            #line hidden
, 1133), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"50\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_ProductID\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">商品编号：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"ProductID\"");

WriteLiteral(" name=\"ProductID\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1369), Tuple.Create("\"", 1395)
            
            #line 29 "..\..\Areas\Product\Views\ProductBookDetail\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 1377), Tuple.Create<System.Object, System.Int32>(Model.ProductID
            
            #line default
            #line hidden
, 1377), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"4\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">商品条码：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"ProductNo\"");

WriteLiteral(" name=\"ProductNo\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1570), Tuple.Create("\"", 1596)
            
            #line 32 "..\..\Areas\Product\Views\ProductBookDetail\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 1578), Tuple.Create<System.Object, System.Int32>(Model.ProductNo
            
            #line default
            #line hidden
, 1578), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"50\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_Price\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">原价：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"Price\"");

WriteLiteral(" name=\"Price\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1796), Tuple.Create("\"", 1818)
            
            #line 37 "..\..\Areas\Product\Views\ProductBookDetail\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 1804), Tuple.Create<System.Object, System.Int32>(Model.Price
            
            #line default
            #line hidden
, 1804), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"8\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">数量：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"Num\"");

WriteLiteral(" name=\"Num\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1979), Tuple.Create("\"", 1999)
            
            #line 40 "..\..\Areas\Product\Views\ProductBookDetail\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 1987), Tuple.Create<System.Object, System.Int32>(Model.Num
            
            #line default
            #line hidden
, 1987), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"8\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_SalePrice\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">销售价格：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"SalePrice\"");

WriteLiteral(" name=\"SalePrice\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2212), Tuple.Create("\"", 2238)
            
            #line 45 "..\..\Areas\Product\Views\ProductBookDetail\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 2220), Tuple.Create<System.Object, System.Int32>(Model.SalePrice
            
            #line default
            #line hidden
, 2220), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"8\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">总金额：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"TotalMoney\"");

WriteLiteral(" name=\"TotalMoney\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2414), Tuple.Create("\"", 2441)
            
            #line 48 "..\..\Areas\Product\Views\ProductBookDetail\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 2422), Tuple.Create<System.Object, System.Int32>(Model.TotalMoney
            
            #line default
            #line hidden
, 2422), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"8\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_Comment\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">备注：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"Comment\"");

WriteLiteral(" name=\"Comment\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2646), Tuple.Create("\"", 2670)
            
            #line 53 "..\..\Areas\Product\Views\ProductBookDetail\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 2654), Tuple.Create<System.Object, System.Int32>(Model.Comment
            
            #line default
            #line hidden
, 2654), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"500\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">备用字段1：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"BackField1\"");

WriteLiteral(" name=\"BackField1\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2850), Tuple.Create("\"", 2877)
            
            #line 56 "..\..\Areas\Product\Views\ProductBookDetail\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 2858), Tuple.Create<System.Object, System.Int32>(Model.BackField1
            
            #line default
            #line hidden
, 2858), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"50\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_BackField2\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">备用字段2：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"BackField2\"");

WriteLiteral(" name=\"BackField2\"");

WriteAttribute("value", Tuple.Create(" value=\"", 3095), Tuple.Create("\"", 3122)
            
            #line 61 "..\..\Areas\Product\Views\ProductBookDetail\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 3103), Tuple.Create<System.Object, System.Int32>(Model.BackField2
            
            #line default
            #line hidden
, 3103), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"50\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">&nbsp;</td><td>&nbsp;</td>\r\n</tr>\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"ProductBookDetailID\"");

WriteLiteral("  name=\"ProductBookDetailID\"");

WriteAttribute("value", Tuple.Create(" value=\"", 3334), Tuple.Create("\"", 3370)
            
            #line 65 "..\..\Areas\Product\Views\ProductBookDetail\_\Edit.cshtml"
  , Tuple.Create(Tuple.Create("", 3342), Tuple.Create<System.Object, System.Int32>(Model.ProductBookDetailID
            
            #line default
            #line hidden
, 3342), false)
);

WriteLiteral("/>\r\n</table>\r\n\r\n");

WriteLiteral("        ");

            
            #line 68 "..\..\Areas\Product\Views\ProductBookDetail\_\Edit.cshtml"
   Write(RenderPage("~/Areas/Product/Views/ProductBookDetail/Extend/Model_FormHtml.cshtml"));

            
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

            
            #line 96 "..\..\Areas\Product\Views\ProductBookDetail\_\Edit.cshtml"
Write(RenderPage("~/Areas/Product/Views/ProductBookDetail/Extend/Model_FormJs.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
