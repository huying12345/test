﻿
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由亚萌智能表单代码生成工具生成。
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。除非此项目不再使用代码生成器生成。
//     如果想修改此文件的方法，请在此文件的上级目录中的APIDAL重写(override)该方法。
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
    /// 接口实体类
    ///</summary>
    public partial class _APIDAL : BaseModelDAL<API>
    {
        public _APIDAL():base("UCenter")
        {
        }

		/// <summary>
        /// 上级类型（ParentID）字段的数据集合（键值对）
        /// </summary>
		public MyNameValueCollection NameValue_ParentID
		{
			get
			{
			    Yamon.Module.SiteManage.DAL.APIDAL dal = new Yamon.Module.SiteManage.DAL.APIDAL();
                string cacheKey = dal.CacheKeyPrefix + "NameValue_API";
                object obj=CacheHelper.Get(cacheKey);
                if (obj == null)
                {
                   obj= dal.GetAllEntityTable_APIType("APIID,APIName").ToNameValueCollection();
                   CacheHelper.Insert(cacheKey,obj);
                }
                return (MyNameValueCollection) obj;

			}
		}
		/// <summary>
        /// 需要登录（NeedUserLogin）字段的数据集合（键值对）
        /// </summary>
		public MyNameValueCollection NameValue_NeedUserLogin
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
        /// 请求方式（RequestType）字段的数据集合（键值对）
        /// </summary>
		public MyNameValueCollection NameValue_RequestType
		{
			get
			{
			    MyNameValueCollection nv=new MyNameValueCollection();
                nv.Add("POST", "POST");
                nv.Add("GET", "GET");
                nv.Add("PUT", "PUT");
                nv.Add("PATCH", "PATCH");
                nv.Add("DELETE", "DELETE");
                return nv;

			}
		}
		/// <summary>
        /// 数据类型（DataType）字段的数据集合（键值对）
        /// </summary>
		public MyNameValueCollection NameValue_DataType
		{
			get
			{
			    MyNameValueCollection nv=new MyNameValueCollection();
                nv.Add("JSON", "JSON");
                nv.Add("XML", "XML");
                nv.Add("HTML", "HTML");
                nv.Add("JS", "JS");
                nv.Add("IMG", "IMG");
                nv.Add("FILE", "FILE");
                return nv;

			}
		}
		/// <summary>
        /// 删除标识（IsDelete）字段的数据集合（键值对）
        /// </summary>
		public MyNameValueCollection NameValue_IsDelete
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
        /// 状态（Status）字段的数据集合（键值对）
        /// </summary>
		public MyNameValueCollection NameValue_Status
		{
			get
			{
			    MyNameValueCollection nv=new MyNameValueCollection();
                nv.Add("0", "禁用");
                nv.Add("1", "启用");
                return nv;

			}
		}



		/// <summary>
		/// 获取数据实体列表(接口类型)
		///</summary>
		/// <param name="nv">页面传递参数集合</param>
		/// <param name="topN">数据条数</param>
		/// <param name="fields">查询的字段</param>
		/// <returns>实体列表</returns>
        public virtual List<API> GetEntityList_APIType(int topN = 0,string fields="")
        {
            object[] arrParams = new object[] {  };
            return GetEntityList("1=1 AND APIType=0 ",arrParams, "", topN,fields);
        }
		
		/// <summary>
		/// 获取数据实体列表(接口类型)
		///</summary>
		/// <param name="fields">查询的字段</param>
		/// <returns>实体列表</returns>
        public virtual List<API> GetAllEntityList_APIType(string fields="")
        {
            return GetEntityList_APIType(0,fields);
        }
		
		/// <summary>
		/// 获取分页的数据实体列表(接口类型)
		///</summary>
		/// <param name="totalRows">记录总条数（out）</param>
		/// <param name="nv">页面传递参数集合</param>
		/// <param name="topN">数据条数</param>
		/// <param name="page">页码</param>
		/// <param name="rows">每页记录数</param>
		/// <param name="orderBy">排序</param>
		/// <returns>实体列表</returns>
        public virtual List<API> GetEntityListByPage_APIType(out int totalRows,int topN = 0, int page=1,int rows=20,string orderBy="")
        {
			string order = "";
			if (!string.IsNullOrEmpty(orderBy))
			{
			   order = orderBy;
			}
			object[] searchParams;
			string where = GetSearchSql("", out searchParams);
			object[] arrParams = new object[] {  };
            arrParams=arrParams.Concat(searchParams).ToArray();
            string fields="APIID,APIName,ParentID,OrderID,Url,NeedUserLogin,Remark,RequestType,DataType,CreateUserID,CreateTime,UpdateUserID,UpdateTime,Status";
            return GetEntityListByPage("1=1 AND APIType=0 "+ where, arrParams,order,fields ,rows,page,topN,out totalRows);
        }
		
		/// <summary>
		/// 获取数据列表DataTable(接口类型)
		///</summary>
		/// <param name="nv">页面传递参数集合</param>
		/// <param name="topN">数据条数</param>
		/// <param name="fields">查询的字段</param>
		/// <returns>数据列表</returns>
        public virtual DataTable GetEntityTable_APIType(int topN = 0,string fields="")
        {
            object[] arrParams = new object[] {  };
            return GetEntityTable("1=1 AND APIType=0 ",arrParams, "", topN,fields);
        }
		
		/// <summary>
		/// 获取数据列表DataTable(接口类型)
		///</summary>
		/// <param name="fields">查询的字段</param>
		/// <returns>数据列表</returns>
        public virtual DataTable GetAllEntityTable_APIType(string fields="")
        {
        	return GetEntityTable_APIType(0,fields);
        }
		/// <summary>
		/// 获取分页的数据列表DataTable(接口类型)
		///</summary>
		/// <param name="totalRows">记录总条数（out）</param>
		/// <param name="nv">页面传递参数集合</param>
		/// <param name="topN">数据条数</param>
		/// <param name="page">页码</param>
		/// <param name="rows">每页记录数</param>
		/// <param name="orderBy">排序</param>
		/// <returns>DataTable</returns>
        public virtual DataTable GetEntityTableByPage_APIType(out int totalRows,int topN = 0, int page=1,int rows=20,string orderBy="")
        {
			string order = "";
			if (!string.IsNullOrEmpty(orderBy))
			{
			    order = orderBy;
			}
			object[] searchParams;
			string where = GetSearchSql("", out searchParams);
			object[] arrParams = new object[] {  };
            arrParams=arrParams.Concat(searchParams).ToArray();
            string fields="APIID,APIName,ParentID,OrderID,Url,NeedUserLogin,Remark,RequestType,DataType,CreateUserID,CreateTime,UpdateUserID,UpdateTime,Status";
            return GetEntityTableByPage("1=1 AND APIType=0 "+ where, arrParams,order,fields, rows,page,topN,out totalRows);
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
		public virtual List<API> GetEntityListByPage(out int totalRows,int topN = 0, int page=1,int rows=20,string orderBy="")
		{
			string order = "";
			if (!string.IsNullOrEmpty(orderBy))
			{
				order = orderBy;
			}
			object[] searchParams;
			string where = GetSearchSql("", out searchParams);
			string fields="APIID,APIName,ParentID,OrderID,Url,NeedUserLogin,Remark,RequestType,DataType,CreateUserID,CreateTime,UpdateUserID,UpdateTime,Status";
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
			string fields="APIID,APIName,ParentID,OrderID,Url,NeedUserLogin,Remark,RequestType,DataType,CreateUserID,CreateTime,UpdateUserID,UpdateTime,Status";
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

		
	    public virtual API GetModelValue(API model)
        {
            return model;
        }
		/// <summary>
        /// 设置接口实体(API)的显示值
        /// </summary>
        /// <param name="model">接口实体(API)</param>
        /// <returns>接口实体(API)</returns>
		public virtual API GetModelShowValue(API model,bool clearValue=false)
        {
            model=GetModelValue(model);
			if (model.ParentID!=null)
			{
				model.ParentID_ShowValue=NameValue_ParentID.Get(model.ParentID.ToString());
			}
			if (model.NeedUserLogin!=null)
			{
				model.NeedUserLogin_ShowValue=NameValue_NeedUserLogin.Get(model.NeedUserLogin.ToString());
			}
			if (model.RequestType!=null)
			{
				model.RequestType_ShowValue=NameValue_RequestType.Get(model.RequestType.ToString());
			}
			if (model.DataType!=null)
			{
				model.DataType_ShowValue=NameValue_DataType.Get(model.DataType.ToString());
			}
			if (model.IsDelete!=null)
			{
				model.IsDelete_ShowValue=NameValue_IsDelete.Get(model.IsDelete.ToString());
			}
			if (model.Status!=null)
			{
				model.Status_ShowValue=NameValue_Status.Get(model.Status.ToString());
			}
			if(clearValue)
			{
				model.ParentID = null;
				model.NeedUserLogin = null;
				model.RequestType = null;
				model.DataType = null;
				model.IsDelete = null;
				model.Status = null;
			}
			return model;
		}
		
		/// <summary>
        /// 设置接口实体(API)的列表显示值
        /// </summary>
        /// <param name="model">接口实体(API)</param>
        /// <returns>接口实体(API)</returns>
		public virtual API GetModelGridShowValue(API model){
			model=GetModelShowValue(model);
			return model;
        }

        public virtual API GetInfoByID(object id){
            API model = GetModelByID(id);
            model = GetModelShowValue(model);
            return model;
        } 


      #region 新建相关方法
		/// <summary>
        /// 设置新增入库时接口实体(API)默认值
        /// </summary>
        /// <param name="model">接口实体(API)</param>
        /// <returns>接口实体(API)</returns>
		public virtual API GetInsertModelValue(API model)
		{
			model.APIID =Guid.NewGuid().ToString();
			model.APIType =RequestHelper.GetInt("APIType");
			model.CreateUserID =CookieHelper.GetCookieInt("UserID");
			model.CreateTime =DateTime.Now;
			model.UpdateUserID =CookieHelper.GetCookieInt("UserID");
			model.UpdateTime =DateTime.Now;
			model.IsDelete =0;
			model.Status =1;
			return model;
		}		/// <summary>
        /// 设置新建页面的接口实体(API)默认值
        /// </summary>
        /// <param name="model">接口实体(API)</param>
        /// <returns>接口实体(API)</returns>
		public virtual API GetCreateFormDefaultValue()
		{
            API model = new API();
			model.APIID=Guid.NewGuid().ToString();
			model.OrderID=0;
			model.APIType=RequestHelper.GetInt("APIType");
			model.NeedUserLogin=0;
			model.RequestType="POST";
			model.DataType="JSON";
            return model;
		}

		/// <summary>
        /// 新建数据格式验证
        /// </summary>
        /// <param name="model">接口实体(API)</param>
        public virtual void CreateFormValidator(API model)
        {
			string value="";
			
			//APIID验证
			value = model.APIID!=null ? model.APIID.ToString() : "";
		            if ( string.IsNullOrEmpty(value))
		            {
		             throw new Exception("接口编号不能为空！");
		            }
			
			//APIName验证
			value = model.APIName!=null ? model.APIName.ToString() : "";
		            if ( string.IsNullOrEmpty(value))
		            {
		             throw new Exception("接口名称不能为空！");
		            }
			
			//OrderID验证
			value = model.OrderID!=null ? model.OrderID.ToString() : "";
		            if ( string.IsNullOrEmpty(value))
		            {
		             throw new Exception("排序号不能为空！");
		            }
			
			//APIType验证
			value = model.APIType!=null ? model.APIType.ToString() : "";
		            if ( string.IsNullOrEmpty(value))
		            {
		             throw new Exception("类型不能为空！");
		            }
			
			//NeedUserLogin验证
			value = model.NeedUserLogin!=null ? model.NeedUserLogin.ToString() : "";
		            if ( string.IsNullOrEmpty(value))
		            {
		             throw new Exception("需要登录不能为空！");
		            }
}
      #endregion

      #region 修改相关方法
		/// <summary>
        /// 设置更新入库时接口实体(API)默认值
        /// </summary>
        /// <param name="model">接口实体(API)</param>
        /// <returns>接口实体(API)</returns>
		public virtual API GetUpdateModelValue(API model)
		{
			model.APIType =null;
			model.CreateUserID =null;
			model.CreateTime =null;
			model.UpdateUserID = CookieHelper.GetCookieInt("UserID");
			model.UpdateTime = DateTime.Now;
			model.IsDelete =null;
			model.Status =null;
			return model;
		}		/// <summary>
        /// 设置编辑页面的接口实体(API)默认值
        /// </summary>
        /// <param name="model">接口实体(API)</param>
        /// <returns>接口实体(API)</returns>
		public virtual API GetEditFormDefaultValue(API model)
		{
			return model;
		}

		/// <summary>
        /// 编辑数据格式验证
        /// </summary>
        /// <param name="model">接口实体(API)</param>
        public virtual void EditFormValidator(API model)
        {
			string value="";
			
			//APIName验证
			value = model.APIName!=null ? model.APIName.ToString() : "";
		            if ( string.IsNullOrEmpty(value))
		            {
		             throw new Exception("接口名称不能为空！");
		            }
			
			//OrderID验证
			value = model.OrderID!=null ? model.OrderID.ToString() : "";
		            if ( string.IsNullOrEmpty(value))
		            {
		             throw new Exception("排序号不能为空！");
		            }
			
			//NeedUserLogin验证
			value = model.NeedUserLogin!=null ? model.NeedUserLogin.ToString() : "";
		            if ( string.IsNullOrEmpty(value))
		            {
		             throw new Exception("需要登录不能为空！");
		            }
}
      #endregion
		/// <summary>
        /// 从DataSet中导入数据
        /// </summary>
        /// <param name="ds">DataSet</param>
        /// <returns>影响的行数</returns>
		public virtual int ImportDataFromDataSet(DataSet ds)
		{
			if (ds.Tables.Count > 0)
			{
                DataTable dt=ds.Tables[0];
                foreach (System.Reflection.PropertyInfo p in typeof(API).GetProperties())
                {
                    var nameAttr = p.GetCustomAttributes(typeof(DisplayNameAttribute), false);
                    if (nameAttr.Length > 0)
                    {
                        DisplayNameAttribute displayNameAttribute = nameAttr[0] as DisplayNameAttribute;
                        if (displayNameAttribute != null && !string.IsNullOrEmpty(displayNameAttribute.DisplayName) && dt.Columns.Contains(displayNameAttribute.DisplayName))
                        {
                            dt.Columns[displayNameAttribute.DisplayName].ColumnName = p.Name;
                        }
                    }
                }
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					if (dt.Columns.Contains("ParentID"))
					{
						if (dt.Rows[i]["ParentID"].ToString()!="")
						{
							dt.Rows[i]["ParentID"] = NameValue_ParentID.GetKeyByValue(dt.Rows[i]["ParentID"].ToString());
						}
					}
					if (dt.Columns.Contains("NeedUserLogin"))
					{
						if (dt.Rows[i]["NeedUserLogin"].ToString()!="")
						{
							dt.Rows[i]["NeedUserLogin"] = NameValue_NeedUserLogin.GetKeyByValue(dt.Rows[i]["NeedUserLogin"].ToString());
						}
					}
					if (dt.Columns.Contains("RequestType"))
					{
						if (dt.Rows[i]["RequestType"].ToString()!="")
						{
							dt.Rows[i]["RequestType"] = NameValue_RequestType.GetKeyByValue(dt.Rows[i]["RequestType"].ToString());
						}
					}
					if (dt.Columns.Contains("DataType"))
					{
						if (dt.Rows[i]["DataType"].ToString()!="")
						{
							dt.Rows[i]["DataType"] = NameValue_DataType.GetKeyByValue(dt.Rows[i]["DataType"].ToString());
						}
					}
					if (dt.Columns.Contains("IsDelete"))
					{
						if (dt.Rows[i]["IsDelete"].ToString()!="")
						{
							dt.Rows[i]["IsDelete"] = NameValue_IsDelete.GetKeyByValue(dt.Rows[i]["IsDelete"].ToString());
						}
					}
					if (dt.Columns.Contains("Status"))
					{
						if (dt.Rows[i]["Status"].ToString()!="")
						{
							dt.Rows[i]["Status"] = NameValue_Status.GetKeyByValue(dt.Rows[i]["Status"].ToString());
						}
					}
				}
				ImportDataFromDataTable(dt);

			}
			return 0;
		}
		
		/// <summary>
		/// 获取异步树接口实体(API)列表(接口类型)
		///</summary>
		/// <param name="nv">页面传递的参数集合</param>
        /// <param name="parentId">上级菜单</param>
        /// <param name="fields">字段列表</param>
		/// <returns></returns>
		public virtual List<API> GetAsyncModelTreeList_APIType(object parentId,string fields="")
		{
		  return GetAsyncTreeList_APIType(parentId, fields).ToObjectList<API>();
		}
		
        /// <summary>
        /// 获取异步树列表(DataTable)(接口类型)
        /// </summary>
        /// <param name="nv">页面传递的参数集合</param>
        /// <param name="parentId">上级菜单</param>
        /// <param name="fields">字段列表</param>
        /// <returns>接口实体(API)列表</returns>
		public virtual DataTable GetAsyncTreeList_APIType(object parentId,string fields="")
		{
		if (string.IsNullOrEmpty(fields))
		{
		    fields = AllFields;
		}
		 object[] parentParam = new object[] { parentId ,null,parentId,null};
		 string sql = @"select {0},ChildCount from SiteManage_API as a left join
		(select ParentID as __ParentID,count(1) as ChildCount from SiteManage_API where ParentID in(
		SELECT  APIID  FROM SiteManage_API where  ParentID=? AND APIType=0) group by ParentID) as b
		on a.APIID=b.__ParentID where  a.ParentID=? AND APIType=0";
		  sql = string.Format(sql, fields);
		  return Db.ExecuteDataTableSqlEx(sql, parentParam);
		}


        /// <summary>
        /// 获取异步树接口实体(API)列表
        /// </summary>
        /// <param name="nv">页面传递的参数集合</param>
        /// <param name="parentId">上级菜单</param>
        /// <param name="fields">字段列表</param>
        /// <returns>接口实体(API)列表</returns>
		public virtual List<API> GetAsyncModelTreeList(object parentId,string fields="")
		{
			return GetAsyncTreeList(parentId, fields).ToObjectList<API>();
			
		}
		
		
        /// <summary>
        /// 获取异步树列表(DataTable)
        /// </summary>
        /// <param name="nv">页面传递的参数集合</param>
        /// <param name="parentId">上级菜单</param>
        /// <param name="fields">字段列表</param>
        /// <returns>DataTable</returns>
		public virtual DataTable GetAsyncTreeList(object parentId,string fields="")
		{
			if (string.IsNullOrEmpty(fields))
			{
				fields = AllFields;
			}
			object[] parentParam = new object[] { parentId,parentId };
			string sql = @"select {0},ChildCount from SiteManage_API as a left join
			(select ParentID as __ParentID,count(1) as ChildCount from SiteManage_API where ParentID in(
			SELECT  APIID  FROM SiteManage_API where  ParentID=?) group by ParentID) as b
			on a.APIID=b.__ParentID where  a.ParentID=?";
			sql = string.Format(sql, fields);
			return Db.ExecuteDataTableSqlEx(sql, parentParam);
		}
        /// <summary>
        /// 更新为树级实体列表
        /// </summary>
        /// <param name="list">实体列表</param>
        /// <returns>树级实体列表</returns>
		public List<API> ModelListToTree(List<API> list)
		{
			//查找父节点
			List<API> rootType = list.Where(o => o.ParentID == "").OrderBy(o => o.OrderID ).ToList();
			//递归主函数
			Action<API> addChild = null;
			addChild = (info =>
				{
					var childInfo = list.Where(o => o.ParentID == info.APIID).OrderBy(o => o.OrderID );
					if (childInfo.Count() == 0)
						return;
					childInfo.All(o =>
					{
						if (info.Children == null)
						{
							info.Children=new List<API>();
						}
						info.Children.Add(o);
						addChild(o);
						return true;
					});
				});
			//递归调用
			rootType.ForEach(o => { addChild(o); });
			return rootType;
		}
		
		// <summary>
        /// 获取树级实体列表
        /// </summary>
        /// <returns>树级实体列表</returns>
        public List<API> GetModelTreeList()
        {
            List<API> list = GetAllEntityList();
            return ModelListToTree(list);
        }

        /// <summary>
        /// 保存编辑树
        /// </summary>
        /// <param name="id"></param>
        /// <param name="targetId"></param>
        /// <param name="point"></param>
        /// <returns></returns>
        public int SaveEditTree(string id, string targetId, string point)
        {
            API targetModel = GetModelByID(targetId);
            string parentId="";
            int orderId = 0;
            if (point == "append")
            {
                parentId = targetModel.APIID ?? "";
                orderId = 1;
            }
            else if (point == "top")
            {
                parentId = targetModel.ParentID ?? "";
                orderId = DataConverter.ToInt(targetModel.OrderID) - 1;
            }
            else if (point == "bottom")
            {
                parentId = targetModel.ParentID ?? "";
                orderId = DataConverter.ToInt(targetModel.OrderID) + 1;
            }
            API model=new API();
            model.APIID = id;
            model.OrderID = orderId;
            model.ParentID = parentId;
            return UpdateByModel(model);
        }    }
}
