namespace WhatsAppCloudApi;

public class WhatsAppButtonParameter
{

    [JsonProperty("type")]
    public string Type { get; set; } = "payload";

    [JsonProperty("payload")]
    public string Payload { get; set; } = default!;
}