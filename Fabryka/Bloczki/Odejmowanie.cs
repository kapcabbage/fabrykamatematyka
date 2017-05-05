using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fabryka.Interface;

namespace Fabryka.Bloczki
{
    public class Odejmowanie : IBloczek
    {
        private char Operator = '-';

        public void wykonaj(Dzialanie dzialanie)
        {
            if (dzialanie.wynik != null)
            {
                if (dzialanie.oper == Operator)
                {
                    dzialanie.wynik = dzialanie.zm1 - dzialanie.zm2;
                }
            }
        }
    }
}
