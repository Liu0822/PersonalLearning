using Glorint.Util;
using System.Web.Mvc;

namespace Glorint.Application.Web
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创建人：Admin
    /// 日 期：2017.03.08
    /// 描 述：控制器执行后执行
    /// </summary>
    public class ResultFillters : FilterAttribute, IResultFilter
    {
        /// <summary>
        /// 执行完action后跳转后执行
        /// </summary>
        /// <param name="filterContext"></param>
        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            if(filterContext.Result is ViewResult ){// 如果返回结果是视图
                var viewResult = (ViewResult)filterContext.Result;
                string html = string.Empty;
                IView view = ViewEngines.Engines.FindView(filterContext, viewResult.ViewName, string.Empty).View;
                using (System.IO.StringWriter sw = new System.IO.StringWriter())
                {
                    ViewContext vc = new ViewContext(filterContext, view, viewResult.ViewData, viewResult.TempData, sw);
                    vc.View.Render(vc, sw);
                    html = sw.ToString();
                }
                ContentResult Content = new ContentResult();
                Content.Content = html;
                filterContext.Result = Content;
            }
        }
        /// <summary>
        /// 执行完action后跳转前执行
        /// </summary>
        /// <param name="filterContext"></param>
        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
        }
    }
}