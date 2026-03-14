using CleanArchitecture.Application.Interface;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Infrastructure.Data.Repositories
{
    public class MovimientoRepository : RepositoryBase<MovimientoInventario>, IMovimientoRepository
    {
        public MovimientoRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}