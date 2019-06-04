using Glorint.Application.Excel;
using System.Data.Entity.ModelConfiguration;

namespace Glorint.Application.Mapping.LR_Excel
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创 建：超级管理员
    /// 日 期：2017-09-05 16:07
    /// 描 述：Excel数据导入设置字段
    /// </summary>
    public class ExcelImportFieldMap : EntityTypeConfiguration<ExcelImportFieldEntity>
    {
        public ExcelImportFieldMap()
        {
            #region 表、主键
            //表
            this.ToTable("LR_EXCEL_IMPORTFILEDS");
            //主键
            this.HasKey(t => t.F_Id);
            #endregion
 
            #region 配置关系
            #endregion
        }
    }
}
