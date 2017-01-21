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
                {"B", "b"},
                {"C", "c"},
                {"D", "d"},
                {"E", "e"},
                {"F", "f"},
                {"G", "g"},
                {"H", "h"},
                {"I", "i"},
                {"J", "j"},
                {"K", "k"},
                {"L", "l"},
                {"M", "m"},
                {"N", "n"},
                {"O", "o"},
                {"P", "p"},
                {"Q", "q"},
                {"R", "r"},
                {"S", "s"},
                {"T", "t"},
                {"U", "u"},
                {"V", "v"},
                {"W", "w"},
                {"X", "x"},
                {"Y", "y"},
                {"Z", "z"},

        };

            return low.Aggregate(s, (current, pair) => current.Replace(pair.Key, pair.Value));

        }


        public static string ToArmenia(this string a)
        {
            var arm = new Dictionary<string, string>
            {

                {"A", "Ա"},
                {"B", "Բ"},
                {"C", "Ս"},
                {"D", "Դ"},
                {"E", "Ե"},
                {"F", "Ֆ"},
                {"G", "Գ"},
                {"H", "Հ"},
                {"I", "Ի"},
                {"J", "Ջ"},
                {"K", "Կ"},
                {"L", "Լ"},
                {"M", "Մ"},
                {"N", "Ն"},
                {"O", "Օ"},
                {"P", "Պ"},
                {"Q", "Ք"},
                {"R", "Ր"},
                {"S", "Ս"},
                {"T", "Տ"},
                {"U", "ՈՒ"},
                {"V", "Վ"},
                {"Y", "Յ"},
                {"Z", "Զ"},
                {"Ch", "Չ"},
                {"Sh", "Շ"},
                {"Vo", "Ո"},
                {"Kh", "Խ"},
                {"Gh", "Ղ"},








                {"a", "ա"},
                {"b", "բ"},
                {"c", "ս"},
                {"d", "դ"},
                {"e", "ե"},
                {"f", "ֆ"},
                {"g", "գ"},
                {"h", "հ"},
                {"i", "ի"},
                {"l", "ջ"},
                {"k", "կ"},
                {"l", "լ"},
                {"m", "մ"},
                {"n", "ն"},
                {"o", "օ"},
                {"p", "պ"},
                {"q", "ք"},
                {"r", "ր"},
                {"s", "ս"},
                {"t", "տ"},
                {"u", "ու"},
                {"v", "վ"},
                {"y", "յ"},
                {"z", "զ"},
                {"ch", "չ"},
                {"sh", "շ"},
                {"vo", "ո"},
                {"kh", "ծ"},
                {"gh", "ղ"},
                {"ev", "և"},

        };

            return arm.Aggregate(a, (current, pair) => current.Replace(pair.Key, pair.Value));

        }


    }

    }



