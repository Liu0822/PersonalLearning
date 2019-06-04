using Glorint.Application.CRM;
using System.Data.Entity.ModelConfiguration;

namespace  Glorint.Application.Mapping
{
    /// <summary>
    /// �� �� Glorint-Admin V1.0 ��Ӧ��WMS
    /// Copyright (c) 2018 ���ڹ�Ͷ��Ӧ���������޹�˾
    /// �� ������������Ա
    /// �� �ڣ�2017-07-11 09:58
    /// �� �����ͻ���ϵ��
    /// </summary>
    public class CrmCustomerContactMap : EntityTypeConfiguration<CrmCustomerContactEntity>
    {
        public CrmCustomerContactMap()
        {
            #region ������
            //��
            this.ToTable("LR_CRM_CUSTOMERCONTACT");
            //����
            this.HasKey(t => t.F_CustomerContactId);
            #endregion

            #region ���ù�ϵ
            #endregion
        }
    }
}

