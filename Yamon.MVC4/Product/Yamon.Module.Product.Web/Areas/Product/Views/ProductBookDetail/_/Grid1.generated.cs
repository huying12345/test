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
    
    #line 24 "..\..\Areas\Product\Views\ProductBookDetail\_\Grid1.cshtml"
    using System.Data;
    
    #line default
    #line hidden
    using System.IO;
    using System.Linq;
    using System.Net;
    
    #line 25 "..\..\Areas\Product\Views\ProductBookDetail\_\Grid1.cshtml"
    using System.Text;
    
    #line default
    #line hidden
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Product/Views/ProductBookDetail/_/Grid1.cshtml")]
    public partial class _Areas_Product_Views_ProductBookDetail___Grid1_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Product_Views_ProductBookDetail___Grid1_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n\r\n");

            
            #line 3 "..\..\Areas\Product\Views\ProductBookDetail\_\Grid1.cshtml"
  
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

WriteLiteral(" id=\"tt\"");

WriteLiteral("></div>\r\n");

            
            #line 17 "..\..\Areas\Product\Views\ProductBookDetail\_\Grid1.cshtml"
Write(RenderPage("~/Areas/Product/Views/ProductBookDetail/Extend/Model_GridHtml.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" id=\"toolbar\"");

WriteLiteral(" style=\"padding: 5px; height: auto\"");

WriteLiteral(">\r\n    <form");

WriteLiteral(" id=\"searchForm\"");

WriteLiteral(" name=\"searchForm\"");

WriteLiteral(" action=\"\"");

WriteLiteral(" method=\"post\"");

WriteLiteral(">\r\n");

            
            #line 20 "..\..\Areas\Product\Views\ProductBookDetail\_\Grid1.cshtml"
        
            
            #line default
            #line hidden
            
            #line 20 "..\..\Areas\Product\Views\ProductBookDetail\_\Grid1.cshtml"
         foreach (ToolBar tool in ViewBag.ToolbarList)
{

            
            #line default
            #line hidden
WriteLiteral("    <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteAttribute("id", Tuple.Create(" id=\"", 718), Tuple.Create("\"", 740)
            
            #line 22 "..\..\Areas\Product\Views\ProductBookDetail\_\Grid1.cshtml"
, Tuple.Create(Tuple.Create("", 723), Tuple.Create<System.Object, System.Int32>(tool.ToolBarID
            
            #line default
            #line hidden
, 723), false)
);

WriteLiteral(" class=\"easyui-linkbutton\"");

WriteAttribute("iconcls", Tuple.Create(" iconcls=\"", 767), Tuple.Create("\"", 794)
            
            #line 22 "..\..\Areas\Product\Views\ProductBookDetail\_\Grid1.cshtml"
             , Tuple.Create(Tuple.Create("", 777), Tuple.Create<System.Object, System.Int32>(tool.ClassName
            
            #line default
            #line hidden
, 777), false)
);

WriteLiteral(" plain=\"true\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 808), Tuple.Create("\"", 882)
, Tuple.Create(Tuple.Create("", 818), Tuple.Create("T_", 818), true)
            
            #line 22 "..\..\Areas\Product\Views\ProductBookDetail\_\Grid1.cshtml"
                                                        , Tuple.Create(Tuple.Create("", 820), Tuple.Create<System.Object, System.Int32>(tool.ToolBarID.Replace("-","")
            
            #line default
            #line hidden
, 820), false)
, Tuple.Create(Tuple.Create("", 853), Tuple.Create("ClickHandler();return", 853), true)
, Tuple.Create(Tuple.Create(" ", 874), Tuple.Create("false;", 875), true)
, Tuple.Create(Tuple.Create(" ", 881), Tuple.Create("", 881), true)
);

WriteLiteral(">");

            
            #line 22 "..\..\Areas\Product\Views\ProductBookDetail\_\Grid1.cshtml"
                                                                                                                                                                                                  Write(tool.ToolBarName);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 23 "..\..\Areas\Product\Views\ProductBookDetail\_\Grid1.cshtml"
}

            
            #line default
            #line hidden
DefineSection("scripts_toolbar", () => {

WriteLiteral("\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n");

            
            #line 29 "..\..\Areas\Product\Views\ProductBookDetail\_\Grid1.cshtml"
    
            
            #line default
            #line hidden
            
            #line 29 "..\..\Areas\Product\Views\ProductBookDetail\_\Grid1.cshtml"
     foreach (ToolBar tool in ViewBag.ToolbarList)
    {

            
            #line default
            #line hidden
WriteLiteral("    ");

WriteLiteral(" function T_");

            
            #line 31 "..\..\Areas\Product\Views\ProductBookDetail\_\Grid1.cshtml"
              Write(tool.ToolBarID.Replace("-",""));

            
            #line default
            #line hidden
WriteLiteral("ClickHandler() {\r\n");

WriteLiteral("    ");

WriteLiteral("     ");

            
            #line 32 "..\..\Areas\Product\Views\ProductBookDetail\_\Grid1.cshtml"
      Write(Html.Raw(tool.OnClick));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

WriteLiteral("     return false;\r\n");

WriteLiteral("    ");

WriteLiteral(" }\r\n");

            
            #line 35 "..\..\Areas\Product\Views\ProductBookDetail\_\Grid1.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</script>\r\n");

});

WriteLiteral("\r\n        <span");

WriteLiteral(" id=\"span_ProductBookDetailID\"");

WriteLiteral("  style=\"height:24px;display: inline-block;\"");

WriteLiteral(">预约编号：<input");

WriteLiteral(" class=\"easyui-textbox\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"ProductBookDetailID\"");

WriteLiteral(" name=\"ProductBookDetailID\"");

WriteLiteral(" value=\"\"");

WriteLiteral(" style=\"width:100px\"");

WriteLiteral(" /></span>\r\n<span");

WriteLiteral(" id=\"span_MakeTime\"");

WriteLiteral("  style=\"height:24px;display: inline-block;\"");

WriteLiteral(">预约时间：<input");

WriteLiteral(" class=\"Wdate\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" onClick=\"WdatePicker({dateFmt:\'yyyy-MM-dd HH:mm:ss\'})\"");

WriteLiteral(" id=\"MakeTime_Start\"");

WriteLiteral(" name=\"MakeTime_Start\"");

WriteLiteral(" value=\"\"");

WriteLiteral(">\r\n到<input");

WriteLiteral(" class=\"Wdate\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" onClick=\"WdatePicker({dateFmt:\'yyyy-MM-dd HH:mm:ss\'})\"");

WriteLiteral(" id=\"MakeTime_End\"");

WriteLiteral(" name=\"MakeTime_End\"");

WriteLiteral(" value=\"\"");

WriteLiteral(">\r\n<script");

WriteLiteral(" src=\"/Resources/JsLib/My97DatePicker/WdatePicker.js\"");

WriteLiteral("></script></span>\r\n<span");

WriteLiteral(" id=\"span_ProductBookID\"");

WriteLiteral("  style=\"height:24px;display: inline-block;\"");

WriteLiteral(">订单编号：<input");

WriteLiteral(" class=\"easyui-textbox\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"ProductBookID\"");

WriteLiteral(" name=\"ProductBookID\"");

WriteLiteral(" value=\"\"");

WriteLiteral(" style=\"width:100px\"");

WriteLiteral(" /></span>\r\n\r\n            <a");

WriteLiteral(" id=\"btnSubmit\"");

WriteLiteral(" class=\"easyui-linkbutton\"");

WriteLiteral(" icon=\"icon-search\"");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(">查询</a>\r\n    </form>\r\n</div>\r\n<div");

WriteLiteral(" id=\"PagerButtons\"");

WriteLiteral("><label><input");

WriteLiteral(" id=\"BatchCheck\"");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" />多选</label></div>\r\n");

DefineSection("scripts", () => {

WriteLiteral("\r\n\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
        var _baseUrl = '/Product/ProductBookDetail';
var _apiUrl = '/api/Product/ProductBookDetail';
var _pageUrl = '';
var Data = {
BaseUrl: _baseUrl,
ApiUrl: _apiUrl,
FilterID: '',
DataUrl: _apiUrl + '/Grid1?'+_pageUrl,
CreateUrl: _baseUrl + '/Create?'+_pageUrl,
EditUrl: _baseUrl + '/Edit/{id}?'+_pageUrl,
ShowUrl: _baseUrl + '/Show/',
BatchDeleteUrl: _apiUrl + '/BatchDelete?'+_pageUrl,
DeleteUrl: _apiUrl + '/Delete?'+_pageUrl,
ModuleID: 'Product',
ModelID: 'ProductBookDetail',
PageSize: 20,
DialogWidth: 700,
DialogHeight: 600,
FieldShowType_Name_FieldName: '',
TreeField: '',
FieldShowType_Name_Title: '',
ItemName: ""预约明细"",
PrimaryKey: 'ProductBookDetailID',
SortField: 'ProductBookDetailID',
OrderType: 'desc',
Height: 0,
UnAutoLoadGrid: ");

            
            #line 78 "..\..\Areas\Product\Views\ProductBookDetail\_\Grid1.cshtml"
            Write(RequestHelper.GetInt("UnAutoLoadGrid"));

            
            #line default
            #line hidden
WriteLiteral(",\r\ncolumns: [[\r\n");

            
            #line 80 "..\..\Areas\Product\Views\ProductBookDetail\_\Grid1.cshtml"
 foreach (ToolBar tool in ViewBag.ToolbarColumnList)
{
    if(tool.OrderID < 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        ");

WriteLiteral("{field: \'");

            
            #line 84 "..\..\Areas\Product\Views\ProductBookDetail\_\Grid1.cshtml"
               Write(tool.ToolBarID);

            
            #line default
            #line hidden
WriteLiteral("\', title: \'");

            
            #line 84 "..\..\Areas\Product\Views\ProductBookDetail\_\Grid1.cshtml"
                                           Write(tool.ToolBarName);

            
            #line default
            #line hidden
WriteLiteral("\', sortable: false,width:");

            
            #line 84 "..\..\Areas\Product\Views\ProductBookDetail\_\Grid1.cshtml"
                                                                                       Write(tool.ToolBarName.Length*15+10);

            
            #line default
            #line hidden
WriteLiteral(",align:\'center\',formatter: function(value, row, index){\r\n");

WriteLiteral("        ");

WriteLiteral("    ");

            
            #line 85 "..\..\Areas\Product\Views\ProductBookDetail\_\Grid1.cshtml"
         Write(Html.Raw(tool.OnClick));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

WriteLiteral("}},\r\n");

            
            #line 87 "..\..\Areas\Product\Views\ProductBookDetail\_\Grid1.cshtml"
    }
}

            
            #line default
            #line hidden
WriteLiteral(@"
{field: 'ProductBookDetailID', title: '预约编号', sortable: true,width:100,align:'left'},
{field: 'MakeTime', title: '预约时间', sortable: true,width:100,align:'left'},
{field: 'ProductBookID', title: '订单编号', sortable: true,width:100,align:'left'},
{field: 'ProductID', title: '商品编号', sortable: true,width:100,align:'left'},
{field: 'ProductNo', title: '商品条码', sortable: true,width:100,align:'left'},
{field: 'Price', title: '原价', sortable: true,width:100,align:'right'},
{field: 'Num', title: '数量', sortable: true,width:100,align:'right'},
{field: 'SalePrice', title: '销售价格', sortable: true,width:100,align:'right'},
{field: 'TotalMoney', title: '总金额', sortable: true,width:100,align:'right'},
{field: 'Comment', title: '备注', sortable: true,width:100,align:'left'},
{field: 'BackField1', title: '备用字段1', sortable: true,width:100,hidden:true,align:'left'},
{field: 'BackField2', title: '备用字段2', sortable: true,width:100,hidden:true,align:'left'}
");

            
            #line 102 "..\..\Areas\Product\Views\ProductBookDetail\_\Grid1.cshtml"
 foreach (ToolBar tool in ViewBag.ToolbarColumnList)
{
    if(tool.OrderID >= 0)
    {

            
            #line default
            #line hidden
WriteLiteral(",{field: \'");

            
            #line 106 "..\..\Areas\Product\Views\ProductBookDetail\_\Grid1.cshtml"
        Write(tool.ToolBarID);

            
            #line default
            #line hidden
WriteLiteral("\', title: \'");

            
            #line 106 "..\..\Areas\Product\Views\ProductBookDetail\_\Grid1.cshtml"
                                    Write(tool.ToolBarName);

            
            #line default
            #line hidden
WriteLiteral("\', sortable: false,width:");

            
            #line 106 "..\..\Areas\Product\Views\ProductBookDetail\_\Grid1.cshtml"
                                                                                Write(tool.ToolBarName.Length*15+10);

            
            #line default
            #line hidden
WriteLiteral(",align:\'center\',formatter: function(value, row, index){\r\n");

WriteLiteral("    ");

            
            #line 107 "..\..\Areas\Product\Views\ProductBookDetail\_\Grid1.cshtml"
 Write(Html.Raw(tool.OnClick));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("}}\r\n");

            
            #line 109 "..\..\Areas\Product\Views\ProductBookDetail\_\Grid1.cshtml"
    }
}

            
            #line default
            #line hidden
WriteLiteral("]],\r\nfrozenColumns: [\r\n    [\r\n        {\r\n            field: \'ck\',\r\n            ch" +
"eckbox: true\r\n        }\r\n    ]\r\n],\r\ntoolbar: \'#toolbar\',\r\nsingleSelect: ");

            
            #line 121 "..\..\Areas\Product\Views\ProductBookDetail\_\Grid1.cshtml"
          Write(RequestHelper.GetBool("SingleSelect",true).ToString().ToLower());

            
            #line default
            #line hidden
WriteLiteral("\r\n}\r\n    </script>\r\n    <script");

WriteLiteral(" src=\"/Resources/JsLib/jquery.query.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/Resources/JsLib/jquery.form.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/Static/v1/js/GridUtils.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/Static/v1/js/SmartFormGrid.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/Static/v1/js/Grid.js\"");

WriteLiteral("></script>\r\n");

            
            #line 129 "..\..\Areas\Product\Views\ProductBookDetail\_\Grid1.cshtml"
Write(RenderPage("~/Areas/Product/Views/ProductBookDetail/Extend/Model_GridJs.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

        }
    }
}
#pragma warning restore 1591
