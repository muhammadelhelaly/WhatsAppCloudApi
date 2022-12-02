namespace WhatsAppCloudApi.Services;

public interface IWhatsAppClient
{
    Task<WhatsAppResponse?> SendMessage(string mobile, string language, string template, List<WhatsAppComponent>? components = null);
}