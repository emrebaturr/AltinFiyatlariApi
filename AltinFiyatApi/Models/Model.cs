using System.Text.Json.Serialization;

namespace AltinFiyatApi.Models
{
    public class Currency
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Buying")]
        public string Buying { get; set; }

        [JsonPropertyName("Type")]
        public string Type { get; set; }

        [JsonPropertyName("Selling")]
        public string Selling { get; set; }

        [JsonPropertyName("Change")]
        public string Change { get; set; }
    }

    public class ExchangeResponse
    {
        [JsonPropertyName("Update_Date")]
        public string UpdateDate { get; set; }

        [JsonPropertyName("ONS")]
        public Currency ONS { get; set; }

        [JsonPropertyName("GRA")]
        public Currency GRA { get; set; }

        [JsonPropertyName("HAS")]
        public Currency HAS { get; set; }

        [JsonPropertyName("CEY")]
        public Currency CEY { get; set; }

        [JsonPropertyName("YAR")]
        public Currency YAR { get; set; }

        [JsonPropertyName("TAM")]
        public Currency TAM { get; set; }

        [JsonPropertyName("CUM")]
        public Currency CUM { get; set; }

        [JsonPropertyName("ATA")]
        public Currency ATA { get; set; }

        [JsonPropertyName("YIA")]
        public Currency YIA { get; set; }

        [JsonPropertyName("RES")]
        public Currency RES { get; set; }

        [JsonPropertyName("HAM")]
        public Currency HAM { get; set; }
    }
}