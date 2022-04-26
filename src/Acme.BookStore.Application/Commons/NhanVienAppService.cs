using System;
using Acme.BookStore.Application.Contracts.Models.NhanVien;
using Acme.BookStore.Application.Contracts.Services;
using Acme.BookStore.Entities;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Application.Commons
{
    public class NhanVienAppService :
        CrudAppService<NhanVien,
        NhanVienResponse, Guid, PagedAndSortedResultRequestDto,
        NhanVienRequest, NhanVienRequest>,
        INhanVienAppService
    {
        public NhanVienAppService(IRepository<NhanVien, Guid> repository) : base(repository)
        {
            
        }
    }
}