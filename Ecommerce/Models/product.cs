using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class product
    {   [Key]
        public int ProductId { get; set; }
        public String ProductName { get; set; }
        public int CategoryId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public DateTime CreatedDate  { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ProductImage { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}