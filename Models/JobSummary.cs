using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshift.Models
{
    public class JobSummary
    {
        public int JobId { get; set; }
        public string StartLocation { get; set; }
        public string Destination { get; set; }
        public DateTime RequestedDate { get; set; }
        public string RequestedProducts { get; set; }
        public decimal RequestedWeight { get; set; }
        public int  RequestedQuantity { get; set; }
        public string RequestedNotes { get; set; }

    }

    public class ComboBoxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }
        public object Tag { get; set; } // Added to store JobSummary or other data
        public override string ToString() => Text;
    }
}
