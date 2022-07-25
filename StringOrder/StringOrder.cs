using System;
using System.Linq;

namespace StringOrder
{
    public static class StringOrder
    {
        public static string Order(string input)
        {
            while (input.IndexOf("  ") != -1) input = input.Replace("  ", " ");
            input = input.Trim();

            var res = input.Split(' ')
                .Select(x => new { str = x, sSum = x.ToArray().Select(arr => Int32.Parse(arr.ToString())).Sum() })
                .OrderBy(x => x.sSum).ThenBy(x => x.str);

            return String.Join(" ", res.Select(s => s.str));
        }
    }
}
