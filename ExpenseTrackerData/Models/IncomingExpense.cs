using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTrackerData.Models
{
    public class IncomingExpense
    {
        public string CustomerName { get; set; }
        public int TransactionID { get; set; }
        public decimal IncomingAmount { get; set; }
        public DateOnly IncomingDate { get; set; }
        public string IncomingDescription { get; set; }
    }
}
