using Glorint.Application.IM;
using System.Data.Entity.ModelConfiguration;

namespace Glorint.Application.Mapping
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创 建：超级管理员
    /// 日 期：2018-05-24 09:57
    /// 描 述：测试
    /// </summary>
    public class IMSysUserMap : EntityTypeConfiguration<IMSysUserEntity>
    {
        public IMSysUserMap()
        {
            #region 表、主键
            //表
            this.ToTable("LR_IM_SYSUSER");
            //主键
            this.HasKey(t => t.F_Id);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
