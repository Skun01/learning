namespace Application.IRepositories;

public interface IUnitOfWork
{
    IUserRepository Users { get; }

    Task<int> SaveChangesAsync();
}
