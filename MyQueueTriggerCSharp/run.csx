#r "Newtonsoft.Json"
#r "AzureFunctionsLibrary1.dll"

using System;
using AzureFunctionsLibrary1;
using Newtonsoft.Json;

public static void Run(string myQueueItem, TraceWriter log)
{
    log.Info($"C# Queue trigger function processed: {myQueueItem}");
    var message = JsonConvert.DeserializeObject<Message>(myQueueItem);
    log.Info($"Content: {MessageProcessor.Process(message)}");
}
