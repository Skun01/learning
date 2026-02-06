using Application.DTOs.ExampleSentence;
namespace Application.DTOs.VocabularyCard;

public class CreateVocabularyRequest
{
    public string Term { set; get; } = string.Empty;
    public string Meaning { set; get; } = string.Empty;
    public string DeckId { set; get; } = string.Empty;
    public IEnumerable<CreateExampleSentenceRequest> Examples { set; get; } = [];
}
