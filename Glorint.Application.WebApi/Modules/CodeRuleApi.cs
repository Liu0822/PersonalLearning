using Glorint.Application.Base.SystemModule;
using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Glorint.Application.WebApi.Modules
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创建人：Admin
    /// 日 期：2018.01.04
    /// 描 述：编码规则
    /// </summary>
    public class CodeRuleApi: BaseApi
    {
        /// <summary>
        /// 注册接口
        /// </summary>
        public CodeRuleApi()
            : base("/learun/adms/coderule")
        {
            Get["/code"] = GetEnCode;// 获取数据字典详细列表
        }
        private CodeRuleIBLL codeRuleIBLL = new CodeRuleBLL();

        /// <summary>
        /// 获取数据字典详细列表
        /// </summary>
        /// <param name="_"></param>
        /// <returns></returns>
        private Response GetEnCode(dynamic _)
        {
            string req = this.GetReqData();// 获取模板请求数据
            var data = codeRuleIBLL.GetBillCode(req);
            return SuccessString(data);
        }
    }
}