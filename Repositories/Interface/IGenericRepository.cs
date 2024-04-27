﻿
using LoanApi.Api.ResponseModel;
using System.Data;

namespace LoanApi.Repositories.Interface
{
    public interface IGenericRepository
    {
        Task<List<T>> GetAllAsync<T>(string spName, object obj, CommandType queryType = CommandType.StoredProcedure);
        Task<T> GetAsync<T>(string spName, object obj, CommandType queryType = CommandType.StoredProcedure);
        Task<List<object>> GetFromMultipleQuery<T0, T1>(string sqlQuery, object sqlParam, CommandType queryType = CommandType.StoredProcedure);
        Task<List<object>> GetFromMultipleQuery<T0, T1, T2>(string sqlQuery, object sqlParam, CommandType queryType = CommandType.StoredProcedure);
        Task<List<object>> GetFromMultipleQuery<T0, T1, T2, T3>(string sqlQuery, object sqlParam, CommandType queryType = CommandType.StoredProcedure);
        Task<SystemResponse> UpdateAsync(string spName, object input, CommandType queryType = CommandType.StoredProcedure);
        Task<SystemResponse> InsertAsync(string spName, object input, CommandType queryType = CommandType.StoredProcedure);
        Task<SystemResponse> DeleteAsync(string spName, object input, CommandType queryType = CommandType.StoredProcedure);
    }
}
