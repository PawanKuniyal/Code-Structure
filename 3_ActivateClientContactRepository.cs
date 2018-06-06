using RiskLogic.Entity;
using RiskLogic.Repository.Infrastructure;
using RiskLogic.Repository.Infrastructure.Interface;

namespace RiskLogic.Repository.Repositories
{
    public class ActivateClientContactRepository : Repository<ActivateClientContact>, IActivateClientContactRepository
    {
        public ActivateClientContactRepository(IUnitOfWork uow) : base(uow) { }

    }
}
