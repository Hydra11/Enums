using System;
using System.Collections.Generic;
using System.Text;

namespace iValon_Huawei.ApiManager.CWMS
{
    public enum AddTaskTaskStatusEnum
    {
        /// <summary>
        /// 任务接受成功(任务状态)
        /// </summary>
        New,
        /// <summary>
        /// 正在执行（任务步骤）,(任务状态)
        /// </summary>
        Doing,
        /// <summary>
        /// 已完成(任务状态，任务步骤）
        /// </summary>
        Succeeded,
        /// <summary>
        /// 正在执行（任务步骤）,(任务状态)
        /// </summary>
        Cancelled,
        /// <summary>
        /// 超时等其他异常(任务状态)WCS异常
        /// </summary>
        Abnormal,
        /// <summary>
        /// 设备故障任务挂起(任务状态)
        /// </summary>
        Pending,
    }

    public enum ExecuteTaskTaskStatusEnum
    {
        /// <summary>
        /// 任务接受成功(任务状态)
        /// </summary>
        New,
        /// <summary>
        /// 正在执行（任务步骤）,(任务状态)
        /// </summary>
        Doing,
        /// <summary>
        /// 已完成(任务状态，任务步骤）
        /// </summary>
        Succeeded,
        /// <summary>
        /// 正在执行（任务步骤）,(任务状态)
        /// </summary>
        Cancelled,
        /// <summary>
        /// 超时等其他异常(任务状态)WCS异常
        /// </summary>
        Abnormal,
        /// <summary>
        /// 设备故障任务挂起(任务状态)
        /// </summary>
        Pending,
    }
}
