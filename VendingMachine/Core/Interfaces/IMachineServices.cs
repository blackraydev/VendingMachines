using System.Collections.Generic;
using VendingMachine.Models;

namespace VendingMachine.Core.Interfaces {
    public interface IMachineServices {
        List<Machine> GetMachines();
        Machine CreateMachine(Machine machine);
        Machine EditMachine(Machine editedMachine);
        Machine DeleteMachine(int id);
    }
}