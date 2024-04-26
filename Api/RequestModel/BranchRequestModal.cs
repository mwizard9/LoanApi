namespace LoanApi.Api.RequestModel;

    public class BranchRequestModal { 
        public string BranchCode { get; set; } = string.Empty;
        public string BranchName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDate { get; set; }
    
        public int? CreatedTime { get; set; }
    }

