using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NesterCode.StreamPipeline.Filter
{
    public interface IMessageFilter
    {
        Task<bool> FilterAsync(Message message);
    }
}
