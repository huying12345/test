﻿
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由亚萌智能表单代码生成工具生成。
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。除非此项目不再使用代码生成器生成。
//     如果想修改此文件的方法，请在此文件的上级目录中的MemberGradeDAL重写(override)该方法。
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
using Yamon.Module.Member.Entity;

namespace Yamon.Module.Member.DAL
{
    /// <summary>
    /// 会员等级实体类
    ///</summary>
    public partial class _MemberGradeDAL : BaseModelDAL<MemberGrade>
    {
        public _MemberGradeDAL():base("UCenter")
        {
        }

		/// <summary>
        /// 是否默认（IsDefault）字段的数据集合（键值对）
        /// </summary>
		public MyNameValueCollection NameValue_IsDefault
		{
			get
			{
			    MyNameValueCollection nv=new MyNameValueCollection();
                nv.Add("1", "是");
                nv.Add("0", "否");
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
		public virtual List<MemberGrade> GetEntityListByPage(out int totalRows,int topN = 0, int page=1,int rows=20,string orderBy="")
		{
			string order = "";
			if (!string.IsNullOrEmpty(orderBy))
			{
				order = orderBy;
			}
			object[] searchParams;
			string where = GetSearchSql("", out searchParams);
			string fields="MemberGradeId,GradeName,IsDefault,DiscountPercent,UpdateTime,CreateTime";
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
			string fields="MemberGradeId,GradeName,IsDefault,DiscountPercent,UpdateTime,CreateTime";
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
			arrParam=param.ToArray();
			return sb.ToString();

		}

		
	    public virtual MemberGrade GetModelValue(MemberGrade model)
        {
            return model;
        }
		/// <summary>
        /// 设置会员等级实体(MemberGrade)的显示值
        /// </summary>
        /// <param name="model">会员等级实体(MemberGrade)</param>
        /// <returns>会员等级实体(MemberGrade)</returns>
		public virtual MemberGrade GetModelShowValue(MemberGrade model,bool clearValue=false)
        {
            model=GetModelValue(model);
			if (model.IsDefault!=null)
			{
				model.IsDefault_ShowValue=NameValue_IsDefault.Get(model.IsDefault.ToString());
			}
			if(clearValue)
			{
				model.IsDefault = null;
			}
			return model;
		}
		
		/// <summary>
        /// 设置会员等级实体(MemberGrade)的列表显示值
        /// </summary>
        /// <param name="model">会员等级实体(MemberGrade)</param>
        /// <returns>会员等级实体(MemberGrade)</returns>
		public virtual MemberGrade GetModelGridShowValue(MemberGrade model){
			model=GetModelShowValue(model);
			return model;
        }

        public virtual MemberGrade GetInfoByID(object id){
            MemberGrade model = GetModelByID(id);
            model = GetModelShowValue(model);
            return model;
        } 


      #region 新建相关方法
		/// <summary>
        /// 设置新增入库时会员等级实体(MemberGrade)默认值
        /// </summary>
        /// <param name="model">会员等级实体(MemberGrade)</param>
        /// <returns>会员等级实体(MemberGrade)</returns>
		public virtual MemberGrade GetInsertModelValue(MemberGrade model)
		{
			model.MemberGradeId =null;
			model.UpdateTime =(DateTime.Now);
			model.CreateTime =(DateTime.Now);
			return model;
		}		/// <summary>
        /// 设置新建页面的会员等级实体(MemberGrade)默认值
        /// </summary>
        /// <param name="model">会员等级实体(MemberGrade)</param>
        /// <returns>会员等级实体(MemberGrade)</returns>
		public virtual MemberGrade GetCreateFormDefaultValue()
		{
            MemberGrade model = new MemberGrade();
			model.GradeName=("0");
			model.IsDefault=1;
			model.DiscountPercent=1;
			model.UpdateTime=(DateTime.Now);
			model.CreateTime=(DateTime.Now);
            return model;
		}

		/// <summary>
        /// 新建数据格式验证
        /// </summary>
        /// <param name="model">会员等级实体(MemberGrade)</param>
        public virtual void CreateFormValidator(MemberGrade model)
        {
			string value="";
}
      #endregion

      #region 修改相关方法
		/// <summary>
        /// 设置更新入库时会员等级实体(MemberGrade)默认值
        /// </summary>
        /// <param name="model">会员等级实体(MemberGrade)</param>
        /// <returns>会员等级实体(MemberGrade)</returns>
		public virtual MemberGrade GetUpdateModelValue(MemberGrade model)
		{
			model.UpdateTime = (DateTime.Now);
			return model;
		}		/// <summary>
        /// 设置编辑页面的会员等级实体(MemberGrade)默认值
        /// </summary>
        /// <param name="model">会员等级实体(MemberGrade)</param>
        /// <returns>会员等级实体(MemberGrade)</returns>
		public virtual MemberGrade GetEditFormDefaultValue(MemberGrade model)
		{
			model.UpdateTime=(DateTime.Now);
			return model;
		}

		/// <summary>
        /// 编辑数据格式验证
        /// </summary>
        /// <param name="model">会员等级实体(MemberGrade)</param>
        public virtual void EditFormValidator(MemberGrade model)
        {
			string value="";
}
      #endregion

    }
}
