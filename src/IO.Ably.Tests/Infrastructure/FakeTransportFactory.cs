﻿using System.Threading.Tasks;
using IO.Ably.Transport;

namespace IO.Ably.Tests.Realtime
{
    public class FakeTransportFactory : ITransportFactory
    {
        public FakeTransport LastCreatedTransport { get; set; }

        public ITransport CreateTransport(TransportParams parameters)
        {
            LastCreatedTransport = new FakeTransport(parameters);
            return LastCreatedTransport;
        }
    }
}