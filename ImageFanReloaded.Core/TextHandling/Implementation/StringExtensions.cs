using System;

namespace ImageFanReloaded.Core.TextHandling.Implementation;

public static class StringExtensions
{
    public static string? GetRemainingStringAfterSubstringMatch(this string longerString, string shorterString, StringComparison stringComparison)
    {
        if (longerString is null)
            throw new ArgumentNullException(nameof(longerString));
        if (shorterString is null)
            throw new ArgumentNullException(nameof(shorterString));

        string? remainingStringAfterSubstringMatch;

        var matchIndex = longerString.IndexOf(shorterString, stringComparison);

        if (matchIndex >= 0)
        {
            var remainingStringStartIndex = matchIndex + shorterString.Length;

            if (remainingStringStartIndex < longerString.Length)
            {
                remainingStringAfterSubstringMatch = longerString[remainingStringStartIndex..];
            }
            else
            {
                remainingStringAfterSubstringMatch = string.Empty;
            }
        }
        else
        {
            remainingStringAfterSubstringMatch = null;
        }

        return remainingStringAfterSubstringMatch;
    }
}