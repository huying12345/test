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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/SiteManage/Views/API/ShowAPI1.cshtml")]
    public partial class _Areas_SiteManage_Views_API_ShowAPI1_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_SiteManage_Views_API_ShowAPI1_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"\"");

WriteLiteral(" style=\"padding-top: 10px;\"");

WriteLiteral(">\r\n    <p>\r\n");

WriteLiteral("        ");

            
            #line 3 "..\..\Areas\SiteManage\Views\API\ShowAPI1.cshtml"
    Write(Model.Remark);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </p>\r\n    <h4>一、请求URL</h4>\r\n    <ul>\r\n        <li><code>");

            
            #line 7 "..\..\Areas\SiteManage\Views\API\ShowAPI1.cshtml"
              Write(Model.Url);

            
            #line default
            #line hidden
WriteLiteral("</code></li>\r\n    </ul>\r\n    <h4>二、请求方式</h4>\r\n    <ul>\r\n        <li>");

            
            #line 11 "..\..\Areas\SiteManage\Views\API\ShowAPI1.cshtml"
        Write(Model.RequestType);

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n    </ul>\r\n    <h4>三、是否需要登录</h4>\r\n    <ul>\r\n        <li>");

            
            #line 15 "..\..\Areas\SiteManage\Views\API\ShowAPI1.cshtml"
        Write(Model.NeedUserLogin_ShowValue);

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n    </ul>\r\n    <h4>四、请求参数</h4>\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"RequestParam\"");

WriteLiteral(" autocomplete=\"off\"");

WriteAttribute("value", Tuple.Create(" value=\"", 432), Tuple.Create("\"", 461)
            
            #line 18 "..\..\Areas\SiteManage\Views\API\ShowAPI1.cshtml"
, Tuple.Create(Tuple.Create("", 440), Tuple.Create<System.Object, System.Int32>(Model.RequestParam
            
            #line default
            #line hidden
, 440), false)
);

WriteLiteral(" />\r\n    <div");

WriteLiteral(" id=\"RequestParamDiv\"");

WriteLiteral(">\r\n        <table");

WriteLiteral(" id=\"RequestParamTable\"");

WriteLiteral(">\r\n            <thead>\r\n                <tr");

WriteLiteral(" style=\"text-align: center\"");

WriteLiteral(">\r\n                    <th");

WriteLiteral(" style=\"width: 20%\"");

WriteLiteral(">参数名</th>\r\n                    <th");

WriteLiteral(" style=\"width: 20%\"");

WriteLiteral(">描述</th>\r\n                    <th");

WriteLiteral(" style=\"width: 10%\"");

WriteLiteral(">类型</th>\r\n                    <th");

WriteLiteral(" style=\"width: 10%\"");

WriteLiteral(">必需</th>\r\n                    <th");

WriteLiteral(" style=\"width: 10%\"");

WriteLiteral(">sign加密</th>\r\n                    <th");

WriteLiteral(" style=\"width: 30%\"");

WriteLiteral(">限制</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody");

WriteLiteral(" data-bind=\'foreach: params\'");

WriteLiteral(">\r\n                <tr>\r\n                    <td");

WriteLiteral(" data-bind=\'text: name\'");

WriteLiteral("></td>\r\n                    <td");

WriteLiteral(" data-bind=\'text: title\'");

WriteLiteral("></td>\r\n                    <td");

WriteLiteral(" data-bind=\'text: type\'");

WriteLiteral("></td>\r\n                    <td");

WriteLiteral(" data-bind=\'text: required\'");

WriteLiteral("></td>\r\n                    <td");

WriteLiteral(" data-bind=\'text: sign\'");

WriteLiteral("></td>\r\n                    <td");

WriteLiteral(" data-bind=\'text: desc\'");

WriteLiteral("></td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n    </div>" +
"\r\n    <h4>五、返回参数</h4>\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"ResponseParam\"");

WriteLiteral(" autocomplete=\"off\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1529), Tuple.Create("\"", 1559)
            
            #line 44 "..\..\Areas\SiteManage\Views\API\ShowAPI1.cshtml"
, Tuple.Create(Tuple.Create("", 1537), Tuple.Create<System.Object, System.Int32>(Model.ResponseParam
            
            #line default
            #line hidden
, 1537), false)
);

WriteLiteral(" />\r\n    <div");

WriteLiteral(" id=\"ResponseParamDiv\"");

WriteLiteral(">\r\n        <table");

WriteLiteral(" id=\"ResponseParamTable\"");

WriteLiteral(">\r\n            <thead>\r\n                <tr");

WriteLiteral(" style=\"text-align: center\"");

WriteLiteral(">\r\n                    <th");

WriteLiteral(" style=\"width: 20%\"");

WriteLiteral(">参数名</th>\r\n                    <th");

WriteLiteral(" style=\"width: 20%\"");

WriteLiteral(">描述</th>\r\n                    <th");

WriteLiteral(" style=\"width: 20%\"");

WriteLiteral(">类型</th>\r\n                    <th");

WriteLiteral(" style=\"width: 40%\"");

WriteLiteral(">说明</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody");

WriteLiteral(" data-bind=\'foreach: params\'");

WriteLiteral(">\r\n                <tr>\r\n                    <td");

WriteLiteral(" data-bind=\'text: name\'");

WriteLiteral("></td>\r\n                    <td");

WriteLiteral(" data-bind=\'text: title\'");

WriteLiteral("></td>\r\n                    <td");

WriteLiteral(" data-bind=\'text: type\'");

WriteLiteral("></td>\r\n                    <td");

WriteLiteral(" data-bind=\'text: desc\'");

WriteLiteral("></td>\r\n                </tr>\r\n                <tr");

WriteLiteral(" data-bind=\'visible: children().length>0\'");

WriteLiteral(">\r\n                    <td");

WriteLiteral(" colspan=\"5\"");

WriteLiteral(">\r\n                        <table>\r\n                            <tbody");

WriteLiteral(" data-bind=\"foreach: children\"");

WriteLiteral(">\r\n                                <tr>\r\n                                    <td");

WriteLiteral(" style=\"width: 20%\"");

WriteLiteral(" data-bind=\'text: name\'");

WriteLiteral("></td>\r\n                                    <td");

WriteLiteral(" style=\"width: 20%\"");

WriteLiteral(" data-bind=\'text: title\'");

WriteLiteral("></td>\r\n                                    <td");

WriteLiteral(" style=\"width: 20%\"");

WriteLiteral(" data-bind=\'text: type\'");

WriteLiteral("></td>\r\n                                    <td");

WriteLiteral(" style=\"width: 40%\"");

WriteLiteral(" data-bind=\'text: desc\'");

WriteLiteral("></td>\r\n                                </tr>\r\n                            </tbod" +
"y>\r\n                        </table>\r\n                    </td>\r\n               " +
" </tr>\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n    <h4>六、错误码</h4>\r\n" +
"    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"ErrorCodeParam\"");

WriteLiteral(" autocomplete=\"off\"");

WriteAttribute("value", Tuple.Create(" value=\"", 3166), Tuple.Create("\"", 3197)
            
            #line 80 "..\..\Areas\SiteManage\Views\API\ShowAPI1.cshtml"
, Tuple.Create(Tuple.Create("", 3174), Tuple.Create<System.Object, System.Int32>(Model.ErrorCodeParam
            
            #line default
            #line hidden
, 3174), false)
);

WriteLiteral(" />\r\n    <div");

WriteLiteral(" id=\"ErrorCodeDiv\"");

WriteLiteral(">\r\n        <table");

WriteLiteral(" id=\"ErrorCodeTable\"");

WriteLiteral(">\r\n            <thead>\r\n                <tr");

WriteLiteral(" style=\"text-align: center\"");

WriteLiteral(">\r\n                    <th");

WriteLiteral(" style=\"width: 30%\"");

WriteLiteral(">参数名</th>\r\n                    <th");

WriteLiteral(" style=\"width: 70%\"");

WriteLiteral(">描述</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody");

WriteLiteral(" data-bind=\'foreach: params\'");

WriteLiteral(">\r\n                <tr>\r\n                    <td");

WriteLiteral(" data-bind=\'text: name\'");

WriteLiteral("></td>\r\n                    <td");

WriteLiteral(" data-bind=\'text: desc\'");

WriteLiteral("></td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n    </div>" +
"\r\n    <h4>七、返回示例</h4>\r\n    <pre><code>");

            
            #line 98 "..\..\Areas\SiteManage\Views\API\ShowAPI1.cshtml"
           Write(Model.ResponseBody);

            
            #line default
            #line hidden
WriteLiteral("</code></pre>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
