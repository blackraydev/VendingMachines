using System.ComponentModel.DataAnnotations;

namespace VendingMachine.Models {
    public class Good {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public string Article { get; set; }
        public string Supplier { get; set; }
        public int SupplierPrice { get; set; }
    }
}