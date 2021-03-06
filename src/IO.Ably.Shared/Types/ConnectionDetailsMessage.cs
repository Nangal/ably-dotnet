﻿using System;

namespace IO.Ably
{
    public class ConnectionDetails
    {
        public string clientId { get; set; }
        public string connectionKey { get; set; }
        public TimeSpan? connectionStateTtl { get; set; }
        public long maxFrameSize { get; set; }
        public long maxInboundRate { get; set; }
        public long maxMessageSize { get; set; }
        public string serverId { get; set; }
    }
}