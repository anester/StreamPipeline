using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NesterCode.StreamPipeline.Responder
{
    public interface IMessageResponder
    {
        Task<bool> Respond(Message message);
    }
}
