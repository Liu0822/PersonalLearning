namespace Glorint.Application.Organization
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创建人：Admin
    /// 日 期：2018.03.27
    /// 描 述：部门数据模型
    /// </summary>
    public class DepartmentModel
    {
        /// <summary>
        /// 部门上级id
        /// </summary>
        public string parentId { get; set; }
        /// <summary>
        /// 公司主键
        /// </summary>
        public string companyId { get; set; }
        /// <summary>
        /// 公司名字
        /// </summary>
        public string name { get; set; }
    }
}
