using Glorint.Application.TwoDevelopment.Other_L;
using System.Data.Entity.ModelConfiguration;

namespace  Glorint.Application.Mapping
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创 建：超级管理员
    /// 日 期：2018-11-29 09:40
    /// 描 述：Other_L
    /// </summary>
    public class Other_LMap : EntityTypeConfiguration<Other_LEntity>
    {
        public Other_LMap()
        {
            #region 表、主键
            //表
            this.ToTable("OTHER_L");
            //主键
            this.HasKey(t => t.ID);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}

