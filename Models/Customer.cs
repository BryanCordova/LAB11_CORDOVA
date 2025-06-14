using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LAB11_CORDOVA.Models
{
    public class Customer
    {
       
        public int CustomerID { get; set; }

        public string FirstName { get; set; }

 
        public string LastName { get; set; }

        public string DocumentNumber { get; set; }

        public bool IsDeleted { get; set; } = false;

    }
}
