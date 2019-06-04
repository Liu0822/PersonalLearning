
namespace Glorint.Application.Base.SystemModule
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创建人：Admin
    /// 日 期：2017.04.01
    /// 描 述：编号规则
    /// </summary>
    public class CodeRuleFormatModel
    {
        #region 实体成员
        /// <summary>
        /// 项目类型
        /// </summary>		
        public int? itemType { get; set; }
        /// <summary>
        /// 项目类型名称
        /// </summary>		
        public string itemTypeName { get; set; }
        /// <summary>
        /// 格式化字符串
        /// </summary>		
        public string formatStr { get; set; }
        /// <summary>
        /// 步长
        /// </summary>		
        public int? stepValue { get; set; }
        /// <summary>
        /// 初始值
        /// </summary>		
        public int? initValue { get; set; }
        /// <summary>
        /// 备注
        /// </summary>		
        public string description { get; set; }
        #endregion
    }
}
