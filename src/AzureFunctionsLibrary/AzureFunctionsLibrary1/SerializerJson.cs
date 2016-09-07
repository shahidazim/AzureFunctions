using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters;

namespace AzureFunctionsLibrary1
{
    public static class SerializerJson
    {
        private static readonly JsonSerializerSettings Settings;

        static SerializerJson()
        {
            Settings = new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.Objects,
                TypeNameAssemblyFormat = FormatterAssemblyStyle.Full
            };
        }

        public static string Serialize(object value)
        {
            return JsonConvert.SerializeObject(value, Settings);
        }

        public static T Deserialize<T>(string value)
        {
            return JsonConvert.DeserializeObject<T>(value, Settings);
        }
    }
}
