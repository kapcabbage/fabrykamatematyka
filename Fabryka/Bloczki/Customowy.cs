using Fabryka.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabryka.Bloczki
{
    public class Customowy : IBloczek
    {
        private char Operator = '(';

        public void wykonaj(Dzialanie dzialanie)
        {
            if (dzialanie.wynik == null)
            {

                if (dzialanie.oper == Operator)
                {
                    dzialanie.wynik = (dzialanie.zm1 + dzialanie.zm2) * 2;
                }
            }
        }
    }
}
