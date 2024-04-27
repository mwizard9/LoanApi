using LoanApi.Api.Models;
using LoanApi.Api.RequestModel;
using LoanApi.Api.ResponseModel;

namespace LoanApi.Repositories.Interface
{
    public interface IBranchRepository
    {
        Task CreateBranchAsync(BranchModel branch);
        Task<List<BranchResponseModal>> GetBranchAsync();
    }
}
