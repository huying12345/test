﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;
using System.IO;
using System.Linq.Expressions;
using System.Web.Mvc;
using Yamon.Framework.DAL;
using Yamon.Module.Product.Entity;
using Yamon.Module.Product.DAL;
using Newtonsoft.Json;
using Yamon.Framework.Common;
using Yamon.Framework.MVC;
using Yamon.Module.SiteManage.DAL;



namespace Yamon.Module.Product.WebApi
{
    /// <summary>
    /// 退单视图
    /// </summary>
    public partial class VOrderRefundController : _VOrderRefundController
    {
        [CheckPurview(0)]
        public override ActionResult Grid1()
        {
            return base.Grid1();
        }
    }
}
