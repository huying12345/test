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
    
    #line 23 "..\..\Areas\SiteManage\Views\City\_\TreeGrid.cshtml"
    using System.Data;
    
    #line default
    #line hidden
    using System.IO;
    using System.Linq;
    using System.Net;
    
    #line 24 "..\..\Areas\SiteManage\Views\City\_\TreeGrid.cshtml"
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
    using Yamon.Module.SiteManage;
    using Yamon.Module.SiteManage.Entity;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/SiteManage/Views/City/_/TreeGrid.cshtml")]
    public partial class _Areas_SiteManage_Views_City___TreeGrid_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_SiteManage_Views_City___TreeGrid_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 2 "..\..\Areas\SiteManage\Views\City\_\TreeGrid.cshtml"
  
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

            
            #line 17 "..\..\Areas\SiteManage\Views\City\_\TreeGrid.cshtml"
    
            
            #line default
            #line hidden
            
            #line 17 "..\..\Areas\SiteManage\Views\City\_\TreeGrid.cshtml"
      

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 19 "..\..\Areas\SiteManage\Views\City\_\TreeGrid.cshtml"
 foreach (ToolBar tool in ViewBag.ToolbarList)
{

            
            #line default
            #line hidden
WriteLiteral("    <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteAttribute("id", Tuple.Create(" id=\"", 564), Tuple.Create("\"", 586)
            
            #line 21 "..\..\Areas\SiteManage\Views\City\_\TreeGrid.cshtml"
, Tuple.Create(Tuple.Create("", 569), Tuple.Create<System.Object, System.Int32>(tool.ToolBarID
            
            #line default
            #line hidden
, 569), false)
);

WriteLiteral(" class=\"easyui-linkbutton\"");

WriteAttribute("iconcls", Tuple.Create(" iconcls=\"", 613), Tuple.Create("\"", 640)
            
            #line 21 "..\..\Areas\SiteManage\Views\City\_\TreeGrid.cshtml"
             , Tuple.Create(Tuple.Create("", 623), Tuple.Create<System.Object, System.Int32>(tool.ClassName
            
            #line default
            #line hidden
, 623), false)
);

WriteLiteral(" plain=\"true\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 654), Tuple.Create("\"", 728)
, Tuple.Create(Tuple.Create("", 664), Tuple.Create("T_", 664), true)
            
            #line 21 "..\..\Areas\SiteManage\Views\City\_\TreeGrid.cshtml"
                                                        , Tuple.Create(Tuple.Create("", 666), Tuple.Create<System.Object, System.Int32>(tool.ToolBarID.Replace("-","")
            
            #line default
            #line hidden
, 666), false)
, Tuple.Create(Tuple.Create("", 699), Tuple.Create("ClickHandler();return", 699), true)
, Tuple.Create(Tuple.Create(" ", 720), Tuple.Create("false;", 721), true)
, Tuple.Create(Tuple.Create(" ", 727), Tuple.Create("", 727), true)
);

WriteLiteral(">");

            
            #line 21 "..\..\Areas\SiteManage\Views\City\_\TreeGrid.cshtml"
                                                                                                                                                                                                  Write(tool.ToolBarName);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 22 "..\..\Areas\SiteManage\Views\City\_\TreeGrid.cshtml"
}

            
            #line default
            #line hidden
DefineSection("scripts_toolbar", () => {

WriteLiteral("\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n");

            
            #line 28 "..\..\Areas\SiteManage\Views\City\_\TreeGrid.cshtml"
    
            
            #line default
            #line hidden
            
            #line 28 "..\..\Areas\SiteManage\Views\City\_\TreeGrid.cshtml"
     foreach (ToolBar tool in ViewBag.ToolbarList)
    {

            
            #line default
            #line hidden
WriteLiteral("    ");

WriteLiteral(" function T_");

            
            #line 30 "..\..\Areas\SiteManage\Views\City\_\TreeGrid.cshtml"
              Write(tool.ToolBarID.Replace("-",""));

            
            #line default
            #line hidden
WriteLiteral("ClickHandler() {\r\n");

WriteLiteral("    ");

WriteLiteral("     ");

            
            #line 31 "..\..\Areas\SiteManage\Views\City\_\TreeGrid.cshtml"
      Write(Html.Raw(tool.OnClick));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

WriteLiteral("     return false;\r\n");

WriteLiteral("    ");

WriteLiteral(" }\r\n");

            
            #line 34 "..\..\Areas\SiteManage\Views\City\_\TreeGrid.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</script>\r\n");

});

WriteLiteral("</div>\r\n");

            
            #line 38 "..\..\Areas\SiteManage\Views\City\_\TreeGrid.cshtml"
Write(RenderPage("~/Areas/SiteManage/Views/City/Extend/Model_GridHtml.cshtml"));

            
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

WriteLiteral(@">
        var _baseUrl = '/SiteManage/City';
var _pageUrl = '';
var Data = {
BaseUrl: _baseUrl,
DataUrl: _baseUrl + '/TreeGridAction?'+_pageUrl,
CreateUrl: _baseUrl + '/Create?'+_pageUrl,
EditUrl: _baseUrl + '/Edit/{id}?'+_pageUrl,
ShowUrl: _baseUrl + '/Show/',
BatchDeleteUrl: _baseUrl + '/BatchDeleteAction?'+_pageUrl,
DeleteUrl: _baseUrl + '/DeleteAction?'+_pageUrl,
ModuleID: 'SiteManage',
ModelID: 'City',
PageSize: 20,
DialogWidth: 500,
DialogHeight: 400,
FieldShowType_Name_FieldName: 'DisplayName',
TreeField: 'DisplayName',
FieldShowType_Name_Title: '显示名称',
ItemName: ""城市站点"",
PrimaryKey: 'CityID',
SortField: 'CityID',
OrderType: 'asc',
Height: 0,
UnAutoLoadGrid: ");

            
            #line 68 "..\..\Areas\SiteManage\Views\City\_\TreeGrid.cshtml"
            Write(RequestHelper.GetInt("UnAutoLoadGrid"));

            
            #line default
            #line hidden
WriteLiteral(",\r\ncolumns: [[\r\n");

            
            #line 70 "..\..\Areas\SiteManage\Views\City\_\TreeGrid.cshtml"
 foreach (ToolBar tool in ViewBag.ToolbarColumnList)
{
    if(tool.OrderID < 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        ");

WriteLiteral("{field: \'");

            
            #line 74 "..\..\Areas\SiteManage\Views\City\_\TreeGrid.cshtml"
               Write(tool.ToolBarID);

            
            #line default
            #line hidden
WriteLiteral("\', title: \'");

            
            #line 74 "..\..\Areas\SiteManage\Views\City\_\TreeGrid.cshtml"
                                           Write(tool.ToolBarName);

            
            #line default
            #line hidden
WriteLiteral("\', sortable: false,width:");

            
            #line 74 "..\..\Areas\SiteManage\Views\City\_\TreeGrid.cshtml"
                                                                                       Write(tool.ToolBarName.Length*15+10);

            
            #line default
            #line hidden
WriteLiteral(",align:\'center\',formatter: function(value, row, index){\r\n");

WriteLiteral("        ");

WriteLiteral("    ");

            
            #line 75 "..\..\Areas\SiteManage\Views\City\_\TreeGrid.cshtml"
         Write(Html.Raw(tool.OnClick));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

WriteLiteral("}},\r\n");

            
            #line 77 "..\..\Areas\SiteManage\Views\City\_\TreeGrid.cshtml"
    }
}

            
            #line default
            #line hidden
WriteLiteral(@"
{field: 'CityID', title: '城市编码', sortable: true,width:60,align:'center'},
{field: 'ParentID_ShowValue', title: '上级城市', sortable: true,width:100,hidden:true,align:'left'},
{field: 'DisplayName', title: '显示名称', sortable: true,width:300,align:'left'},
{field: 'CityName', title: '城市名称', sortable: true,width:100,align:'center'},
{field: 'OrderID', title: '排序号', sortable: true,width:100,align:'center'},
{field: 'CityTypeID_ShowValue', title: '站点类型', sortable: true,width:100,align:'left'},
{field: 'Enabled_ShowValue', title: '是否启用', sortable: true,width:100,align:'center'},
{field: 'StationID', title: '站号', sortable: true,width:100,align:'left'}
");

            
            #line 88 "..\..\Areas\SiteManage\Views\City\_\TreeGrid.cshtml"
 foreach (ToolBar tool in ViewBag.ToolbarColumnList)
{
    if(tool.OrderID >= 0)
    {

            
            #line default
            #line hidden
WriteLiteral(",{field: \'");

            
            #line 92 "..\..\Areas\SiteManage\Views\City\_\TreeGrid.cshtml"
        Write(tool.ToolBarID);

            
            #line default
            #line hidden
WriteLiteral("\', title: \'");

            
            #line 92 "..\..\Areas\SiteManage\Views\City\_\TreeGrid.cshtml"
                                    Write(tool.ToolBarName);

            
            #line default
            #line hidden
WriteLiteral("\', sortable: false,width:");

            
            #line 92 "..\..\Areas\SiteManage\Views\City\_\TreeGrid.cshtml"
                                                                                Write(tool.ToolBarName.Length*15+10);

            
            #line default
            #line hidden
WriteLiteral(",align:\'center\',formatter: function(value, row, index){\r\n");

WriteLiteral("    ");

            
            #line 93 "..\..\Areas\SiteManage\Views\City\_\TreeGrid.cshtml"
 Write(Html.Raw(tool.OnClick));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("}}\r\n");

            
            #line 95 "..\..\Areas\SiteManage\Views\City\_\TreeGrid.cshtml"
    }
}

            
            #line default
            #line hidden
WriteLiteral("]],\r\nfrozenColumns: [\r\n    [\r\n        {\r\n            field: \'ck\',\r\n            ch" +
"eckbox: true\r\n        }\r\n    ]\r\n],\r\ntoolbar: \'#toolbar\',\r\nsingleSelect: false\r\n}" +
"\r\n        \r\n        jQuery(function() {\r\n            window.onresize = setGridHe" +
"ight;\r\n            jQuery(\'#toolbar\').append(\'<a id=\"btnRefresh\" href=\"javascrip" +
"t:void(0)\"  class=\"easyui-linkbutton\" iconcls=\"icon-reload\" plain=\"true\" onclick" +
"=\"ReloadData();return false; \">刷新</a>\');\r\n            jQuery(\'#btnRefresh\').link" +
"button();\r\n            jQuery(\'#tt\').treegrid({\r\n                iconCls: \'icon-" +
"save\',\r\n                url: _baseUrl + \'/TreeGridAction?\' + _pageUrl,\r\n        " +
"        nowrap: true,\r\n                rownumbers: true,\r\n                animat" +
"e: true,\r\n                collapsible: true,\r\n                idField: Data.Prim" +
"aryKey,\r\n                treeField: Data.TreeField,\r\n                onBeforeLoa" +
"d: function(row, param) {\r\n                    jQuery(\'#tt\').datagrid(\'unselectA" +
"ll\');\r\n                },\r\n                onLoadError: function() {\r\n          " +
"          jQuery.messager.alert(\'加载数据出错\', \"加载数据出错\", \'error\');\r\n                }" +
",\r\n                onLoadSuccess: function(row, data) {\r\n                    if " +
"(data.total == \"-1\") {\r\n                        jQuery.messager.alert(\'加载数据出错\', " +
"data.msg, \'error\');\r\n                    }\r\n                },\r\n                " +
"onDblClickRow: function(row) {\r\n                    OpenDialog_ViewFormByID(row[" +
"Data.PrimaryKey]);\r\n                },\r\n                columns: Data.columns,\r\n" +
"                toolbar: Data.toolbar\r\n            });\r\n            setGridHeigh" +
"t();\r\n        });\r\n    </script>\r\n");

});

        }
    }
}
#pragma warning restore 1591
