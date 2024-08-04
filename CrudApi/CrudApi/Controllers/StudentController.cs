using CrudApi.Model_Entities;
using CrudApi.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IBookRepo repo;

        public StudentController(IBookRepo Repo)
        {
            repo = Repo;
        }
        [HttpGet]
        public async Task<IActionResult> ListBook()
        {
            var data = await repo.ListBook();
            return Ok(data);
        }
        [HttpPost]
        public async Task<IActionResult> AddBook(Studentsdb obj)
        {
            await repo.AddBook(obj);
            return Ok(obj);
        }
        [HttpDelete ("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var data =await repo.DeleteBook(id);
            if (data == null)
            { 
                return NotFound();

            }
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data= await repo.GetById(id);
            if (data == null)
            {
                return BadRequest();
            }
            return Ok(data);
        }
    }
}
