using LoanApi.Api.Models;
using LoanApi.Api.RequestModel;
using LoanApi.Api.ResponseModel;
using LoanApi.Repositories.Interface;
using System.Net.NetworkInformation;

namespace LoanApi.Repositories.Implementation
{
    public class BranchRepository : DapperService, IBranchRepository
    {
        private IConfiguration _configuration;
        public BranchRepository(IConfiguration configuration) : base(configuration)
        {
            _configuration = configuration;
        }

        public async Task CreateBranchAsync(BranchModel branch)
        {
            var result = await this.ExecuteAsync("insert into tblBranch(BranchCode,BranchName,Address,PhoneNo,status,CreatedDate)" + "values(@BranchCode,@BranchName,@Address,@PhoneNo,@status,@CreatedDate)",
            new
            {
                BranchCode = branch.BranchCode,
                BranchName = branch.BranchName,
                Address = branch.Address,
                PhoneNo = branch.PhoneNumber,
                status = branch.Status,
                CreatedDate = branch.CreatedDate

            }
                );
        }

        public async Task<List<BranchResponseModal>> GetBranchAsync()
        {
            var BranchList = await this.GetQueryResultAsync<BranchResponseModal>(
                "select * from tblBranch"
                );
            return BranchList;
        }
    }
}
