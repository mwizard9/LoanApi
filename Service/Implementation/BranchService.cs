using AutoMapper;
using LoanApi.Api.Models;
using LoanApi.Api.RequestModel;
using LoanApi.Api.ResponseModel;
using LoanApi.Repositories.Interface;
using LoanApi.Service.Interface;

namespace LoanApi.Service.Implementation
{
    public class BranchService : IBranchService
    {
        private IBranchRepository _repository;
        private IMapper _automapper;
        private IGenericRepository _genericRepository;
        public BranchService(IBranchRepository branchRepository,IMapper mapper,IGenericRepository genericRepository)
        {
            _repository = branchRepository;
            _automapper = mapper;
            _genericRepository = genericRepository;

        }
        public Task CreateBranchAsync(BranchRequestModal branch)
        {
          
            var BranchMappingModal = _automapper.Map<BranchParam>(branch);
            BranchMappingModal.Flag = 'c';
            var response = _genericRepository.InsertAsync("spbranch", BranchMappingModal);
            return response;
            //return _repository.CreateBranchAsync(BranchMappingModal);
        }

        public async Task<List<BranchResponseModal>> GetBranchAsync()
        {
            BranchParam branchParam = new()
            {
                Flag = 's'
            };
            var BranchList = await _genericRepository.GetAllAsync<BranchResponseModal>("spbranch", branchParam);
            return BranchList;
            //return _repository.GetBranchAsync();
        }
    }
}
