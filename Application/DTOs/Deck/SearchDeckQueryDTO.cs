using Application.DTOs.Common;

namespace Application.DTOs.Deck;

public class SearchDeckQueryDTO : BaseQueryDTO
{
    public string Keyword { set; get; } = string.Empty;
    public string Type { set; get; } = string.Empty;
}
