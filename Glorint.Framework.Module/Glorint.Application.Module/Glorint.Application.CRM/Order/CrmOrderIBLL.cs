using Glorint.Util;
using System.Collections.Generic;

namespace Glorint.Application.CRM
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创建人：Admin
    /// 日 期：2017.03.09
    /// 描 述：订单管理
    /// </summary>
    public interface CrmOrderIBLL
    {
        #region 获取数据
        /// <summary>
        /// 订单列表
        /// </summary>
        /// <returns></returns>
        IEnumerable<CrmOrderEntity> GetPageList(Pagination pagination, string queryJson, string custmerQuerySql);
        /// <summary>
        /// 获取订单信息主键
        /// </summary>
        /// <param name="keyValue">主键</param>
        /// <returns></returns>
        CrmOrderEntity GetCrmOrderEntity(string keyValue);
        /// <summary>
        /// 获取订单产品明细数据
        /// </summary>
        /// <param name="orderId">订单主键</param>
        /// <returns></returns>
        IEnumerable<CrmOrderProductEntity> GetCrmOrderProductEntity(string orderId);
        #endregion

        #region 提交数据
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="keyValue">主键</param>
        void DeleteEntity(string keyValue);
        /// <summary>
        /// 保存表单（新增、修改）
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="crmOrderEntity">实体对象</param>
        /// <param name="CrmOrderProductEntity">明细实体对象</param>
        /// <returns></returns>
        void SaveEntity(string keyValue, CrmOrderEntity crmOrderEntity, List<CrmOrderProductEntity> crmOrderProductList);
        #endregion
    }
}
