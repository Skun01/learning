using Application.DTOs.Card;
using Application.DTOs.User;
using Domain.Enums;

namespace Application.DTOs.Deck;

public class DeckDTO
{
    public string Id { set; get; } = string.Empty;
    public string Name { set; get; } = string.Empty;
    public string Description { set; get; } = string.Empty;
    public DeckType Type { set; get; }
    public UserDTO Author { set; get; } = null!;
    public List<PreviewCardDTO> Cards { set; get; } = [];
}
