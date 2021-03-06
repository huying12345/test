﻿
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由亚萌智能表单代码生成工具生成。
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。除非此项目不再使用代码生成器生成。
//     如果想修改此文件的方法，请在此文件的上级目录中的PositionDAL重写(override)该方法。
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
using Yamon.Module.UCenter.Entity;

namespace Yamon.Module.UCenter.DAL
{
    /// <summary>
    /// 岗位模型实体类
    ///</summary>
    public partial class _PositionDAL : BaseModelDAL<Position>
    {
        public _PositionDAL():base("UCenter")
        {
        }

		/// <summary>
        /// 所属部门（DepartmentID）字段的数据集合（键值对）
        /// </summary>
		public MyNameValueCollection NameValue_DepartmentID
		{
			get
			{
			    Yamon.Module.UCenter.DAL.DepartmentDAL dal = new Yamon.Module.UCenter.DAL.DepartmentDAL();
                string cacheKey = dal.CacheKeyPrefix + "NameValue_Department";
                object obj=CacheHelper.Get(cacheKey);
                if (obj == null)
                {
                   obj= dal.GetAllEntityTable("DepartmentID,DepartmentName").ToNameValueCollection();
                   CacheHelper.Insert(cacheKey,obj);
                }
                return (MyNameValueCollection) obj;

			}
		}
		/// <summary>
        /// 是否为部门主管（IsManager）字段的数据集合（键值对）
        /// </summary>
		public MyNameValueCollection NameValue_IsManager
		{
			get
			{
			    MyNameValueCollection nv=new MyNameValueCollection();
                nv.Add("0", "否");
                nv.Add("1", "是");
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
		public virtual List<Position> GetEntityListByPage(out int totalRows,int topN = 0, int page=1,int rows=20,string orderBy="")
		{
			string order = "";
			if (!string.IsNullOrEmpty(orderBy))
			{
				order = orderBy;
			}
			object[] searchParams;
			string where = GetSearchSql("", out searchParams);
			string fields="PositionID,DepartmentID,PositionName,IsManager,Responsibility,Tips";
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
			string fields="PositionID,DepartmentID,PositionName,IsManager,Responsibility,Tips";
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
			
			
			//DepartmentID
			if (!("," + notIn.ToLower() + ",").Contains(",departmentid,"))
			{
				value = RequestHelper.GetString("DepartmentID");
				if (!string.IsNullOrEmpty(value))
				{
				 sb.Append(" AND [`DepartmentID`]=?");
				  param.Add(value);
				}
			}
			
			
			//PositionName
			if (!("," + notIn.ToLower() + ",").Contains(",positionname,"))
			{
			value = RequestHelper.GetString("PositionName");
			if (!string.IsNullOrEmpty(value))
			{
			    string[] arrValue = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			    if (arrValue.Length > 1)
			    {
			        for (int i = 0; i < arrValue.Length; i++)
			        {
			       		sb.Append(" AND [`PositionName`] like ?");
			       		param.Add("%"+ arrValue[i]+"%");
			        }
			    }
			    else
			    {
			          sb.Append(" AND [`PositionName`] like ?");
			          param.Add("%"+ value+"%");
			    }
			}
			}
			
			
			//IsManager
			if (!("," + notIn.ToLower() + ",").Contains(",ismanager,"))
			{
				value = RequestHelper.GetString("IsManager");
				if (!string.IsNullOrEmpty(value))
				{
				 sb.Append(" AND [`IsManager`]=?");
				  param.Add(value);
				}
			}
			arrParam=param.ToArray();
			return sb.ToString();

		}

		
	    public virtual Position GetModelValue(Position model)
        {
            return model;
        }
		/// <summary>
        /// 设置岗位模型实体(Position)的显示值
        /// </summary>
        /// <param name="model">岗位模型实体(Position)</param>
        /// <returns>岗位模型实体(Position)</returns>
		public virtual Position GetModelShowValue(Position model,bool clearValue=false)
        {
            model=GetModelValue(model);
			if (model.DepartmentID!=null)
			{
				model.DepartmentID_ShowValue=NameValue_DepartmentID.Get(model.DepartmentID.ToString());
			}
			if (model.IsManager!=null)
			{
				model.IsManager_ShowValue=NameValue_IsManager.Get(model.IsManager.ToString());
			}
			if(clearValue)
			{
				model.DepartmentID = null;
				model.IsManager = null;
			}
			return model;
		}
		
		/// <summary>
        /// 设置岗位模型实体(Position)的列表显示值
        /// </summary>
        /// <param name="model">岗位模型实体(Position)</param>
        /// <returns>岗位模型实体(Position)</returns>
		public virtual Position GetModelGridShowValue(Position model){
			model=GetModelShowValue(model);
			return model;
        }

        public virtual Position GetInfoByID(object id){
            Position model = GetModelByID(id);
            model = GetModelShowValue(model);
            return model;
        } 


      #region 新建相关方法
		/// <summary>
        /// 设置新增入库时岗位模型实体(Position)默认值
        /// </summary>
        /// <param name="model">岗位模型实体(Position)</param>
        /// <returns>岗位模型实体(Position)</returns>
		public virtual Position GetInsertModelValue(Position model)
		{
			model.PositionID =null;
			return model;
		}		/// <summary>
        /// 设置新建页面的岗位模型实体(Position)默认值
        /// </summary>
        /// <param name="model">岗位模型实体(Position)</param>
        /// <returns>岗位模型实体(Position)</returns>
		public virtual Position GetCreateFormDefaultValue()
		{
            Position model = new Position();
			model.IsManager=0;
            return model;
		}

		/// <summary>
        /// 新建数据格式验证
        /// </summary>
        /// <param name="model">岗位模型实体(Position)</param>
        public virtual void CreateFormValidator(Position model)
        {
			string value="";
			
			//DepartmentID验证
			value = model.DepartmentID!=null ? model.DepartmentID.ToString() : "";
		            if ( string.IsNullOrEmpty(value))
		            {
		             throw new Exception("所属部门不能为空！");
		            }
			
			//PositionName验证
			value = model.PositionName!=null ? model.PositionName.ToString() : "";
		            if ( string.IsNullOrEmpty(value))
		            {
		             throw new Exception("岗位名称不能为空！");
		            }
}
      #endregion

      #region 修改相关方法
		/// <summary>
        /// 设置更新入库时岗位模型实体(Position)默认值
        /// </summary>
        /// <param name="model">岗位模型实体(Position)</param>
        /// <returns>岗位模型实体(Position)</returns>
		public virtual Position GetUpdateModelValue(Position model)
		{
			return model;
		}		/// <summary>
        /// 设置编辑页面的岗位模型实体(Position)默认值
        /// </summary>
        /// <param name="model">岗位模型实体(Position)</param>
        /// <returns>岗位模型实体(Position)</returns>
		public virtual Position GetEditFormDefaultValue(Position model)
		{
			return model;
		}

		/// <summary>
        /// 编辑数据格式验证
        /// </summary>
        /// <param name="model">岗位模型实体(Position)</param>
        public virtual void EditFormValidator(Position model)
        {
			string value="";
			
			//DepartmentID验证
			value = model.DepartmentID!=null ? model.DepartmentID.ToString() : "";
		            if ( string.IsNullOrEmpty(value))
		            {
		             throw new Exception("所属部门不能为空！");
		            }
			
			//PositionName验证
			value = model.PositionName!=null ? model.PositionName.ToString() : "";
		            if ( string.IsNullOrEmpty(value))
		            {
		             throw new Exception("岗位名称不能为空！");
		            }
}
      #endregion

    }
}
