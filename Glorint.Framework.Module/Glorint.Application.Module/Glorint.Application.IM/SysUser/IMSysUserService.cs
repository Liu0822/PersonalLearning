﻿using Glorint.DataBase.Repository;
using Glorint.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Glorint.Application.IM
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创建人：Admin
    /// 日 期：2018.05.30
    /// 描 述：即时通讯用户注册
    /// </summary>
    public class IMSysUserService: RepositoryFactory
    {
        #region 构造函数和属性

        private string fieldSql;
        public IMSysUserService()
        {
            fieldSql = @"
                t.F_Id,
                t.F_Name,
                t.F_Code,
                t.F_Icon,
                t.F_CreateDate,
                t.F_CreateUserId,
                t.F_CreateUserName,
                t.F_Description,
                t.F_DeleteMark
            ";
        }
        #endregion

        #region 获取数据

        /// <summary>
        /// 获取列表数据
        /// </summary>
        /// <param name="keyWord">查询关键字</param>
        /// <returns></returns>
        public IEnumerable<IMSysUserEntity> GetList(string keyWord)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM LR_IM_SysUser t where  t.F_DeleteMark = 0 ");

                if (!string.IsNullOrEmpty(keyWord)) {
                    keyWord = "%" + keyWord + "%";
                    strSql.Append(" AND t.F_Name Like @keyWord ");
                }

                return this.BaseRepository().FindList<IMSysUserEntity>(strSql.ToString(), new { keyWord = keyWord });
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
        /// <param name="keyWord">查询关键字</param>
        /// <summary>
        /// <returns></returns>
        public IEnumerable<IMSysUserEntity> GetPageList(Pagination pagination, string keyWord)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM LR_IM_SysUser t where  t.F_DeleteMark = 0 ");

                if (!string.IsNullOrEmpty(keyWord))
                {
                    keyWord = "%" + keyWord + "%";
                    strSql.Append(" AND t.F_Name Like @keyWord ");
                }

                return this.BaseRepository().FindList<IMSysUserEntity>(strSql.ToString(), new { keyWord = keyWord }, pagination);
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
        public IMSysUserEntity GetEntity(string keyValue)
        {
            try
            {
                return this.BaseRepository().FindEntity<IMSysUserEntity>(keyValue);
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
        /// 删除实体数据(虚拟)
        /// <param name="keyValue">主键</param>
        /// <summary>
        /// <returns></returns>
        public void DeleteEntity(string keyValue)
        {
            try
            {
                IMSysUserEntity entity = new IMSysUserEntity();
                entity.F_Id = keyValue;
                entity.F_DeleteMark = 1;
                this.BaseRepository().Update(entity);
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
        public void SaveEntity(string keyValue, IMSysUserEntity entity)
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

        #region 验证数据
        /// <summary>
        /// 规则编号不能重复
        /// </summary>
        /// <param name="code">编号</param>
        /// <param name="keyValue">主键</param>
        /// <returns></returns>
        public bool ExistEnCode(string code, string keyValue)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append(" SELECT t.F_Id FROM LR_IM_SysUser t WHERE t.F_DeleteMark = 0 AND t.F_Code = @code ");
                if (!string.IsNullOrEmpty(keyValue))
                {
                    strSql.Append(" AND t.F_Id != @keyValue  ");
                }
                IMSysUserEntity entity = this.BaseRepository().FindEntity<IMSysUserEntity>(strSql.ToString(), new { code = code, keyValue = keyValue });

                return entity == null ? true : false;
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
