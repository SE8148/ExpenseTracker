using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTrackerData.Models
{
    public class OutgoingExpense
    {
        public string OutgoingRecipient { get; set; }
        public decimal OutgoingAmount { get; set; }
        public string OutgoingDescription { get; set; }
        public DateOnly ExpenseDate { get; set; }
    }
}
