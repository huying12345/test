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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Product/Views/VProductBookDetail/_/Create.cshtml")]
    public partial class _Areas_Product_Views_VProductBookDetail___Create_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Product_Views_VProductBookDetail___Create_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 2 "..\..\Areas\Product\Views\VProductBookDetail\_\Create.cshtml"
  
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
    ViewBag.Title="新建预约信息视图";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" region=\"center\"");

WriteLiteral(" border=\"true\"");

WriteLiteral(" style=\"padding: 10px; background: #FFFFFF; border: 1px solid #ccc;\"");

WriteLiteral(">\r\n    <form");

WriteLiteral(" id=\"myForm\"");

WriteLiteral(" name=\"myForm\"");

WriteLiteral(" action=\"/api/Product/VProductBookDetail/Create\"");

WriteLiteral(" method=\"post\"");

WriteLiteral(">\r\n        <table");

WriteLiteral(" class=\"mytable\"");

WriteLiteral("  cellpadding=\"1\"");

WriteLiteral(" width=\"100%\"");

WriteLiteral(" cellspacing=\"0\"");

WriteLiteral(" align=\"center\"");

WriteLiteral(">\r\n<tr");

WriteLiteral(" id=\"Container_ProductBookDetailID\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">预约编号：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"ProductBookDetailID\"");

WriteLiteral(" name=\"ProductBookDetailID\"");

WriteAttribute("value", Tuple.Create(" value=\"", 879), Tuple.Create("\"", 915)
            
            #line 22 "..\..\Areas\Product\Views\VProductBookDetail\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 887), Tuple.Create<System.Object, System.Int32>(Model.ProductBookDetailID
            
            #line default
            #line hidden
, 887), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral(" required=\"true\"");

WriteLiteral("  maxlength=\"50\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">商品类型：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"TypeName\"");

WriteLiteral(" name=\"TypeName\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1105), Tuple.Create("\"", 1130)
            
            #line 25 "..\..\Areas\Product\Views\VProductBookDetail\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 1113), Tuple.Create<System.Object, System.Int32>(Model.TypeName
            
            #line default
            #line hidden
, 1113), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral(" required=\"true\"");

WriteLiteral("  maxlength=\"30\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_ProductInfoId\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">商品信息id：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"ProductInfoId\"");

WriteLiteral(" name=\"ProductInfoId\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1374), Tuple.Create("\"", 1404)
            
            #line 30 "..\..\Areas\Product\Views\VProductBookDetail\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 1382), Tuple.Create<System.Object, System.Int32>(Model.ProductInfoId
            
            #line default
            #line hidden
, 1382), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral(" required=\"true\"");

WriteLiteral("  maxlength=\"4\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">商品名称：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"ProductName\"");

WriteLiteral(" name=\"ProductName\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1599), Tuple.Create("\"", 1627)
            
            #line 33 "..\..\Areas\Product\Views\VProductBookDetail\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 1607), Tuple.Create<System.Object, System.Int32>(Model.ProductName
            
            #line default
            #line hidden
, 1607), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"50\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_ProductBookID\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">预约订单编号：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"ProductBookID\"");

WriteLiteral(" name=\"ProductBookID\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1855), Tuple.Create("\"", 1885)
            
            #line 38 "..\..\Areas\Product\Views\VProductBookDetail\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 1863), Tuple.Create<System.Object, System.Int32>(Model.ProductBookID
            
            #line default
            #line hidden
, 1863), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"50\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">ProductID：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"ProductID\"");

WriteLiteral(" name=\"ProductID\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2066), Tuple.Create("\"", 2092)
            
            #line 41 "..\..\Areas\Product\Views\VProductBookDetail\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 2074), Tuple.Create<System.Object, System.Int32>(Model.ProductID
            
            #line default
            #line hidden
, 2074), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"4\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_ProductNo\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">ProductNo：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"ProductNo\"");

WriteLiteral(" name=\"ProductNo\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2310), Tuple.Create("\"", 2336)
            
            #line 46 "..\..\Areas\Product\Views\VProductBookDetail\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 2318), Tuple.Create<System.Object, System.Int32>(Model.ProductNo
            
            #line default
            #line hidden
, 2318), false)
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

WriteAttribute("value", Tuple.Create(" value=\"", 2502), Tuple.Create("\"", 2524)
            
            #line 49 "..\..\Areas\Product\Views\VProductBookDetail\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 2510), Tuple.Create<System.Object, System.Int32>(Model.Price
            
            #line default
            #line hidden
, 2510), false)
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

WriteAttribute("value", Tuple.Create(" value=\"", 2717), Tuple.Create("\"", 2737)
            
            #line 54 "..\..\Areas\Product\Views\VProductBookDetail\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 2725), Tuple.Create<System.Object, System.Int32>(Model.Num
            
            #line default
            #line hidden
, 2725), false)
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

WriteAttribute("value", Tuple.Create(" value=\"", 2912), Tuple.Create("\"", 2938)
            
            #line 57 "..\..\Areas\Product\Views\VProductBookDetail\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 2920), Tuple.Create<System.Object, System.Int32>(Model.SalePrice
            
            #line default
            #line hidden
, 2920), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"8\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_Money\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">总金额：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"Money\"");

WriteLiteral(" name=\"Money\"");

WriteAttribute("value", Tuple.Create(" value=\"", 3138), Tuple.Create("\"", 3160)
            
            #line 62 "..\..\Areas\Product\Views\VProductBookDetail\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 3146), Tuple.Create<System.Object, System.Int32>(Model.Money
            
            #line default
            #line hidden
, 3146), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"8\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">预约时间：</td><td>&nbsp;    <input");

WriteLiteral(" class=\"Wdate\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" onClick=\"WdatePicker({dateFmt:\'yyyy-MM-dd HH:mm:ss\'})\"");

WriteLiteral(" id=\"MakeTime\"");

WriteLiteral(" name=\"MakeTime\"");

WriteAttribute("value", Tuple.Create(" value=\"", 3404), Tuple.Create("\"", 3485)
            
            #line 64 "..\..\Areas\Product\Views\VProductBookDetail\_\Create.cshtml"
                                                                                          , Tuple.Create(Tuple.Create("", 3412), Tuple.Create<System.Object, System.Int32>(Model.MakeTime==null?"":Model.MakeTime.ToString("yyyy-MM-dd HH:mm:ss")
            
            #line default
            #line hidden
, 3412), false)
);

WriteLiteral(" style=\"width:135px;\"");

WriteLiteral(">\r\n</td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_BackField2\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">BackField2：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"BackField2\"");

WriteLiteral(" name=\"BackField2\"");

WriteAttribute("value", Tuple.Create(" value=\"", 3656), Tuple.Create("\"", 3683)
            
            #line 69 "..\..\Areas\Product\Views\VProductBookDetail\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 3664), Tuple.Create<System.Object, System.Int32>(Model.BackField2
            
            #line default
            #line hidden
, 3664), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"50\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">PurchasePrice：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"PurchasePrice\"");

WriteLiteral(" name=\"PurchasePrice\"");

WriteAttribute("value", Tuple.Create(" value=\"", 3876), Tuple.Create("\"", 3906)
            
            #line 72 "..\..\Areas\Product\Views\VProductBookDetail\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 3884), Tuple.Create<System.Object, System.Int32>(Model.PurchasePrice
            
            #line default
            #line hidden
, 3884), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"8\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_StockNum\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">StockNum：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"StockNum\"");

WriteLiteral(" name=\"StockNum\"");

WriteAttribute("value", Tuple.Create(" value=\"", 4120), Tuple.Create("\"", 4145)
            
            #line 77 "..\..\Areas\Product\Views\VProductBookDetail\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 4128), Tuple.Create<System.Object, System.Int32>(Model.StockNum
            
            #line default
            #line hidden
, 4128), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"4\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">ExchangeNeedBonus：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"ExchangeNeedBonus\"");

WriteLiteral(" name=\"ExchangeNeedBonus\"");

WriteAttribute("value", Tuple.Create(" value=\"", 4349), Tuple.Create("\"", 4383)
            
            #line 80 "..\..\Areas\Product\Views\VProductBookDetail\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 4357), Tuple.Create<System.Object, System.Int32>(Model.ExchangeNeedBonus
            
            #line default
            #line hidden
, 4357), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"4\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_SaleDiscountPercent\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">SaleDiscountPercent：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"SaleDiscountPercent\"");

WriteLiteral(" name=\"SaleDiscountPercent\"");

WriteAttribute("value", Tuple.Create(" value=\"", 4641), Tuple.Create("\"", 4677)
            
            #line 85 "..\..\Areas\Product\Views\VProductBookDetail\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 4649), Tuple.Create<System.Object, System.Int32>(Model.SaleDiscountPercent
            
            #line default
            #line hidden
, 4649), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"5\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">MinDiscountPercent：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"MinDiscountPercent\"");

WriteLiteral(" name=\"MinDiscountPercent\"");

WriteAttribute("value", Tuple.Create(" value=\"", 4884), Tuple.Create("\"", 4919)
            
            #line 88 "..\..\Areas\Product\Views\VProductBookDetail\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 4892), Tuple.Create<System.Object, System.Int32>(Model.MinDiscountPercent
            
            #line default
            #line hidden
, 4892), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"5\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_BackField1\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">BackField1：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"BackField1\"");

WriteLiteral(" name=\"BackField1\"");

WriteAttribute("value", Tuple.Create(" value=\"", 5141), Tuple.Create("\"", 5168)
            
            #line 93 "..\..\Areas\Product\Views\VProductBookDetail\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 5149), Tuple.Create<System.Object, System.Int32>(Model.BackField1
            
            #line default
            #line hidden
, 5149), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"50\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">Comment：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"Comment\"");

WriteLiteral(" name=\"Comment\"");

WriteAttribute("value", Tuple.Create(" value=\"", 5343), Tuple.Create("\"", 5367)
            
            #line 96 "..\..\Areas\Product\Views\VProductBookDetail\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 5351), Tuple.Create<System.Object, System.Int32>(Model.Comment
            
            #line default
            #line hidden
, 5351), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"500\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_MemberID\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">MemberID：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"MemberID\"");

WriteLiteral(" name=\"MemberID\"");

WriteAttribute("value", Tuple.Create(" value=\"", 5583), Tuple.Create("\"", 5608)
            
            #line 101 "..\..\Areas\Product\Views\VProductBookDetail\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 5591), Tuple.Create<System.Object, System.Int32>(Model.MemberID
            
            #line default
            #line hidden
, 5591), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"4\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">创建时间：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"CreateUserID\"");

WriteLiteral(" name=\"CreateUserID\"");

WriteAttribute("value", Tuple.Create(" value=\"", 5789), Tuple.Create("\"", 5818)
            
            #line 104 "..\..\Areas\Product\Views\VProductBookDetail\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 5797), Tuple.Create<System.Object, System.Int32>(Model.CreateUserID
            
            #line default
            #line hidden
, 5797), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"30\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_TotalMoney\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">TotalMoney：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"TotalMoney\"");

WriteLiteral(" name=\"TotalMoney\"");

WriteAttribute("value", Tuple.Create(" value=\"", 6041), Tuple.Create("\"", 6068)
            
            #line 109 "..\..\Areas\Product\Views\VProductBookDetail\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 6049), Tuple.Create<System.Object, System.Int32>(Model.TotalMoney
            
            #line default
            #line hidden
, 6049), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"8\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">模型：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"Models\"");

WriteLiteral(" name=\"Models\"");

WriteAttribute("value", Tuple.Create(" value=\"", 6235), Tuple.Create("\"", 6258)
            
            #line 112 "..\..\Areas\Product\Views\VProductBookDetail\_\Create.cshtml"
, Tuple.Create(Tuple.Create("", 6243), Tuple.Create<System.Object, System.Int32>(Model.Models
            
            #line default
            #line hidden
, 6243), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"500\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td>\r\n</tr>\r\n\r\n</table>\r\n\r\n");

WriteLiteral("        ");

            
            #line 118 "..\..\Areas\Product\Views\VProductBookDetail\_\Create.cshtml"
   Write(RenderPage("~/Areas/Product/Views/VProductBookDetail/Extend/Model_FormHtml.cshtml"));

            
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

            
            #line 146 "..\..\Areas\Product\Views\VProductBookDetail\_\Create.cshtml"
Write(RenderPage("~/Areas/Product/Views/VProductBookDetail/Extend/Model_FormJs.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
