using Glorint.Application.CRM;
using Nancy;

namespace Glorint.Application.WebApi.Modules.LR_Crm
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创建人：Admin
    /// 日 期：2018.07.10
    /// 描 述：客户管理
    /// </summary>
    public class CrmCustomer: BaseApi
    {
        /// <summary>
        /// 注册接口
        /// </summary>
        public CrmCustomer()
            : base("/learun/adms/crm/customer")
        {
            Get["/list"] = GetList;// 获取客户列表
        }

        private CrmCustomerIBLL crmCustomerIBLL = new CrmCustomerBLL();

        /// <summary>
        /// 获取客户列表
        /// </summary>
        /// <param name="_"></param>
        /// <returns></returns>
        private Response GetList(dynamic _)
        {
            var list = crmCustomerIBLL.GetList();
            return Success(list);
        }
    }
}