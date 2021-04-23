using System.Collections.Generic;

namespace FindReplace.Models
{
    public class FindR
    {
        public string ConvertSentence(string source, string from, string to)
        {
            string replacement = source.Replace(from, to);
            return replacement;
        }
    }
}