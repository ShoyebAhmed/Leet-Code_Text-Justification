using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
public class Solution
{
    public List<string> FullJustify(string[] words, int maxWidth)
    {
        List<string> final = new List<string>();
        int i;
        int n = words.Length;
        i = 0;
        while (i < n)
        {
            int j = i + 1;
            int lineLength = words[i].Length;
            while (j < n && (lineLength + words[j].Length + (j - i - 1)) < maxWidth)
            {
                lineLength += words[j].Length;
                j++;
            }
            int diff = maxWidth - lineLength;
            int numberOfWords = j - i;
            if (numberOfWords == 1 || j == n)
            {
                final.Add(LeftJustify(words, diff, i, j));
            }
            else
            {
                final.Add(MiddleJustify(words, diff, i, j));
            }

            i = j;
        }
        return final;

    }
    private string LeftJustify(string[] words, int diff, int i, int j)
    {
        int spacesOnRight = diff - (j - i - 1);
        StringBuilder sb = new StringBuilder(words[i]);
        for (int k = i + 1; k < j; k++)
        {
            sb.Append(" " + words[k]);
        }
        if (spacesOnRight > 0)
            sb.Append(' ', spacesOnRight);
        return sb.ToString();
    }
    private string MiddleJustify(string[] words, int diff, int i, int j)
    {
        int spacesNeeded = j - i - 1;
        int spaces = diff / spacesNeeded;
        int extraSpaces = diff % spacesNeeded;
        StringBuilder sb = new StringBuilder(words[i]);
        for (int k = i + 1; k < j; k++)
        {
            int spacesToApply = spaces + (extraSpaces-- > 0 ? 1 : 0);
            sb.Append(' ', (spacesToApply));
            sb.Append(words[k]);
        }
        return sb.ToString();
    }
}