using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NesterCode.StreamPipeline.Transport
{
    public abstract class MessageTransport : IMessageTransport
    {
        public MessageTransport()
        {

        }

        public Task<Message> NextAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> WaitAsync()
        {
            throw new NotImplementedException();
        }
    }
}
