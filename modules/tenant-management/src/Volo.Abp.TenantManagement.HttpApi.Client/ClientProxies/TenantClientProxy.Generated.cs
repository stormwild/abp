// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Modeling;
using Volo.Abp.TenantManagement;

// ReSharper disable once CheckNamespace
namespace Volo.Abp.TenantManagement.ClientProxies
{
    public partial class TenantClientProxy
    {
        public virtual async Task<TenantDto> GetAsync(Guid id)
        {
            return await RequestAsync<TenantDto>(nameof(GetAsync), id);
        }

        public virtual async Task<PagedResultDto<TenantDto>> GetListAsync(GetTenantsInput input)
        {
            return await RequestAsync<PagedResultDto<TenantDto>>(nameof(GetListAsync), input);
        }

        public virtual async Task<TenantDto> CreateAsync(TenantCreateDto input)
        {
            return await RequestAsync<TenantDto>(nameof(CreateAsync), input);
        }

        public virtual async Task<TenantDto> UpdateAsync(Guid id, TenantUpdateDto input)
        {
            return await RequestAsync<TenantDto>(nameof(UpdateAsync), id, input);
        }

        public virtual async Task DeleteAsync(Guid id)
        {
            await RequestAsync(nameof(DeleteAsync), id);
        }

        public virtual async Task<string> GetDefaultConnectionStringAsync(Guid id)
        {
            return await RequestAsync<string>(nameof(GetDefaultConnectionStringAsync), id);
        }

        public virtual async Task UpdateDefaultConnectionStringAsync(Guid id, string defaultConnectionString)
        {
            await RequestAsync(nameof(UpdateDefaultConnectionStringAsync), id, defaultConnectionString);
        }

        public virtual async Task DeleteDefaultConnectionStringAsync(Guid id)
        {
            await RequestAsync(nameof(DeleteDefaultConnectionStringAsync), id);
        }
    }
}