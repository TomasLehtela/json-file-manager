using Newtonsoft.Json;

namespace JsonFileManager
{
    public class Manager
    {
        // JSON -> Dict
        public Dictionary<string, object> CreateDictFromJson(string json)
        {
            if (json == null)
            {
                throw new ArgumentNullException(nameof(json), "JSON string cannot be null.");
            }

            var dict = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);

            return dict;
        }

        // Dict -> JSON
        public string CreateJsonFromDict(Dictionary<string, object> dict)
        {
            if (dict == null || !dict.Any())
            {
                throw new ArgumentException("Dictionary cannot be null or empty.", nameof(dict));
            }

            string json = JsonConvert.SerializeObject(dict);

            return json;
        }

        // Read JSON


        // Write JSON

    }
}
