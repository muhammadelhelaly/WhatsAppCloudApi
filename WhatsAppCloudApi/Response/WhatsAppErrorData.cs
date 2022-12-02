namespace WhatsAppCloudApi;

public class WhatsAppErrorData
{
    [JsonProperty("messaging_product")]
    public string MessagingProduct { get; set; } = default!;

    [JsonProperty("details")]
    public string Details { get; set; } = default!;
}