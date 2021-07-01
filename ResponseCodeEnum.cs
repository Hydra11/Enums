using System;
using System.Collections.Generic;
using System.Text;

namespace Ivalon.WMS.Model.InterFaceModel.Enums
{
    /// <summary>
    /// 返回消息代码
    /// </summary>
    public enum ResponseCodeEnum
    {
        /// <summary>
        /// 接收成功
        /// </summary>
        succeed = 0,
        /// <summary>
        /// 输入错误
        /// </summary>
        InputError = 1,
        /// <summary>
        /// 目标事物不存在
        /// </summary>
        ThingNotFound = 2,
        /// <summary>
        /// 目标事物不唯一
        /// </summary>
        ThingMustUnique = 3,
        /// <summary>
        /// 设备操作失败
        /// </summary>
        DeviceOperationFailed = 4,
        /// <summary>
        /// 目标事物已经存在
        /// </summary>
        ThingAlreadyExist = 5,
        /// <summary>
        /// 功能不支持
        /// </summary>
        NotSupported = 6,
        /// <summary>
        /// 内部配置错误
        /// </summary>
        InternalConfigError = 998,
        /// <summary>
        /// 异常错误
        /// </summary>
        InternalException = 999,
    }
}
