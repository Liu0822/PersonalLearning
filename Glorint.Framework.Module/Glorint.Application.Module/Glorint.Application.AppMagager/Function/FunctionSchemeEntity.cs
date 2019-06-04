using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Glorint.Application.AppMagager
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创建人：Admin
    /// 日 期：2018.03.16
    /// 描 述：移动端功能管理
    /// </summary>
    public class FunctionSchemeEntity
    {
        #region 实体成员
        /// <summary>
        /// F_Id
        /// </summary>
        /// <returns></returns>
        [Column("F_ID")]
        public string F_Id { get; set; }
        /// <summary>
        /// F_Scheme
        /// </summary>
        /// <returns></returns>
        [Column("F_SCHEME")]
        public string F_Scheme { get; set; }
        #endregion

        #region 扩展操作
        /// <summary>
        /// 新增调用
        /// </summary>
        public void Create()
        {
            this.F_Id = Guid.NewGuid().ToString();
        }
        /// <summary>
        /// 编辑调用
        /// </summary>
        /// <param name="keyValue"></param>
        public void Modify(string keyValue)
        {
            this.F_Id = keyValue;
        }
        #endregion
    }
}
