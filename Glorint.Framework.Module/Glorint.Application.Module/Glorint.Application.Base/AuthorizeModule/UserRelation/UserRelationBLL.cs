﻿using Glorint.Cache.Base;
using Glorint.Cache.Factory;
using Glorint.Util;
using System;
using System.Collections.Generic;

namespace Glorint.Application.Base.AuthorizeModule
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创建人：Admin
    /// 日 期：2017.04.17
    /// 描 述：用户关联对象
    /// </summary>
    public class UserRelationBLL : UserRelationIBLL
    {
        UserRelationService userRelationService = new UserRelationService();
        #region 缓存定义
        private ICache cache = CacheFactory.CaChe();
        private string cacheKey = "learun_adms_userrelation_"; // + 分类 +用户主键
        #endregion

        #region 获取数据
        /// <summary>
        /// 获取对象主键列表信息
        /// </summary>
        /// <param name="userId">用户主键</param>
        /// <param name="category">分类:1-角色2-岗位</param>
        /// <returns></returns>
        public List<UserRelationEntity> GetObjectIdList(string userId, int category)
        {
            try
            {
                List<UserRelationEntity> list = cache.Read<List<UserRelationEntity>>(cacheKey + category + '_' + userId, CacheId.userRelation);
                if (list == null)
                {
                    list = (List<UserRelationEntity>)userRelationService.GetObjectIdList(userId, category);
                    cache.Write<List<UserRelationEntity>>(cacheKey + category + '_' + userId, list, CacheId.userRelation);
                }
                return list;
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowBusinessException(ex);
                }
            }
        }
        /// <summary>
        /// 获取对象主键列表信息
        /// </summary>
        /// <param name="userId">用户主键</param>
        /// <param name="category">分类:1-角色2-岗位</param>
        /// <returns></returns>
        public string GetObjectIds(string userId, int category)
        {
            try
            {
                string res = "";
                List<UserRelationEntity> list = GetObjectIdList(userId, category);
                foreach (UserRelationEntity item in list)
                {
                    if (res != "")
                    {
                        res += ",";
                    }
                    res += item.F_ObjectId;
                }
                return res;
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowBusinessException(ex);
                }
            }
        }
        /// <summary>
        /// 获取用户主键列表信息
        /// </summary>
        /// <param name="objectId">用户主键</param>
        /// <returns></returns>
        public IEnumerable<UserRelationEntity> GetUserIdList(string objectId)
        {
            try
            {
                return userRelationService.GetUserIdList(objectId);
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowBusinessException(ex);
                }
            }
        }
        #endregion

        #region 提交数据
        /// <summary>
        /// 保存用户对应对象数据
        /// </summary>
        /// <param name="objectId">对应对象主键</param>
        /// <param name="category">分类:1-角色2-岗位</param>
        /// <param name="userIds">对用户主键列表</param>
        public void SaveEntityList(string objectId, int category, string userIds)
        {
            try
            {
                List<UserRelationEntity> list = new List<UserRelationEntity>();
                string[] userIdList = userIds.Split(',');
                foreach (string userId in userIdList)
                {
                    UserRelationEntity userRelationEntity = new UserRelationEntity();
                    userRelationEntity.Create();
                    userRelationEntity.F_UserId = userId;
                    userRelationEntity.F_Category = category;
                    userRelationEntity.F_ObjectId = objectId;
                    list.Add(userRelationEntity);
                    cache.Remove(cacheKey + category + '_' + userId, CacheId.userRelation);
                }
                userRelationService.SaveEntityList(objectId, list);
            }
            catch (Exception ex)
            {
                if (ex is ExceptionEx)
                {
                    throw;
                }
                else
                {
                    throw ExceptionEx.ThrowBusinessException(ex);
                }
            }
        }
        #endregion
    }
}
