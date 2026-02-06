namespace Application.DTOs.ExampleSentence;

public class ExampleSentenceDTO
{
    public string Id { set; get; } = string.Empty;
    public string ClozeSentence { set; get; } = string.Empty;
    public string ExpectedAnswer { set; get; } = string.Empty;
    public string FullSentence { set; get; } = string.Empty;
    public string? Hint { set; get; }
}
