﻿using System;
using System.Net;

namespace Quandl.Shared.Errors
{
    public class QuandlErrorBase : Exception
    {
        public QuandlErrorBase(HttpStatusCode statusCode, string errorCode = null, string message = null)
            : base(message)
        {
            ErrorCode = errorCode;
            StatusCode = statusCode;
        }

        public string ErrorCode { get; internal set; }
        public HttpStatusCode StatusCode { get; internal set; }
    }
}