using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Library.Infrastructure
{
    public static class Format
    {
        public static string UpperCaseFirstLetters(this string text)
        {
            var upperCaseTextInfo = new CultureInfo("en-US", false).TextInfo;
            return upperCaseTextInfo.ToTitleCase(text.ToLower());
        }

        public static string RemoveDoubleWhiteSpaces(this string text)
        {
            return Regex.Replace(text, @"\s+", " ");
        }
    }
}
