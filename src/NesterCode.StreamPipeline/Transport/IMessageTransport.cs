using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NesterCode.StreamPipeline.Transport
{
    public interface IMessageTransport
    {
        Task<bool> WaitAsync();
        Task<Message> NextAsync();
    }
}
