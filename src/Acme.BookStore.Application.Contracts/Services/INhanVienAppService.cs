using Acme.BookStore.Models.NhanVien;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Services
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