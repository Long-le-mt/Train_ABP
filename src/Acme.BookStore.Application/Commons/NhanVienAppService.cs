using System;
using Acme.BookStore.Models.NhanVien;
using Acme.BookStore.Services;
using Acme.BookStore.Entities;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Commons
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