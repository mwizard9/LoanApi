using LoanApi.Api.RequestModel;
using LoanApi.Repositories.Interface;
using LoanApi.Service.Interface;

namespace LoanApi.Service.Implementation
{
    public class BranchService : IBranchService
    {
        private IBranchRepository _repository;
        public BranchService(IBranchRepository branchRepository)
        {
            _repository = branchRepository;
        }
        public Task CreateBranchAsync(BranchRequestModal branch)
        {
            return _repository.CreateBranchAsync(branch);
        }
    }
}
