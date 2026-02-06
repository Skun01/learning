namespace Application.DTOs.ExampleSentence;

public class CreateExampleSentenceRequest
{
    public string ClozeSentence { set; get; } = string.Empty;
    public string ExpectedAnswer { set; get; } = string.Empty;
    public string? Hint { set; get; }
}
