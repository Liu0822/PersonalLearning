﻿using Glorint.Util;
using System.Collections.Generic;

namespace Glorint.Application.Organization
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创建人：Admin
    /// 日 期：2017.04.17
    /// 描 述：部门管理
    /// </summary>
    public interface DepartmentIBLL
    {
        #region 获取数据
        /// <summary>
        /// 获取部门列表信息(根据公司Id)
        /// </summary>
        /// <param name="companyId">公司Id</param>
        /// <returns></returns>
        List<DepartmentEntity> GetList(string companyId);
        /// <summary>
        /// 获取部门列表信息(根据公司Id)
        /// </summary>
        /// <param name="companyId">公司Id</param>
        /// <param name="keyWord">查询关键字</param>
        /// <returns></returns>
        List<DepartmentEntity> GetList(string companyId, string keyWord);
        /// <summary>
        /// 获取部门数据实体
        /// </summary>
        /// <param name="keyValue">主键</param>
        /// <returns></returns>
        DepartmentEntity GetEntity(string keyValue);
        /// <summary>
        /// 获取部门数据实体
        /// </summary>
        /// <param name="companyId">公司主键</param>
        /// <param name="departmentId">部门主键</param>
        /// <returns></returns>
        DepartmentEntity GetEntity(string companyId, string departmentId);
        /// <summary>
        /// 获取树形数据
        /// </summary>
        /// <param name="companyId">公司id</param>
        /// <param name="parentId">父级id</param>
        /// <returns></returns>
        List<TreeModel> GetTree(string companyId, string parentId);
        /// <summary>
        /// 获取树形数据
        /// </summary>
        /// <param name="companyId">公司id</param>
        /// <param name="parentId">父级id</param>
        /// <returns></returns>
        List<TreeModel> GetTree(List<CompanyEntity> companylist);
        /// <summary>
        /// 获取部门本身和子部门的id
        /// </summary>
        /// <param name="parentId">父级ID</param>
        /// <returns></returns>
        List<string> GetSubNodes(string companyId, string parentId);
        /// <summary>
        /// 获取部门映射数据
        /// </summary>
        /// <returns></returns>
        Dictionary<string, DepartmentModel> GetModelMap();
        #endregion

        #region 提交数据
        /// <summary>
        /// 虚拟删除部门信息
        /// </summary>
        /// <param name="keyValue">主键</param>
        void VirtualDelete(string keyValue);
        /// <summary>
        /// 保存部门信息（新增、修改）
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="departmentEntity">部门实体</param>
        /// <returns></returns>
        void SaveEntity(string keyValue, DepartmentEntity departmentEntity);
        #endregion
    }
}
