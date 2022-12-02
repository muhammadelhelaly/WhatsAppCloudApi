namespace WhatsAppCloudApi;

public class WhatsAppDocumentParameter
{

    [JsonProperty("type")]
    public string Type { get; set; } = "document";

    [JsonProperty("document")]
    public WhatsAppMediaParameter Document { get; set; } = default!;
}