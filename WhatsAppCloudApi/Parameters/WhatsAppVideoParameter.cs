namespace WhatsAppCloudApi;

public class WhatsAppVideoParameter
{

    [JsonProperty("type")]
    public string Type { get; set; } = "video";

    [JsonProperty("video")]
    public WhatsAppMediaParameter Video { get; set; } = default!;
}