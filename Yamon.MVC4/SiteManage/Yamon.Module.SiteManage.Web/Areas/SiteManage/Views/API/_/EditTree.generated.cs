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
    using System.Data;
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
    using Yamon.Module.SiteManage;
    using Yamon.Module.SiteManage.Entity;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/SiteManage/Views/API/_/EditTree.cshtml")]
    public partial class _Areas_SiteManage_Views_API___EditTree_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_SiteManage_Views_API___EditTree_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 2 "..\..\Areas\SiteManage\Views\API\_\EditTree.cshtml"
  
//------------------------------------------------------------------------------
// <auto-generated>
    //     此代码由亚萌智能表单代码生成工具生成。
    //
    //     对此文件的更改可能会导致不正确的行为，并且如果
    //     重新生成代码，这些更改将会丢失。除非此项目不再使用代码生成器生成。
    //     如果想修改此文件的内容，请复制一份到此文件的上级目录进行修改
    //
    //     如有问题联系zongeasy@qq.com
    //
//</auto-generated>
//------------------------------------------------------------------------------

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" region=\"center\"");

WriteLiteral(" border=\"true\"");

WriteLiteral(" style=\"padding: 10px; background: #F6F6F6; border: 1px solid #ccc;\"");

WriteLiteral(">\r\n    <ul");

WriteLiteral(" id=\"tt\"");

WriteLiteral("></ul>\r\n</div>\r\n<div");

WriteLiteral(" region=\"south\"");

WriteLiteral(" border=\"false\"");

WriteLiteral(" style=\"text-align: right; background: #F6F6F6; height: 30px; line-height: 30px;\"" +
"");

WriteLiteral(">\r\n    <a");

WriteLiteral(" id=\"btnCancel\"");

WriteLiteral("\r\n       class=\"easyui-linkbutton\"");

WriteLiteral(" icon=\"icon-cancel\"");

WriteLiteral(" href=\"javascript:CloseDialog();\"");

WriteLiteral(">\r\n        关闭\r\n    </a>\r\n</div>\r\n");

DefineSection("scripts", () => {

WriteLiteral("\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n    var _baseUrl = \'/SiteManage/API\';\r\n    var _apiUrl = \'/api/SiteManage/API\'" +
";\r\n    var _pageUrl = \'\';\r\n    jQuery(function () {\r\n        jQuery(\'#tt\').tree(" +
"{\r\n            url: _apiUrl + \'/EditTree?\' + _pageUrl,\r\n            animate: tru" +
"e,\r\n            dnd: true,\r\n            onDblClick: function (node) {\r\n         " +
"       jQuery(\'#tt\').tree(\'beginEdit\', node.target);\r\n            },\r\n          " +
"  onLoadSuccess: function (node, data) {\r\n                jQuery(\"#tt\").tree(\'co" +
"llapseAll\');\r\n            },\r\n            onAfterEdit: function (node) {\r\n      " +
"          jQuery.ajax({\r\n                    url: _apiUrl + \'/SaveEditTreeField\'" +
",\r\n                    type: \'post\',\r\n                    dataType: \'json\',\r\n   " +
"                 data: {\r\n                        id: node.id,\r\n                " +
"        value: node.text\r\n                    },\r\n                    success: f" +
"unction (data) {\r\n                        if (data.success) {\r\n                 " +
"           var node = $(\'#tt\').tree(\'getRoot\');\r\n                        } else " +
"{\r\n                            alert(data.message);\r\n                        }\r\n" +
"                        jQuery(\'#tt\').tree(\"reload\", node);\r\n                   " +
" }\r\n                });\r\n            },\r\n            onDrop: function (target, s" +
"ource, point) {\r\n\r\n                var targetId = jQuery(\'#tt\').tree(\'getNode\', " +
"target).id;\r\n\r\n                jQuery.ajax({\r\n                    url: _apiUrl +" +
" \'/SaveEditTree\',\r\n                    type: \'post\',\r\n                    dataTy" +
"pe: \'json\',\r\n                    data: {\r\n                        id: source.id," +
"\r\n                        targetId: targetId,\r\n                        point: po" +
"int\r\n                    },\r\n                    success: function (data) {\r\n   " +
"                     if (data.success) {\r\n                            var node =" +
" jQuery(\'#tt\').tree(\'getRoot\');\r\n                        } else {\r\n             " +
"               alert(data.message);\r\n                        }\r\n                " +
"        jQuery(\'#tt\').tree(\"reload\", node);\r\n                    }\r\n            " +
"    });\r\n            }\r\n        });\r\n    });\r\n\r\n</script>\r\n");

});

        }
    }
}
#pragma warning restore 1591
