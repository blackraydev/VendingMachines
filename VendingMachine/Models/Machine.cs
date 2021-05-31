using System.ComponentModel.DataAnnotations;

namespace VendingMachine.Models {
    public class Machine {
        [Key]
        public int Id { get; set; }
        public string Model { get; set; }
        public string Address { get; set; }
    }
}