using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Entities
{
    public class Contract
    {
        public int ContractID {  get; set; }
        public int PropertyID {  get; set; }
        public int ClientID {  get; set; }
        public String ContractType {  get; set; }
        public DateTime StartDate {  get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalAmount {  get; set; }
         public string Status { get; set; }
    }
}
