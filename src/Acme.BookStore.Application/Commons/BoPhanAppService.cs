using System;
using Acme.BookStore.Entities;
using Acme.BookStore.Models.BoPhan;
using Acme.BookStore.Services;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Commons
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