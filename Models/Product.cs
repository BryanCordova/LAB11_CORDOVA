using System.ComponentModel.DataAnnotations;

namespace LAB11_CORDOVA.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        public string Name { get; set; }

        public float Price { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
