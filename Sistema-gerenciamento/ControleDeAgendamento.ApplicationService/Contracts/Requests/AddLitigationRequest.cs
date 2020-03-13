using ControleDeAgendamento.ApplicationService.Contracts.Messages;
using System.Text.Json.Serialization;

namespace ControleDeAgendamento.ApplicationService.Contracts.Requests
{
    public class AddLitigationRequest
    {
        [JsonPropertyName("litigationMessage")]
        public AddLitigationMessage LitigationMessage { get; set; }
    }
}
