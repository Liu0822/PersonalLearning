﻿using Glorint.DataBase.Repository;
using Glorint.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Glorint.Application.WorkFlow
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创建人：Admin
    /// 日 期：2017.04.17
    /// 描 述：任务实例处理记录
    /// </summary>
    public class WfTaskHistoryService : RepositoryFactory
    {
        #region 获取数据
        private string fieldSql = "";

        public WfTaskHistoryService()
        {
            fieldSql = @"
                    t.F_Id,
                    t.F_ProcessId,
                    t.F_NodeId,
                    t.F_NodeName,
                    t.F_TaskType,
                    t.F_Result,
                    t.F_PreviousId,
                    t.F_PreviousName,
                    t.F_CreateDate,
                    t.F_CreateUserId,
                    t.F_CreateUserName,
                    t.F_Description";
        }

        /// <summary>
        /// 获取流程实例
        /// </summary>
        /// <param name="processId">流程实例主键</param>
        /// <returns></returns>
        public IEnumerable<WfTaskHistoryEntity> GetList(string processId)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM LR_WF_TaskHistory t WHERE t.F_ProcessId = @processId ORDER BY t.F_CreateDate DESC ");
                return this.BaseRepository().FindList<WfTaskHistoryEntity>(strSql.ToString(), new { processId = processId });
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
        /// 保存流程实例任务处理完记录
        /// </summary>
        /// <param name="entity">实体</param>
        public void SaveEntity(WfTaskHistoryEntity entity)
        {
            try
            {
                entity.Create();
                this.BaseRepository().Insert(entity);
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
