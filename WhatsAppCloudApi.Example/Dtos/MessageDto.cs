namespace WhatsAppCloudApi.Example.Dtos;

public record MessageDto(string To, string LanguageCode, string Template, List<WhatsAppComponent>? Components = null);