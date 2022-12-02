using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using WhatsAppCloudApi.Services;

namespace WhatsAppCloudApi.Extensions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddWhatsAppApiClient(this IServiceCollection services, ConfigurationManager configuration)
    {
        var whatsAppConfigurations = new WhatsAppConfigurations();

        configuration.Bind(nameof(WhatsAppConfigurations), whatsAppConfigurations);

        services.AddSingleton(Options.Create(whatsAppConfigurations));

        services.AddTransient<IWhatsAppClient, WhatsAppClient>();

        return services;
    }
}