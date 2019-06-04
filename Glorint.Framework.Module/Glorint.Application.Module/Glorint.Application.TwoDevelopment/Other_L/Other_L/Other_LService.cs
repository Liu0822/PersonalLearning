using Dapper;
using Glorint.DataBase.Repository;
using Glorint.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Glorint.Application.TwoDevelopment.Other_L
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创 建：超级管理员
    /// 日 期：2018-11-29 09:40
    /// 描 述：Other_L
    /// </summary>
    public class Other_LService : RepositoryFactory
    {
        #region 构造函数和属性

        private string fieldSql;
        public Other_LService()
        {
            fieldSql= @"
                t.ID,
                t.Name,
                t.Title,
                t.Selects,t.Editor,
                t.Files
            ";
        }
        #endregion

        #region 获取数据

        /// <summary>
        /// 获取列表数据
        /// <summary>
        /// <returns></returns>
        public IEnumerable<Other_LEntity> GetList( string queryJson )
        {
            try
            {
                //参考写法
                //var queryParam = queryJson.ToJObject();
                // 虚拟参数
                //var dp = new DynamicParameters(new { });
                //dp.Add("startTime", queryParam["StartTime"].ToDate(), DbType.DateTime);
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM Other_L t ");
                return this.BaseRepository().FindList<Other_LEntity>(strSql.ToString());
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowServiceException(ex);
                }
            }
        }

        /// <summary>
        /// 获取列表分页数据
        /// <param name="pagination">分页参数</param>
        /// <summary>
        /// <returns></returns>
        public IEnumerable<Other_LEntity> GetPageList(Pagination pagination, string queryJson)
        {
            try
            {
                var queryParam = queryJson.ToJObject(); //序列成linq对象
                var keyword = "";    //申明搜素关键字变量
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM Other_L t WHERE 1=1");
                //查询操作
                if (!queryParam["keyword"].IsEmpty())
                {
                    keyword = "%" + queryParam["keyword"].ToString() + "%";
                    strSql.Append("AND t.Name LIKE @keyword");  //AND模糊查询
                }
                return this.BaseRepository().FindList<Other_LEntity>(strSql.ToString(), new { keyword }, pagination);
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowServiceException(ex);
                }
            }
        }

        /// <summary>
        /// 获取实体数据
        /// <param name="keyValue">主键</param>
        /// <summary>
        /// <returns></returns>
        public Other_LEntity GetEntity(string keyValue)
        {
            try
            {
                return this.BaseRepository().FindEntity<Other_LEntity>(keyValue);
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowServiceException(ex);
                }
            }
        }

        #endregion

        #region 提交数据

        /// <summary>
        /// 删除实体数据 (多条)
        /// <param name="keyValue">主键</param>
        /// <summary>
        /// <returns></returns>
        public void DeleteEntity(string keyValue)
        {
            try
            {
                var list = keyValue.Split(',');   //截取ids
                foreach (var item in list)
                {
                    Other_LEntity other = new Other_LEntity()
                    {
                        ID = item
                    }; this.BaseRepository().Delete(other);
                }
                   // this.BaseRepository().Delete<Other_LEntity>(t=>t.ID == keyValue);
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowServiceException(ex);
                }
            }
        }

        /// <summary>
        /// 保存实体数据（新增、修改）
        /// <param name="keyValue">主键</param>
        /// <summary>
        /// <returns></returns>
        public void SaveEntity(string keyValue, Other_LEntity entity)
        {
            try
            {
                if (!string.IsNullOrEmpty(keyValue))
                {
                    entity.Modify(keyValue);
                    this.BaseRepository().Update(entity);
                }
                else
                {
                    entity.Create();
                    this.BaseRepository().Insert(entity);
                }
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowServiceException(ex);
                }
            }
        }

        #endregion

    }
}
