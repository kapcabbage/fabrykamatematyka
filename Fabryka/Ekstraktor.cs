using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Fabryka
{
    public class Ekstraktor
    {

        public static Dzialanie extract(string input)
        {
            Dzialanie d = new Dzialanie();
            Regex rgx = new Regex(@"^\d+[^\d]+\d+$");
            Regex liczba1 = new Regex(@"^\d+");
            Regex liczba2 = new Regex(@"\d+$");
            Regex oper = new Regex(@"[^\d]+");

            if (rgx.IsMatch(input) == false)
                return null;
            else
            {
                d.zm1 = Double.Parse(liczba1.Match(input).Value);
                d.zm2 = Double.Parse(liczba2.Match(input).Value);
                d.oper = Char.Parse(oper.Match(input).Value);
            }

            return d;
        }

    }
}
