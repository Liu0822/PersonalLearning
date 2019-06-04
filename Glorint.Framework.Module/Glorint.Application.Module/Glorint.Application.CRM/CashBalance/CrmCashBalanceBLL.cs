using Glorint.Util;
using System;
using System.Collections.Generic;

namespace Glorint.Application.CRM
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创 建：超级管理员
    /// 日 期：2017-07-11 14:20
    /// 描 述：现金余额
    /// </summary>
    public class CrmCashBalanceBLL : CrmCashBalanceIBLL
    {
        CrmCashBalanceService crmCashBalanceService = new CrmCashBalanceService();

        #region 获取数据
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="queryJson">查询参数</param>
        /// <returns>返回列表</returns>
        public IEnumerable<CrmCashBalanceEntity> GetList(string queryJson)
        {
            try
            {
                return crmCashBalanceService.GetList(queryJson);
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
