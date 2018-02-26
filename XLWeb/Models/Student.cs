using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XLWeb.Models
{
    public class Student : BaseC
    {
        [Display(Name = "编号")]
        [Required(AllowEmptyStrings = false)]
        [StringLength(50)]
        public string Code { get; set; }

        [Display(Name = "姓名")]
        [Required(AllowEmptyStrings = false)]
        [StringLength(50)]
        public string Name { get; set; }

        [Display(Name = "性别")]
        [Required(AllowEmptyStrings = false)]
        [StringLength(10)]
        public string Sex { get; set; }

        [Display(Name = "生日")]
        [Required(AllowEmptyStrings = false)]
        public DateTime Birthday { get; set; }

        [Display(Name = "年龄")]
        [Required(AllowEmptyStrings = false)]
        public int Age { get; set; }

        [Display(Name = "地址")]
        [StringLength(500)]
        public string Address { get; set; }

        [Display(Name = "手机")]
        [StringLength(50)]
        public string Phone { get; set; }

        [Display(Name = "QQ")]
        [StringLength(50)]
        public string QQ { get; set; }

        [Display(Name = "备注")]
        [StringLength(500)]
        public string Remark { get; set; }
    }
}