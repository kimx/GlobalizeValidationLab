using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GlobalizeValidationLab.Models
{
    public class ProductModel
    {
        [Display(Name = "CreateDate", ResourceType = typeof(GlobalizeValidationLab.Resources.Index))]
        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }

        [Range(1.001D, 3000.33D)]
        public decimal PricedDecmial { get; set; }

        public int Qty { get; set; }

    }
}