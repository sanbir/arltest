using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Contracts.Second;

namespace BusinessLayer.BusinessTasks.Second
{
    public class SecondTask : ISecondTask<string, string>
    {
        public ISecondTaskResult<string> Calculate(ISecondTaskArguments<string> arguments)
        {
            var result = new SecondTaskResultStrings
            {
                Items = arguments.Items,
                MaxCommonStrings = GetLongestCommonSubstrings(arguments.Items)
            };

            return result;
        }

        private static IEnumerable<string> GetLongestCommonSubstrings(IList<string> strings)
        {
            if (strings == null)
                throw new ArgumentNullException("strings");
            if (!strings.Any() || strings.Any(String.IsNullOrEmpty))
                throw new ArgumentException("None of the strings must be empty", "strings");

            var commonSubstrings = GetCommonSubstrings(strings);
            var longestCommonSubstrings = GetLongestCommonSubstrings(commonSubstrings);

            return longestCommonSubstrings;
        }

        private static IEnumerable<string> GetLongestCommonSubstrings(HashSet<string> commonSubstrings)
        {
            return commonSubstrings.Where(s => s.Length == commonSubstrings.Max(m => m.Length));
        }

        private static HashSet<string> GetCommonSubstrings(IList<string> strings)
        {
            var commonSubstrings = new HashSet<string>(GetSubstrings(strings[0]));
            foreach (string str in strings.Skip(1))
            {
                commonSubstrings.IntersectWith(GetSubstrings(str));
                if (commonSubstrings.Count == 0)
                    return commonSubstrings;
            }
            return commonSubstrings;
        }

        public static IEnumerable<string> GetSubstrings(string str)
        {
            if (String.IsNullOrEmpty(str))
                throw new ArgumentException("str must not be null or empty", "str");

            for (int c = 0; c < str.Length - 1; c++)
            {
                for (int cc = 1; c + cc <= str.Length; cc++)
                {
                    yield return str.Substring(c, cc);
                }
            }
        }
    }
}
