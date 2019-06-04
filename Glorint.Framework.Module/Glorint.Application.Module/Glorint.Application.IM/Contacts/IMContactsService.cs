using Glorint.DataBase.Repository;
using Glorint.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Glorint.Application.IM
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创建人：Admin
    /// 日 期：2018.05.31
    /// 描 述：最近联系人列表
    /// </summary>
    public class IMContactsService: RepositoryFactory
    {
        #region 构造函数和属性

        private string fieldSql;
        public IMContactsService()
        {
            fieldSql = @"
                t.F_Id,
                t.F_MyUserId,
                t.F_OtherUserId,
                t.F_Content,
                t.F_Time,
                t.F_IsRead
            ";
        }
        #endregion

        #region 获取数据

        /// <summary>
        /// 获取列表数据
        /// </summary>
        /// <param name="userId">用户Id</param>
        /// <returns></returns>
        public IEnumerable<IMContactsEntity> GetList(string userId)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM LR_IM_Contacts t where  t.F_MyUserId = @userId Order By t.F_Time Desc ");
                return this.BaseRepository().FindList<IMContactsEntity>(strSql.ToString(), new { userId = userId });
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowServiceException(ex);
                }
            }
        }
        /// <summary>
        /// 获取列表数据
        /// </summary>
        /// <param name="userId">用户Id</param>
        /// <param name="time">时间</param>
        /// <returns></returns>
        public IEnumerable<IMContactsEntity> GetList(string userId, DateTime time)
        {
            try
            {
                var strSql = new StringBuilder();
                strSql.Append("SELECT ");
                strSql.Append(fieldSql);
                strSql.Append(" FROM LR_IM_Contacts t where  t.F_MyUserId = @userId AND t.F_Time >= @time  Order By t.F_Time Asc ");
                return this.BaseRepository().FindList<IMContactsEntity>(strSql.ToString(), new { userId, time });
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowServiceException(ex);
                }
            }
        }
        /// <summary>
        /// 获取实体
        /// </summary>
        /// <param name="userId">发送人</param>
        /// <param name="otherUserId">接收人</param>
        /// <returns></returns>
        public IMContactsEntity GetEntity(string userId, string otherUserId)
        {
            try
            {
                return this.BaseRepository().FindEntity<IMContactsEntity>(t=>t.F_MyUserId.Equals(userId) && t.F_OtherUserId.Equals(otherUserId));
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowServiceException(ex);
                }
            }
        }
        #endregion

        #region 提交数据
        /// <summary>
        /// 保存实体数据（新增、修改）
        /// <param name="keyValue">主键</param>
        /// <summary>
        /// <returns></returns>
        public void SaveEntity(IMContactsEntity entity)
        {
            try
            {
                IMContactsEntity entity2 = GetEntity(entity.F_MyUserId, entity.F_OtherUserId);
                entity.F_IsRead = 2;
                if (entity2 == null)
                {
                    entity.Create();
                    this.BaseRepository().Insert(entity);
                }
                else {
                    entity.Modify(entity2.F_Id);
                    this.BaseRepository().Update(entity);
                }
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowServiceException(ex);
                }
            }
        }

        /// <summary>
        /// 更新记录读取状态
        /// </summary>
        /// <param name="myUserId">自己本身用户ID</param>
        /// <param name="otherUserId">对方用户ID</param>
        public void UpdateState(string myUserId, string otherUserId)
        {
            try
            {
                IMContactsEntity entity = GetEntity(myUserId, otherUserId);
                if (entity != null) {
                    entity.F_IsRead = 2;
                    this.BaseRepository().Update(entity);
                }
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowServiceException(ex);
                }
            }
        }

        #endregion
    }
}
