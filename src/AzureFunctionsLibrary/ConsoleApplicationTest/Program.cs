using AzureFunctionsLibrary1;

namespace ConsoleApplicationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = new Message
            {
                Content = "Hello World!"
            };
            var serializedMessage = SerializerJson.Serialize(message);
            var deserializedMessage = SerializerJson.Deserialize(serializedMessage);
        }
    }
}
