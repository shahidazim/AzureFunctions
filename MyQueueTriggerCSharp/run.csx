#r "Newtonsoft.Json"
#r "AzureFunctionsLibrary1.dll"

using System;
using AzureFunctionsLibrary1;
using Newtonsoft.Json;

public static void Run(string myQueueItem, TraceWriter log)
{
    log.Info($"C# Queue trigger function processed: {myQueueItem}");
    //var message = SerializerJson.Deserialize<Message>(myQueueItem);
    var message = JsonConvert.DeserializeObject<T>(value, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
    log.Info($"Content: {message.Content}");
}
