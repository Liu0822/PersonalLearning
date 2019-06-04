using Glorint.Application.CRM;
using System.Data.Entity.ModelConfiguration;

namespace  Glorint.Application.Mapping
{
    /// <summary>
    /// �� �� Glorint-Admin V1.0 ��Ӧ��WMS
    /// Copyright (c) 2018 ���ڹ�Ͷ��Ӧ���������޹�˾
    /// �� ������������Ա
    /// �� �ڣ�2017-07-11 11:20
    /// �� ����������¼
    /// </summary>
    public class CrmTrailRecordMap : EntityTypeConfiguration<CrmTrailRecordEntity>
    {
        public CrmTrailRecordMap()
        {
            #region ������
            //��
            this.ToTable("LR_CRM_TRAILRECORD");
            //����
            this.HasKey(t => t.F_TrailId);
            #endregion

            #region ���ù�ϵ
            #endregion
        }
    }
}

