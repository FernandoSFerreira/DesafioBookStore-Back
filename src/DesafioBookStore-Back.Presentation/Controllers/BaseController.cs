using DesafioBookStore_Back.Application.DTO;
using DesafioBookStore_Back.Application.Interfaces;
using DesafioBookStore_Back.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesafioBookStore_Back.Presentation.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<Entidade, EntidadeDTO> : ControllerBase
        where Entidade : BaseEntity
        where EntidadeDTO : BaseDTO
    {
        readonly protected IAppBase<Entidade, EntidadeDTO> app;

        public BaseController(IAppBase<Entidade, EntidadeDTO> app)
        {
            this.app = app;
        }

        [HttpGet]
        [Route("")]
        public IActionResult List()
        {
            try
            {
                var lstItens = app.GetAll();
                return new OkObjectResult(lstItens);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult ListById(int id)
        {
            try
            {
                var lstItens = app.GetById(id);
                return new OkObjectResult(lstItens);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Include([FromBody] EntidadeDTO item)
        {
            try
            {
                return new OkObjectResult(app.Add(item));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Change([FromBody] EntidadeDTO item)
        {
            try
            {
                app.Update(item);
                return new OkObjectResult(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Exclude(int id)
        {
            try
            {
                app.Remove(id);
                return new OkObjectResult(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
