#r "Newtonsoft.Json"
#r "AzureFunctionsLibrary.dll"

using System;
using Newtonsoft.Json;
using AzureFunctionsLibrary;

public static void Run(string myQueueItem, TraceWriter log)
{
    log.Info($"C# Queue trigger function processed: {myQueueItem}");
    var message = (Message)JsonConvert.DeserializeObject(myQueueItem);
    log.Info($"Content: {message.Content}");
}
