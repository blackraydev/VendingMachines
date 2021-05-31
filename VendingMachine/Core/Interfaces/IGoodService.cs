using System.Collections.Generic;
using VendingMachine.Models;

namespace VendingMachine.Core.Interfaces {
    public interface IGoodService {
        List<Good> GetGoods();
        Good CreateGood(Good good);
        Good EditGood(Good editedoGood);
        Good DeleteGood(int id);
    }
}