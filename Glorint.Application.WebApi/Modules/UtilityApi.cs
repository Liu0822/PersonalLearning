using Nancy;

namespace Glorint.Application.WebApi.Modules
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创建人：Admin
    /// 日 期：2017.05.12
    /// 描 述：通用功能
    /// </summary>
    public class UtilityApi : BaseApi
    {
        /// <summary>
        /// 注册接口
        /// </summary>
        public UtilityApi()
            : base("/learun/adms")
        {
            Get["/heart"] = Heart;
        }

        /// <summary>
        /// 登录接口
        /// </summary>
        /// <param name="_"></param>
        /// <returns></returns>
        private Response Heart(dynamic _)
        {
            return Success("成功");
        }
    }
}