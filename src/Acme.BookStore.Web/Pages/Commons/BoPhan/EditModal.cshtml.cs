using System;
using System.Threading.Tasks;
using Acme.BookStore.Models.BoPhan;
using Acme.BookStore.Services;
using Acme.BookStore.Web.Pages;
using Microsoft.AspNetCore.Mvc;

namespace Core.Web.Pages.Commons.BoPhan
{
    public class EditModalModel : BookStorePageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public BoPhanRequest ViewModel { get; set; }

        private readonly IBoPhanAppService _service;

        public EditModalModel(IBoPhanAppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var response = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<BoPhanResponse, BoPhanRequest>(response);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            await _service.UpdateAsync(Id, ViewModel);
            return NoContent();
        }
    }
}