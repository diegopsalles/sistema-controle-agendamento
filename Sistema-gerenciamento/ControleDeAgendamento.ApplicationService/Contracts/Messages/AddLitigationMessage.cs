using ControleDeAgendamento.Domain.Entities;
using System;
using System.Text.Json.Serialization;

namespace ControleDeAgendamento.ApplicationService.Contracts.Messages
{
    public class AddLitigationMessage
    {
        [JsonPropertyName("idProcess")]
        public string IdProcess { get; set; }

        [JsonPropertyName("valueProcess")]
        public float ValueProcess { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("dateProcess")]
        public DateTime DateProcess { get; set; }
        
        [JsonPropertyName("isActive")]
        public bool IsActive { get; set; }
        
        [JsonPropertyName("companysId")]
        public int CompanyId { get; set; }
    }
}
