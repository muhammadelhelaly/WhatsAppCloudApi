namespace WhatsAppCloudApi;

public class WhatsAppError
{
    [JsonProperty("message")]
    public string Message { get; set; } = default!;

    [JsonProperty("type")]
    public string Type { get; set; } = default!;

    [JsonProperty("code")]
    public int Code { get; set; } = default!;

    [JsonProperty("error_data")]
    public WhatsAppErrorData? ErrorData { get; set; }

    [JsonProperty("error_subcode")]
    public int ErrorSubcode { get; set; } = default!;

    [JsonProperty("fbtrace_id")]
    public string FbtraceId { get; set; } = default!;
}