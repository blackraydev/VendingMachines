using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VendingMachine.Core.Interfaces;
using VendingMachine.Models;

namespace VendingMachine.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class GoodToMachineController : Controller {
        private readonly ILogger<GoodToMachineController> _logger;
        private IGoodToMachineServices _goodToMachineService;
        
        public GoodToMachineController(ILogger<GoodToMachineController> logger, IGoodToMachineServices goodToMachineService) {
            _logger = logger;
            _goodToMachineService = goodToMachineService;
        }
        
        [HttpGet("{id}")]
        public IActionResult GetMachineGoods(int id) {
            return Ok(_goodToMachineService.GetMachineGoods(id));
        }
        
        [HttpPost("add")]
        public IActionResult AddGoodToMachine(GoodToMachine good) {
            return Ok(_goodToMachineService.AddGoodToMachine(good));
        }

        [HttpPost("edit")]
        public IActionResult EditGoodInMachine(GoodToMachine goodToMachine) {
            return Ok(_goodToMachineService.EditGoodInMachine(goodToMachine));
        }
        
        [HttpPost("remove")]
        public IActionResult RemoveGoodFromMachine(GoodToMachine goodToMachine) {
            return Ok(_goodToMachineService.RemoveGoodFromMachine(goodToMachine));
        }
    }
}