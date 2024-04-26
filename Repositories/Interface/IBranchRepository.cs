using LoanApi.Api.RequestModel;

namespace LoanApi.Repositories.Interface
{
    public interface IBranchRepository
    {
        Task CreateBranchAsync(BranchRequestModal branch);
    }
}
