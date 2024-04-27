using LoanApi.Api.RequestModel;
using LoanApi.Service.Implementation;
using LoanApi.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoanApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private IBranchService _branchService;
        public BranchController(IBranchService branchService)
        {
            _branchService = branchService;
         }
        [HttpPost("CreateBranch")]
        public async Task<IActionResult> CreateBranchAsync(BranchRequestModal modal)
        {
            await _branchService.CreateBranchAsync(modal);
            return Ok();
        }

        [HttpGet("GetBranch")]
        public async Task<IActionResult> GetBranchAsync()
        {
           var branchList = await _branchService.GetBranchAsync();
            return Ok(branchList);
        }
    }
}
