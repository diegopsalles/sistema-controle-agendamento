using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Company
    {
        public int IdCompany { get; set; }
        public string Name { get; set; }
        public string Cnpj { get; set; }
        public string State { get; set; }

        public List<Litigation> Litigation { get; set; }


    }
}
