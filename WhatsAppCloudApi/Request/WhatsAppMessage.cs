namespace WhatsAppCloudApi;

public class WhatsAppMessage
{
    [JsonProperty("messaging_product")]
    public string MessagingProduct { get; set; } = "whatsapp";

    [JsonProperty("recipient_type")]
    public string RecipientType { get; set; } = "individual";

    [JsonProperty("to")]
    public string To { get; set; } = default!;

    [JsonProperty("type")]
    public string Type { get; set; } = "template";

    [JsonProperty("template")]
    public WhatsAppTemplate Template { get; set; } = default!;
}
