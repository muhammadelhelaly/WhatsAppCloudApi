namespace WhatsAppCloudApi;

public class WhatsAppCurrencyParameter
{
    [JsonProperty("type")]
    public string Type { get; set; } = "currency";

    [JsonProperty("currency")]
    public WhatsAppCurrency Currency { get; set; } = default!;
}