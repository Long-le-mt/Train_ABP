using Acme.BookStore.Application.Contracts.Models.BoPhan;
using Acme.BookStore.Application.Contracts.Models.NhanVien;
using Acme.BookStore.Entities;
using AutoMapper;

namespace Acme.BookStore
{
    public class BookStoreApplicationAutoMapperProfile : Profile
    {
        public BookStoreApplicationAutoMapperProfile()
        {
            //nhân viên
            CreateMap<NhanVien, NhanVienResponse>();
            CreateMap<NhanVienRequest, NhanVien>();
            CreateMap<NhanVienResponse, NhanVienRequest>();

            //bộ phận
            CreateMap<BoPhan, BoPhanResponse>();
            CreateMap<BoPhanRequest, BoPhan>();
            CreateMap<BoPhanResponse, BoPhanRequest>();
        }
    }
}
