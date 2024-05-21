namespace ChapterArraysStrings;

public static class TwoStringsAreAnagrams
{
    public static bool StringsAreAnagrams(string firstInput, string secondInput)
    {
        if (firstInput.Length != secondInput.Length)
            return false;

        var firstInputOrdered = firstInput.Order().ToArray();
        var secondInputOrdered = secondInput.Order().ToArray();

        return firstInputOrdered.SequenceEqual(secondInputOrdered);
    }
    
    public static bool StringsAreAnagramsModified(string firstInput, string secondInput)
    {
        if (firstInput.Length != secondInput.Length)
            return false;

        var charCounts = new int[256];
        foreach (var c in firstInput)
            charCounts[c]++;

        foreach (var c in secondInput)
            charCounts[c]--;

        return charCounts.All(count => count == 0);
    }
}