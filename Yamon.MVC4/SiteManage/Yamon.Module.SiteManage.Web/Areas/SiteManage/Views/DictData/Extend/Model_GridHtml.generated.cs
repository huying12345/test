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
    
    #line 1 "..\..\Areas\SiteManage\Views\DictData\Extend\Model_GridHtml.cshtml"
    using Yamon.Framework.Common;
    
    #line default
    #line hidden
    using Yamon.Module.SiteManage;
    using Yamon.Module.SiteManage.Entity;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/SiteManage/Views/DictData/Extend/Model_GridHtml.cshtml")]
    public partial class _Areas_SiteManage_Views_DictData_Extend_Model_GridHtml_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_SiteManage_Views_DictData_Extend_Model_GridHtml_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n    jQuery(function () {\r\n        Data.DictTypeID = \"");

            
            #line 5 "..\..\Areas\SiteManage\Views\DictData\Extend\Model_GridHtml.cshtml"
                       Write(RequestHelper.GetString("DictTypeID"));

            
            #line default
            #line hidden
WriteLiteral(@""";
        $(""#tt"").wrap('<div id=""FormDiv"" class=""col-md-10""></div>');
        $(""#FormDiv"").wrap('<div class=""row""></div>');
        $(""#FormDiv"").after('<div class=""col-md-2""><div id=""groupTree"" style=""text-align:left""></div></div>');
        LoadGrid();
        jQuery('#groupTree').tree({
            url: '/api/SiteManage/DictType/EditTree',
            onSelect: function(node) {
                location.href = '/SiteManage/DictData/Grid1?&Frame=");

            
            #line 13 "..\..\Areas\SiteManage\Views\DictData\Extend\Model_GridHtml.cshtml"
                                                               Write(RequestHelper.GetInt("Frame"));

            
            #line default
            #line hidden
WriteLiteral("&Menu=Dictionary_List&DictTypeID=\' + node.id;\r\n            },\r\n            onLoad" +
"Success:function(data) {\r\n                //jQuery(\'#groupTree\').tree(\'collapseA" +
"ll\');\r\n            }\r\n        });\r\n    });\r\n</script>\r\n");

        }
    }
}
#pragma warning restore 1591
