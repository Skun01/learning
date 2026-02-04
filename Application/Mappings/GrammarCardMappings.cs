using Application.DTOs.Card;
using Domain.Entities;

namespace Application.Mappings;

public static class GrammarCardMappings
{
    public static PreviewCardDTO ToPreviewDTO(this GrammarCard card)
    {
        return new PreviewCardDTO()
        {
            Id = card.Id,
            Term = card.Term,
            Meaning = card.Meaning
        };
    }
}
