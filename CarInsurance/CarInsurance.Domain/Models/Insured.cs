using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance.Domain.Models
{
    public class Insured
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public int Age { get; set; }

    }
}
