﻿
using Glorint.Util;
using System.Collections.Generic;
namespace Glorint.Application.WorkFlow
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创建人：Admin
    /// 日 期：2017.04.17
    /// 描 述：工作流实例
    /// </summary>
    public interface WfProcessInstanceIBLL
    {
        #region 获取数据
        /// <summary>
        /// 获取流程实例
        /// </summary>
        /// <param name="keyValue">主键</param>
        /// <returns></returns>
        WfProcessInstanceEntity GetEntity(string keyValue);
         /// <summary>
        /// 获取流程信息列表
        /// </summary>
        /// <param name="pagination">分页参数</param>
        /// <param name="queryJson">查询条件</param>
        /// <returns></returns>
        IEnumerable<WfProcessInstanceEntity> GetPageList(Pagination pagination, string queryJson);
        /// <summary>
        /// 获取我的流程信息列表
        /// </summary>
        /// <param name="userId">用户主键</param>
        /// <param name="pagination">分页参数</param>
        /// <param name="queryJson">查询条件</param>
        /// <returns></returns>
        IEnumerable<WfProcessInstanceEntity> GetMyPageList(string userId, Pagination pagination, string queryJson);
        /// <summary>
        /// 获取流程实例信息
        /// </summary>
        /// <param name="processId">实例主键</param>
        /// <returns></returns>
        IEnumerable<WfProcessInstanceEntity> GetListByProcessIds(string processId);
        /// <summary>
        /// 获取全部流程实例
        /// </summary>
        /// <param name="processIds"></param>
        /// <returns></returns>
        IEnumerable<WfProcessInstanceEntity> GetListByAllProcessIds(string processIds);
        #endregion

        #region 提交数据
        /// <summary>
        /// 删除流程实例
        /// </summary>
        /// <param name="keyValue"></param>
        void DeleteEntity(string keyValue);
        /// <summary>
        /// 保存流程实例
        /// </summary>
        /// <param name="keyValue">主键</param>
        /// <param name="entity">实体</param>
        void SaveEntity(string keyValue, WfProcessInstanceEntity entity);
        #endregion
    }
}
