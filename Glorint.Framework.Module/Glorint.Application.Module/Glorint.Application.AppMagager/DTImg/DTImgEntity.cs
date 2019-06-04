﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Glorint.Application.AppMagager
{
    /// <summary> 
    /// 版 本 Glorint-Admin V1.0 供应链WMS 
    /// Copyright (c) 2018 深圳国投供应链管理有限公司 
    /// 创 建：超级管理员 
    /// 日 期：2018-07-02 15:31 
    /// 描 述：App首页图片管理 
    /// </summary> 
    public class DTImgEntity
    {
        #region 实体成员 
        /// <summary> 
        /// 主键 
        /// </summary> 
        /// <returns></returns> 
        [Column("F_ID")]
        public string F_Id { get; set; }
        /// <summary> 
        /// 图片说明 
        /// </summary> 
        /// <returns></returns> 
        [Column("F_DES")]
        public string F_Des { get; set; }
        /// <summary> 
        /// 图片文件名 
        /// </summary> 
        /// <returns></returns> 
        [Column("F_FILENAME")]
        public string F_FileName { get; set; }
        /// <summary> 
        /// 有效标志0否1是 
        /// </summary> 
        /// <returns></returns> 
        [Column("F_ENABLEDMARK")]
        public int? F_EnabledMark { get; set; }
        /// <summary> 
        /// 排序码 
        /// </summary> 
        /// <returns></returns> 
        [Column("F_SORTCODE")]
        public int? F_SortCode { get; set; }
        #endregion

        #region 扩展操作 
        /// <summary> 
        /// 新增调用 
        /// </summary> 
        public void Create()
        {
            this.F_Id = Guid.NewGuid().ToString();
            this.F_EnabledMark = 1;
        }
        /// <summary> 
        /// 编辑调用 
        /// </summary> 
        /// <param name="keyValue"></param> 
        public void Modify(string keyValue)
        {
            this.F_Id = keyValue;
        }
        #endregion
    }
}
