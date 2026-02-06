namespace Application.Helpers;

public static class TextHelpers
{
    public static string CombineFullExampleSentence(string clozeSentence, string answer)
    {
        return clozeSentence.Replace("____", answer);
    }
}
