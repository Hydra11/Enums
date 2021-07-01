using System;
using System.Collections.Generic;
using System.Text;

namespace iValon_Huawei.ApiManager.CWMS
{
    public enum CwmsTaskStatusEnum
    {
        /// <summary>
        /// 
        /// </summary>
        taskStatus,
        /// <summary>
        /// 任务接受成功(任务状态)
        /// </summary>
        New,
        /// <summary>
        /// 正在执行（任务步骤）,(任务状态)
        /// </summary>
        Doing,
        /// <summary>
        /// 已完成(任务状态,任务步骤）
        /// </summary>
        Succeeded,
        /// <summary>
        /// 取消(任务状态)CWMS发起的任务取消。
        /// </summary>
        Cancelled,
        /// <summary>
        /// 超时等其他异常(任务状态)WCS异常。
        /// </summary>
        Abnormal,
        /// <summary>
        /// 设备故障任务挂起(任务状态)
        /// </summary>
        Pending,


        /// <summary>
        /// 取消失败,CWMS发起取消
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


        /// <summary>
        /// 更改成功
        /// </summary>
        Changed,
        /// <summary>
        /// 更改失败
        /// </summary>
        ChangeFailed,
    }
}
