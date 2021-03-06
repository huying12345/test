﻿
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由亚萌智能表单代码生成工具生成。
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。除非此项目不再使用代码生成器生成。
//     如果想修改此文件的方法，请在此文件的上级目录中的LogDAL重写(override)该方法。
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
using Yamon.Module.SiteManage.Entity;

namespace Yamon.Module.SiteManage.DAL
{
    /// <summary>
    /// 日志模型实体类
    ///</summary>
    public partial class _LogDAL : BaseModelDAL<Log>
    {
        public _LogDAL():base("UCenter")
        {
        }

		/// <summary>
        /// 日志类型（LogType）字段的数据集合（键值对）
        /// </summary>
		public MyNameValueCollection NameValue_LogType
		{
			get
			{
			    MyNameValueCollection nv=new MyNameValueCollection();
                nv.Add("Login", "登录");
                nv.Add("LogOut", "退出");
                nv.Add("Create", "新增");
                nv.Add("Edit", "修改");
                nv.Add("Delete", "删除");
                nv.Add("BatchDelete", "批量删除");
                nv.Add("Exception", "异常");
                return nv;

			}
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
		public virtual List<Log> GetEntityListByPage(out int totalRows,int topN = 0, int page=1,int rows=20,string orderBy="")
		{
			string order = "";
			if (!string.IsNullOrEmpty(orderBy))
			{
				order = orderBy;
			}
			object[] searchParams;
			string where = GetSearchSql("", out searchParams);
			string fields="ModelID,IsSuccess,LogID,LogType,LogContent,LogTime,UserIP,UserName";
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
			string fields="ModelID,IsSuccess,LogID,LogType,LogContent,LogTime,UserIP,UserName";
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
			
			
			//LogType
			if (!("," + notIn.ToLower() + ",").Contains(",logtype,"))
			{
			value = RequestHelper.GetString("LogType");
			if (!string.IsNullOrEmpty(value))
			{
			    string[] arrValue = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			    if (arrValue.Length > 1)
			    {
			        for (int i = 0; i < arrValue.Length; i++)
			        {
			       		sb.Append(" AND [`LogType`] like ?");
			       		param.Add("%"+ arrValue[i]+"%");
			        }
			    }
			    else
			    {
			          sb.Append(" AND [`LogType`] like ?");
			          param.Add("%"+ value+"%");
			    }
			}
			}
			
			
			//UserName
			if (!("," + notIn.ToLower() + ",").Contains(",username,"))
			{
			value = RequestHelper.GetString("UserName");
			if (!string.IsNullOrEmpty(value))
			{
			    string[] arrValue = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			    if (arrValue.Length > 1)
			    {
			        for (int i = 0; i < arrValue.Length; i++)
			        {
			       		sb.Append(" AND [`UserName`] like ?");
			       		param.Add("%"+ arrValue[i]+"%");
			        }
			    }
			    else
			    {
			          sb.Append(" AND [`UserName`] like ?");
			          param.Add("%"+ value+"%");
			    }
			}
			}
			
			
			//LogContent
			if (!("," + notIn.ToLower() + ",").Contains(",logcontent,"))
			{
			value = RequestHelper.GetString("LogContent");
			if (!string.IsNullOrEmpty(value))
			{
			    string[] arrValue = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			    if (arrValue.Length > 1)
			    {
			        for (int i = 0; i < arrValue.Length; i++)
			        {
			       		sb.Append(" AND [`LogContent`] like ?");
			       		param.Add("%"+ arrValue[i]+"%");
			        }
			    }
			    else
			    {
			          sb.Append(" AND [`LogContent`] like ?");
			          param.Add("%"+ value+"%");
			    }
			}
			}
			
			
			//LogTime
			if (!("," + notIn.ToLower() + ",").Contains(",logtime,"))
			{
					 value1 = RequestHelper.GetString("LogTime_Start");
					 value2 = RequestHelper.GetString("LogTime_End");
			    if (!string.IsNullOrEmpty(value1))
			    {
			      sb.Append(" AND [`LogTime`] >=?");
			      param.Add(value1);
			    }
			    if (!string.IsNullOrEmpty(value2))
			    {
			      sb.Append(" AND [`LogTime`] <=?");
			      param.Add(value2);
			    }
			}
			
			
			//UserIP
			if (!("," + notIn.ToLower() + ",").Contains(",userip,"))
			{
			value = RequestHelper.GetString("UserIP");
			if (!string.IsNullOrEmpty(value))
			{
			    string[] arrValue = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			    if (arrValue.Length > 1)
			    {
			        for (int i = 0; i < arrValue.Length; i++)
			        {
			       		sb.Append(" AND [`UserIP`] like ?");
			       		param.Add("%"+ arrValue[i]+"%");
			        }
			    }
			    else
			    {
			          sb.Append(" AND [`UserIP`] like ?");
			          param.Add("%"+ value+"%");
			    }
			}
			}
			arrParam=param.ToArray();
			return sb.ToString();

		}

		
	    public virtual Log GetModelValue(Log model)
        {
            return model;
        }
		/// <summary>
        /// 设置日志模型实体(Log)的显示值
        /// </summary>
        /// <param name="model">日志模型实体(Log)</param>
        /// <returns>日志模型实体(Log)</returns>
		public virtual Log GetModelShowValue(Log model,bool clearValue=false)
        {
            model=GetModelValue(model);
			if (model.LogType!=null)
			{
				model.LogType_ShowValue=NameValue_LogType.Get(model.LogType.ToString());
			}
			if(clearValue)
			{
				model.LogType = null;
			}
			return model;
		}
		
		/// <summary>
        /// 设置日志模型实体(Log)的列表显示值
        /// </summary>
        /// <param name="model">日志模型实体(Log)</param>
        /// <returns>日志模型实体(Log)</returns>
		public virtual Log GetModelGridShowValue(Log model){
			model=GetModelShowValue(model);
			return model;
        }

        public virtual Log GetInfoByID(object id){
            Log model = GetModelByID(id);
            model = GetModelShowValue(model);
            return model;
        } 




    }
}
