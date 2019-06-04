namespace Glorint.Application.Organization
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创建人：Admin
    /// 日 期：2018.03.27
    /// 描 述：公司数据模型
    /// </summary>
    public class CompanyModel
    {
        /// <summary>
        /// 公司上级Id
        /// </summary>
        public string parentId { get; set; }
        /// <summary>
        /// 公司名称
        /// </summary>
        public string name { get; set; }
    }
}
