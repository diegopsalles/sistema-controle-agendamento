using System;
using System.Text.Json.Serialization;

namespace ControleDeAgendamento.ApplicationService.Contracts.Responses
{
    public class AddLitigationResponse : BaseResponse
    {
        public AddLitigationResponse(bool success, int id = 0, string error = "")
        {
            Id = id;
            Success = success;
            if (!success)
                SetError(error);
        }

        [JsonPropertyName("id")]
        public int Id { get; private set; }
    }
}
