﻿namespace Nancy.Diagnostics
{
    using System;
    using System.Collections.Generic;

    public class RequestTrace
    {
        public string Method { get; set; }

        public Url RequestUrl { get; set; }

        public TraceLog TraceLog { get; private set; }

        public IDictionary<string, object> Items { get; private set; }

        public Type ResponseType { get; set; }

        public HttpStatusCode StatusCode { get; set; }

        public string ContentType { get; set; }

        public RequestTrace()
        {
            this.TraceLog = new TraceLog();
            this.Items = new Dictionary<string, object>();
        }
    }
}