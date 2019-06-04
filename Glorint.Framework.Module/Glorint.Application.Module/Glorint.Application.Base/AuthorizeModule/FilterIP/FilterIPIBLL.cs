using System.Collections.Generic;

namespace Glorint.Application.Base.AuthorizeModule
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创建人：Admin
    /// 日 期：2017.04.17
    /// 描 述：IP过滤
    /// </summary>
    public interface FilterIPIBLL
    {
        #region 获取数据
        /// <summary>
        /// 过滤IP列表
        /// </summary>
        /// <param name="objectId">对象Id</param>
        /// <param name="visitType">访问:0-拒绝，1-允许</param>
        /// <returns></returns>
        IEnumerable<FilterIPEntity> GetList(string objectId, string visitType);
        /// <summary>
        /// 过滤IP实体
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        FilterIPEntity GetEntity(string keyValue);
        #endregion

        #region 提交数据
        /// <summary>
        /// 删除过滤IP
        /// </summary>
        /// <param name="keyValue">主键</param>
        void DeleteEntiy(string keyValue);
        /// <summary>
        /// 保存过滤IP表单（新增、修改）
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="filterIPEntity">过滤IP实体</param>
        /// <returns></returns>
        void SaveForm(string keyValue, FilterIPEntity filterIPEntity);
        #endregion
    }
}
