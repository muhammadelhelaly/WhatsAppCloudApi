namespace WhatsAppCloudApi;

public class WhatsAppCurrency
{
    [JsonProperty("fallback_value")]
    public string FallbackValue { get; set; } = default!;

    [JsonProperty("code")]
    public string Code { get; set; } = default!;

    [JsonProperty("amount_1000")]
    public string Amount { get; set; } = default!;
}