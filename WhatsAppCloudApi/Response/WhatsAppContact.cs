namespace WhatsAppCloudApi;

public class WhatsAppContact
{
    [JsonProperty("input")]
    public string Input { get; set; } = default!;

    [JsonProperty("wa_id")]
    public string WaId { get; set; } = default!;
}