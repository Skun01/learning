using Application.DTOs.VocabularyCard;
using Application.IRepositories;
using Application.IServices;
using Domain.Constants;
using Domain.Entities;
using Domain.Enums;

namespace Application.Services;

public class VocabularyCardService : IVocabularyCardService
{
    private IUnitOfWork _unitOfWork;
    public VocabularyCardService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<bool> CreateVocabularyCardAsync(CreateVocabularyRequest request, string userId)
    {
        var deck = await _unitOfWork.Decks.GetByIdAsync(request.DeckId);

        if(deck == null)
            throw new ApplicationException(MessageConstants.CommonMessage.NOT_FOUND);

        if(deck.CreatedBy != userId)
            throw new ApplicationException(MessageConstants.CommonMessage.NOT_ALLOW);

        if(deck.Type != DeckType.Vocabulary)
            throw new ApplicationException(MessageConstants.CommonMessage.INVALID);

        var examples = request.Examples.Select(e => new ExampleSentence()
        {
            Id = Guid.NewGuid().ToString(),
            ClozeSentence = e.ClozeSentence,
            Hint = e.Hint,
            ExpectedAnswer = e.ExpectedAnswer,
        }).ToList();

        var newVocabCard = new VocabularyCard()
        {
            Id = Guid.NewGuid().ToString(),
            Term = request.Term,
            Meaning = request.Meaning,
            DeckId = request.DeckId,
            ExampleSentences = examples
        };
        
        await _unitOfWork.VocabularyCards.AddAsync(newVocabCard);
        await _unitOfWork.SaveChangesAsync();

        return true;
    }
}
