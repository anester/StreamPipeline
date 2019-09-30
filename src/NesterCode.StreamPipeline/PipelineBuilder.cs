using System;
using System.Collections.Generic;
using System.Text;

namespace NesterCode.StreamPipeline
{
    public class PipelineBuilder
    {
        IMessageTransport _transport = null;
        public TransportBuilder AddTransport(IMessageTransport transport)
        {
            _transport = transport;
            return new TransportBuilder(_transport);
        }
    }
}
