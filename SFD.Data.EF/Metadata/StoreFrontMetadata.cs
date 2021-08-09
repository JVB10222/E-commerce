using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFD.Data.EF.Metadata
{
    class StoreFrontMetadata
    {
        //public int ProductID { get; set; }  DO NOT need to setup metadata for this, as it will not be displayed to the user
        [Required(ErrorMessage = "* Product Name is required.")]
        [StringLength(40, ErrorMessage = "* Product Name must be 40 characters or less.")]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        public Nullable<int> SupplierID { get; set; }

        public Nullable<int> CategoryID { get; set; }

        public string QuantityPerUnit { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}", NullDisplayText = "[-Price Not Given-]")]
        [Display(Name = "Unit Price")]
        [Required(ErrorMessage = "* Unit Price is required.")]
        public Nullable<decimal> UnitPrice { get; set; }

        [DisplayFormat(NullDisplayText = "[-No Description Providied -]")]
        public Nullable<short> UnitsInStock { get; set; }

        [DisplayFormat(NullDisplayText = "[-No Description Providied -]")]
        public Nullable<short> UnitsOnOrder { get; set; }

        public Nullable<short> ReorderLevel { get; set; }

        public bool Discontinued { get; set; }

        [Display(Name = "Primary Image")]
        public string ShoeImage { get; set; }

        [Required(ErrorMessage = "* Description is required.")]
        [UIHint("MultilineText")]
        [DisplayFormat(NullDisplayText = "[-No Description Providied -]")]
        public string Description { get; set; }
    }
}
