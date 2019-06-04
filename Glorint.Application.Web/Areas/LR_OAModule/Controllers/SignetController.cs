using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Glorint.Application.Web.Areas.LR_OAModule.Controllers
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创建人：Admin
    /// 日 期：2017.07.17
    /// 描 述：电子签章
    /// </summary>
    public class SignetController : MvcControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}