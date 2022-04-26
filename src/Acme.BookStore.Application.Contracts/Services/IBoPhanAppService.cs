using System;
using Acme.BookStore.Application.Contracts.Models.BoPhan;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Application.Contracts.Services
{
    public interface IBoPhanAppService : 
        ICrudAppService<
        BoPhanResponse,
        Guid,
        PagedAndSortedResultRequestDto,
        BoPhanRequest,
        BoPhanRequest
        >
    {
         
    }
}