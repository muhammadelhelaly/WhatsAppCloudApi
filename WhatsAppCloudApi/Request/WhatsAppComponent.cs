namespace WhatsAppCloudApi;

public class WhatsAppComponent
{
    [JsonProperty("type")]
    public string Type { get; set; } = default!;

    [JsonProperty("sub_type", NullValueHandling = NullValueHandling.Ignore)]
    public string SubType { get; set; } = default!;

    [JsonProperty("index", NullValueHandling = NullValueHandling.Ignore)]
    public string Index { get; set; } = default!;

    [JsonProperty("parameters")]
    public List<object> Parameters { get; set; } = new ();
}