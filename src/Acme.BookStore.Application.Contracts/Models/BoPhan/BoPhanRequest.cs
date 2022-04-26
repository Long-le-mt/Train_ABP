using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Acme.BookStore.Application.Contracts.Models.BoPhan
{
    public class BoPhanRequest
    {
        [Required(ErrorMessage = "Trường này là trường bắt buộc")]
        [StringLength(255)]
        [Display(Name = "BoPhanName", Prompt = "PlaceHolder")]
        public string Name { get; set; }

        [DisplayName("GhiChu")]
        [StringLength(255)]
        public string GhiChu { get; set; }
    }
}