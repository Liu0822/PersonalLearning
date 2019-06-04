using Glorint.Application.WorkFlow;
using System.Data.Entity.ModelConfiguration;

namespace Glorint.Application.Mapping
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创建人：Admin
    /// 日 期：2017.04.17
    /// 描 述：工作流模板权限信息
    /// </summary>
    public class WfSchemeAuthorizeMap : EntityTypeConfiguration<WfSchemeAuthorizeEntity>
    {
        public WfSchemeAuthorizeMap()
        {
            #region 表、主键
            //表
            this.ToTable("LR_WF_SCHEMEAUTHORIZE");
            //主键
            this.HasKey(t => t.F_Id);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
