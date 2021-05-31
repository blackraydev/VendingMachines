using System.Collections.Generic;
using System.Linq;
using VendingMachine.Core.Interfaces;
using VendingMachine.Models;

namespace VendingMachine.Core.Services {
    public class MachineServices : IMachineServices {
        public AppDbContext _context;

        public MachineServices(AppDbContext context) {
            _context = context;
        }

        public List<Machine> GetMachines() {
            List<Machine> machines = _context.Machines.ToList();
            return machines;
        }

        public Machine CreateMachine(Machine machine) {
            _context.Machines.Add(machine);
            _context.SaveChanges();
            
            return machine;
        }

        public Machine EditMachine(Machine editedMachine) {
            var targetMachine = _context.Machines.FirstOrDefault(machine => machine.Id == editedMachine.Id);

            _context.Machines.Remove(targetMachine);
            _context.Machines.Add(editedMachine);
            _context.SaveChanges();

            return editedMachine;
        }

        public Machine DeleteMachine(int id) {
            var deletedMachine = _context.Machines.FirstOrDefault(machine => machine.Id == id);
            
            _context.Machines.Remove(deletedMachine);
            _context.SaveChanges();

            return deletedMachine;
        }
    }
}