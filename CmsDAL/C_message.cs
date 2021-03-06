﻿/**  版本信息模板在安装目录下，可自行修改。
* C_message.cs
*
* 功 能： N/A
* 类 名： C_message
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/7/11 18:39:01   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Cms.DBUtility;//Please add references
namespace Cms.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:C_message
	/// </summary>
	public partial class C_message
	{
		public C_message()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("messageid", "C_message"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int messageid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from C_message");
			strSql.Append(" where messageid=@messageid");
			SqlParameter[] parameters = {
					new SqlParameter("@messageid", SqlDbType.Int,4)
			};
			parameters[0].Value = messageid;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Cms.Model.C_message model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into C_message(");
			strSql.Append("Name,UnitName,PhoneNum,telNum,email,QQ,adress,title,content,userid,userName,updateTime,replay,re_updateTime,textParam1,textParam2,textParam3,textParam4,textParam5)");
			strSql.Append(" values (");
			strSql.Append("@Name,@UnitName,@PhoneNum,@telNum,@email,@QQ,@adress,@title,@content,@userid,@userName,@updateTime,@replay,@re_updateTime,@textParam1,@textParam2,@textParam3,@textParam4,@textParam5)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.VarChar,300),
					new SqlParameter("@UnitName", SqlDbType.VarChar,300),
					new SqlParameter("@PhoneNum", SqlDbType.VarChar,300),
					new SqlParameter("@telNum", SqlDbType.VarChar,300),
					new SqlParameter("@email", SqlDbType.VarChar,300),
					new SqlParameter("@QQ", SqlDbType.VarChar,300),
					new SqlParameter("@adress", SqlDbType.VarChar,-1),
					new SqlParameter("@title", SqlDbType.VarChar,300),
					new SqlParameter("@content", SqlDbType.Text),
					new SqlParameter("@userid", SqlDbType.Int,4),
					new SqlParameter("@userName", SqlDbType.VarChar,300),
					new SqlParameter("@updateTime", SqlDbType.DateTime),
					new SqlParameter("@replay", SqlDbType.Text),
					new SqlParameter("@re_updateTime", SqlDbType.VarChar,350),
					new SqlParameter("@textParam1", SqlDbType.VarChar,-1),
					new SqlParameter("@textParam2", SqlDbType.VarChar,-1),
					new SqlParameter("@textParam3", SqlDbType.VarChar,-1),
					new SqlParameter("@textParam4", SqlDbType.VarChar,-1),
					new SqlParameter("@textParam5", SqlDbType.VarChar,-1)};
			parameters[0].Value = model.Name;
			parameters[1].Value = model.UnitName;
			parameters[2].Value = model.PhoneNum;
			parameters[3].Value = model.telNum;
			parameters[4].Value = model.email;
			parameters[5].Value = model.QQ;
			parameters[6].Value = model.adress;
			parameters[7].Value = model.title;
			parameters[8].Value = model.content;
			parameters[9].Value = model.userid;
			parameters[10].Value = model.userName;
			parameters[11].Value = model.updateTime;
			parameters[12].Value = model.replay;
			parameters[13].Value = model.re_updateTime;
			parameters[14].Value = model.textParam1;
			parameters[15].Value = model.textParam2;
			parameters[16].Value = model.textParam3;
			parameters[17].Value = model.textParam4;
			parameters[18].Value = model.textParam5;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Cms.Model.C_message model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update C_message set ");
			strSql.Append("Name=@Name,");
			strSql.Append("UnitName=@UnitName,");
			strSql.Append("PhoneNum=@PhoneNum,");
			strSql.Append("telNum=@telNum,");
			strSql.Append("email=@email,");
			strSql.Append("QQ=@QQ,");
			strSql.Append("adress=@adress,");
			strSql.Append("title=@title,");
			strSql.Append("content=@content,");
			strSql.Append("userid=@userid,");
			strSql.Append("userName=@userName,");
			strSql.Append("updateTime=@updateTime,");
			strSql.Append("replay=@replay,");
			strSql.Append("re_updateTime=@re_updateTime,");
			strSql.Append("textParam1=@textParam1,");
			strSql.Append("textParam2=@textParam2,");
			strSql.Append("textParam3=@textParam3,");
			strSql.Append("textParam4=@textParam4,");
			strSql.Append("textParam5=@textParam5");
			strSql.Append(" where messageid=@messageid");
			SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.VarChar,300),
					new SqlParameter("@UnitName", SqlDbType.VarChar,300),
					new SqlParameter("@PhoneNum", SqlDbType.VarChar,300),
					new SqlParameter("@telNum", SqlDbType.VarChar,300),
					new SqlParameter("@email", SqlDbType.VarChar,300),
					new SqlParameter("@QQ", SqlDbType.VarChar,300),
					new SqlParameter("@adress", SqlDbType.VarChar,-1),
					new SqlParameter("@title", SqlDbType.VarChar,300),
					new SqlParameter("@content", SqlDbType.Text),
					new SqlParameter("@userid", SqlDbType.Int,4),
					new SqlParameter("@userName", SqlDbType.VarChar,300),
					new SqlParameter("@updateTime", SqlDbType.DateTime),
					new SqlParameter("@replay", SqlDbType.Text),
					new SqlParameter("@re_updateTime", SqlDbType.VarChar,350),
					new SqlParameter("@textParam1", SqlDbType.VarChar,-1),
					new SqlParameter("@textParam2", SqlDbType.VarChar,-1),
					new SqlParameter("@textParam3", SqlDbType.VarChar,-1),
					new SqlParameter("@textParam4", SqlDbType.VarChar,-1),
					new SqlParameter("@textParam5", SqlDbType.VarChar,-1),
					new SqlParameter("@messageid", SqlDbType.Int,4)};
			parameters[0].Value = model.Name;
			parameters[1].Value = model.UnitName;
			parameters[2].Value = model.PhoneNum;
			parameters[3].Value = model.telNum;
			parameters[4].Value = model.email;
			parameters[5].Value = model.QQ;
			parameters[6].Value = model.adress;
			parameters[7].Value = model.title;
			parameters[8].Value = model.content;
			parameters[9].Value = model.userid;
			parameters[10].Value = model.userName;
			parameters[11].Value = model.updateTime;
			parameters[12].Value = model.replay;
			parameters[13].Value = model.re_updateTime;
			parameters[14].Value = model.textParam1;
			parameters[15].Value = model.textParam2;
			parameters[16].Value = model.textParam3;
			parameters[17].Value = model.textParam4;
			parameters[18].Value = model.textParam5;
			parameters[19].Value = model.messageid;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int messageid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from C_message ");
			strSql.Append(" where messageid=@messageid");
			SqlParameter[] parameters = {
					new SqlParameter("@messageid", SqlDbType.Int,4)
			};
			parameters[0].Value = messageid;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string messageidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from C_message ");
			strSql.Append(" where messageid in ("+messageidlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Cms.Model.C_message GetModel(int messageid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 messageid,Name,UnitName,PhoneNum,telNum,email,QQ,adress,title,content,userid,userName,updateTime,replay,re_updateTime,textParam1,textParam2,textParam3,textParam4,textParam5 from C_message ");
			strSql.Append(" where messageid=@messageid");
			SqlParameter[] parameters = {
					new SqlParameter("@messageid", SqlDbType.Int,4)
			};
			parameters[0].Value = messageid;

			Cms.Model.C_message model=new Cms.Model.C_message();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Cms.Model.C_message DataRowToModel(DataRow row)
		{
			Cms.Model.C_message model=new Cms.Model.C_message();
			if (row != null)
			{
				if(row["messageid"]!=null && row["messageid"].ToString()!="")
				{
					model.messageid=int.Parse(row["messageid"].ToString());
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["UnitName"]!=null)
				{
					model.UnitName=row["UnitName"].ToString();
				}
				if(row["PhoneNum"]!=null)
				{
					model.PhoneNum=row["PhoneNum"].ToString();
				}
				if(row["telNum"]!=null)
				{
					model.telNum=row["telNum"].ToString();
				}
				if(row["email"]!=null)
				{
					model.email=row["email"].ToString();
				}
				if(row["QQ"]!=null)
				{
					model.QQ=row["QQ"].ToString();
				}
				if(row["adress"]!=null)
				{
					model.adress=row["adress"].ToString();
				}
				if(row["title"]!=null)
				{
					model.title=row["title"].ToString();
				}
				if(row["content"]!=null)
				{
					model.content=row["content"].ToString();
				}
				if(row["userid"]!=null && row["userid"].ToString()!="")
				{
					model.userid=int.Parse(row["userid"].ToString());
				}
				if(row["userName"]!=null)
				{
					model.userName=row["userName"].ToString();
				}
				if(row["updateTime"]!=null && row["updateTime"].ToString()!="")
				{
					model.updateTime=DateTime.Parse(row["updateTime"].ToString());
				}
				if(row["replay"]!=null)
				{
					model.replay=row["replay"].ToString();
				}
				if(row["re_updateTime"]!=null)
				{
					model.re_updateTime=row["re_updateTime"].ToString();
				}
				if(row["textParam1"]!=null)
				{
					model.textParam1=row["textParam1"].ToString();
				}
				if(row["textParam2"]!=null)
				{
					model.textParam2=row["textParam2"].ToString();
				}
				if(row["textParam3"]!=null)
				{
					model.textParam3=row["textParam3"].ToString();
				}
				if(row["textParam4"]!=null)
				{
					model.textParam4=row["textParam4"].ToString();
				}
				if(row["textParam5"]!=null)
				{
					model.textParam5=row["textParam5"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select messageid,Name,UnitName,PhoneNum,telNum,email,QQ,adress,title,content,userid,userName,updateTime,replay,re_updateTime,textParam1,textParam2,textParam3,textParam4,textParam5 ");
			strSql.Append(" FROM C_message ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" messageid,Name,UnitName,PhoneNum,telNum,email,QQ,adress,title,content,userid,userName,updateTime,replay,re_updateTime,textParam1,textParam2,textParam3,textParam4,textParam5 ");
			strSql.Append(" FROM C_message ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM C_message ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.messageid desc");
			}
			strSql.Append(")AS Row, T.*  from C_message T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "C_message";
			parameters[1].Value = "messageid";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

