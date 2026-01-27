using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Entities
{
    public class Payment
    {
        public int PaymentID {  get; set; }
        public int ContractID {  get; set; }
        public decimal Amount {  get; set; }
        public DateTime PaymentDate {  get; set; }

    }
}
