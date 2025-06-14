using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LAB11_CORDOVA.Models
{
    public class Invoice
    {
   
        public int InvoiceID { get; set; }

        public DateTime Date { get; set; }

        public string InvoiceNumber { get; set; }

        public float Total { get; set; }

        // Navegación
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
      
    }
}
