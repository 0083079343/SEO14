using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SEO14.Models.ViewModels
{
    public class LodinViewModel
    {
        [Display(Name = "شماره موبایل")]
        [Required(ErrorMessage = "فیلد {0} اجباری است!")]
        [RegularExpression("(09)[0-9]{9}", ErrorMessage = "فرمت {0} شما صحیح نیست!")]
        public string PhoneNumber { get; set; }
        [Display(Name = "رمز عبور")]
        [Required(ErrorMessage = "فیلد {0} اجباری است!")]
        [DataType(DataType.Password)]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "رمز عبور شما باید حداقل 6 و حداکثر 30 کاراکتر باشد!")]
        public string Password { get; set; }
    }
}