using System.Collections.Generic;
using VendingMachine.Models;

namespace VendingMachine.Core.Interfaces {
    public interface IGoodToMachineServices {
        List<ExtraGood> GetMachineGoods(int id);
        GoodToMachine AddGoodToMachine(GoodToMachine good);
        GoodToMachine EditGoodInMachine(GoodToMachine goodToMachine);
        GoodToMachine RemoveGoodFromMachine(GoodToMachine goodToMachine);
    }
}