using Domain.Enums;

namespace Application.DTOs.Deck;

public class CreateDeckRequest
{
    public string Name { set; get; } = string.Empty;
    public string Description { set; get; } = string.Empty;
    public DeckType Type { set; get; } 
}
