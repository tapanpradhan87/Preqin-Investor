using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preqin_Investor.Service.Models
{
    public class Investor
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Address { get; set; }
        public decimal TotalCommitment { get; set; }
        public string Currency { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<Commitment> Commitments { get; set; }
    }
}
