using System;

namespace ControleDeAgendamento.Domain.Entities
{
    public class Litigation
    {
        public int Id { get; set; }
        public string IdProcess { get; set; }
        public decimal ValueProcess { get; set; }
        public string State { get; set; }
        public DateTime Date { get; set; }
        public bool IsActive { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
