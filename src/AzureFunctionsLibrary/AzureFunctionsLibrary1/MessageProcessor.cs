namespace AzureFunctionsLibrary1
{
    public static class MessageProcessor
    {
        public static string Process(Message message)
        {
            return message.Content;
        }
    }
}
