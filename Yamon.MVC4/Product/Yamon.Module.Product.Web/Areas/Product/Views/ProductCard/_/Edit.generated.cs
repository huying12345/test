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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Product/Views/ProductCard/_/Edit.cshtml")]
    public partial class _Areas_Product_Views_ProductCard___Edit_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Product_Views_ProductCard___Edit_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 2 "..\..\Areas\Product\Views\ProductCard\_\Edit.cshtml"
  
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
    ViewBag.Title="编辑体验卡";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" region=\"center\"");

WriteLiteral(" border=\"true\"");

WriteLiteral(" style=\"padding: 10px; background: #FFFFFF; border: 1px solid #ccc;\"");

WriteLiteral(">\r\n    <form");

WriteLiteral(" id=\"myForm\"");

WriteLiteral(" name=\"myForm\"");

WriteLiteral(" action=\"/api/Product/ProductCard/Edit\"");

WriteLiteral(" method=\"post\"");

WriteLiteral(">\r\n        <table");

WriteLiteral(" class=\"mytable\"");

WriteLiteral("  cellpadding=\"1\"");

WriteLiteral(" width=\"100%\"");

WriteLiteral(" cellspacing=\"0\"");

WriteLiteral(" align=\"center\"");

WriteLiteral(">\r\n<tr");

WriteLiteral(" id=\"Container_CardSN\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_CardSN\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">厂商代码：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"CardSN\"");

WriteLiteral(" name=\"CardSN\"");

WriteAttribute("value", Tuple.Create(" value=\"", 844), Tuple.Create("\"", 867)
            
            #line 21 "..\..\Areas\Product\Views\ProductCard\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 852), Tuple.Create<System.Object, System.Int32>(Model.CardSN
            
            #line default
            #line hidden
, 852), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral(" required=\"true\"");

WriteLiteral("  maxlength=\"20\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td></tr>\r\n<tr");

WriteLiteral(" id=\"Container_CardNo\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_CardNo\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">卡序号：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"CardNo\"");

WriteLiteral(" name=\"CardNo\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1101), Tuple.Create("\"", 1124)
            
            #line 24 "..\..\Areas\Product\Views\ProductCard\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 1109), Tuple.Create<System.Object, System.Int32>(Model.CardNo
            
            #line default
            #line hidden
, 1109), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"20\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td></tr>\r\n<tr");

WriteLiteral(" id=\"Container_CardType\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_CardType\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">卡类型：</td><td>&nbsp;\r\n");

            
            #line 27 "..\..\Areas\Product\Views\ProductCard\_\Edit.cshtml"
Write(Html.Raw(MyHtmlHelper2.ShowRadio(ViewBag.DAL.NameValue_CardType, "CardType", Model.CardType, "&nbsp;&nbsp;")));

            
            #line default
            #line hidden
WriteLiteral("\r\n</td></tr>\r\n<tr");

WriteLiteral(" id=\"Container_ValidityStart\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_ValidityStart\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">有效期开始：</td><td>&nbsp;    <input");

WriteLiteral(" class=\"Wdate\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" onClick=\"WdatePicker({dateFmt:\'yyyy-MM-dd\'})\"");

WriteLiteral(" id=\"ValidityStart\"");

WriteLiteral(" name=\"ValidityStart\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1647), Tuple.Create("\"", 1687)
            
            #line 29 "..\..\Areas\Product\Views\ProductCard\_\Edit.cshtml"
                                                                                                                                                      , Tuple.Create(Tuple.Create("", 1655), Tuple.Create<System.Object, System.Int32>(Model.ValidityStart_ShowValue
            
            #line default
            #line hidden
, 1655), false)
);

WriteLiteral(" style=\"width:120px;\"");

WriteLiteral(">\r\n</td></tr>\r\n<tr");

WriteLiteral(" id=\"Container_ValidityEnd\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_ValidityEnd\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">有效期结束：</td><td>&nbsp;    <input");

WriteLiteral(" class=\"Wdate\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" onClick=\"WdatePicker({dateFmt:\'yyyy-MM-dd\'})\"");

WriteLiteral(" id=\"ValidityEnd\"");

WriteLiteral(" name=\"ValidityEnd\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1937), Tuple.Create("\"", 1975)
            
            #line 31 "..\..\Areas\Product\Views\ProductCard\_\Edit.cshtml"
                                                                                                                                              , Tuple.Create(Tuple.Create("", 1945), Tuple.Create<System.Object, System.Int32>(Model.ValidityEnd_ShowValue
            
            #line default
            #line hidden
, 1945), false)
);

WriteLiteral(" style=\"width:120px;\"");

WriteLiteral(">\r\n</td></tr>\r\n<tr");

WriteLiteral(" id=\"Container_Times\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_Times\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">次数：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"Times\"");

WriteLiteral(" name=\"Times\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2136), Tuple.Create("\"", 2158)
            
            #line 34 "..\..\Areas\Product\Views\ProductCard\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 2144), Tuple.Create<System.Object, System.Int32>(Model.Times
            
            #line default
            #line hidden
, 2144), false)
);

WriteLiteral(" class=\"easyui-numberbox\"");

WriteLiteral(" min=\"0\"");

WriteLiteral(" max=\"1000000\"");

WriteLiteral("  style=\"width:200px;\"");

WriteLiteral("/>\r\n</td></tr>\r\n<tr");

WriteLiteral(" id=\"Container_Balance\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_Balance\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">余额：</td><td>&nbsp;\r\n<input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"Balance\"");

WriteLiteral(" name=\"Balance\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2376), Tuple.Create("\"", 2400)
            
            #line 37 "..\..\Areas\Product\Views\ProductCard\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 2384), Tuple.Create<System.Object, System.Int32>(Model.Balance
            
            #line default
            #line hidden
, 2384), false)
);

WriteLiteral(" class=\"easyui-validatebox textbox\"");

WriteLiteral("  maxlength=\"8\"");

WriteLiteral(" style=\"width:200px\"");

WriteLiteral(" />\r\n</td></tr>\r\n<tr");

WriteLiteral(" id=\"Container_CreateTime\"");

WriteLiteral("><td");

WriteLiteral(" id=\"Label_CreateTime\"");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">创建时间：</td><td>&nbsp;    <input");

WriteLiteral(" class=\"Wdate\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" onClick=\"WdatePicker({dateFmt:\'yyyy-MM-dd HH:mm:ss\'})\"");

WriteLiteral(" id=\"CreateTime\"");

WriteLiteral(" name=\"CreateTime\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2705), Tuple.Create("\"", 2790)
            
            #line 39 "..\..\Areas\Product\Views\ProductCard\_\Edit.cshtml"
                                                                                                                                                  , Tuple.Create(Tuple.Create("", 2713), Tuple.Create<System.Object, System.Int32>(Model.CreateTime==null?"":Model.CreateTime.ToString("yyyy-MM-dd HH:mm:ss")
            
            #line default
            #line hidden
, 2713), false)
);

WriteLiteral(" style=\"width:135px;\"");

WriteLiteral(">\r\n</td></tr>\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"MemberID\"");

WriteLiteral("  name=\"MemberID\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2878), Tuple.Create("\"", 2903)
            
            #line 41 "..\..\Areas\Product\Views\ProductCard\_\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 2886), Tuple.Create<System.Object, System.Int32>(Model.MemberID
            
            #line default
            #line hidden
, 2886), false)
);

WriteLiteral("/>\r\n</table>\r\n\r\n");

WriteLiteral("        ");

            
            #line 44 "..\..\Areas\Product\Views\ProductCard\_\Edit.cshtml"
   Write(RenderPage("~/Areas/Product/Views/ProductCard/Extend/Model_FormHtml.cshtml"));

            
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
jQuery('input[name=CardType]').bind('click', CheckConditions);
function CheckConditions(){
if(IsInCheckBox(document.myForm.CardType,'4')){
jQuery('#Container_Balance').show();
} 
else{ 
jQuery('#Container_Balance').hide();
} 
if(IsInCheckBox(document.myForm.CardType,'1')){
jQuery('#Container_Times').show();
} 
else{ 
jQuery('#Container_Times').hide();
} 
if((IsInCheckBox(document.myForm.CardType,'2')||IsInCheckBox(document.myForm.CardType,'3'))){
jQuery('#Container_ValidityEnd').show();
} 
else{ 
jQuery('#Container_ValidityEnd').hide();
} 
if((IsInCheckBox(document.myForm.CardType,'2')||IsInCheckBox(document.myForm.CardType,'3'))){
jQuery('#Container_ValidityStart').show();
} 
else{ 
jQuery('#Container_ValidityStart').hide();
} 
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

            
            #line 97 "..\..\Areas\Product\Views\ProductCard\_\Edit.cshtml"
Write(RenderPage("~/Areas/Product/Views/ProductCard/Extend/Model_FormJs.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
