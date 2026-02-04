using Application.DTOs.Card;
using Domain.Entities;

namespace Application.Mappings;

public static class VocabularyCardMappings
{
    public static PreviewCardDTO ToPreviewDTO(this VocabularyCard card)
    {
        return new PreviewCardDTO()
        {
            Id = card.Id,
            Meaning = card.Meaning,
            Term = card.Term
        };
    }
}
