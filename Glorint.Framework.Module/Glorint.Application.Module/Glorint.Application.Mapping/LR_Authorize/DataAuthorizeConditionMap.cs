using Glorint.Application.Base.AuthorizeModule;
using System.Data.Entity.ModelConfiguration;

namespace Glorint.Application.Mapping
{
    /// <summary>
    /// �� �� Glorint-Admin V1.0 ��Ӧ��WMS
    /// Copyright (c) 2018 ���ڹ�Ͷ��Ӧ���������޹�˾
    /// �� ���������ܿ�����
    /// �� �ڣ�2017-06-21 16:30
    /// �� ��������Ȩ��
    /// </summary>
    public class DataAuthorizeConditionMap : EntityTypeConfiguration<DataAuthorizeConditionEntity>
    {
        public DataAuthorizeConditionMap()
        {
            #region ������
            //��
            this.ToTable("LR_BASE_DATACONDITION");
            //����
            this.HasKey(t => t.F_Id);
            #endregion

            #region ���ù�ϵ
            #endregion
        }
    }
}

