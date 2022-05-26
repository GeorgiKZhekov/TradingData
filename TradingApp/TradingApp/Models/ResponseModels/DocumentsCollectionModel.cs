using Newtonsoft.Json;

namespace TradingApp.Models
{
    public class DocumentsCollectionModel
    {
        [JsonProperty("directory")]
        public Directory Directory { get; set; }
    }

    public class Directory
    {
        [JsonProperty("item")]
        public Item[] Items { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("parentdir")]
        public string ParentDir { get; set; }
    }

    public class Item
    {
        [JsonProperty("lastmodified")]
        public string LastModified { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("size")]
        public string Size { get; set; }
    }
}
