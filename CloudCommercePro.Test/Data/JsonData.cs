
namespace CloudCommercePro.Test.Data
{
    internal class JsonData
    {
        internal static string JsonDataContacts()
        {
            string jsonData = "{  " +
                "\"name\": \"Dave\", " +
                " \"address\": { " +
                " \"line1\": \"Street\", " +
                " \"line2\":  \"Town \" " +
                "}" +
                "  } ";

            return jsonData;
        }

        internal static string JsonDataContactsShort()
        {
            string jsonData = "{  " +
                "\"name\": \"Dave\", " +
                "  } ";

            return jsonData;
        }
    }
}
