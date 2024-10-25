using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preqin_Investor.Service.Models
{
    public class Commitment
    {
        public string Id { get; set; }
        public string AssetClass { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
