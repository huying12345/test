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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/SiteManage/Views/VersionInfo/Version.cshtml")]
    public partial class _Areas_SiteManage_Views_VersionInfo_Version_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_SiteManage_Views_VersionInfo_Version_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Areas\SiteManage\Views\VersionInfo\Version.cshtml"
  
    Layout = null;

            
            #line default
            #line hidden
WriteLiteral("\r\n<!DOCTYPE html>\r\n<html");

WriteLiteral(" lang=\"zh-CN\"");

WriteLiteral(">\r\n<head>\r\n    <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" http-equiv=\"X-UA-Compatible\"");

WriteLiteral(" content=\"IE=edge\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width,initial-scale=1\"");

WriteLiteral(">\r\n    <title>版本更新日志</title>\r\n    <meta");

WriteLiteral(" name=\"description\"");

WriteLiteral(" content=\"jQuery is a fast and concise JavaScript Library that simplifies HTML do" +
"cument traversing, event handling, animating, and Ajax interactions for rapid we" +
"b development. jQuery is designed to change the way that you write JavaScript.\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" name=\"keywords\"");

WriteLiteral(" content=\"jquery,library,ajax,framework,toolkit,popular\"");

WriteLiteral(">\r\n    <link");

WriteLiteral(" href=\"/Resources/JsLib/bootstrap/css/bootstrap.min.css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteLiteral(" href=\"/Resources/JsLib/font-awesome/css/font-awesome.min.css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteLiteral(" href=\"/Static/SiteManage/css/version.css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <!--[if lt IE 9]>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 902), Tuple.Create("\"", 942)
, Tuple.Create(Tuple.Create("", 908), Tuple.Create<System.Object, System.Int32>(Href("~/Resources/JsLib/html5shiv.min.js")
, 908), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 966), Tuple.Create("\"", 1004)
, Tuple.Create(Tuple.Create("", 972), Tuple.Create<System.Object, System.Int32>(Href("~/Resources/JsLib/respond.min.js")
, 972), false)
);

WriteLiteral("></script>\r\n            <![endif]-->\r\n    <script>var _hmt = _hmt || [];</script>" +
"\r\n</head>\r\n<body");

WriteLiteral(" class=\"\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"navbar navbar-inverse navbar-fixed-top hidden-print navbar-back\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"container-fluid\"");

WriteLiteral(">\r\n            <a");

WriteLiteral(" href=\"/\"");

WriteLiteral(" class=\"btn btn-default navbar-btn btn-back\"");

WriteLiteral(">返回首页</a>\r\n        </div>\r\n    </div>\r\n    <header");

WriteLiteral(" class=\"site-header jumbotron\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"site-nav\"");

WriteLiteral(">\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n            <h1>版本更新日志</h1>\r\n            <p>我们一直在努力!</p>\r\n        </div>\r\n    " +
"</header>\r\n    <div");

WriteLiteral(" class=\"package-info well well-md\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n            <ul");

WriteLiteral(" class=\"list-inline\"");

WriteLiteral(">\r\n                ");

WriteLiteral("\r\n            </ul>\r\n        </div>\r\n    </div>\r\n\r\n    <main");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n\r\n");

            
            #line 48 "..\..\Areas\SiteManage\Views\VersionInfo\Version.cshtml"
        
            
            #line default
            #line hidden
            
            #line 48 "..\..\Areas\SiteManage\Views\VersionInfo\Version.cshtml"
         foreach (Yamon.Module.SiteManage.Entity.VersionInfo row in ViewBag.VersionList)
        {

            
            #line default
            #line hidden
WriteLiteral("            <a");

WriteLiteral(" class=\"version-anchor\"");

WriteLiteral(" id=\"3.0.0-alpha1\"");

WriteLiteral("></a>\r\n");

WriteLiteral("            <h3>版本：V");

            
            #line 51 "..\..\Areas\SiteManage\Views\VersionInfo\Version.cshtml"
                Write(row.Major);

            
            #line default
            #line hidden
WriteLiteral(".");

            
            #line 51 "..\..\Areas\SiteManage\Views\VersionInfo\Version.cshtml"
                             Write(row.Minor);

            
            #line default
            #line hidden
WriteLiteral(".");

            
            #line 51 "..\..\Areas\SiteManage\Views\VersionInfo\Version.cshtml"
                                          Write(row.Build);

            
            #line default
            #line hidden
WriteLiteral(".");

            
            #line 51 "..\..\Areas\SiteManage\Views\VersionInfo\Version.cshtml"
                                                       Write(row.Revision);

            
            #line default
            #line hidden
WriteLiteral(" Build");

            
            #line 51 "..\..\Areas\SiteManage\Views\VersionInfo\Version.cshtml"
                                                                            Write(row.CreatedDate.Value.ToString("yyyyMMdd"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n");

WriteLiteral("            <div");

WriteLiteral(" class=\"package-version\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"col-md-11 col-md-offset-1 col-sm-12\"");

WriteLiteral(">\r\n                        <pre>");

            
            #line 55 "..\..\Areas\SiteManage\Views\VersionInfo\Version.cshtml"
                         Write(Html.Raw(row.ChangeLog));

            
            #line default
            #line hidden
WriteLiteral("</pre>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");

            
            #line 59 "..\..\Areas\SiteManage\Views\VersionInfo\Version.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n    </main>\r\n    <footer");

WriteLiteral(" id=\"footer\"");

WriteLiteral(" class=\"footer hidden-print\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"about footer-col col-md-5 col-sm-12\"");

WriteLiteral(" id=\"about\"");

WriteLiteral(">\r\n\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </footer><" +
"a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" id=\"back-to-top\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-angle-up\"");

WriteLiteral("></i></a>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3131), Tuple.Create("\"", 3168)
, Tuple.Create(Tuple.Create("", 3137), Tuple.Create<System.Object, System.Int32>(Href("~/Resources/JsLib/jquery.min.js")
, 3137), false)
);

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/Resources/JsLib/bootstrap/js/bootstrap.min.js\"");

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3268), Tuple.Create("\"", 3307)
, Tuple.Create(Tuple.Create("", 3274), Tuple.Create<System.Object, System.Int32>(Href("~/Static/SiteManage/js/version.js")
, 3274), false)
);

WriteLiteral("></script>\r\n</body>\r\n</html>");

        }
    }
}
#pragma warning restore 1591
