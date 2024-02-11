﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEO14.Models
{
    [Table("T_Student")]
    public class Student
    {
        [Display(Name = "آیدی")]
        [Required(ErrorMessage = "فیلد {0} اجباری است!")]
        public int Id { get; set; }
        [Display(Name = "نام")]
        [Required(ErrorMessage = "فیلد {0} اجباری است!")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "نام شما باید حداقل 2 و حداکثر 20 کاراکتر باشد!")]
        [RegularExpression("^[آ-ی ]+$", ErrorMessage = "فقط کاراکترهای فارسی مورد تایید است!")]
        public string Name { get; set; }
        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "فیلد {0} اجباری است!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "نام خانوادگی شما باید حداقل 3 و حداکثر 50 کاراکتر باشد!")]
        [RegularExpression("^[آ-ی ]+$", ErrorMessage = "فقط کاراکترهای فارسی مورد تایید است!")]
        public string Family { get; set; }
        [Display(Name = "کدملی")]
        [Required(ErrorMessage = "فیلد {0} اجباری است!")]
        [MaxLength(10)]
        public string Ncode { get; set; }
        [Display(Name = "تاریخ تولد")]
        [Required(ErrorMessage = "فیلد {0} اجباری است!")]
        public DateTime Birthdate { get; set; }


        [Display(Name = "آدرس ایمیل")]
        [EmailAddress(ErrorMessage = "فرمت {0} شما صحیح نیست!")]
        public string Email { get; set; }
        [Display(Name = "شماره موبایل")]
        [Required(ErrorMessage = "فیلد {0} اجباری است!")]
        [RegularExpression("(09)[0-9]{9}", ErrorMessage = "فرمت {0} شما صحیح نیست!")]
        public string PhoneNumber { get; set; }
        [Display(Name = "رمز عبور")]
        [Required(ErrorMessage = "فیلد {0} اجباری است!")]
        [DataType(DataType.Password)]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "رمز عبور شما باید حداقل 6 و حداکثر 30 کاراکتر باشد!")]
        public string Password { get; set; }

        [Display(Name = "وضعیت ")]
        [Required(ErrorMessage = "فیلد {0} اجباری است!")]
        public bool IsActive { get; set; }
        [Display(Name = "تاریخ عضویت ")]
        [Required(ErrorMessage = "فیلد {0} اجباری است!")]
        public DateTime RegisterDate { get; set; }
        [Display(Name = "سن ")]
        public Nullable<int> age { get; set; }
    }
}