namespace Application.DTOs.VocabularyCard;

public class UpdateVocabularyCardRequest
{
    public string Term { set; get; } = string.Empty;
    public string Meaning { set; get; } = string.Empty;
}
