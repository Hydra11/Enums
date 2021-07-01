using System;
using System.Collections.Generic;
using System.Text;

namespace iValon_Huawei.ApiManager.CWMS
{
    public enum CwmsDownInterfaceNameEnum
    {
        /// <summary>
        /// ZL001-上架任务接口
        /// </summary>
        CwmsPutaway = 1,
        /// <summary>
        /// 上架取消
        /// </summary>
        CwmsPutawayCancel = 21,


        /// <summary>
        /// ZL003补货
        /// </summary>
        CwmsReplenishment = 3,
        /// <summary>
        /// 补货下架取消
        /// </summary>
        CwmsReplenishmentCancel = 31,


        /// <summary>
        /// ZL004拣选
        /// </summary>
        CwmsPicking = 4,
        /// <summary>
        /// 下架取消
        /// </summary>
        CwmsPickingCancel = 24,


        /// <summary>
        /// ZL005-复核推送接口
        /// </summary>
        CwmsTally = 5,


        /// <summary>
        /// 主数据同步
        /// </summary>
        CwmsMasterDataSynchronization = 11,
        /// <summary>
        /// 库存同步
        /// </summary>
        CwmsInventorySynchronization = 12,
    }
}
