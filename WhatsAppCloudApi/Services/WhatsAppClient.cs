using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using System.Text;

namespace WhatsAppCloudApi.Services;

public class WhatsAppClient : IWhatsAppClient
{
    private readonly WhatsAppConfigurations _configurations;

    public WhatsAppClient(IOptions<WhatsAppConfigurations> configurations)
    {
        _configurations = configurations.Value;
    }

    public async Task<WhatsAppResponse?> SendMessage(string mobile, string language, string template, List<WhatsAppComponent>? components = null)
    {

        using HttpClient httpClient = new ();
        httpClient.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", _configurations.AccessToken);

        WhatsAppMessage body = new()
        {
            To = mobile,
            Template = new WhatsAppTemplate
            {
                Name = template,
                Language = new WhatsAppLanguage { Code = language }
            }
        };

        if (components is not null)
            body.Template.Components = components;

        StringContent content = new (JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
        var response = await httpClient.PostAsync($"https://graph.facebook.com/v13.0/{_configurations.PhoneNumberId}/messages", content);

        var responseContent = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<WhatsAppResponse?>(responseContent);
    }
}