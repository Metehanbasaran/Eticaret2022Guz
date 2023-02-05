using ETicaret.BussinessLayer.Abstract;
using ETicaret.EntityLayer.Concretes;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Eticaret.WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommetController: ControllerBase
    {
        private ICommetService _commetService;

        public CommetController(ICommetService commetService)
        {
            _commetService = commetService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetList()
        {
            var result = await _commetService.GetListAsync(x => x.CommetStatu == true);
            if (result is not null)
                return Ok(result);
            return BadRequest();
        }

        [HttpGet]
        [Route("[action]/{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _commetService.GetModelByIdAsync(id);
            if (result is not null)
                return Ok(result);
            return NotFound();
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Add([FromBody] Commet commet)
        {
            var result = await _commetService.AddAsync(commet);
            if (result is not null)
                return Ok(commet);
            return BadRequest(result);
        }


        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> Update([FromBody] Commet commet)
        {
            var result = await _commetService.UpdateAsync(commet);
            if (result is not null)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpDelete]
        [Route("[action]/{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _commetService.DeleteByIdAsync(id);
            if (result)
                return Ok(result);

            return BadRequest(result);
        }
    }
}
