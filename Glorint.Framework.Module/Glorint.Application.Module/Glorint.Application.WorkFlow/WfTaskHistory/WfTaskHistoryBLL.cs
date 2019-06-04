using Glorint.Util;
using System;
using System.Collections.Generic;

namespace Glorint.Application.WorkFlow
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创建人：Admin
    /// 日 期：2017.04.17
    /// 描 述：任务实例处理记录
    /// </summary>
    public class WfTaskHistoryBLL : WfTaskHistoryIBLL
    {
        private WfTaskHistoryService wfTaskHistoryService = new WfTaskHistoryService();

        #region 获取数据
        /// <summary>
        /// 获取流程实例
        /// </summary>
        /// <param name="processId">流程实例主键</param>
        /// <returns></returns>
        public IEnumerable<WfTaskHistoryEntity> GetList(string processId)
        {
            try
            {
                return wfTaskHistoryService.GetList(processId);
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
        /// 保存流程实例任务处理完记录
        /// </summary>
        /// <param name="entity">实体</param>
        public void SaveEntity(WfTaskHistoryEntity entity)
        {
            try
            {
                wfTaskHistoryService.SaveEntity(entity);
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
