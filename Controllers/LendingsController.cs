using System.Collections.Generic;
using System.Threading.Tasks;
using exco_api.IService;
using exco_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace exco_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LendingsController : ControllerBase
    {
        private readonly ILendingService _lendingService;

        public LendingsController(ILendingService lendingService)
        {
            _lendingService = lendingService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllLendings()
        {
            List<Lending> lendings = await _lendingService.GetAllLendings();

            if (lendings.Count == 0)
            {
                return NotFound("No lendings found!");
            }

            return Ok(lendings);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetLendingById(int id)
        {
            Lending lending = await _lendingService.GetLendingById(id);

            if (lending == null)
            {
                return NotFound("No lending found!");
            }

            return Ok(lending);
        }
    }
}