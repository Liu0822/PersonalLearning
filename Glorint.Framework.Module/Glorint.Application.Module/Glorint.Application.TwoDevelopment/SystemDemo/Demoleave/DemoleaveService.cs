﻿using Glorint.DataBase.Repository;
using Glorint.Util;
using System;
using System.Collections.Generic;

namespace Glorint.Application.TwoDevelopment.SystemDemo
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创建人：Admin
    /// 日 期：2017.04.17
    /// 描 述：系统表单-请假单
    /// </summary>
    public class DemoleaveService : RepositoryFactory
    {
        #region 获取数据
        /// <summary>
        /// 获取请假数据列表
        /// </summary>
        /// <param name="pagination">分页</param>
        /// <returns></returns>
        public IEnumerable<DemoleaveEntity> GetPageList(Pagination pagination)
        {
            try
            {
                return this.BaseRepository().FindList<DemoleaveEntity>(pagination);
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
        /// 根据流程实例获取表单数据
        /// </summary>
        /// <param name="processId"></param>
        /// <returns></returns>
        public DemoleaveEntity GetEntity(string processId)
        {
            try
            {
                return this.BaseRepository().FindEntity<DemoleaveEntity>(processId);
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
        /// 保存更新数据
        /// </summary>
        /// <param name="keyValue">主键</param>
        /// <param name="entity">实体对象</param>
        public void SaveEntity(string keyValue, DemoleaveEntity entity)
        {
            try
            {
                if (string.IsNullOrEmpty(keyValue))
                {
                    entity.Create();
                    this.BaseRepository().Insert(entity);
                }
                else
                {
                    entity.Modify(keyValue);
                    this.BaseRepository().Update(entity);
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
