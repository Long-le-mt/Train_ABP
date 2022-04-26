using System;
using Acme.BookStore.Application.Contracts.Models.NhanVien;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Application.Contracts.Services
{
    public interface INhanVienAppService : 
        ICrudAppService<
        NhanVienResponse,
        Guid,
        PagedAndSortedResultRequestDto,
        NhanVienRequest,
        NhanVienRequest
        >
    {
    }
}