using System;
using System.Collections.Generic;
using System.Text;

namespace NesterCode.StreamPipeline
{
    public class Message
    {
        public IDictionary<string, string> Headers { get; set; }
        public IDictionary<string, string> Annotations { get; set; }
        public IEnumerable<string> Tags { get; set; }
        public byte[] Payload { get; set; }
    }
}
