using System.Threading.Tasks;
using Acme.BookStore.Models.BoPhan;
using Acme.BookStore.Services;
using Acme.BookStore.Web.Pages;
using Microsoft.AspNetCore.Mvc;

namespace Core.Web.Pages.Commons.BoPhan
{
    public class CreateModalModel : BookStorePageModel
    {
        [BindProperty]
        public BoPhanRequest ViewModel { get; set; }

        private readonly IBoPhanAppService _service;

        public CreateModalModel(IBoPhanAppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            await _service.CreateAsync(ViewModel);
            return NoContent();
        }
    }
}