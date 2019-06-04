using Glorint.Application.Base.SystemModule;
using System.Data.Entity.ModelConfiguration;

namespace Glorint.Application.Mapping.LR_System.Database
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创 建：超级管理员
    /// 日 期：2017-12-19 12:03
    /// 描 述：常用字段类
    /// </summary>
    public class DbFieldMap : EntityTypeConfiguration<DbFieldEntity>
    {
        public DbFieldMap()
        {
            #region 表、主键
            //表
            this.ToTable("LR_BASE_DBFIELD");
            //主键
            this.HasKey(t => t.F_Id);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
