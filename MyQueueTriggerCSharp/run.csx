#r "Newtonsoft.Json"
#r "AzureFunctionsLibrary1.dll"

using System;
using AzureFunctionsLibrary1;
using Newtonsoft.Json;
using System.IO;

public static void Run(string myQueueItem, TraceWriter log)
{
    log.Info($"C# Queue trigger function processed: {myQueueItem}");
    var message = JsonConvert.DeserializeObject<Message>(myQueueItem);
    var content = MessageProcessor.Process(message);
    log.Info($"Content: {content}");
    log.Info("Hello World!");
}
