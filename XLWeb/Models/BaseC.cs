using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace XLWeb.Models
{
    public class BaseC
    {
        [Key]
        public int ID { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(50)]
        public string CreateUser { get; set; }

        [Required(AllowEmptyStrings = false)]
        public DateTime CreateTime { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(50)]
        public string ModifyUser { get; set; }

        [Required(AllowEmptyStrings = false)]
        public DateTime ModifyTime { get; set; }

    }
}