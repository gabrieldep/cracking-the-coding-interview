using System.Text;

namespace ChapterArraysStrings;

public static class ReverseCStyle
{
    public static string? GetReverseCStyle(string inputString)
    {
        var arrayResponse = new char[inputString.Length];
        arrayResponse[inputString.Length - 1] = '\n';

        var j = 0;
        for (var i = inputString.Length - 2; i >= 0; i--)
        {
            arrayResponse[j] = inputString[i];
            j++;
        }
        
        var stringResponse = new string(arrayResponse);

        return stringResponse;
    }
    
    public static string? GetReverseCStyleModified(string inputString)
    {
        if (string.IsNullOrEmpty(inputString))
            return null;

        var reversedString = new StringBuilder(inputString.Length);

        for (var i = inputString.Length - 2; i >= 0; i--)
            reversedString.Append(inputString[i]);

        reversedString.Append('\0');
        return reversedString.ToString();
    }
}
