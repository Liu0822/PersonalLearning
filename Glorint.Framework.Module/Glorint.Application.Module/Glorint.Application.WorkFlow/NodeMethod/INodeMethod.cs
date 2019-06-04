
namespace Glorint.Application.WorkFlow
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创建人：Admin
    /// 日 期：2017.04.17
    /// 描 述：工作流引擎节点触发接口
    /// </summary>
    public interface INodeMethod
    {
        /// <summary>
        /// 节点审核通过执行方法
        /// </summary>
        /// <param name="processId"></param>
        void Sucess(string processId);
        /// <summary>
        /// 节点审核失败执行方法
        /// </summary>
        /// <param name="processId"></param>
        void Fail(string processId);
    }
}
