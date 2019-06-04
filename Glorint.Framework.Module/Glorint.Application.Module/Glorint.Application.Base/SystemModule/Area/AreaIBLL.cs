using Glorint.Util;
using System.Collections.Generic;

namespace Glorint.Application.Base.SystemModule
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创建人：Admin
    /// 日 期：2017.04.01
    /// 描 述：行政区域
    /// </summary>
    public interface AreaIBLL
    {
        #region 获取数据
        /// <summary>
        /// 获取区域列表数据
        /// </summary>
        /// <param name="parentId">父节点主键（0表示顶层）</param>
        /// <returns></returns>
        List<AreaEntity> GetList(string parentId);
        /// <summary>
        /// 获取区域列表数据
        /// </summary>
        /// <param name="parentId">父节点主键（0表示顶层）</param>
        /// <param name="keyword">关键字查询（名称/编号）</param>
        /// <returns></returns>
        List<AreaEntity> GetList(string parentId, string keyword);
        /// <summary>
        /// 获取区域数据树（某一级的）
        /// </summary>
        /// <param name="parentId">父级主键</param>
        /// <returns></returns>
        List<TreeModel> GetTree(string parentId);
        /// <summary>
        /// 区域实体
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        AreaEntity GetEntity(string keyValue);
        #endregion

        #region 提交数据
        /// <summary>
        /// 虚拟删除区域
        /// </summary>
        /// <param name="keyValue">主键</param>
        void VirtualDelete(string keyValue);
        /// <summary>
        /// 保存区域表单（新增、修改）
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="areaEntity">区域实体</param>
        /// <returns></returns>
        void SaveEntity(string keyValue, AreaEntity areaEntity);
        #endregion
    }
}
