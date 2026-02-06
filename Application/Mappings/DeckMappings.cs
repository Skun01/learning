using Application.DTOs.Deck;
using Domain.Entities;
using Domain.Enums;

namespace Application.Mappings;

public static class DeckMappings
{
    public static DeckSummaryDTO ToSummaryDTO(this Deck deck)
    {
        return new DeckSummaryDTO()
        {
            Id = deck.Id,
            Name = deck.Name,
            Type = deck.Type,
            CardNumber = deck.Type == DeckType.Grammar ? deck.GrammarCards.Count() : deck.VocabularyCards.Count(),
            Author = deck.User!.ToDTO()
        };
    }
}
