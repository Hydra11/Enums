using System;
using System.Collections.Generic;
using System.Text;

namespace iValon_Huawei.ApiManager.CWMS
{
    /// <summary>
    /// 入库任务 入库订单类型
    /// </summary>
    public enum CwmsPutawayTaskDetailTypeEnum
    {
        /// <summary>
        /// 上架
        /// </summary>
        SJ = 1,
        /// <summary>
        /// 补货
        /// </summary>
        BH = 2,
        /// <summary>
        /// 其他
        /// </summary>
        OTHER = 3,
    }
}
