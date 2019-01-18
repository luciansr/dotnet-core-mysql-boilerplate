using Repository.Repositories;

namespace Repository.UnitOfWork
{
    public interface IUnitOfWork
    {
        UserRepository Users { get; set; }
    }
}