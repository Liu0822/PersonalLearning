using Glorint.Util;
using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace Glorint.Application.TwoDevelopment.Other_L

{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创 建：超级管理员
    /// 日 期：2018-11-29 09:40
    /// 描 述：Other_L
    /// </summary>
    public class Other_LEntity 
    {
        #region 实体成员
        /// <summary>
        /// ID
        /// </summary>
        /// <returns></returns>
        [Column("ID")]
        public string ID { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        /// <returns></returns>
        [Column("NAME")]
        public string Name { get; set; }
        /// <summary>
        /// Title
        /// </summary>
        /// <returns></returns>
        [Column("TITLE")]
        public string Title { get; set; }
        /// <summary>
        /// Files
        /// </summary>
        /// <returns></returns>
        [Column("FILES")]
        public string Files { get; set; }
        /// <summary>
        /// Selects
        /// </summary>
        [Column("SELECTS")]
        public string Selects { get; set; }
        /// <summary>
        /// 富文本
        /// </summary>
        [Column("EDITOR")]
        public string Editor { get; set; } 
        #endregion

        #region 扩展操作
        /// <summary>
        /// 新增调用
        /// </summary>
        public void Create()
        {
            this.ID = Guid.NewGuid().ToString();
        }
        /// <summary>
        /// 编辑调用
        /// </summary>
        /// <param name="keyValue"></param>
        public void Modify(string keyValue)
        {
            this.ID = keyValue;
        }
        #endregion
    }
}

