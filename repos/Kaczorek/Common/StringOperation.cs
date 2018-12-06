using System;

namespace Common
{
    public static class StringOperation
    {
        public static string InsertSpace(this string source)
        {
            var output = string.Empty;
            if (!String.IsNullOrWhiteSpace(source))
            {
                foreach (var letter in source)
                {
                    if (char.IsUpper(letter) && !output.EndsWith(" "))
                    {
                        output += " ";
                    }
                    output += letter;
                }
            }
            return output.Trim();
        }
    }
}
