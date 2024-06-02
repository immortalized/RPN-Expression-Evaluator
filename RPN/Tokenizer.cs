using System.Text.RegularExpressions;

public static class Tokenizer
{
    public static string[] Tokenize(string input)
    {
        List<string> tokens = new List<string>();
        // Regular expression pattern to match numeric values and operators
        string pattern = @"(\d+(\.\d+)?)|[\+\-\*/\^\(\)]";
        foreach (Match match in Regex.Matches(input, pattern))
        {
            // Add matched tokens to the list
            tokens.Add(match.Value);
        }
        // Convert the list to an array and return
        return tokens.ToArray();
    }
}
