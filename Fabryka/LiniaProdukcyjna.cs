using Fabryka.Bloczki;
using Fabryka.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabryka
{
    public class LiniaProdukcyjna
    {
        List<IBloczek> bloczki = new List<IBloczek>();


        public LiniaProdukcyjna()
        {
            bloczki.Add(new Dodawanie());
            bloczki.Add(new Dzielenie());
            bloczki.Add(new Mnozenie());
            bloczki.Add(new Odejmowanie());
            bloczki.Add(new Customowy());



            Console.Out.WriteLine(przetworz("12+3"));
            Console.Out.WriteLine(przetworz("12*3"));
            Console.Out.WriteLine(przetworz("12-3"));
            Console.Out.WriteLine(przetworz("12/3"));
            Console.Out.WriteLine(przetworz("12(3"));

            Console.In.ReadLine();

        }



        public string przetworz(string input)
        {
            Dzialanie dzialanie = Ekstraktor.extract(input);
            if(dzialanie == null)
            {
                return "Błędny input";
            }
            else
            {
                foreach(IBloczek bloczek in bloczki)
                {
                    bloczek.wykonaj(dzialanie);
                }

                return $"Wynik {input} to: {dzialanie.wynik}";
            }


        }





    }
}
