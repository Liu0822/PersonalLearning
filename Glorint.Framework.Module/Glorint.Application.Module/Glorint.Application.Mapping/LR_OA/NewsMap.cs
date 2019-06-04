using Glorint.Application.OA;
using System.Data.Entity.ModelConfiguration;

namespace Glorint.Application.Mapping
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创建人：Admin
    /// 日 期：2017.04.17
    /// 描 述：新闻公告
    /// </summary>
    public class NewsMap : EntityTypeConfiguration<NewsEntity>
    {
        public NewsMap()
        {
            #region 表、主键
            //表
            this.ToTable("LR_OA_NEWS");
            //主键
            this.HasKey(t => t.F_NewsId);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
