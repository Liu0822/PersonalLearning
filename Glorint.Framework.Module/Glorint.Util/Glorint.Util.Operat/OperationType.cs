﻿using System.ComponentModel;

namespace Glorint.Util.Operat
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创建人：Admin
    /// 日 期：2017.03.08
    /// 描 述：操作类型
    /// </summary>
    public enum OperationType
    {
        /// <summary>
        /// 其他
        /// </summary>
        [Description("其他")]
        Other = 0,
        /// <summary>
        /// 登陆
        /// </summary>
        [Description("登录")]
        Login = 1,
        /// <summary>
        /// 登陆
        /// </summary>
        [Description("退出")]
        Exit = 2,
        /// <summary>
        /// 访问
        /// </summary>
        [Description("访问")]
        Visit = 3,
        /// <summary>
        /// 离开
        /// </summary>
        [Description("离开")]
        Leave = 4,
        /// <summary>
        /// 新增
        /// </summary>
        [Description("新增")]
        Create = 5,
        /// <summary>
        /// 删除
        /// </summary>
        [Description("删除")]
        Delete = 6,
        /// <summary>
        /// 修改
        /// </summary>
        [Description("修改")]
        Update = 7,
        /// <summary>
        /// 提交
        /// </summary>
        [Description("提交")]
        Submit = 8,
        /// <summary>
        /// 异常
        /// </summary>
        [Description("异常")]
        Exception = 9,
        /// <summary>
        /// 异常
        /// </summary>
        [Description("移动登录")]
        AppLogin = 10,
    }
}
