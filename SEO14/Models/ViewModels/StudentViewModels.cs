using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEO14.Models.ViewModels
{
    public class StudentViewModels
    {
        [Display(Name = "نام")]
        [Required(ErrorMessage = "فیلد {0} اجباری است!")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "نام شما باید حداقل 2 و حداکثر 20 کاراکتر باشد!")]
        [RegularExpression("^[آ-ی ]+$", ErrorMessage = "فقط کاراکترهای فارسی مورد تایید است!")]
        public string Name{ get; set; }
        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "فیلد {0} اجباری است!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "نام خانوادگی شما باید حداقل 3 و حداکثر 50 کاراکتر باشد!")]
        [RegularExpression("^[آ-ی ]+$", ErrorMessage = "فقط کاراکترهای فارسی مورد تایید است!")]
        public string Family{ get; set; }
        [Display(Name = "شماره موبایل")]
        [Required(ErrorMessage = "فیلد {0} اجباری است!")]
        [RegularExpression("(09)[0-9]{9}", ErrorMessage = "فرمت {0} شما صحیح نیست!")]
        public string PhoneNumber{ get; set; }
        [Display(Name = "رمز عبور")]
        [Required(ErrorMessage = "فیلد {0} اجباری است!")]
        [DataType(DataType.Password)]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "رمز عبور شما باید حداقل 6 و حداکثر 30 کاراکتر باشد!")]
        public string Password{ get; set; }

    }
}