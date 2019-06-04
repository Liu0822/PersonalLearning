using Glorint.Application.AppMagager;
using System.Data.Entity.ModelConfiguration;

namespace Glorint.Application.Mapping
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创建人：Admin
    /// 日 期：2018.03.16
    /// 描 述：工作流模板
    /// </summary>
    public class FunctionMap : EntityTypeConfiguration<FunctionEntity>
    {
        public FunctionMap()
        {
            #region 表、主键
            //表
            this.ToTable("LR_APP_FUNCTION");
            //主键
            this.HasKey(t => t.F_Id);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
