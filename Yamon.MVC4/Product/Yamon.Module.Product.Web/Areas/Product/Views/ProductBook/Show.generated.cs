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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Product/Views/ProductBook/Show.cshtml")]
    public partial class _Areas_Product_Views_ProductBook_Show_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Product_Views_ProductBook_Show_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Areas\Product\Views\ProductBook\Show.cshtml"
  
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
WriteLiteral("\r\n");

DefineSection("styles", () => {

WriteLiteral("\r\n    <link");

WriteLiteral(" href=\"/Resources/JsLib/bootstrap/css/bootstrap.css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <style>\r\n        .panel-body {\r\n            padding: 0px !important;\r\n  " +
"      }\r\n    </style>\r\n\r\n");

});

DefineSection("scripts", () => {

WriteLiteral("\r\n    <script");

WriteLiteral(" src=\"/Resources/JsLib/bootstrap/js/bootstrap.js\"");

WriteLiteral("></script>\r\n");

});

WriteLiteral("<div");

WriteLiteral(" region=\"center\"");

WriteLiteral(" border=\"true\"");

WriteLiteral(" style=\"padding: 10px; background: #F6F6F6; border: 1px solid #ccc;\"");

WriteLiteral(">\r\n\r\n    <div");

WriteLiteral(" class=\"panel panel-primary\"");

WriteLiteral(">\r\n        <!-- Default panel contents -->\r\n        <div");

WriteLiteral(" class=\"panel-heading\"");

WriteLiteral(">预约订单信息</div>\r\n        <!-- Table -->\r\n        <table");

WriteLiteral(" class=\"table\"");

WriteLiteral(@">
            <thead>
                <tr>
                    <th>
                        预约订单编号
                    </th>

                        <th>
                            会员编号
                        </th>
    
                    <th>
                        总金额
                    </th>

                    <th>
                        创建时间
                    </th>
                    <th>
                        备注
                    </th>

                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>");

            
            #line 58 "..\..\Areas\Product\Views\ProductBook\Show.cshtml"
                    Write(Html.Raw(Model.ProductBookID));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n\r\n                        <td>");

            
            #line 60 "..\..\Areas\Product\Views\ProductBook\Show.cshtml"
                        Write(Html.Raw(Model.MemberID));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n\r\n                    <td>");

            
            #line 62 "..\..\Areas\Product\Views\ProductBook\Show.cshtml"
                    Write(Html.Raw(Model.TotalMoney));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    <td>");

            
            #line 63 "..\..\Areas\Product\Views\ProductBook\Show.cshtml"
                    Write(Html.Raw(Model.CreateTime));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    <td>");

            
            #line 64 "..\..\Areas\Product\Views\ProductBook\Show.cshtml"
                    Write(Html.Raw(Model.Comment));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n    </div>\r" +
"\n\r\n    <div");

WriteLiteral(" class=\"panel panel-primary\"");

WriteLiteral(">\r\n        <!-- Default panel contents -->\r\n        <div");

WriteLiteral(" class=\"panel-heading\"");

WriteLiteral(">订单明细</div>\r\n        <!-- Table -->\r\n        <table");

WriteLiteral(" class=\"table\"");

WriteLiteral(@">
            <thead>
                <tr>
                    <th>
                 预约编号
                    </th>
                    <th>
                        商品名称
                    </th>

                    <th>
                        原价
                    </th>

                    <th>
                        数量
                    </th>
                    <th>
                        预约时间
                    </th>
                </tr>
            </thead>
            <tbody>

");

            
            #line 98 "..\..\Areas\Product\Views\ProductBook\Show.cshtml"
                
            
            #line default
            #line hidden
            
            #line 98 "..\..\Areas\Product\Views\ProductBook\Show.cshtml"
                 foreach (var item in ViewBag.List)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <tr>\r\n                        <td>");

            
            #line 101 "..\..\Areas\Product\Views\ProductBook\Show.cshtml"
                        Write(item.ProductBookDetailID);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                        <td>");

            
            #line 102 "..\..\Areas\Product\Views\ProductBook\Show.cshtml"
                        Write(item.ProductName);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                        <td>");

            
            #line 103 "..\..\Areas\Product\Views\ProductBook\Show.cshtml"
                        Write(item.Price);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                        <td>");

            
            #line 104 "..\..\Areas\Product\Views\ProductBook\Show.cshtml"
                        Write(item.Num);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                        <td>");

            
            #line 105 "..\..\Areas\Product\Views\ProductBook\Show.cshtml"
                        Write(item.MakeTime);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n\r\n                    </tr>\r\n");

            
            #line 108 "..\..\Areas\Product\Views\ProductBook\Show.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n            </tbody>\r\n\r\n        </table>\r\n    </div>\r\n\r\n\r\n\r\n");

WriteLiteral("    ");

            
            #line 117 "..\..\Areas\Product\Views\ProductBook\Show.cshtml"
Write(RenderPage("~/Areas/Product/Views/OrderDetail/Extend/Model_ViewHtml.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n</div>\r\n<div");

WriteLiteral(" region=\"south\"");

WriteLiteral(" border=\"false\"");

WriteLiteral(" style=\"text-align: right; background: #F6F6F6;height: 30px; line-height: 30px;\"");

WriteLiteral(">\r\n    <a");

WriteLiteral(" id=\"btnCancel\"");

WriteLiteral(" class=\"easyui-linkbutton\"");

WriteLiteral(" icon=\"icon-cancel\"");

WriteLiteral(" href=\"javascript:CloseDialog();\"");

WriteLiteral(">\r\n        关闭\r\n    </a>\r\n</div>\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
