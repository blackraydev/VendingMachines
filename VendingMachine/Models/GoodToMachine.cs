using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace VendingMachine.Models {
    public class GoodToMachine {
        [Key]
        public int Id { get; set; }
        public int GoodId { get; set; }
        public int MachineId { get; set; }
        public int GoodCount { get; set; }
        public int GoodPrice { get; set; }
    }
}