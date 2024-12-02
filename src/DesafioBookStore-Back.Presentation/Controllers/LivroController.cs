using DesafioBookStore_Back.Application.DTO;
using DesafioBookStore_Back.Application.Interfaces;
using DesafioBookStore_Back.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace DesafioBookStore_Back.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : BaseController<Livro, LivroDTO>
    {
        public LivroController(ILivroApp app)
            : base(app)
        { }
    }
}
