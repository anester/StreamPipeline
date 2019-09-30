using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NesterCode.StreamPipeline.Handler
{
    public interface IMessageHandler
    {
        Task<Message> HandleAsync(Message message);
    }
}
