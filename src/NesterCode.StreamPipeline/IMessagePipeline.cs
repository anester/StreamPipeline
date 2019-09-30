using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NesterCode.StreamPipeline
{
    public interface IMessagePipeline
    {
        Task StartAsync();
        void Stop();
    }
}
