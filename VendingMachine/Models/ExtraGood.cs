using System.ComponentModel.DataAnnotations;
using VendingMachine.Models;

namespace VendingMachine.Models {
    public class ExtraGood {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public string Article { get; set; }
        public string Supplier { get; set; }
        public int SupplierPrice { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }

        public ExtraGood(Good good, GoodToMachine goodToMachine) {
            Id = good.Id;
            Name = good.Name;
            Weight = good.Weight;
            Article = good.Article;
            Supplier = good.Supplier;
            SupplierPrice = good.SupplierPrice;
            Price = goodToMachine.GoodPrice;
            Count = goodToMachine.GoodCount;
        }
    }
}