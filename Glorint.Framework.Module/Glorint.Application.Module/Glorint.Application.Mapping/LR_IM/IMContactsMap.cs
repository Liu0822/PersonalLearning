using Glorint.Application.IM;
using System.Data.Entity.ModelConfiguration;

namespace Glorint.Application.Mapping
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创建人：Admin
    /// 日 期：2018.05.31
    /// 描 述：即时通讯消息内容
    /// </summary>
    public class IMContactsMap : EntityTypeConfiguration<IMContactsEntity>
    {
        public IMContactsMap()
        {
            #region 表、主键
            //表
            this.ToTable("LR_IM_CONTACTS");
            //主键
            this.HasKey(t => t.F_Id);
            #endregion

            #region 配置关系
            #endregion
        }
    }
}
