namespace WhatsAppCloudApi;

public class WhatsAppTemplate
{
    [JsonProperty("name")]
    public string Name { get; set; } = default!;

    [JsonProperty("language")]
    public WhatsAppLanguage Language { get; set; } = default!;

    [JsonProperty("components", NullValueHandling = NullValueHandling.Ignore)]
    public List<WhatsAppComponent> Components { get; set; } = default!;
}