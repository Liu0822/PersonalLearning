﻿using Glorint.Application.WorkFlow;
using Glorint.Util;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Glorint.Application.Web.Areas.LR_WorkFlowModule.Controllers
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创建人：Admin
    /// 日 期：2017.04.17
    /// 描 述：我的任务
    /// </summary>
    public class WfMyTaskController : MvcControllerBase
    {
        private WfProcessInstanceIBLL wfProcessInstanceIBLL = new WfProcessInstanceBLL();
        private WfTaskIBLL wfTaskIBLL = new WfTaskBLL();

        #region 视图功能
        /// <summary>
        /// 主页面
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 发起流程
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult ReleaseForm()
        {
            return View();
        }
        /// <summary>
        /// 流程处理页面
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult CustmerWorkFlowForm()
        {
            return View();
        }
        /// <summary>
        /// 流程节点信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult WfNodeForm()
        {
            return View();
        }

        /// <summary>
        /// 提交发起流程界面
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult ReleaseFlowForm()
        {
            return View();
        }


        /// <summary>
        /// 审核流程
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult AuditFlowForm()
        {
            return View();
        }
        /// <summary>
        /// 流程加签
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult SignFlowForm()
        {
            return View();
        }
        #endregion

        #region 获取数据
        /// <summary>
        /// 获取我的流程信息列表
        /// </summary>
        /// <param name="pagination">分页参数</param>
        /// <param name="queryJson">查询条件</param>
        /// <returns></returns>
        [HttpGet]
        [AjaxOnly]
        public ActionResult GetTaskList(string pagination, string queryJson, string categoryId)
        {
            Pagination paginationobj = pagination.ToObject<Pagination>();
            IEnumerable<WfProcessInstanceEntity> list = new List<WfProcessInstanceEntity>();

            UserInfo userInfo = LoginUserInfo.Get();
            switch (categoryId)
            {
                case "1":
                    list = wfProcessInstanceIBLL.GetMyPageList(userInfo.userId, paginationobj, queryJson);
                    break;
                case "2":
                    list = wfTaskIBLL.GetActiveList(userInfo, paginationobj, queryJson);
                    break;
                case "3":
                    list = wfTaskIBLL.GetHasList(userInfo.userId, paginationobj, queryJson);
                    break;
            }

            var jsonData = new
            {
                rows = list,
                total = paginationobj.total,
                page = paginationobj.page,
                records = paginationobj.records,
            };
            return Success(jsonData);
        }
        #endregion
    }
}