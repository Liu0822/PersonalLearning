using System.Collections.Generic;

namespace Glorint.Util
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创建人：Admin
    /// 日 期：2017.03.07
    /// 描 述：数据库查询拼接数据模型
    /// </summary>
    public class DbWhere
    {
        /// <summary>
        /// sql语句
        /// </summary>
        public string sql { get; set; }
        /// <summary>
        /// 查询参数
        /// </summary>
        public List<FieldValueParam> dbParameters { get; set; }
    }
}
