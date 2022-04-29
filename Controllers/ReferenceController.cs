using System.Collections.Generic;
using System.Threading.Tasks;
using exco_api.IService;
using exco_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace exco_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReferencesController : ControllerBase
    {
        private readonly IReferenceService _referenceService;

        public ReferencesController(IReferenceService referenceService)
        {
            _referenceService = referenceService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllReferences()
        {
            List<Reference> references = await _referenceService.GetAllReferences();

            if (references.Count == 0)
            {
                return NotFound("No references found!");
            }

            return Ok(references);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetReferenceById(int id)
        {
            Reference reference = await _referenceService.GetReferenceById(id);

            if (reference == null)
            {
                return NotFound("No reference found!");
            }

            return Ok(reference);
        }
    }
}