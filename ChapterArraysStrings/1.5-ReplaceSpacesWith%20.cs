using System.Text;

namespace ChapterArraysStrings;

public static class ReplaceSpacesWith20
{
    public static string ReplaceSpaces(string inputString)
    {
        var stringBuilder = new StringBuilder();
        foreach (var t in inputString)
            if (t == ' ')
                stringBuilder.Append("%20");
            else
                stringBuilder.Append(t);

        return stringBuilder.ToString();
    }
}