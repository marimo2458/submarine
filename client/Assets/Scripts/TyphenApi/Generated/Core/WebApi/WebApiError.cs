﻿// This file was generated by typhen-api

using System;
using System.Collections.Generic;

namespace TyphenApi
{
    public class WebApiError<T> : SystemException where T : class, IType, new()
    {
        public Dictionary<string, string> Headers { get; private set; }

        public T Error { get; private set; }
        public byte[] RawError { get; private set; }
        public string RawErrorMessage { get; private set; }

        public WebApiError(Dictionary<string, string> headers, T error,
            byte[] rawError, string rawErrorMessage) : base(rawErrorMessage)
        {
            Headers = headers;
            Error = error;
            RawError = rawError;
            RawErrorMessage = rawErrorMessage;
        }

        public override string ToString()
        {
            return string.Format("[WebApiError: RawErrorMessage={0}, Error={1}]", RawErrorMessage, Error);
        }
    }
}
