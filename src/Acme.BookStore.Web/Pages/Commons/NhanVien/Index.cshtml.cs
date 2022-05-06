using Acme.BookStore.Web.Pages;
using System.Threading.Tasks;

namespace Core.Web.Pages.Commons.NhanVien
{
    public class IndexModel : BookStorePageModel
    {
        public virtual async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
