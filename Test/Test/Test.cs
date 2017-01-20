using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translate
{
    public static class Translater
    {

        public static string A(this string s)

        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary.Add("A", "a");
            dictionary.Add("B", "b");
            dictionary.Add("C", "c");

            return s;


        }

    }


}
