using System.Collections;

namespace Practic_11._12
{   

    internal class Contry
    {
        public string Name { private set; get; }
        public string Capital { private set; get; }
        public int Squre { private set; get; }
        public int Population { private set; get; }
        public string Continent { private set; get; }

        public Contry(string name, string capital, int squre, int population, string continent)
        {
            Name = name;
            Capital = capital;
            Squre = squre;
            Population = population;
            Continent = continent;
        }

        public static Contry[] GetContriesByLetter(Contry[] contries, char letter)
        {
            List<Contry> res = new List<Contry>();
            foreach (var contry in contries)
            {
                if(contry.Name.StartsWith(letter.ToString()))
                {
                    res.Add(contry);
                }
            }
            return res.ToArray();
        }

        public static Contry[] SortByPoplation(Contry[] input)
        {  
            Array.Sort(input, new ContryComparer());
            return input.ToArray();
        }

        public static Contry[] SortByContryName(Contry[] input)
        {
            Array.Sort(input, new ContryNameComparer());
            return input.ToArray();
        }
    }
    class ContryComparer : IComparer
    {
        public int Compare(object inputContry1, object inputContry2)
        {
            var Contry1 = (Contry)inputContry1;
            var Contry2 = (Contry)inputContry2;
            return Contry1.Population.CompareTo(Contry2.Population);
        }
    }

    class ContryNameComparer : IComparer
    {
        public int Compare(object inputContry1, object inputContry2)
        {
            var Contry1 = (Contry)inputContry1;
            var Contry2 = (Contry)inputContry2;
            return Contry1.Name.CompareTo(Contry2.Name);
        }
    }
}
