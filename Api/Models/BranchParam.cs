namespace LoanApi.Api.Models
{
    public class BranchParam
    {
        public char Flag { get; set; }  
        public int BranchId { get; set; }
        public string BranchCode { get; set; } = string.Empty;
        public string BranchName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDate { get; set; }= DateTime.Now;
        public string? SystemDate { get; set; }
        public string? CreateTime { get; set; } 
    }
}
