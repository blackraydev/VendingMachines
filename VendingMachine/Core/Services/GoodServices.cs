using System.Collections.Generic;
using System.Linq;
using VendingMachine.Core.Interfaces;
using VendingMachine.Models;

namespace VendingMachine.Core.Services {
    public class GoodServices : IGoodService {
        public AppDbContext _context;

        public GoodServices(AppDbContext context) {
            _context = context;
        }

        public List<Good> GetGoods() {
            List<Good> goods = _context.Goods.ToList();
            return goods;
        }

        public Good CreateGood(Good good) {
            _context.Goods.Add(good);
            _context.SaveChanges();
            
            return good;
        }

        public Good EditGood(Good editedoGood) {
            var targetGood = _context.Goods.FirstOrDefault(good => good.Id == editedoGood.Id);

            _context.Goods.Remove(targetGood);
            _context.Goods.Add(editedoGood);
            _context.SaveChanges();

            return editedoGood;
        }

        public Good DeleteGood(int id) {
            var deletedGood = _context.Goods.FirstOrDefault(good => good.Id == id);
            
            _context.Goods.Remove(deletedGood);
            _context.SaveChanges();

            return deletedGood;
        }
    }
}