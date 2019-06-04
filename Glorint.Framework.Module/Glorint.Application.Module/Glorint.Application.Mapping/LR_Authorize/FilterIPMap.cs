using Glorint.Application.Base.AuthorizeModule;
using System.Data.Entity.ModelConfiguration;

namespace Glorint.Application.Mapping
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创建人：Admin
    /// 日 期：2017.04.17
    /// 描 述：IP过滤
    /// </summary>
    public class FilterIPMap : EntityTypeConfiguration<FilterIPEntity>
    {
        public FilterIPMap()
        {
            #region 表、主键
            //表
            this.ToTable("LR_BASE_FILTERIP");
            //主键
            this.HasKey(t => t.F_FilterIPId);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
