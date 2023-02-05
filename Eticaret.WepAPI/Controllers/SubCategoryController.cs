using ETicaret.BussinessLayer.Abstract;
using ETicaret.EntityLayer.Concretes;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Eticaret.WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCategoryController : ControllerBase
    {
        private ISubCategoryService _subCategoryService;

        public SubCategoryController(ISubCategoryService subCategoryService)
        {
            _subCategoryService = subCategoryService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetList()
        {
            var result = await _subCategoryService.GetListAsync(x => x.SubCategoryStatu == true);
            if (result is not null)
                return Ok(result);
            return BadRequest();
        }

        [HttpGet]
        [Route("[action]/{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _subCategoryService.GetModelByIdAsync(id);
            if (result is not null)
                return Ok(result);
            return NotFound();
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Add([FromBody] SubCategory subCategoy)
        {
            var result = await _subCategoryService.AddAsync(subCategoy);
            if (result is not null)
                return Ok(subCategoy);
            return BadRequest(result);
        }


        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> Update([FromBody] SubCategory subCategory)
        {
            var result = await _subCategoryService.UpdateAsync(subCategory);
            if (result is not null)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpDelete]
        [Route("[action]/{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _subCategoryService.DeleteByIdAsync(id);
            if (result)
                return Ok(result);

            return BadRequest(result);
        }

    }
}
