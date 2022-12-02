namespace WhatsAppCloudApi;

public class WhatsAppTextParameter
{
    [JsonProperty("type")]
    public string Type { get; set; } = "text";

    [JsonProperty("text")]
    public string Text { get; set; } = default!;
}