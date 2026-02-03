namespace Application.IRepositories;

public interface IUnitOfWork
{
    IUserRepository Users { get; }
    IRefreshTokenRepository RefreshTokens { get; }
    IDeckRepository Decks { get; }

    Task<int> SaveChangesAsync();
}
