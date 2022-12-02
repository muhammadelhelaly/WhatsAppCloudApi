namespace WhatsAppCloudApi.Response;

public class WhatsAppResponseMessage
{
    [JsonProperty("id")]
    public string Id { get; set; } = default!;
}