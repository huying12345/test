﻿
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由亚萌智能表单代码生成工具生成。
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。除非此项目不再使用代码生成器生成。
//     如果想修改此文件的方法，请在此文件的上级目录中的VOrderDetailDAL重写(override)该方法。
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
    /// 订单明细视图实体类
    ///</summary>
    public partial class _VOrderDetailDAL : BaseModelDAL<VOrderDetail>
    {
        public _VOrderDetailDAL():base("UCenter")
        {
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
        /// 模型（Models）字段的数据集合（键值对）
        /// </summary>
		public MyNameValueCollection NameValue_Models
		{
			get
			{
			    return Yamon.Module.SiteManage.DAL.DictTypeDAL.GetNameValueCollectionByID("ce7932da-a2cb-4366-9c7a-6ae9aadc9e4f");

			}
		}
		/// <summary>
        /// 销售员（CreateUserID）字段的数据集合（键值对）
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
                   obj= dal.GetAllEntityTable("UserID,TrueName").ToNameValueCollection();
                   CacheHelper.Insert(cacheKey,obj);
                }
                return (MyNameValueCollection) obj;

			}
		}



		/// <summary>
		/// 获取数据实体列表(模型过滤)
		///</summary>
		/// <param name="nv">页面传递参数集合</param>
		/// <param name="topN">数据条数</param>
		/// <param name="fields">查询的字段</param>
		/// <returns>实体列表</returns>
        public virtual List<VOrderDetail> GetEntityList_Models(int topN = 0,string fields="")
        {
            object[] arrParams = new object[] { RequestHelper.GetString("Models") };
            return GetEntityList("1=1 AND Models=? ",arrParams, "", topN,fields);
        }
		
		/// <summary>
		/// 获取数据实体列表(模型过滤)
		///</summary>
		/// <param name="fields">查询的字段</param>
		/// <returns>实体列表</returns>
        public virtual List<VOrderDetail> GetAllEntityList_Models(string fields="")
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
        public virtual List<VOrderDetail> GetEntityListByPage_Models(out int totalRows,int topN = 0, int page=1,int rows=20,string orderBy="")
        {
			string order = "";
			if (!string.IsNullOrEmpty(orderBy))
			{
			   order = orderBy;
			}
			object[] searchParams;
			string where = GetSearchSql(",Models", out searchParams);
			object[] arrParams = new object[] { RequestHelper.GetString("Models") };
            arrParams=arrParams.Concat(searchParams).ToArray();
            string fields="OrderDetailID,Status,PayStatus,PayType,OrderID,ProductNo,Price,Num,SalePrice,ProductName,TypeName,Models,TotalMoney,CreateTime,MemberID,CreateUserID";
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
			string where = GetSearchSql(",Models", out searchParams);
			object[] arrParams = new object[] { RequestHelper.GetString("Models") };
            arrParams=arrParams.Concat(searchParams).ToArray();
            string fields="OrderDetailID,Status,PayStatus,PayType,OrderID,ProductNo,Price,Num,SalePrice,ProductName,TypeName,Models,TotalMoney,CreateTime,MemberID,CreateUserID";
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
		public virtual List<VOrderDetail> GetEntityListByPage(out int totalRows,int topN = 0, int page=1,int rows=20,string orderBy="")
		{
			string order = "";
			if (!string.IsNullOrEmpty(orderBy))
			{
				order = orderBy;
			}
			object[] searchParams;
			string where = GetSearchSql("", out searchParams);
			string fields="OrderDetailID,Status,PayStatus,PayType,OrderID,ProductNo,Price,Num,SalePrice,ProductName,TypeName,Models,TotalMoney,CreateTime,MemberID,CreateUserID";
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
			string fields="OrderDetailID,Status,PayStatus,PayType,OrderID,ProductNo,Price,Num,SalePrice,ProductName,TypeName,Models,TotalMoney,CreateTime,MemberID,CreateUserID";
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
			
			
			//OrderID
			if (!("," + notIn.ToLower() + ",").Contains(",orderid,"))
			{
			value = RequestHelper.GetString("OrderID");
			if (!string.IsNullOrEmpty(value))
			{
			    string[] arrValue = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			    if (arrValue.Length > 1)
			    {
			        for (int i = 0; i < arrValue.Length; i++)
			        {
			       		sb.Append(" AND [`OrderID`] like ?");
			       		param.Add("%"+ arrValue[i]+"%");
			        }
			    }
			    else
			    {
			          sb.Append(" AND [`OrderID`] like ?");
			          param.Add("%"+ value+"%");
			    }
			}
			}
			
			
			//ProductNo
			if (!("," + notIn.ToLower() + ",").Contains(",productno,"))
			{
			value = RequestHelper.GetString("ProductNo");
			if (!string.IsNullOrEmpty(value))
			{
			    string[] arrValue = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			    if (arrValue.Length > 1)
			    {
			        for (int i = 0; i < arrValue.Length; i++)
			        {
			       		sb.Append(" AND [`ProductNo`] like ?");
			       		param.Add("%"+ arrValue[i]+"%");
			        }
			    }
			    else
			    {
			          sb.Append(" AND [`ProductNo`] like ?");
			          param.Add("%"+ value+"%");
			    }
			}
			}
			
			
			//ProductName
			if (!("," + notIn.ToLower() + ",").Contains(",productname,"))
			{
			value = RequestHelper.GetString("ProductName");
			if (!string.IsNullOrEmpty(value))
			{
			    string[] arrValue = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			    if (arrValue.Length > 1)
			    {
			        for (int i = 0; i < arrValue.Length; i++)
			        {
			       		sb.Append(" AND [`ProductName`] like ?");
			       		param.Add("%"+ arrValue[i]+"%");
			        }
			    }
			    else
			    {
			          sb.Append(" AND [`ProductName`] like ?");
			          param.Add("%"+ value+"%");
			    }
			}
			}
			
			
			//TypeName
			if (!("," + notIn.ToLower() + ",").Contains(",typename,"))
			{
			value = RequestHelper.GetString("TypeName");
			if (!string.IsNullOrEmpty(value))
			{
			    string[] arrValue = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			    if (arrValue.Length > 1)
			    {
			        for (int i = 0; i < arrValue.Length; i++)
			        {
			       		sb.Append(" AND [`TypeName`] like ?");
			       		param.Add("%"+ arrValue[i]+"%");
			        }
			    }
			    else
			    {
			          sb.Append(" AND [`TypeName`] like ?");
			          param.Add("%"+ value+"%");
			    }
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
			
			
			//Models
			if (!("," + notIn.ToLower() + ",").Contains(",models,"))
			{
			value = RequestHelper.GetString("Models");
			if (!string.IsNullOrEmpty(value))
			{
			    string[] arrValue = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			    if (arrValue.Length > 1)
			    {
			        for (int i = 0; i < arrValue.Length; i++)
			        {
			       		sb.Append(" AND [`Models`] like ?");
			       		param.Add("%"+ arrValue[i]+"%");
			        }
			    }
			    else
			    {
			          sb.Append(" AND [`Models`] like ?");
			          param.Add("%"+ value+"%");
			    }
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
			
			
			//PayType
			if (!("," + notIn.ToLower() + ",").Contains(",paytype,"))
			{
			value = RequestHelper.GetString("PayType");
			if (!string.IsNullOrEmpty(value))
			{
			    string[] arrValue = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			    if (arrValue.Length > 1)
			    {
			        for (int i = 0; i < arrValue.Length; i++)
			        {
			       		sb.Append(" AND [`PayType`] like ?");
			       		param.Add("%"+ arrValue[i]+"%");
			        }
			    }
			    else
			    {
			          sb.Append(" AND [`PayType`] like ?");
			          param.Add("%"+ value+"%");
			    }
			}
			}
			
			
			//CreateUserID
			if (!("," + notIn.ToLower() + ",").Contains(",createuserid,"))
			{
				value = RequestHelper.GetString("CreateUserID");
				if (!string.IsNullOrEmpty(value))
				{
				 sb.Append(" AND [`CreateUserID`]=?");
				  param.Add(value);
				}
			}
			arrParam=param.ToArray();
			return sb.ToString();

		}

		
	    public virtual VOrderDetail GetModelValue(VOrderDetail model)
        {
            return model;
        }
		/// <summary>
        /// 设置订单明细视图实体(VOrderDetail)的显示值
        /// </summary>
        /// <param name="model">订单明细视图实体(VOrderDetail)</param>
        /// <returns>订单明细视图实体(VOrderDetail)</returns>
		public virtual VOrderDetail GetModelShowValue(VOrderDetail model,bool clearValue=false)
        {
            model=GetModelValue(model);
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
			if (model.Models!=null)
			{
				model.Models_ShowValue=NameValue_Models.Get(model.Models.ToString());
			}
			if (model.CreateUserID!=null)
			{
				model.CreateUserID_ShowValue=NameValue_CreateUserID.Get(model.CreateUserID.ToString());
			}
			if(clearValue)
			{
				model.Status = null;
				model.PayStatus = null;
				model.PayType = null;
				model.Models = null;
				model.CreateUserID = null;
			}
			return model;
		}
		
		/// <summary>
        /// 设置订单明细视图实体(VOrderDetail)的列表显示值
        /// </summary>
        /// <param name="model">订单明细视图实体(VOrderDetail)</param>
        /// <returns>订单明细视图实体(VOrderDetail)</returns>
		public virtual VOrderDetail GetModelGridShowValue(VOrderDetail model){
			model=GetModelShowValue(model);
			return model;
        }

        public virtual VOrderDetail GetInfoByID(object id){
            VOrderDetail model = GetModelByID(id);
            model = GetModelShowValue(model);
            return model;
        } 




    }
}
