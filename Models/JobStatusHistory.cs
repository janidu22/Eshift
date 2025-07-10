using System;

namespace Eshift.Models
{
    public class JobStatusHistory
    {
        public int HistoryId { get; set; }
        public int JobId { get; set; }
        public string? Status { get; set; }
        public int? ChangedByAdminId { get; set; }
        public DateTime ChangedAt { get; set; }
        public string? Notes { get; set; }
    }
} 