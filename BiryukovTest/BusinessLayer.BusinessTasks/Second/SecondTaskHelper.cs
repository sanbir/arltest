using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.BusinessTasks.Second
{
    internal static class SecondTaskHelper
    {
        public static IEnumerable<string> GetLongestCommonSubstrings(this IList<string> strings, int minNumberOfStringsToCount)
        {
            if (strings == null)
                throw new ArgumentNullException("strings");
            if (!strings.Any() || strings.Any(String.IsNullOrEmpty))
                throw new ArgumentException("None of the strings must be empty", "strings");

            return strings.GetCommonSubstrings(minNumberOfStringsToCount).GetLongestCommonSubstrings();
        }

        private static IEnumerable<string> GetLongestCommonSubstrings(this HashSet<string> commonSubstrings)
        {
            return commonSubstrings.Where(s => s.Length == commonSubstrings.Max(m => m.Length));
        }

        private static HashSet<string> GetCommonSubstrings(this IList<string> strings, int minNumberOfStringsToCount)
        {
            var commonSubstrings = new HashSet<KeyValuePair<string, int>>(strings[0].GetSubstrings());
            foreach (string str in strings.Skip(1))
            {
                var temp = new HashSet<KeyValuePair<string, int>>(commonSubstrings);
                temp.IntersectWith(str.GetSubstrings());

                foreach (KeyValuePair<string, int> s in temp)
                {
                    if(commonSubstrings)
                    commonSubstrings
                }

                //if (commonSubstrings.Count == 0)
                //    return commonSubstrings;
            }
            return commonSubstrings;
        }



        private static IEnumerable<KeyValuePair<string, int>> GetSubstrings(this string str)
        {
            if (String.IsNullOrEmpty(str))
                throw new ArgumentException("str must not be null or empty", "str");

            for (int c = 0; c < str.Length - 1; c++)
            {
                for (int cc = 1; c + cc <= str.Length; cc++)
                {
                    yield return new KeyValuePair<string, int> (str.Substring(c, cc), 0);
                }
            }
        }
    }
}
