using WhatsAppCloudApi.Response;

namespace WhatsAppCloudApi;

public class WhatsAppResponse
{
    [JsonProperty("messaging_product")]
    public string MessagingProduct { get; set; } = default!;

    [JsonProperty("contacts")]
    public List<WhatsAppContact> Contacts { get; set; } = default!;

    [JsonProperty("messages")]
    public List<WhatsAppResponseMessage> Messages { get; set; } = default!;

    [JsonProperty("error")]
    public WhatsAppError? Error { get; set; }
}
