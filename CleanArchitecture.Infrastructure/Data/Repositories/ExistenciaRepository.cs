using CleanArchitecture.Application.Interface;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Infrastructure.Data.Repositories
{
    public class ExistenciaRepository : RepositoryBase<Existencia>, IExistenciaRepository
    {
        public ExistenciaRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}