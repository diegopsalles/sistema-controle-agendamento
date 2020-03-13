using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ControleDeAgendamento.ApplicationService.Contracts.Responses
{
    public class AddCompanyResponse : BaseResponse
    {
        public AddCompanyResponse(bool success, int id = 0, string error = "")
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
