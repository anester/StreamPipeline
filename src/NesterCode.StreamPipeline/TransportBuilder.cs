using System;
using System.Collections.Generic;
using System.Text;

namespace NesterCode.StreamPipeline
{
    public class TransportBuilder
    {
        private IMessageTransport _transport;

        public TransportBuilder(IMessageTransport transport)
        {
            _transport = transport;
        }

        public TransportBuilder AddResponder()
        {
            return this;
        }

        public TransportBuilder AddHandler()
        {
            return this;
        }

        public TransportBuilder AddException()
        {
            return this;
        }
    }
}
