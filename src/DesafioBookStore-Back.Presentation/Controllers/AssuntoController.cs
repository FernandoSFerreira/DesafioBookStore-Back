using DesafioBookStore_Back.Application.DTO;
using DesafioBookStore_Back.Application.Interfaces;
using DesafioBookStore_Back.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesafioBookStore_Back.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssuntoController : BaseController<Assunto, AssuntoDTO>
    {
        public AssuntoController(IAssuntoApp app)
            : base(app)
        { }
    }
}
