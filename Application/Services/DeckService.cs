using Application.DTOs.Deck;
using Application.IRepositories;
using Application.IServices;
using Domain.Entities;

namespace Application.Services;

public class DeckService : IDeckService
{
    private readonly IUnitOfWork _unitOfWork;
    public DeckService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<bool> CreateDeckAsync(CreateDeckRequest request, string userId)
    {
        var newDeck = new Deck()
        {
            Id = Guid.NewGuid().ToString(),
            Name = request.Name,
            Description = request.Description,
            Type = request.Type,
            CreatedBy = userId
        };

        await _unitOfWork.Decks.AddAsync(newDeck);
        await _unitOfWork.SaveChangesAsync();

        return true;
    }
}
