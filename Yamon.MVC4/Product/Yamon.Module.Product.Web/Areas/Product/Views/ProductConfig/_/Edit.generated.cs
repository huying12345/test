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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Product/Views/ProductConfig/_/Edit.cshtml")]
    public partial class _Areas_Product_Views_ProductConfig___Edit_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Product_Views_ProductConfig___Edit_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 2 "..\..\Areas\Product\Views\ProductConfig\_\Edit.cshtml"
  
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
    ViewBag.Title="编辑商品模块配置";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" region=\"center\"");

WriteLiteral(" border=\"true\"");

WriteLiteral(" style=\"padding: 10px; background: #FFFFFF; border: 1px solid #ccc;\"");

WriteLiteral(">\r\n    <form");

WriteLiteral(" id=\"myForm\"");

WriteLiteral(" name=\"myForm\"");

WriteLiteral(" action=\"/api/Product/ProductConfig/Edit\"");

WriteLiteral(" method=\"post\"");

WriteLiteral(">\r\n        <table");

WriteLiteral(" class=\"mytable\"");

WriteLiteral("  cellpadding=\"1\"");

WriteLiteral(" width=\"100%\"");

WriteLiteral(" cellspacing=\"0\"");

WriteLiteral(" align=\"center\"");

WriteLiteral(">\r\n<tr");

WriteLiteral(" id=\"Container_VisitNum\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_VisitNum\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">每天限制人数：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"VisitNum\"");

WriteLiteral(" name=\"VisitNum\"");

WriteAttribute("value", Tuple.Create(" value=\"", 859), Tuple.Create("\"", 884)
            
            #line 21 "..\..\Areas\Product\Views\ProductConfig\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 867), Tuple.Create<System.Object, System.Int32>(Model.VisitNum
            
            #line default
            #line hidden
, 867), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"30\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td></tr>\r\n<tr");

WriteLiteral(" id=\"Container_Menber\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_Menber\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">是否开启打折功能：</td><td>&nbsp;");

            
            #line 23 "..\..\Areas\Product\Views\ProductConfig\_\Edit.cshtml"
                                                                                   Write(Html.Raw(MyHtmlHelper2.ShowCheckBox(ViewBag.DAL.NameValue_Menber, "Menber", Model.Menber, "&nbsp;&nbsp;")));

            
            #line default
            #line hidden
WriteLiteral("\r\n</td></tr>\r\n<tr");

WriteLiteral(" id=\"Container_GoodPassword\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_GoodPassword\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">商品退单密码：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"GoodPassword\"");

WriteLiteral(" name=\"GoodPassword\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1338), Tuple.Create("\"", 1367)
            
            #line 26 "..\..\Areas\Product\Views\ProductConfig\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 1346), Tuple.Create<System.Object, System.Int32>(Model.GoodPassword
            
            #line default
            #line hidden
, 1346), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"30\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td></tr>\r\n<tr");

WriteLiteral(" id=\"Container_TicketPassword\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_TicketPassword\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">门票退单密码：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"TicketPassword\"");

WriteLiteral(" name=\"TicketPassword\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1620), Tuple.Create("\"", 1651)
            
            #line 29 "..\..\Areas\Product\Views\ProductConfig\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 1628), Tuple.Create<System.Object, System.Int32>(Model.TicketPassword
            
            #line default
            #line hidden
, 1628), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"30\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td></tr>\r\n<tr");

WriteLiteral(" id=\"Container_FoodPassword\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_FoodPassword\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">餐饮退单密码：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"FoodPassword\"");

WriteLiteral(" name=\"FoodPassword\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1896), Tuple.Create("\"", 1925)
            
            #line 32 "..\..\Areas\Product\Views\ProductConfig\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 1904), Tuple.Create<System.Object, System.Int32>(Model.FoodPassword
            
            #line default
            #line hidden
, 1904), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"30\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td></tr>\r\n<tr");

WriteLiteral(" id=\"Container_PlaygroudPassword\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_PlaygroudPassword\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">游乐场退单密码：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"PlaygroudPassword\"");

WriteLiteral(" name=\"PlaygroudPassword\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2191), Tuple.Create("\"", 2225)
            
            #line 35 "..\..\Areas\Product\Views\ProductConfig\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 2199), Tuple.Create<System.Object, System.Int32>(Model.PlaygroudPassword
            
            #line default
            #line hidden
, 2199), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"30\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td></tr>\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"Module\"");

WriteLiteral("  name=\"Module\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2361), Tuple.Create("\"", 2384)
            
            #line 37 "..\..\Areas\Product\Views\ProductConfig\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 2369), Tuple.Create<System.Object, System.Int32>(Model.Module
            
            #line default
            #line hidden
, 2369), false)
);

WriteLiteral("/>\r\n</table>\r\n\r\n");

WriteLiteral("        ");

            
            #line 40 "..\..\Areas\Product\Views\ProductConfig\_\Edit.cshtml"
   Write(RenderPage("~/Areas/Product/Views/ProductConfig/Extend/Model_FormHtml.cshtml"));

            
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

            
            #line 68 "..\..\Areas\Product\Views\ProductConfig\_\Edit.cshtml"
Write(RenderPage("~/Areas/Product/Views/ProductConfig/Extend/Model_FormJs.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
