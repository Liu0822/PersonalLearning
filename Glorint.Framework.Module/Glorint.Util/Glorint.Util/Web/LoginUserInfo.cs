using System.Web;

namespace Glorint.Util
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创建人：Admin
    /// 日 期：2017.03.08
    /// 描 述：当前上下文执行用户信息获取
    /// </summary>
    public static class LoginUserInfo
    {
        /// <summary>
        /// 获取当前上下文执行用户信息
        /// </summary>
        /// <returns></returns>
        public static UserInfo Get()
        {
            return (UserInfo)HttpContext.Current.Items["LoginUserInfo"];
        }
    }
}
