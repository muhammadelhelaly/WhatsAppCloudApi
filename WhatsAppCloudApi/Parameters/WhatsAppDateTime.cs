namespace WhatsAppCloudApi;

public class WhatsAppDateTime
{
    [JsonProperty("fallback_value")]
    public string FallbackValue { get; set; } = default!;
}