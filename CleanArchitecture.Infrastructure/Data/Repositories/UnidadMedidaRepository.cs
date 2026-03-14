using CleanArchitecture.Application.Interface;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Infrastructure.Data.Repositories
{
    public class UnidadMedidaRepository : RepositoryBase<UnidadMedida>, IUnidadMedidaRepository
    {
        public UnidadMedidaRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}