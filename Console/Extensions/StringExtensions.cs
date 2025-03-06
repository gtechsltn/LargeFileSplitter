using System;

namespace LargeFileSplitter
{
    public static class StringExtensions
    {
        public static string FormatWith(this string input, params object[] args)
        {
            if (input == null)
                throw new ArgumentNullException("format");

            return string.Format(input, args);
        }

        public static bool IsNullOrEmpty(this string input)
        {
            return string.IsNullOrEmpty(input);
        }
    }
}