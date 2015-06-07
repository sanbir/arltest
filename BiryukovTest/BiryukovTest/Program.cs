﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiryukovTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var ff = int.Parse(args[0]);



            switch (ff)
            {
                case 1:

            }

            var list = new List<Guid>
            {
                new Guid("5399cbaa-a0d5-4032-8bf8-ff4920ddc157"),
                new Guid("564733fc-920d-44de-9297-d5399e7642f8"),
                new Guid("345920d2-2c6d-5399-905d-f7f7a1ce8b0b")
            };

            var strings = list.Select(guid => guid.ToString("N")).ToList();

            var longestCommon = strings.GetLongestCommonSubstring();

            foreach (var longestString in longestCommon)
            {
                Console.WriteLine(longestString);
            }

            Console.ReadLine();
        }
    }

    public static class Helper
    {
        public static IEnumerable<string> GetLongestCommonSubstring(this IList<string> strings)
        {
            if (strings == null)
                throw new ArgumentNullException("strings");
            if (!strings.Any() || strings.Any(String.IsNullOrEmpty))
                throw new ArgumentException("None of the strings must be empty", "strings");

            var commonSubstrings = new HashSet<string>(strings[0].GetSubstrings());
            foreach (string str in strings.Skip(1))
            {
                commonSubstrings.IntersectWith(str.GetSubstrings());
                if (commonSubstrings.Count == 0)
                    return null;
            }

            return commonSubstrings.Where(s => s.Length == commonSubstrings.Max(m => m.Length));
        }

        public static IEnumerable<string> GetSubstrings(this string str)
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
