using Application.DTOs.ExampleSentence;

namespace Application.DTOs.VocabularyCard;

public class VocabularyCardDTO
{
    public string Id { set; get; } = string.Empty;
    public string Term { set; get; } = string.Empty;
    public string Meaning { set; get; } = string.Empty;
    public string DeckId { set; get; } = string.Empty;
    public IEnumerable<ExampleSentenceDTO> Examples { set; get; } = [];
}
