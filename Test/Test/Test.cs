using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class StringExtension
    {

        public static string ToLower(this string s)
        {
            var low = new Dictionary<string, string>
            {

                {"A", "a"},
                {"B", "b" },
            { "C", "c" },
            { "D", "d" },
            { "E", "e" },
                { "F", "f" },
                { "G", "g" },
            ("H", "h" },
            ("I", "i"},
            ("J", "j"},
            ("K", "k"}',
            ("L", "l"
            ("M", "m");
            ("N", "n");
            ("O", "o");
            ("P", "p");
            ("Q", "q");
            ("R", "r");
            ("S", "s");
            ("T", "t");
            ("U", "u");
            ("V", "v");
            ("W", "w");
            ("X", "x");
            ("Y", "y");
            ("Z", "z");

        };

            return low.Aggregate(s, (current, pair) => current.Replace(pair.Key, pair.Value));

        }


}

    }



