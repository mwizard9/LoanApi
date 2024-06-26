﻿namespace LoanApi.Api.Models
{
    public class BranchModel
    {
        public int BranchId { get; set; }
        public string BranchCode { get; set; } = string.Empty;
        public string BranchName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDate { get; set; } = new DateTime();
        public DateOnly SystemDate { get; set; } = new DateOnly();
        public TimeOnly CreatedTime { get; set; } = new TimeOnly();
        
    }
}
