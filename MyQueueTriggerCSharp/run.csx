#r "Newtonsoft.Json"
#r "AzureFunctionsLibrary1.dll"

using System;
using AzureFunctionsLibrary1;

public static void Run(string myQueueItem, TraceWriter log)
{
    log.Info($"C# Queue trigger function processed: {myQueueItem}");
    var message = (Message)SerializerJson.Deserialize(myQueueItem);
    log.Info($"Content: {message.Content}");
}
