using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VendingMachine.Core.Interfaces;
using VendingMachine.Models;

namespace VendingMachine.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class MachinesController : Controller {
        private readonly ILogger<MachinesController> _logger;
        private IMachineServices _machineServices;
        
        public MachinesController(ILogger<MachinesController> logger, IMachineServices machineServices) {
            _logger = logger;
            _machineServices = machineServices;
        }

        [HttpGet("")]
        public IActionResult GetMachines() {
            return Ok(_machineServices.GetMachines());
        }

        [HttpPost("create")]
        public IActionResult CreateMachine(Machine machine) {
            return Ok(_machineServices.CreateMachine(machine));
        }
        
        [HttpPost("edit")]
        public IActionResult EditMachine(Machine machine) {
            return Ok(_machineServices.EditMachine(machine));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMachine(int id) {
            return Ok(_machineServices.DeleteMachine(id));
        }
    }
}