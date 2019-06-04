using System;
namespace Glorint.Util.Operat
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创建人：Admin
    /// 日 期：2017.03.08
    /// 描 述：当前连接用户信息
    /// </summary>
    public class Operator
    {
        /// <summary>
        /// 应用Id
        /// </summary>
        public string appId { get; set; }
        /// <summary>
        /// 用户账号
        /// </summary>
        public string account { get; set; }
        /// <summary>
        /// 登录时间
        /// </summary>
        public DateTime logTime { get; set; }
        /// <summary>
        /// 登录IP地址
        /// </summary>
        public string iPAddress { get; set; }
        /// <summary>
        /// 浏览器名称
        /// </summary>
        public string browser { get; set; }
        /// <summary>
        /// 登录者标识
        /// </summary>
        public string loginMark { get; set; }
        /// <summary>
        /// 票据信息
        /// </summary>
        public string token { get; set; }
    }
}
