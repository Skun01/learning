using Application.DTOs.User;
using Domain.Enums;

namespace Application.DTOs.Deck;

public class DeckSummaryDTO
{
    public string Id { set; get; } = string.Empty;
    public string Name { set; get; } = string.Empty;
    public DeckType Type { set; get; }
    public int CardNumber { set; get; } = 0;
    public UserDTO Author { set; get; } = null!;
}
