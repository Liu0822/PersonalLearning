using Glorint.Application.CRM;
using System.Data.Entity.ModelConfiguration;

namespace  Glorint.Application.Mapping
{
    /// <summary>
    /// �� �� Glorint-Admin V1.0 ��Ӧ��WMS
    /// Copyright (c) 2018 ���ڹ�Ͷ��Ӧ���������޹�˾
    /// �� ������������Ա
    /// �� �ڣ�2017-07-11 14:48
    /// �� ����Ӧ���˿�
    /// </summary>
    public class LR_CRM_ReceivableMap : EntityTypeConfiguration<CrmReceivableEntity>
    {
        public LR_CRM_ReceivableMap()
        {
            #region ������
            //��
            this.ToTable("LR_CRM_RECEIVABLE");
            //����
            this.HasKey(t => t.F_ReceivableId);
            #endregion

            #region ���ù�ϵ
            #endregion
        }
    }
}

