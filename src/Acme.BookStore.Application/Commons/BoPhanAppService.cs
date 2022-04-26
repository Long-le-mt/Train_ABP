using System;
using Acme.BookStore.Application.Contracts.Models.BoPhan;
using Acme.BookStore.Application.Contracts.Services;
using Acme.BookStore.Entities;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Application.Commons
{
    public class BoPhanAppService :
        CrudAppService<BoPhan,
        BoPhanResponse, Guid, PagedAndSortedResultRequestDto,
        BoPhanRequest, BoPhanRequest>,
        IBoPhanAppService
    {
        public BoPhanAppService(IRepository<BoPhan, Guid> repository) : base(repository)
        {
            
        }
    }
}