namespace WhatsAppCloudApi;

public class WhatsAppImageParameter
{

    [JsonProperty("type")]
    public string Type { get; set; } = "image";

    [JsonProperty("image")]
    public WhatsAppMediaParameter Image { get; set; } = default!;
}