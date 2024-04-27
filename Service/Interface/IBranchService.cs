using LoanApi.Api.RequestModel;
using LoanApi.Api.ResponseModel;

namespace LoanApi.Service.Interface
{
    public interface IBranchService
    {
        Task CreateBranchAsync(BranchRequestModal branch);
        Task<List<BranchResponseModal>> GetBranchAsync();
    }
}
