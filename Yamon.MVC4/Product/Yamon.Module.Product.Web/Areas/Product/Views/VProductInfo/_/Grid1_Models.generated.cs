﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    
    #line 24 "..\..\Areas\Product\Views\VProductInfo\_\Grid1_Models.cshtml"
    using System.Data;
    
    #line default
    #line hidden
    using System.IO;
    using System.Linq;
    using System.Net;
    
    #line 25 "..\..\Areas\Product\Views\VProductInfo\_\Grid1_Models.cshtml"
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Product/Views/VProductInfo/_/Grid1_Models.cshtml")]
    public partial class _Areas_Product_Views_VProductInfo___Grid1_Models_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Product_Views_VProductInfo___Grid1_Models_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n\r\n");

            
            #line 3 "..\..\Areas\Product\Views\VProductInfo\_\Grid1_Models.cshtml"
  
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

            
            #line 17 "..\..\Areas\Product\Views\VProductInfo\_\Grid1_Models.cshtml"
Write(RenderPage("~/Areas/Product/Views/VProductInfo/Extend/Model_GridHtml.cshtml"));

            
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

            
            #line 20 "..\..\Areas\Product\Views\VProductInfo\_\Grid1_Models.cshtml"
        
            
            #line default
            #line hidden
            
            #line 20 "..\..\Areas\Product\Views\VProductInfo\_\Grid1_Models.cshtml"
         foreach (ToolBar tool in ViewBag.ToolbarList)
{

            
            #line default
            #line hidden
WriteLiteral("    <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteAttribute("id", Tuple.Create(" id=\"", 713), Tuple.Create("\"", 735)
            
            #line 22 "..\..\Areas\Product\Views\VProductInfo\_\Grid1_Models.cshtml"
, Tuple.Create(Tuple.Create("", 718), Tuple.Create<System.Object, System.Int32>(tool.ToolBarID
            
            #line default
            #line hidden
, 718), false)
);

WriteLiteral(" class=\"easyui-linkbutton\"");

WriteAttribute("iconcls", Tuple.Create(" iconcls=\"", 762), Tuple.Create("\"", 789)
            
            #line 22 "..\..\Areas\Product\Views\VProductInfo\_\Grid1_Models.cshtml"
             , Tuple.Create(Tuple.Create("", 772), Tuple.Create<System.Object, System.Int32>(tool.ClassName
            
            #line default
            #line hidden
, 772), false)
);

WriteLiteral(" plain=\"true\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 803), Tuple.Create("\"", 877)
, Tuple.Create(Tuple.Create("", 813), Tuple.Create("T_", 813), true)
            
            #line 22 "..\..\Areas\Product\Views\VProductInfo\_\Grid1_Models.cshtml"
                                                        , Tuple.Create(Tuple.Create("", 815), Tuple.Create<System.Object, System.Int32>(tool.ToolBarID.Replace("-","")
            
            #line default
            #line hidden
, 815), false)
, Tuple.Create(Tuple.Create("", 848), Tuple.Create("ClickHandler();return", 848), true)
, Tuple.Create(Tuple.Create(" ", 869), Tuple.Create("false;", 870), true)
, Tuple.Create(Tuple.Create(" ", 876), Tuple.Create("", 876), true)
);

WriteLiteral(">");

            
            #line 22 "..\..\Areas\Product\Views\VProductInfo\_\Grid1_Models.cshtml"
                                                                                                                                                                                                  Write(tool.ToolBarName);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 23 "..\..\Areas\Product\Views\VProductInfo\_\Grid1_Models.cshtml"
}

            
            #line default
            #line hidden
DefineSection("scripts_toolbar", () => {

WriteLiteral("\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n");

            
            #line 29 "..\..\Areas\Product\Views\VProductInfo\_\Grid1_Models.cshtml"
    
            
            #line default
            #line hidden
            
            #line 29 "..\..\Areas\Product\Views\VProductInfo\_\Grid1_Models.cshtml"
     foreach (ToolBar tool in ViewBag.ToolbarList)
    {

            
            #line default
            #line hidden
WriteLiteral("    ");

WriteLiteral(" function T_");

            
            #line 31 "..\..\Areas\Product\Views\VProductInfo\_\Grid1_Models.cshtml"
              Write(tool.ToolBarID.Replace("-",""));

            
            #line default
            #line hidden
WriteLiteral("ClickHandler() {\r\n");

WriteLiteral("    ");

WriteLiteral("     ");

            
            #line 32 "..\..\Areas\Product\Views\VProductInfo\_\Grid1_Models.cshtml"
      Write(Html.Raw(tool.OnClick));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

WriteLiteral("     return false;\r\n");

WriteLiteral("    ");

WriteLiteral(" }\r\n");

            
            #line 35 "..\..\Areas\Product\Views\VProductInfo\_\Grid1_Models.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</script>\r\n");

});

WriteLiteral("\r\n        <span");

WriteLiteral(" id=\"span_ProductTypeId\"");

WriteLiteral("  style=\"height:24px;display: inline-block;\"");

WriteLiteral(">商品类型ID：<input");

WriteLiteral(" class=\"easyui-textbox\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"ProductTypeId\"");

WriteLiteral(" name=\"ProductTypeId\"");

WriteLiteral(" value=\"\"");

WriteLiteral(" style=\"width:100px\"");

WriteLiteral(" /></span>\r\n<span");

WriteLiteral(" id=\"span_ProductInfoNo\"");

WriteLiteral("  style=\"height:24px;display: inline-block;\"");

WriteLiteral(">商品编号：<input");

WriteLiteral(" class=\"easyui-textbox\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"ProductInfoNo\"");

WriteLiteral(" name=\"ProductInfoNo\"");

WriteLiteral(" value=\"\"");

WriteLiteral(" style=\"width:100px\"");

WriteLiteral(" /></span>\r\n<span");

WriteLiteral(" id=\"span_ProductName\"");

WriteLiteral("  style=\"height:24px;display: inline-block;\"");

WriteLiteral(">商品名称：<input");

WriteLiteral(" class=\"easyui-textbox\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"ProductName\"");

WriteLiteral(" name=\"ProductName\"");

WriteLiteral(" value=\"\"");

WriteLiteral(" style=\"width:100px\"");

WriteLiteral(" /></span>\r\n<span");

WriteLiteral(" id=\"span_CreateTime\"");

WriteLiteral("  style=\"height:24px;display: inline-block;\"");

WriteLiteral(">创建时间：<input");

WriteLiteral(" class=\"Wdate\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" onClick=\"WdatePicker({dateFmt:\'yyyy-MM-dd HH:mm:ss\'})\"");

WriteLiteral(" id=\"CreateTime_Start\"");

WriteLiteral(" name=\"CreateTime_Start\"");

WriteLiteral(" value=\"\"");

WriteLiteral(">\r\n到<input");

WriteLiteral(" class=\"Wdate\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" onClick=\"WdatePicker({dateFmt:\'yyyy-MM-dd HH:mm:ss\'})\"");

WriteLiteral(" id=\"CreateTime_End\"");

WriteLiteral(" name=\"CreateTime_End\"");

WriteLiteral(" value=\"\"");

WriteLiteral(">\r\n<script");

WriteLiteral(" src=\"/Resources/JsLib/My97DatePicker/WdatePicker.js\"");

WriteLiteral("></script></span>\r\n\r\n            <a");

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

WriteLiteral(">\r\n        var _baseUrl = \'/Product/VProductInfo\';\r\nvar _apiUrl = \'/api/Product/V" +
"ProductInfo\';\r\nvar _pageUrl = \'&Models=");

            
            #line 55 "..\..\Areas\Product\Views\VProductInfo\_\Grid1_Models.cshtml"
                    Write(RequestHelper.GetString("Models"));

            
            #line default
            #line hidden
WriteLiteral(@"';
var Data = {
BaseUrl: _baseUrl,
ApiUrl: _apiUrl,
FilterID: 'VProductInfo_Models',
DataUrl: _apiUrl + '/Grid1_Models?'+_pageUrl,
CreateUrl: _baseUrl + '/Create?'+_pageUrl,
EditUrl: _baseUrl + '/Edit/{id}?'+_pageUrl,
ShowUrl: _baseUrl + '/Show/',
BatchDeleteUrl: _apiUrl + '/BatchDelete?'+_pageUrl,
DeleteUrl: _apiUrl + '/Delete?'+_pageUrl,
ModuleID: 'Product',
ModelID: 'VProductInfo',
PageSize: 20,
DialogWidth: 700,
DialogHeight: 400,
FieldShowType_Name_FieldName: '',
TreeField: '',
FieldShowType_Name_Title: '',
ItemName: ""商品"",
PrimaryKey: 'ProductInfoId',
SortField: 'ProductInfoId',
OrderType: 'desc',
Height: 0,
UnAutoLoadGrid: ");

            
            #line 79 "..\..\Areas\Product\Views\VProductInfo\_\Grid1_Models.cshtml"
            Write(RequestHelper.GetInt("UnAutoLoadGrid"));

            
            #line default
            #line hidden
WriteLiteral(",\r\ncolumns: [[\r\n");

            
            #line 81 "..\..\Areas\Product\Views\VProductInfo\_\Grid1_Models.cshtml"
 foreach (ToolBar tool in ViewBag.ToolbarColumnList)
{
    if(tool.OrderID < 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        ");

WriteLiteral("{field: \'");

            
            #line 85 "..\..\Areas\Product\Views\VProductInfo\_\Grid1_Models.cshtml"
               Write(tool.ToolBarID);

            
            #line default
            #line hidden
WriteLiteral("\', title: \'");

            
            #line 85 "..\..\Areas\Product\Views\VProductInfo\_\Grid1_Models.cshtml"
                                           Write(tool.ToolBarName);

            
            #line default
            #line hidden
WriteLiteral("\', sortable: false,width:");

            
            #line 85 "..\..\Areas\Product\Views\VProductInfo\_\Grid1_Models.cshtml"
                                                                                       Write(tool.ToolBarName.Length*15+10);

            
            #line default
            #line hidden
WriteLiteral(",align:\'center\',formatter: function(value, row, index){\r\n");

WriteLiteral("        ");

WriteLiteral("    ");

            
            #line 86 "..\..\Areas\Product\Views\VProductInfo\_\Grid1_Models.cshtml"
         Write(Html.Raw(tool.OnClick));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

WriteLiteral("}},\r\n");

            
            #line 88 "..\..\Areas\Product\Views\VProductInfo\_\Grid1_Models.cshtml"
    }
}

            
            #line default
            #line hidden
WriteLiteral(@"
{field: 'ProductInfoId', title: '商品信息ID', sortable: true,width:100,hidden:true,align:'left'},
{field: 'TypeName', title: '类型名称', sortable: true,width:70,align:'left'},
{field: 'ProductInfoNo', title: '商品编号', sortable: true,width:70,align:'left'},
{field: 'ProductName', title: '商品名称', sortable: true,width:100,align:'left'},
{field: 'SalePrice', title: '销售价格', sortable: true,width:70,align:'right'},
{field: 'PurchasePrice', title: '进货价格', sortable: true,width:70,align:'right'},
{field: 'StockNum', title: '商品库存', sortable: true,width:70,align:'right'},
{field: 'SaleDiscountPercent', title: '出售折扣率', sortable: true,width:70,align:'right'},
{field: 'MinDiscountPercent', title: '最低折扣率', sortable: true,width:70,align:'right'},
{field: 'Models_ShowValue', title: '模型', sortable: true,width:50,align:'left'},
{field: 'Comment', title: '备注', sortable: true,width:100,hidden:true,align:'left'},
{field: 'CreateTime', title: '创建时间', sortable: true,width:200,align:'left'}
");

            
            #line 103 "..\..\Areas\Product\Views\VProductInfo\_\Grid1_Models.cshtml"
 foreach (ToolBar tool in ViewBag.ToolbarColumnList)
{
    if(tool.OrderID >= 0)
    {

            
            #line default
            #line hidden
WriteLiteral(",{field: \'");

            
            #line 107 "..\..\Areas\Product\Views\VProductInfo\_\Grid1_Models.cshtml"
        Write(tool.ToolBarID);

            
            #line default
            #line hidden
WriteLiteral("\', title: \'");

            
            #line 107 "..\..\Areas\Product\Views\VProductInfo\_\Grid1_Models.cshtml"
                                    Write(tool.ToolBarName);

            
            #line default
            #line hidden
WriteLiteral("\', sortable: false,width:");

            
            #line 107 "..\..\Areas\Product\Views\VProductInfo\_\Grid1_Models.cshtml"
                                                                                Write(tool.ToolBarName.Length*15+10);

            
            #line default
            #line hidden
WriteLiteral(",align:\'center\',formatter: function(value, row, index){\r\n");

WriteLiteral("    ");

            
            #line 108 "..\..\Areas\Product\Views\VProductInfo\_\Grid1_Models.cshtml"
 Write(Html.Raw(tool.OnClick));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("}}\r\n");

            
            #line 110 "..\..\Areas\Product\Views\VProductInfo\_\Grid1_Models.cshtml"
    }
}

            
            #line default
            #line hidden
WriteLiteral("]],\r\nfrozenColumns: [\r\n    [\r\n        {\r\n            field: \'ck\',\r\n            ch" +
"eckbox: true\r\n        }\r\n    ]\r\n],\r\ntoolbar: \'#toolbar\',\r\nsingleSelect: ");

            
            #line 122 "..\..\Areas\Product\Views\VProductInfo\_\Grid1_Models.cshtml"
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

            
            #line 130 "..\..\Areas\Product\Views\VProductInfo\_\Grid1_Models.cshtml"
Write(RenderPage("~/Areas/Product/Views/VProductInfo/Extend/Model_GridJs.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

        }
    }
}
#pragma warning restore 1591
