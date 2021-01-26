using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace test_mvc_webapp.Models
{
    public class Product
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        //get: get value from variable IdProduct
        //set: set value from variable IdProduct
        public int IdProduct { get; set; }

        [Display(Name = "Enter Product Code")]
        [StringLength(20)]
        [Required(ErrorMessage = "{0} Is required.")]

        public string ProductCode { get; set; }

         [Display(Name = "Enter Product Type")]
         [StringLength(50)]
         [Required(ErrorMessage = "{0} Is required.")]

        public string ProductType { get; set; }

         [Display(Name = "Enter Product Description")]
         [StringLength(150)]

        public string Description { get; set; }

         [Display(Name = "Unit Price")]
         [DisplayFormat(DataFormatString = "{0:C")]
        [Required(ErrorMessage = "{0} Is required.")]

        public decimal UnitPrice { get; set; }

         [Display(Name = "Quantity In Stock")]
         [Required(ErrorMessage = "{0} Is required.")]

        public int QTtyInStock { get; set; }

    }   

}