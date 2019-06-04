namespace Glorint.Application.Base.SystemModule
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创建人：Admin
    /// 日 期：2018.03.27
    /// 描 述：数据字典数据模型
    /// </summary>
    public class DataItemModel
    {
        /// <summary>
        /// 上级ID
        /// </summary>
        public string parentId { get; set; }
        /// <summary>
        /// 显示名称
        /// </summary>
        public string text { get; set; }
        /// <summary>
        /// 值
        /// </summary>
        public string value { get; set; }
    }
}
