using Glorint.Cache.Base;
using Glorint.Cache.Redis;

namespace Glorint.Cache.Factory
{
    /// <summary>
    /// 版 本 Glorint-Admin V1.0 供应链WMS
    /// Copyright (c) 2018 深圳国投供应链管理有限公司
    /// 创建人：Admin
    /// 日 期：2017.03.06
    /// 描 述：定义缓存工厂类
    /// </summary>
    public class CacheFactory
    {
        public static ICache CaChe()
        {
            return new CacheByRedis();
        }
    }
}
