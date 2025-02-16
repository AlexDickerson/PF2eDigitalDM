using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;

namespace Library.Models
{
    public class ConditionsJSON
    {
        [JsonPropertyName("conditions")]
        public required List<Condition> Conditions { get; set; }
    }

    public class Condition
    {
        [JsonPropertyName("name")]
        public required string Name { get; set; }
        [JsonPropertyName("value")]
        public required string Description { get; set; }
    }
}
