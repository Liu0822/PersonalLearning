using Glorint.Application.CRM;
using System.Data.Entity.ModelConfiguration;

namespace  Glorint.Application.Mapping
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创 建：超级管理员
    /// 日 期：2017-07-11 11:20
    /// 描 述：跟进记录
    /// </summary>
    public class CrmTrailRecordMap : EntityTypeConfiguration<CrmTrailRecordEntity>
    {
        public CrmTrailRecordMap()
        {
            #region 表、主键
            //表
            this.ToTable("LR_CRM_TRAILRECORD");
            //主键
            this.HasKey(t => t.F_TrailId);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}

