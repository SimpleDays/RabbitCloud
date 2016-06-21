﻿using System;

namespace Rabbit.Rpc.Exceptions
{
    /// <summary>
    /// 一个基础的Rpc异常类。
    /// </summary>
    public class RpcException : Exception
    {
        /// <summary>
        /// 初始化一个新的Rpc异常实例。
        /// </summary>
        /// <param name="message">异常消息。</param>
        public RpcException(string message) : base(message)
        {
        }
    }
}