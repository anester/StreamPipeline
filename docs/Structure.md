# General Structure of The Streaming Pipeline

There is a Transport that communicates with the "queue". (e.g. Kafak).  That transport
is composed of Filters, Handlers, Responders and Exception handlers.

## Builders

* PipelineBuilder
  * AddTransport
* TransportBuilder
  * AddFilter
  * AddHandler
  * AddResponder
  * AddException

## Transport

The transport is responsible for polling the transport and pulling the message into the pipeline.
The Message class is this

```csharp
public interface IMessage {
  IDictionary<string, string> Headers { get; set; }
  byte[] Message { get; set; }
  IDictionary<string, string> Annotations { get; set; }
  IEnumerable<string> Tags{ get; set; }
}
```

```csharp
public interface ITransport {
  Task<bool> WaitAsync();
  Task<IMessage> NextAsync();
}
```
