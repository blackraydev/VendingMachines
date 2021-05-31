using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VendingMachine.Core.Interfaces;
using VendingMachine.Models;

namespace VendingMachine.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class GoodsController : Controller {
        private readonly ILogger<GoodsController> _logger;
        private IGoodService _goodService;
        
        public GoodsController(ILogger<GoodsController> logger, IGoodService goodService) {
            _logger = logger;
            _goodService = goodService;
        }
        
        [HttpGet("")]
        public IActionResult GetGoods() {
            return Ok(_goodService.GetGoods());
        }
        
        [HttpPost("create")]
        public IActionResult CreateGood(Good good) {
            return Ok(_goodService.CreateGood(good));
        }
        
        [HttpPost("edit")]
        public IActionResult EditGood(Good good) {
            return Ok(_goodService.EditGood(good));
        }
        
        [HttpDelete("{id}")]
        public IActionResult DeleteGood(int id) {
            return Ok(_goodService.DeleteGood(id));
        }
    }
}