using Glorint.Application.CRM;
using System.Data.Entity.ModelConfiguration;

namespace  Glorint.Application.Mapping
{
    /// <summary>
    /// �� �� Glorint-Admin V1.0 ��Ӧ��WMS
    /// Copyright (c) 2018 ���ڹ�Ͷ��Ӧ���������޹�˾
    /// �� ������������Ա
    /// �� �ڣ�2017-07-10 17:59
    /// �� ������������
    /// </summary>
    public class LR_CRM_OrderEntryMap : EntityTypeConfiguration<CrmOrderProductEntity>
    {
        public LR_CRM_OrderEntryMap()
        {
            #region ������
            //��
            this.ToTable("LR_CRM_ORDERPRODUCT");
            //����
            this.HasKey(t => t.F_OrderEntryId);
            #endregion

            #region ���ù�ϵ
            #endregion
        }
    }
}

