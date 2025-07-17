using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshift.Helper
{
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }
        public object Tag { get; set; } // Added to store JobSummary or other data
        public override string ToString() => Text;
    }
}
