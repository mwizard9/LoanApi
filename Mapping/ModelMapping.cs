using AutoMapper;
using LoanApi.Api.Models;
using LoanApi.Api.RequestModel;

namespace LoanApi.Mapping
{
    public class ModelMapping:Profile
    {
        public ModelMapping()
        {
            CreateMap<BranchModel,BranchRequestModal>().ReverseMap();
            CreateMap<BranchParam, BranchRequestModal>().ReverseMap();
        }
    }
}
