﻿
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由亚萌智能表单代码生成工具生成。
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。除非此项目不再使用代码生成器生成。
//     如果想修改此文件的方法，请在此文件的上级目录中的OrderInfoDAL重写(override)该方法。
//     如有问题联系zongeasy@qq.com
//
//</auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;
using Yamon.Framework.DBUtility;
using System.Collections;
using Yamon.Framework.Common.DataBase;
using Yamon.Framework.Common;
using Yamon.Framework.Common.IO;
using System.IO;
using System.Linq.Expressions;
using Yamon.Framework.DAL;
using Yamon.Module.Product.Entity;

namespace Yamon.Module.Product.DAL
{
    /// <summary>
    /// 订单实体类
    ///</summary>
    public partial class _OrderInfoDAL : BaseModelDAL<OrderInfo>
    {
        public _OrderInfoDAL():base("UCenter")
        {
        }

		/// <summary>
        /// 会员（MemberID）字段的数据集合（键值对）
        /// </summary>
		public MyNameValueCollection NameValue_MemberID
		{
			get
			{
			    Yamon.Module.Member.DAL.MemberInfoDAL dal = new Yamon.Module.Member.DAL.MemberInfoDAL();
                string cacheKey = dal.CacheKeyPrefix + "NameValue_MemberInfo";
                object obj=CacheHelper.Get(cacheKey);
                if (obj == null)
                {
                   obj= dal.GetAllEntityTable("MemberNo,MemberName").ToNameValueCollection();
                   CacheHelper.Insert(cacheKey,obj);
                }
                return (MyNameValueCollection) obj;

			}
		}
		/// <summary>
        /// 创建人（CreateUserID）字段的数据集合（键值对）
        /// </summary>
		public MyNameValueCollection NameValue_CreateUserID
		{
			get
			{
			    Yamon.Module.UCenter.DAL.UserDAL dal = new Yamon.Module.UCenter.DAL.UserDAL();
                string cacheKey = dal.CacheKeyPrefix + "NameValue_User";
                object obj=CacheHelper.Get(cacheKey);
                if (obj == null)
                {
                   obj= dal.GetAllEntityTable("UserID,UserName").ToNameValueCollection();
                   CacheHelper.Insert(cacheKey,obj);
                }
                return (MyNameValueCollection) obj;

			}
		}
		/// <summary>
        /// 状态（Status）字段的数据集合（键值对）
        /// </summary>
		public MyNameValueCollection NameValue_Status
		{
			get
			{
			    return Yamon.Module.SiteManage.DAL.DictTypeDAL.GetNameValueCollectionByID("a6007cb1-224d-4303-9733-1d891373cc6b");

			}
		}
		/// <summary>
        /// 支付状态（PayStatus）字段的数据集合（键值对）
        /// </summary>
		public MyNameValueCollection NameValue_PayStatus
		{
			get
			{
			    return Yamon.Module.SiteManage.DAL.DictTypeDAL.GetNameValueCollectionByID("2b30a823-35a4-42b7-9016-9cc911c2f805");

			}
		}
		/// <summary>
        /// 支付类型（PayType）字段的数据集合（键值对）
        /// </summary>
		public MyNameValueCollection NameValue_PayType
		{
			get
			{
			    return Yamon.Module.SiteManage.DAL.DictTypeDAL.GetNameValueCollectionByID("ad69e049-5617-4845-95c8-78512de97406");

			}
		}



		/// <summary>
		/// 获取数据实体列表(模型过滤)
		///</summary>
		/// <param name="nv">页面传递参数集合</param>
		/// <param name="topN">数据条数</param>
		/// <param name="fields">查询的字段</param>
		/// <returns>实体列表</returns>
        public virtual List<OrderInfo> GetEntityList_Models(int topN = 0,string fields="")
        {
            object[] arrParams = new object[] { RequestHelper.GetString("Models") };
            return GetEntityList("1=1 AND Models=? ",arrParams, "", topN,fields);
        }
		
		/// <summary>
		/// 获取数据实体列表(模型过滤)
		///</summary>
		/// <param name="fields">查询的字段</param>
		/// <returns>实体列表</returns>
        public virtual List<OrderInfo> GetAllEntityList_Models(string fields="")
        {
            return GetEntityList_Models(0,fields);
        }
		
		/// <summary>
		/// 获取分页的数据实体列表(模型过滤)
		///</summary>
		/// <param name="totalRows">记录总条数（out）</param>
		/// <param name="nv">页面传递参数集合</param>
		/// <param name="topN">数据条数</param>
		/// <param name="page">页码</param>
		/// <param name="rows">每页记录数</param>
		/// <param name="orderBy">排序</param>
		/// <returns>实体列表</returns>
        public virtual List<OrderInfo> GetEntityListByPage_Models(out int totalRows,int topN = 0, int page=1,int rows=20,string orderBy="")
        {
			string order = "";
			if (!string.IsNullOrEmpty(orderBy))
			{
			   order = orderBy;
			}
			object[] searchParams;
			string where = GetSearchSql("", out searchParams);
			object[] arrParams = new object[] { RequestHelper.GetString("Models") };
            arrParams=arrParams.Concat(searchParams).ToArray();
            string fields="OrderID,MemberID,CreateTime,CreateUserID,TotalMoney,UpdateTime,Comment,Models,Status,PayStatus,PayType";
            return GetEntityListByPage("1=1 AND Models=? "+ where, arrParams,order,fields ,rows,page,topN,out totalRows);
        }
		
		/// <summary>
		/// 获取数据列表DataTable(模型过滤)
		///</summary>
		/// <param name="nv">页面传递参数集合</param>
		/// <param name="topN">数据条数</param>
		/// <param name="fields">查询的字段</param>
		/// <returns>数据列表</returns>
        public virtual DataTable GetEntityTable_Models(int topN = 0,string fields="")
        {
            object[] arrParams = new object[] { RequestHelper.GetString("Models") };
            return GetEntityTable("1=1 AND Models=? ",arrParams, "", topN,fields);
        }
		
		/// <summary>
		/// 获取数据列表DataTable(模型过滤)
		///</summary>
		/// <param name="fields">查询的字段</param>
		/// <returns>数据列表</returns>
        public virtual DataTable GetAllEntityTable_Models(string fields="")
        {
        	return GetEntityTable_Models(0,fields);
        }
		/// <summary>
		/// 获取分页的数据列表DataTable(模型过滤)
		///</summary>
		/// <param name="totalRows">记录总条数（out）</param>
		/// <param name="nv">页面传递参数集合</param>
		/// <param name="topN">数据条数</param>
		/// <param name="page">页码</param>
		/// <param name="rows">每页记录数</param>
		/// <param name="orderBy">排序</param>
		/// <returns>DataTable</returns>
        public virtual DataTable GetEntityTableByPage_Models(out int totalRows,int topN = 0, int page=1,int rows=20,string orderBy="")
        {
			string order = "";
			if (!string.IsNullOrEmpty(orderBy))
			{
			    order = orderBy;
			}
			object[] searchParams;
			string where = GetSearchSql("", out searchParams);
			object[] arrParams = new object[] { RequestHelper.GetString("Models") };
            arrParams=arrParams.Concat(searchParams).ToArray();
            string fields="OrderID,MemberID,CreateTime,CreateUserID,TotalMoney,UpdateTime,Comment,Models,Status,PayStatus,PayType";
            return GetEntityTableByPage("1=1 AND Models=? "+ where, arrParams,order,fields, rows,page,topN,out totalRows);
        }

		/// <summary>
		/// 获取分页的数据实体列表
		///</summary>
		/// <param name="totalRows">记录总条数（out）</param>
		/// <param name="nv">页面传递参数集合</param>
		/// <param name="topN">数据条数</param>
		/// <param name="page">页码</param>
		/// <param name="rows">每页记录数</param>
		/// <param name="orderBy">排序</param>
		/// <returns>实体列表</returns>
		public virtual List<OrderInfo> GetEntityListByPage(out int totalRows,int topN = 0, int page=1,int rows=20,string orderBy="")
		{
			string order = "";
			if (!string.IsNullOrEmpty(orderBy))
			{
				order = orderBy;
			}
			object[] searchParams;
			string where = GetSearchSql("", out searchParams);
			string fields="OrderID,MemberID,CreateTime,CreateUserID,TotalMoney,UpdateTime,Comment,Models,Status,PayStatus,PayType";
			return GetEntityListByPage("1=1 "+ where, searchParams,order,fields, rows,page,topN,out totalRows);
		}

		/// <summary>
		/// 获取分页的数据列表DataTable
		///</summary>
		/// <param name="totalRows">记录总条数（out）</param>
		/// <param name="nv">页面传递参数集合</param>
		/// <param name="topN">数据条数</param>
		/// <param name="page">页码</param>
		/// <param name="rows">每页记录数</param>
		/// <param name="orderBy">排序</param>
		/// <returns>DataTable</returns>
		public virtual DataTable GetEntityTableByPage(out int totalRows,int topN = 0, int page=1,int rows=20,string orderBy="")
		{
			string order = "";
			if (!string.IsNullOrEmpty(orderBy))
			{
				order = orderBy;
			}
			object[] searchParams;
			string where = GetSearchSql("", out searchParams);
			string fields="OrderID,MemberID,CreateTime,CreateUserID,TotalMoney,UpdateTime,Comment,Models,Status,PayStatus,PayType";
			return GetEntityTableByPage("1=1 "+ where, searchParams,order,fields,rows,page,topN,out totalRows);
		}

		/// <summary>
        /// 拼接查询Sql语句及参数
        /// </summary>
        /// <param name="nv">页面传递的参数集合</param>
        /// <param name="notIn">排除字段</param>
        /// <param name="arrParam">out查询参数</param>
        /// <returns>查询Sql语句</returns>
		public virtual string GetSearchSql(string notIn,out object[] arrParam)
		{
			StringBuilder sb=new StringBuilder();
			string value="";
			string value1 = "";
			string value2 = "";
			ArrayList param=new ArrayList();
			
			
			//CreateTime
			if (!("," + notIn.ToLower() + ",").Contains(",createtime,"))
			{
					 value1 = RequestHelper.GetString("CreateTime_Start");
					 value2 = RequestHelper.GetString("CreateTime_End");
			    if (!string.IsNullOrEmpty(value1))
			    {
			      sb.Append(" AND [`CreateTime`] >=?");
			      param.Add(value1);
			    }
			    if (!string.IsNullOrEmpty(value2))
			    {
			      sb.Append(" AND [`CreateTime`] <=?");
			      param.Add(value2);
			    }
			}
			
			
			//Status
			if (!("," + notIn.ToLower() + ",").Contains(",status,"))
			{
				value = RequestHelper.GetString("Status");
				if (!string.IsNullOrEmpty(value))
				{
				 sb.Append(" AND [`Status`]=?");
				  param.Add(value);
				}
			}
			
			
			//PayStatus
			if (!("," + notIn.ToLower() + ",").Contains(",paystatus,"))
			{
				value = RequestHelper.GetString("PayStatus");
				if (!string.IsNullOrEmpty(value))
				{
				 sb.Append(" AND [`PayStatus`]=?");
				  param.Add(value);
				}
			}
			
			
			//PayType
			if (!("," + notIn.ToLower() + ",").Contains(",paytype,"))
			{
				value = RequestHelper.GetString("PayType");
				if (!string.IsNullOrEmpty(value))
				{
				 sb.Append(" AND [`PayType`]=?");
				  param.Add(value);
				}
			}
			
			
			//MemberID
			if (!("," + notIn.ToLower() + ",").Contains(",memberid,"))
			{
				value = RequestHelper.GetString("MemberID");
				if (!string.IsNullOrEmpty(value))
				{
				 sb.Append(" AND [`MemberID`]=?");
				  param.Add(value);
				}
			}
			arrParam=param.ToArray();
			return sb.ToString();

		}

		
	    public virtual OrderInfo GetModelValue(OrderInfo model)
        {
            return model;
        }
		/// <summary>
        /// 设置订单实体(OrderInfo)的显示值
        /// </summary>
        /// <param name="model">订单实体(OrderInfo)</param>
        /// <returns>订单实体(OrderInfo)</returns>
		public virtual OrderInfo GetModelShowValue(OrderInfo model,bool clearValue=false)
        {
            model=GetModelValue(model);
			if (model.MemberID!=null)
			{
				model.MemberID_ShowValue=NameValue_MemberID.Get(model.MemberID.ToString());
			}
			if (model.CreateUserID!=null)
			{
				model.CreateUserID_ShowValue=NameValue_CreateUserID.Get(model.CreateUserID.ToString());
			}
			if (model.Status!=null)
			{
				model.Status_ShowValue=NameValue_Status.Get(model.Status.ToString());
			}
			if (model.PayStatus!=null)
			{
				model.PayStatus_ShowValue=NameValue_PayStatus.Get(model.PayStatus.ToString());
			}
			if (model.PayType!=null)
			{
				model.PayType_ShowValue=NameValue_PayType.Get(model.PayType.ToString());
			}
			if(clearValue)
			{
				model.MemberID = null;
				model.CreateUserID = null;
				model.Status = null;
				model.PayStatus = null;
				model.PayType = null;
			}
			return model;
		}
		
		/// <summary>
        /// 设置订单实体(OrderInfo)的列表显示值
        /// </summary>
        /// <param name="model">订单实体(OrderInfo)</param>
        /// <returns>订单实体(OrderInfo)</returns>
		public virtual OrderInfo GetModelGridShowValue(OrderInfo model){
			model=GetModelShowValue(model);
			return model;
        }

        public virtual OrderInfo GetInfoByID(object id){
            OrderInfo model = GetModelByID(id);
            model = GetModelShowValue(model);
            return model;
        } 


      #region 新建相关方法
		/// <summary>
        /// 设置新增入库时订单实体(OrderInfo)默认值
        /// </summary>
        /// <param name="model">订单实体(OrderInfo)</param>
        /// <returns>订单实体(OrderInfo)</returns>
		public virtual OrderInfo GetInsertModelValue(OrderInfo model)
		{
			model.CreateUserID =(CookieHelper.GetCookieInt("UserID"));
			model.UpdateTime =(DateTime.Now);
			model.Status =0;
			return model;
		}		/// <summary>
        /// 设置新建页面的订单实体(OrderInfo)默认值
        /// </summary>
        /// <param name="model">订单实体(OrderInfo)</param>
        /// <returns>订单实体(OrderInfo)</returns>
		public virtual OrderInfo GetCreateFormDefaultValue()
		{
            OrderInfo model = new OrderInfo();
			model.CreateUserID=(CookieHelper.GetCookieInt("UserID"));
			model.UpdateTime=(DateTime.Now);
			model.PayStatus=1;
            return model;
		}

		/// <summary>
        /// 新建数据格式验证
        /// </summary>
        /// <param name="model">订单实体(OrderInfo)</param>
        public virtual void CreateFormValidator(OrderInfo model)
        {
			string value="";
			
			//OrderID验证
			value = model.OrderID!=null ? model.OrderID.ToString() : "";
		            if ( string.IsNullOrEmpty(value))
		            {
		             throw new Exception("订单编号不能为空！");
		            }
			
			//Status验证
			value = model.Status!=null ? model.Status.ToString() : "";
		            if ( string.IsNullOrEmpty(value))
		            {
		             throw new Exception("状态不能为空！");
		            }
			
			//PayStatus验证
			value = model.PayStatus!=null ? model.PayStatus.ToString() : "";
		            if ( string.IsNullOrEmpty(value))
		            {
		             throw new Exception("支付状态不能为空！");
		            }
			
			//PayType验证
			value = model.PayType!=null ? model.PayType.ToString() : "";
		            if ( string.IsNullOrEmpty(value))
		            {
		             throw new Exception("支付类型不能为空！");
		            }
}
      #endregion

      #region 修改相关方法
		/// <summary>
        /// 设置更新入库时订单实体(OrderInfo)默认值
        /// </summary>
        /// <param name="model">订单实体(OrderInfo)</param>
        /// <returns>订单实体(OrderInfo)</returns>
		public virtual OrderInfo GetUpdateModelValue(OrderInfo model)
		{
			model.UpdateTime = (DateTime.Now);
			return model;
		}		/// <summary>
        /// 设置编辑页面的订单实体(OrderInfo)默认值
        /// </summary>
        /// <param name="model">订单实体(OrderInfo)</param>
        /// <returns>订单实体(OrderInfo)</returns>
		public virtual OrderInfo GetEditFormDefaultValue(OrderInfo model)
		{
			model.UpdateTime=(DateTime.Now);
			return model;
		}

		/// <summary>
        /// 编辑数据格式验证
        /// </summary>
        /// <param name="model">订单实体(OrderInfo)</param>
        public virtual void EditFormValidator(OrderInfo model)
        {
			string value="";
			
			//Status验证
			value = model.Status!=null ? model.Status.ToString() : "";
		            if ( string.IsNullOrEmpty(value))
		            {
		             throw new Exception("状态不能为空！");
		            }
			
			//PayStatus验证
			value = model.PayStatus!=null ? model.PayStatus.ToString() : "";
		            if ( string.IsNullOrEmpty(value))
		            {
		             throw new Exception("支付状态不能为空！");
		            }
			
			//PayType验证
			value = model.PayType!=null ? model.PayType.ToString() : "";
		            if ( string.IsNullOrEmpty(value))
		            {
		             throw new Exception("支付类型不能为空！");
		            }
}
      #endregion

    }
}