namespace WhatsAppCloudApi;

public class WhatsAppDateTimeParameter
{
    [JsonProperty("type")]
    public string Type { get; set; } = "date_time";

    [JsonProperty("date_time")]
    public WhatsAppDateTime DateTime { get; set; } = default!;
}