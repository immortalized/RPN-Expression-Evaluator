using System.Text.RegularExpressions;

public static class Tokenizer
{
    public static string[] Tokenize(string input)
    {
        List<string> tokens = new List<string>();
        string pattern = @"(\d+(\.\d+)?)|[\+\-\*/\^\(\)]";
        foreach (Match match in Regex.Matches(input, pattern))
        {
            tokens.Add(match.Value);
        }
        
        return tokens.ToArray();
    }
}
