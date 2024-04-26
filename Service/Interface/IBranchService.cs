using LoanApi.Api.RequestModel;

namespace LoanApi.Service.Interface
{
    public interface IBranchService
    {
        Task CreateBranchAsync(BranchRequestModal branch);
    }
}
