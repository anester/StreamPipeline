using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NesterCode.StreamPipeline.Filter;
using NesterCode.StreamPipeline.Transport;
using NesterCode.StreamPipeline.Handler;
using NesterCode.StreamPipeline.Responder;

namespace NesterCode.StreamPipeline
{
    internal class MessagePipeline : IMessagePipeline
    {
        public IEnumerable<IMessageFilter> Filters { get; internal set; }
        public IMessageTransport Transport { get; internal set; }
        public IEnumerable<IMessageHandler> Handlers { get; internal set; }
        public IEnumerable<IMessageResponder> Responders { get; internal set; }

        public MessagePipeline(
            IEnumerable<IMessageFilter> filters,
            IMessageTransport transport,
            IEnumerable<IMessageHandler> handlers,
            IEnumerable<IMessageResponder> responders)
        {
            Filters = filters;
            Transport = transport;
            Handlers = handlers;
            Responders = responders;
        }

        public async Task StartAsync()
        {
            while (await Transport.WaitAsync())
            {
                try
                {
                    var msg = await Transport.NextAsync();
                    bool notCanceled = true;
                    foreach (var fltr in Filters)
                    {
                        notCanceled = notCanceled && (await fltr.FilterAsync(msg));
                    }

                    if (notCanceled)
                    {
                        foreach (var handler in Handlers)
                        {
                            await handler.HandleAsync(msg);
                        }

                        foreach (var responder in Responders)
                        {
                            await responder.Respond(msg);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
