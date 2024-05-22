using System.Text;

namespace ChapterArraysStrings;

public static class RotationIsSubstring
{
    public static bool IsRotation(string firstInput, string secondInput)
    {
        if (firstInput.Length != secondInput.Length)
            return false;

        foreach (var t in firstInput)
            if (firstInput == secondInput)
                return true;
            else
                secondInput = RotateOnePositionRight(secondInput);
        
        return default;
    }
    
    public static bool IsRotationModified(string s1, string s2)
    {
        if (s1.Length != s2.Length || s1.Length == 0)
            return false;

        var concatenated = s1 + s1;
        return IsSubstring(concatenated, s2);
    }


    private static string RotateOnePositionRight(string inputString)
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.Append(inputString[^1]);
        for (var i = 0; i < inputString.Length - 1; i++)
            stringBuilder.Append(inputString[i]);
        return stringBuilder.ToString();
    }

    private static bool IsSubstring(string inputString, string inputSubstring)
        => inputString.Contains(inputSubstring);
}