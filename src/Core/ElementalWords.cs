namespace Core;

public static class ElementalWords
{
    const int MAX_LENGTH = 5;
    private static IDictionary<string, Element> ELEMENTS = Elements.GetElements();

    public static string[][] ElementalForms(string word)
    {
        word = word.Trim();
        if (!Validate(word))
            return [];

        var maxElementLength = ELEMENTS.Keys.Max(x => x.Length);
        var parts = Parts(word, maxElementLength);
        var output = new List<string[]>();
        foreach(var part in parts)
        {
            var allFound = true;
            var partOutput = new string[part.Length];
            for(var i = 0; i < part.Length; i++)
            {
                var e = part[i].ToLowerInvariant();
                if (!ELEMENTS.ContainsKey(e))
                {
                    allFound = false;
                    break;
                }

                partOutput[i] = ELEMENTS[e].ToString();
            }

            if (allFound)
                output.Add(partOutput);
        }

        return [.. output];
    }

    // Break up the word into smaller parts which are the element symbols
    public static string[][] Parts(string word, int maxLength)
    {
        var results = new List<string[]>();
        Parts(word, maxLength, 0, [], results);
        return [..results];
    }

    private static void Parts(string word, int maxLength, int index, List<string> current, List<string[]> results)
    {
        if (index == word.Length)
        {
            // If we get here, we're at the end of the word - Add the parts to the result and stop
            results.Add([.. current]);
            return;
        }

        for (var i = 1; i <= maxLength && index + i <= word.Length; i++)
        {
            var part = word.Substring(index, i); // Get the current substring 
            current.Add(part); // Add it to the current list of parts
            Parts(word, maxLength, index + i, current, results); // Get all the parts from the rest of the word
            current.RemoveAt(current.Count - 1); // Remove the last entry to avoid duplicating the current letter
        }
    }

    private static bool Validate(string word)
    {
        if (string.IsNullOrEmpty(word))
            return false;

        if (word.Length > MAX_LENGTH)
            return false;

        return true;
    }
}
