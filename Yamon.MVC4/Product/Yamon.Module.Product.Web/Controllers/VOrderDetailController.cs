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
using Yamon.Module.SiteManage.DAL;
using Yamon.Framework.MVC;
using Yamon.Framework.Common.DataBase;



namespace Yamon.Module.Product.Web.Controllers
{
    /// <summary>
    /// 订单明细视图
    /// </summary>
    public partial class VOrderDetailController : _VOrderDetailController
    {
        [CheckPurview(param: "Models")]
        public override ActionResult Grid1_Models()
        {
            return base.Grid1_Models();
        }


    }
}
