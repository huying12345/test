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
    
    #line 21 "..\..\Areas\Product\Views\ProductType\_\TreeGrid_Models.cshtml"
    using System.Data;
    
    #line default
    #line hidden
    using System.IO;
    using System.Linq;
    using System.Net;
    
    #line 22 "..\..\Areas\Product\Views\ProductType\_\TreeGrid_Models.cshtml"
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Product/Views/ProductType/_/TreeGrid_Models.cshtml")]
    public partial class _Areas_Product_Views_ProductType___TreeGrid_Models_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Product_Views_ProductType___TreeGrid_Models_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 2 "..\..\Areas\Product\Views\ProductType\_\TreeGrid_Models.cshtml"
  
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

WriteLiteral("></div>\r\n<div");

WriteLiteral(" id=\"toolbar\"");

WriteLiteral(" style=\"padding: 5px; height: auto\"");

WriteLiteral(">\r\n");

            
            #line 17 "..\..\Areas\Product\Views\ProductType\_\TreeGrid_Models.cshtml"
    
            
            #line default
            #line hidden
            
            #line 17 "..\..\Areas\Product\Views\ProductType\_\TreeGrid_Models.cshtml"
     foreach (ToolBar tool in ViewBag.ToolbarList)
{

            
            #line default
            #line hidden
WriteLiteral("    <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteAttribute("id", Tuple.Create(" id=\"", 557), Tuple.Create("\"", 579)
            
            #line 19 "..\..\Areas\Product\Views\ProductType\_\TreeGrid_Models.cshtml"
, Tuple.Create(Tuple.Create("", 562), Tuple.Create<System.Object, System.Int32>(tool.ToolBarID
            
            #line default
            #line hidden
, 562), false)
);

WriteLiteral(" class=\"easyui-linkbutton\"");

WriteAttribute("iconcls", Tuple.Create(" iconcls=\"", 606), Tuple.Create("\"", 633)
            
            #line 19 "..\..\Areas\Product\Views\ProductType\_\TreeGrid_Models.cshtml"
             , Tuple.Create(Tuple.Create("", 616), Tuple.Create<System.Object, System.Int32>(tool.ClassName
            
            #line default
            #line hidden
, 616), false)
);

WriteLiteral(" plain=\"true\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 647), Tuple.Create("\"", 721)
, Tuple.Create(Tuple.Create("", 657), Tuple.Create("T_", 657), true)
            
            #line 19 "..\..\Areas\Product\Views\ProductType\_\TreeGrid_Models.cshtml"
                                                        , Tuple.Create(Tuple.Create("", 659), Tuple.Create<System.Object, System.Int32>(tool.ToolBarID.Replace("-","")
            
            #line default
            #line hidden
, 659), false)
, Tuple.Create(Tuple.Create("", 692), Tuple.Create("ClickHandler();return", 692), true)
, Tuple.Create(Tuple.Create(" ", 713), Tuple.Create("false;", 714), true)
, Tuple.Create(Tuple.Create(" ", 720), Tuple.Create("", 720), true)
);

WriteLiteral(">");

            
            #line 19 "..\..\Areas\Product\Views\ProductType\_\TreeGrid_Models.cshtml"
                                                                                                                                                                                                  Write(tool.ToolBarName);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 20 "..\..\Areas\Product\Views\ProductType\_\TreeGrid_Models.cshtml"
}

            
            #line default
            #line hidden
DefineSection("scripts_toolbar", () => {

WriteLiteral("\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n");

            
            #line 26 "..\..\Areas\Product\Views\ProductType\_\TreeGrid_Models.cshtml"
    
            
            #line default
            #line hidden
            
            #line 26 "..\..\Areas\Product\Views\ProductType\_\TreeGrid_Models.cshtml"
     foreach (ToolBar tool in ViewBag.ToolbarList)
    {

            
            #line default
            #line hidden
WriteLiteral("    ");

WriteLiteral(" function T_");

            
            #line 28 "..\..\Areas\Product\Views\ProductType\_\TreeGrid_Models.cshtml"
              Write(tool.ToolBarID.Replace("-",""));

            
            #line default
            #line hidden
WriteLiteral("ClickHandler() {\r\n");

WriteLiteral("    ");

WriteLiteral("     ");

            
            #line 29 "..\..\Areas\Product\Views\ProductType\_\TreeGrid_Models.cshtml"
      Write(Html.Raw(tool.OnClick));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

WriteLiteral("     return false;\r\n");

WriteLiteral("    ");

WriteLiteral(" }\r\n");

            
            #line 32 "..\..\Areas\Product\Views\ProductType\_\TreeGrid_Models.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</script>\r\n");

});

WriteLiteral("</div>\r\n");

            
            #line 36 "..\..\Areas\Product\Views\ProductType\_\TreeGrid_Models.cshtml"
Write(RenderPage("~/Areas/Product/Views/ProductType/Extend/Model_GridHtml.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("scripts", () => {

WriteLiteral("\r\n    <script");

WriteLiteral(" src=\"/Resources/JsLib/jquery.query.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/Resources/JsLib/jquery.form.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/Static/v1/js/TreeGridUtils.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/Static/v1/js/SmartFormGrid.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        var _baseUrl = \'/Product/ProductType\';\r\nvar _apiUrl = \'/api/Product/Pr" +
"oductType\';\r\nvar _pageUrl = \'&Models=");

            
            #line 45 "..\..\Areas\Product\Views\ProductType\_\TreeGrid_Models.cshtml"
                    Write(RequestHelper.GetString("Models"));

            
            #line default
            #line hidden
WriteLiteral(@"';
var Data = {
BaseUrl: _baseUrl,
ApiUrl: _apiUrl,
FilterID: 'ProductType_Models',
DataUrl: _apiUrl + '/TreeGrid_Models?'+_pageUrl,
CreateUrl: _baseUrl + '/Create?'+_pageUrl,
EditUrl: _baseUrl + '/Edit/{id}?'+_pageUrl,
ShowUrl: _baseUrl + '/Show/',
BatchDeleteUrl: _apiUrl + '/BatchDelete?'+_pageUrl,
DeleteUrl: _apiUrl + '/Delete?'+_pageUrl,
ModuleID: 'Product',
ModelID: 'ProductType',
PageSize: 20,
DialogWidth: 700,
DialogHeight: 300,
FieldShowType_Name_FieldName: 'TypeName',
TreeField: 'TypeName',
FieldShowType_Name_Title: '名称',
ItemName: ""商品类型"",
PrimaryKey: 'ProductTypeId',
SortField: 'ProductTypeId',
OrderType: 'desc',
Height: 0,
UnAutoLoadGrid: ");

            
            #line 69 "..\..\Areas\Product\Views\ProductType\_\TreeGrid_Models.cshtml"
            Write(RequestHelper.GetInt("UnAutoLoadGrid"));

            
            #line default
            #line hidden
WriteLiteral(",\r\ncolumns: [[\r\n");

            
            #line 71 "..\..\Areas\Product\Views\ProductType\_\TreeGrid_Models.cshtml"
 foreach (ToolBar tool in ViewBag.ToolbarColumnList)
{
    if(tool.OrderID < 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        ");

WriteLiteral("{field: \'");

            
            #line 75 "..\..\Areas\Product\Views\ProductType\_\TreeGrid_Models.cshtml"
               Write(tool.ToolBarID);

            
            #line default
            #line hidden
WriteLiteral("\', title: \'");

            
            #line 75 "..\..\Areas\Product\Views\ProductType\_\TreeGrid_Models.cshtml"
                                           Write(tool.ToolBarName);

            
            #line default
            #line hidden
WriteLiteral("\', sortable: false,width:");

            
            #line 75 "..\..\Areas\Product\Views\ProductType\_\TreeGrid_Models.cshtml"
                                                                                       Write(tool.ToolBarName.Length*15+10);

            
            #line default
            #line hidden
WriteLiteral(",align:\'center\',formatter: function(value, row, index){\r\n");

WriteLiteral("        ");

WriteLiteral("    ");

            
            #line 76 "..\..\Areas\Product\Views\ProductType\_\TreeGrid_Models.cshtml"
         Write(Html.Raw(tool.OnClick));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

WriteLiteral("}},\r\n");

            
            #line 78 "..\..\Areas\Product\Views\ProductType\_\TreeGrid_Models.cshtml"
    }
}

            
            #line default
            #line hidden
WriteLiteral(@"
{field: 'ProductTypeId', title: 'ID', sortable: true,width:100,align:'left'},
{field: 'TypeName', title: '名称', sortable: true,width:300,align:'left'},
{field: 'OrderID', title: '排序', sortable: true,width:100,hidden:true,align:'left'},
{field: 'ParentID_ShowValue', title: '上级类别', sortable: true,width:100,hidden:true,align:'left'},
{field: 'Models_ShowValue', title: '模型', sortable: true,width:100,hidden:true,align:'left'}
");

            
            #line 86 "..\..\Areas\Product\Views\ProductType\_\TreeGrid_Models.cshtml"
 foreach (ToolBar tool in ViewBag.ToolbarColumnList)
{
    if(tool.OrderID >= 0)
    {

            
            #line default
            #line hidden
WriteLiteral(",{field: \'");

            
            #line 90 "..\..\Areas\Product\Views\ProductType\_\TreeGrid_Models.cshtml"
        Write(tool.ToolBarID);

            
            #line default
            #line hidden
WriteLiteral("\', title: \'");

            
            #line 90 "..\..\Areas\Product\Views\ProductType\_\TreeGrid_Models.cshtml"
                                    Write(tool.ToolBarName);

            
            #line default
            #line hidden
WriteLiteral("\', sortable: false,width:");

            
            #line 90 "..\..\Areas\Product\Views\ProductType\_\TreeGrid_Models.cshtml"
                                                                                Write(tool.ToolBarName.Length*15+10);

            
            #line default
            #line hidden
WriteLiteral(",align:\'center\',formatter: function(value, row, index){\r\n");

WriteLiteral("    ");

            
            #line 91 "..\..\Areas\Product\Views\ProductType\_\TreeGrid_Models.cshtml"
 Write(Html.Raw(tool.OnClick));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("}}\r\n");

            
            #line 93 "..\..\Areas\Product\Views\ProductType\_\TreeGrid_Models.cshtml"
    }
}

            
            #line default
            #line hidden
WriteLiteral("]],\r\nfrozenColumns: [\r\n    [\r\n        {\r\n            field: \'ck\',\r\n            ch" +
"eckbox: true\r\n        }\r\n    ]\r\n],\r\ntoolbar: \'#toolbar\',\r\nsingleSelect: ");

            
            #line 105 "..\..\Areas\Product\Views\ProductType\_\TreeGrid_Models.cshtml"
          Write(RequestHelper.GetBool("SingleSelect",true).ToString().ToLower());

            
            #line default
            #line hidden
WriteLiteral(@"
}
        
        jQuery(function() {
            window.onresize = setGridHeight;
            jQuery('#toolbar').append('<a id=""btnRefresh"" href=""javascript:void(0)""  class=""easyui-linkbutton"" iconcls=""icon-reload"" plain=""true"" onclick=""ReloadData();return false; "">刷新</a>');
            jQuery('#btnRefresh').linkbutton();
            jQuery('#tt').treegrid({
                iconCls: 'icon-save',
                url: Data.DataUrl,
                nowrap: true,
                rownumbers: true,
                animate: true,
                collapsible: true,
                idField: Data.PrimaryKey,
                treeField: Data.TreeField,
                onBeforeLoad: function(row, param) {
                    jQuery('#tt').datagrid('unselectAll');
                },
                onLoadError: function() {
                    jQuery.messager.alert('加载数据出错', ""加载数据出错"", 'error');
                },
                onLoadSuccess: function(row, data) {
                    if (data.total == ""-1"") {
                        jQuery.messager.alert('加载数据出错', data.msg, 'error');
                    }
                },
                onDblClickRow: function(row) {
                    OpenDialog_ViewFormByID(row[Data.PrimaryKey]);
                },
                columns: Data.columns,
                toolbar: Data.toolbar
            });
            setGridHeight();
        });
    </script>
");

            
            #line 141 "..\..\Areas\Product\Views\ProductType\_\TreeGrid_Models.cshtml"
Write(RenderPage("~/Areas/Product/Views/ProductType/Extend/Model_GridJs.cshtml"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

        }
    }
}
#pragma warning restore 1591
