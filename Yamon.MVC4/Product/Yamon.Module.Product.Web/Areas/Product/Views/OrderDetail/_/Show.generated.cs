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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Product/Views/OrderDetail/_/Show.cshtml")]
    public partial class _Areas_Product_Views_OrderDetail___Show_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Product_Views_OrderDetail___Show_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 2 "..\..\Areas\Product\Views\OrderDetail\_\Show.cshtml"
  
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

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" region=\"center\"");

WriteLiteral(" border=\"true\"");

WriteLiteral(" style=\"padding: 10px; background: #F6F6F6; border: 1px solid #ccc;\"");

WriteLiteral(">\r\n    <form");

WriteLiteral(" id=\"myForm\"");

WriteLiteral(" name=\"myForm\"");

WriteLiteral(" action=\"/api/Product/OrderDetail/Show\"");

WriteLiteral(" method=\"post\"");

WriteLiteral(">\r\n        <table");

WriteLiteral(" class=\"mytable\"");

WriteLiteral("  cellpadding=\"1\"");

WriteLiteral(" width=\"100%\"");

WriteLiteral(" cellspacing=\"0\"");

WriteLiteral(" align=\"center\"");

WriteLiteral(">\r\n<tr");

WriteLiteral(" id=\"Container_OrderDetailID\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">ID：</td><td>&nbsp;<span");

WriteLiteral(" id=\"OrderDetailID\"");

WriteLiteral(">");

            
            #line 19 "..\..\Areas\Product\Views\OrderDetail\_\Show.cshtml"
                                                           Write(Html.Raw(Model.OrderDetailID));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">订单编号：</td><td>&nbsp;<span");

WriteLiteral(" id=\"OrderID\"");

WriteLiteral(">");

            
            #line 20 "..\..\Areas\Product\Views\OrderDetail\_\Show.cshtml"
                                                       Write(Html.Raw(Model.OrderID));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_ProductID\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">商品编号：</td><td>&nbsp;<span");

WriteLiteral(" id=\"ProductID\"");

WriteLiteral(">");

            
            #line 23 "..\..\Areas\Product\Views\OrderDetail\_\Show.cshtml"
                                                         Write(Html.Raw(Model.ProductID));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">商品条码：</td><td>&nbsp;<span");

WriteLiteral(" id=\"ProductNo\"");

WriteLiteral(">");

            
            #line 24 "..\..\Areas\Product\Views\OrderDetail\_\Show.cshtml"
                                                         Write(Html.Raw(Model.ProductNo));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_Price\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">原价：</td><td>&nbsp;<span");

WriteLiteral(" id=\"Price\"");

WriteLiteral(">");

            
            #line 27 "..\..\Areas\Product\Views\OrderDetail\_\Show.cshtml"
                                                   Write(Html.Raw(Model.Price));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">数量：</td><td>&nbsp;<span");

WriteLiteral(" id=\"Num\"");

WriteLiteral(">");

            
            #line 28 "..\..\Areas\Product\Views\OrderDetail\_\Show.cshtml"
                                                 Write(Html.Raw(Model.Num));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_SalePrice\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">销售价格：</td><td>&nbsp;<span");

WriteLiteral(" id=\"SalePrice\"");

WriteLiteral(">");

            
            #line 31 "..\..\Areas\Product\Views\OrderDetail\_\Show.cshtml"
                                                         Write(Html.Raw(Model.SalePrice));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">总金额：</td><td>&nbsp;<span");

WriteLiteral(" id=\"TotalMoney\"");

WriteLiteral(">");

            
            #line 32 "..\..\Areas\Product\Views\OrderDetail\_\Show.cshtml"
                                                         Write(Html.Raw(Model.TotalMoney));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_Comment\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">备注：</td><td>&nbsp;<span");

WriteLiteral(" id=\"Comment\"");

WriteLiteral(">");

            
            #line 35 "..\..\Areas\Product\Views\OrderDetail\_\Show.cshtml"
                                                     Write(Html.Raw(Model.Comment));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">备用字段1：</td><td>&nbsp;<span");

WriteLiteral(" id=\"BackField1\"");

WriteLiteral(">");

            
            #line 36 "..\..\Areas\Product\Views\OrderDetail\_\Show.cshtml"
                                                           Write(Html.Raw(Model.BackField1));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n</tr>\r\n<tr");

WriteLiteral(" id=\"Container_BackField2\"");

WriteLiteral(">\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">备用字段2：</td><td>&nbsp;<span");

WriteLiteral(" id=\"BackField2\"");

WriteLiteral(">");

            
            #line 39 "..\..\Areas\Product\Views\OrderDetail\_\Show.cshtml"
                                                           Write(Html.Raw(Model.BackField2));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n<td");

WriteLiteral(" class=\"labeltd\"");

WriteLiteral(">状态：</td><td>&nbsp;<span");

WriteLiteral(" id=\"Status\"");

WriteLiteral(">");

            
            #line 40 "..\..\Areas\Product\Views\OrderDetail\_\Show.cshtml"
                                                    Write(Html.Raw(Model.Status_ShowValue));

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n</tr>\r\n\r\n</table>\r\n\r\n");

WriteLiteral("        ");

            
            #line 45 "..\..\Areas\Product\Views\OrderDetail\_\Show.cshtml"
   Write(RenderPage("~/Areas/Product/Views/OrderDetail/Extend/Model_ViewHtml.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </form>\r\n</div>\r\n<div");

WriteLiteral(" region=\"south\"");

WriteLiteral(" border=\"false\"");

WriteLiteral(" style=\"text-align: right; background: #F6F6F6;height: 30px; line-height: 30px;\"");

WriteLiteral(">\r\n    <a");

WriteLiteral(" id=\"btnCancel\"");

WriteLiteral(" class=\"easyui-linkbutton\"");

WriteLiteral(" icon=\"icon-cancel\"");

WriteLiteral(" href=\"javascript:CloseDialog();\"");

WriteLiteral(">\r\n        关闭\r\n    </a>\r\n</div>\r\n");

            
            #line 53 "..\..\Areas\Product\Views\OrderDetail\_\Show.cshtml"
Write(RenderPage("~/Areas/Product/Views/OrderDetail/Extend/Model_ViewJs.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
