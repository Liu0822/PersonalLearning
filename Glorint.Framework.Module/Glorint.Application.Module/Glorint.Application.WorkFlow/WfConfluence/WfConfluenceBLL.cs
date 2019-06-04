﻿using Glorint.Util;
using System;
using System.Collections.Generic;

namespace Glorint.Application.WorkFlow
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创建人：Admin
    /// 日 期：2017.04.17
    /// 描 述：会签记录操作
    /// </summary>
    public class WfConfluenceBLL : WfConfluenceIBLL
    {

        private WfConfluenceService wfConfluenceService = new WfConfluenceService();

        #region 获取数据
        /// <summary>
        /// 获取会签记录
        /// </summary>
        /// <param name="processId">流程实例主键</param>
        /// <param name="nodeId">节点主键</param>
        /// <returns></returns>
        public IEnumerable<WfConfluenceEntity> GetList(string processId, string nodeId)
        {
            try
            {
                return wfConfluenceService.GetList(processId, nodeId);
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowBusinessException(ex);
                }
            }
        }
        #endregion

        #region 提交数据
        /// <summary>
        /// 保存成功的会前记录
        /// </summary>
        /// <param name="entity">实体</param>
        public void SaveEntity(WfConfluenceEntity entity)
        {
            try
            {
                wfConfluenceService.SaveEntity(entity);
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowBusinessException(ex);
                }
            }
        }
        /// <summary>
        /// 删除会签节点数据
        /// </summary>
        /// <param name="processId">实例主键</param>
        /// <param name="nodeId">节点主键</param>
        public void DeleteEntity(string processId, string nodeId)
        {
            try
            {
                wfConfluenceService.DeleteEntity(processId, nodeId);
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowBusinessException(ex);
                }
            }
        }
        #endregion
    }
}
