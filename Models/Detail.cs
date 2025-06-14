using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LAB11_CORDOVA.Models
{
    public class Detail
    {
        [Key]
        public int DetailID { get; set; }


        public int Amount { get; set; }

        public float Price { get; set; }

        public float SubTotal { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }


        public int InvoiceId { get; set; }

        public Invoice Invoice { get; set; }
    }
}
