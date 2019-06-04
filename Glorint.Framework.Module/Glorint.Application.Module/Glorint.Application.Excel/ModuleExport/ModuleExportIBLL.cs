using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glorint.Application.Excel
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创建人：Admin
    /// 日 期：2017.04.01
    /// 描 述：模板导出
    /// </summary>
    public interface ModuleExportIBLL
    {
        /// <summary>
        /// 导出PDF
        /// </summary>
        /// <param name="html">html页面字串</param>
        void ExportPDF(string html);
    }
}
