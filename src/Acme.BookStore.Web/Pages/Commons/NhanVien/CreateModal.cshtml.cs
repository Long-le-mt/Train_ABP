using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Acme.BookStore.Models.NhanVien;
using Acme.BookStore.Services;
using Acme.BookStore.Web.Pages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace Core.Web.Pages.Commons.NhanVien
{
    public class CreateModalModel : BookStorePageModel
    {
        [BindProperty]
        public NhanVienModel ViewModel { get; set; }

        public List<SelectListItem> BoPhanList { get; set; }

        private readonly INhanVienAppService _service;

        private readonly IBoPhanAppService _boPhanService;

        public CreateModalModel(INhanVienAppService service, IBoPhanAppService boPhanService)
        {
            _service = service;
            _boPhanService = boPhanService;
        }

        public virtual async Task OnGetAsync()
        {
            var boPhanList = await _boPhanService.GetListAsync(new PagedAndSortedResultRequestDto { MaxResultCount=1000});
            BoPhanList = new List<SelectListItem>();
            BoPhanList.Add(new SelectListItem
            {
                Value = "",
                Text = "Chọn bộ phận",
                Selected = true
            });
            foreach (var item in boPhanList.Items)
            {
                BoPhanList.Add(new SelectListItem
                {
                    Value = item.Id.ToString(),
                    Text = item.Name.ToString()
                });
            }
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            await _service.CreateAsync(ViewModel);
            return NoContent();
        }

        public class NhanVienModel : NhanVienRequest
        {
            [SelectItems(nameof(BoPhanList))]
            [Display(Name = "BoPhan")]
            public override Guid BoPhanId { get; set; }
        }
    }
}