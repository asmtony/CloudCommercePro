// https://app.quicktype.io/#l=cs&r=json2csharp

namespace CloudCommercePro.Data.JSONData
{
    using System.Globalization;
    using CloudCommercePro.Models.DataModels;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Contacts : DataContacts
    {
        [JsonProperty("name")]
        public new string Name { get; set; }

        [JsonProperty("address")]
        public new Address Address { get; set; }
    }
    public partial class Address : DataAddress
    {
        [JsonProperty("line1")]
        public new string Line1 { get; set; }

        [JsonProperty("line2")]
        public new string Line2 { get; set; }
    }

    public partial class Contacts
    {
        public static Contacts FromJson(string json) => 
            JsonConvert.DeserializeObject<Contacts>(json, CloudCommercePro.Data.JSONData.Converter.Settings);
    }
    public static class Serialize
    {
        public static string ToJson(this Contacts self) => 
            JsonConvert.SerializeObject(self, CloudCommercePro.Data.JSONData.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}

