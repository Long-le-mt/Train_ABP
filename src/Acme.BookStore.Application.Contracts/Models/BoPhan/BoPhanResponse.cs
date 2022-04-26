using System;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Application.Contracts.Models.BoPhan
{
    public class BoPhanResponse: EntityDto<Guid>
    {
        public string Name { get; set; }
        public string GhiChu { get; set; }
    }
}