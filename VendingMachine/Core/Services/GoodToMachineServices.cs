using System;
using System.Collections.Generic;
using System.Linq;
using VendingMachine.Core.Interfaces;
using VendingMachine.Models;

namespace VendingMachine.Core.Services {
    public class GoodToMachineServices : IGoodToMachineServices {
        public AppDbContext _context;
        
        public GoodToMachineServices(AppDbContext context) {
            _context = context;
        }

        public List<ExtraGood> GetMachineGoods(int id) {
            var goods = _context.GoodToMachine.ToList();
            List<GoodToMachine> goodsToMachine = new List<GoodToMachine>();
            List<ExtraGood> extraGoods = new List<ExtraGood>();

            for (int i = 0; i < goods.Count; i++) {
                if (goods[i].MachineId == id) {
                    goodsToMachine.Add(goods[i]);
                }
            }

            foreach (var extraField in goodsToMachine) {
                var targetGood = _context.Goods.FirstOrDefault(good => good.Id == extraField.GoodId);
                ExtraGood extraGood = new ExtraGood(targetGood, extraField);
                extraGoods.Add(extraGood);
            }
            
            return extraGoods;
        }

        public GoodToMachine AddGoodToMachine(GoodToMachine good) {
            _context.GoodToMachine.Add(good);
            _context.SaveChanges();
            
            return good;
        }

        public GoodToMachine EditGoodInMachine(GoodToMachine goodToMachine) {
            var targetGood = _context.GoodToMachine.FirstOrDefault(good => 
                good.GoodId == goodToMachine.GoodId && good.MachineId == goodToMachine.MachineId
            );

            _context.GoodToMachine.Remove(targetGood);
            _context.GoodToMachine.Add(goodToMachine);
            _context.SaveChanges();

            return goodToMachine;
        }

        public GoodToMachine RemoveGoodFromMachine(GoodToMachine goodToMachine) {
            var deletedGood = _context.GoodToMachine.FirstOrDefault(good => 
                good.GoodId == goodToMachine.GoodId && good.MachineId == goodToMachine.MachineId
            );
            
            _context.GoodToMachine.Remove(deletedGood);
            _context.SaveChanges();

            return deletedGood;
        }
    }
}