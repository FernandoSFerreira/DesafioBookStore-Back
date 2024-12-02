using DesafioBookStore_Back.Application.Interfaces;
using DesafioBookStore_Back.Application.Services;
using DesafioBookStore_Back.Domain.Interfaces.Repositories;
using DesafioBookStore_Back.Domain.Interfaces.Services;
using DesafioBookStore_Back.Domain.Services;
using DesafioBookStore_Back.Infrastructure.Data.Mapping;
using DesafioBookStore_Back.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBookStore_Back.IoC
{
    public class DependencyInjection
    {
        public static void Register(IServiceCollection svcCollection)
        {
            //Aplicação
            svcCollection.AddScoped(typeof(IAppBase<,>), typeof(AppBaseService<,>));
            svcCollection.AddScoped<ILivroApp, LivroApp>();
            svcCollection.AddScoped<IAssuntoApp, AssuntoApp>();
            svcCollection.AddScoped<IAutorApp, AutorApp>();

            //Domínio
            svcCollection.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
            svcCollection.AddScoped<ILivroService, LivroService>();
            svcCollection.AddScoped<IAssuntoService, AssuntoService>();
            svcCollection.AddScoped<IAutorService, AutorService>();

            //Repositorio
            svcCollection.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            svcCollection.AddScoped<ILivroRepository, LivroRepository>();
            svcCollection.AddScoped<IAssuntoRepository, AssuntoRepository>();
            svcCollection.AddScoped<IAutorRepository, AutorRepository>();
        }
    }
}
