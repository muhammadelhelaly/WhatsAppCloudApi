using Microsoft.AspNetCore.Mvc;
using WhatsAppCloudApi.Example.Dtos;
using WhatsAppCloudApi.Services;

namespace WhatsAppCloudApi.Example.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessagesController : ControllerBase
    {
        private readonly IWhatsAppClient _whatsAppClient;

        public MessagesController(IWhatsAppClient whatsAppClient)
        {
            _whatsAppClient = whatsAppClient;
        }

        [HttpPost("sendMessage")]
        public async Task<IActionResult> SendMessage(MessageDto dto)
        {
            var result = await _whatsAppClient.SendMessage(dto.To, dto.LanguageCode, dto.Template);

            return result?.Error is null ? Ok(result) : BadRequest(result.Error);
        }

        [HttpPost("sendMessageWithTextParams")]
        public async Task<IActionResult> SendMessageWithTextParams(MessageDto dto)
        {
            /*
                {
                  "to": "",
                  "languageCode": "en_US",
                  "template": "",
                  "components": [
                    {
                      "type": "body",
                      "parameters": [
                        "value1",
                        "value2"
                      ]
                    }
                  ]
                }
             */

            List<WhatsAppComponent> body = new();

            foreach (var component in dto.Components!)
            {
                WhatsAppComponent bodyComponent = new() { Type = component.Type };

                foreach (var param in component.Parameters)
                    bodyComponent.Parameters.Add(new WhatsAppTextParameter { Text = param?.ToString()! });

                body.Add(bodyComponent);
            }

            var result = await _whatsAppClient.SendMessage(dto.To, dto.LanguageCode, dto.Template, body);

            return result?.Error is null ? Ok(result) : BadRequest(result.Error);
        }

        //Send Image,Video or Document
        [HttpPost("sendMessageWithMedia")]
        public async Task<IActionResult> SendMessageWithMedia(MessageDto dto)
        {
            /*
                {
                  "to": "",
                  "languageCode": "en_US",
                  "template": "",
                  "components": [
                    {
                      "type": "body",
                      "parameters": [
                        "value1",
                        "value2"
                      ]
                    }
                  ]
                }
             */

            List<WhatsAppComponent> body = new();

            foreach (var component in dto.Components!)
            {
                WhatsAppComponent bodyComponent = new() { Type = component.Type };

                foreach (var param in component.Parameters)
                    bodyComponent.Parameters.Add(new WhatsAppVideoParameter { Video = new WhatsAppMediaParameter { Link = param.ToString()! } });

                //You can use also WhatsAppImageParameter, WhatsAppDocumentParameter

                body.Add(bodyComponent);
            }

            var result = await _whatsAppClient.SendMessage(dto.To, dto.LanguageCode, dto.Template, body);

            return result?.Error is null ? Ok(result) : BadRequest(result.Error);
        }
    }
}