﻿
namespace Glorint.Application.WorkFlow
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创建人：Admin
    /// 日 期：2017.04.17
    /// 描 述：工作流字段权限信息
    /// </summary>
    public class WfAuthorizeField
    {
        /// <summary>
        /// 字段名称
        /// </summary>
        public string fieldName { get; set; }
        /// <summary>
        /// 字段Id
        /// </summary>
        public string fieldId { get; set; }
        /// <summary>
        /// 是否可编辑1是0不是
        /// </summary>
        public int isEdit { get; set; }
        /// <summary>
        /// 是否可查看1是0不是
        /// </summary>
        public int isLook { get; set; }
    }
}
