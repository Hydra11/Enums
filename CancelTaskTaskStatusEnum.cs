using System;
using System.Collections.Generic;
using System.Text;

namespace iValon_Huawei.ApiManager.CWMS.Enums
{
    public enum CancelTaskTaskStatusEnum
    {
        /// <summary>
        /// 取消成功，CWMS发起取消
        /// </summary>
        Cancelled,
        /// <summary>
        /// 取消失败
        /// </summary>
        CancelFailed,
        /// <summary>
        /// 强制取消
        /// </summary>
        Aborted,
        /// <summary>
        /// 强制取消失败
        /// </summary>
        AbortFailed,
    }
}
