using System.Web.Mvc;

namespace Glorint.Application.Web.Areas.LR_CodeDemo.Controllers
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创建人：Admin
    /// 日 期：2018.04.12
    /// 描 述：附件管理
    /// </summary>
    public class GridDemoController : MvcControllerBase
    {
        /// <summary>
        /// 普通表格
        /// </summary>
        /// <returns></returns>
        public ActionResult CommonIndex()
        {
            return View();
        }


        /// <summary>
        /// 编辑表格
        /// </summary>
        /// <returns></returns>
        public ActionResult EditIndex()
        {
            return View();
        }

        /// <summary>
        /// 报表表格
        /// </summary>
        /// <returns></returns>
        public ActionResult ReportIndex()
        {
            return View();
        }
    }
}