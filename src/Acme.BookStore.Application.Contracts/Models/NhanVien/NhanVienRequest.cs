using System;
using System.ComponentModel.DataAnnotations;

namespace Acme.BookStore.Models.NhanVien
{
    public class NhanVienRequest
    {
        [Required(ErrorMessage = "Required")]
        [StringLength(255)]
        [Display(Name = "NhanVienName", Prompt = "PlaceHolder")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "NhanVienName", Prompt = "PlaceHolder")]
        public int Tuoi { get; set; }
        public string CMND { get; set; }

        [Required(ErrorMessage = "Required")]
        public virtual Guid BoPhanId  { get; set; }

    }
}