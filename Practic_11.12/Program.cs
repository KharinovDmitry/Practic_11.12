namespace Practic_11._12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Contry[] input = Parser.Parse("./countrey.txt");
            input = Contry.SortByPoplation(input);

            Console.WriteLine("Какой континет?");
            string continent = Console.ReadLine();
            Console.WriteLine("Куда сохранить?");
            string nameFileSort = Console.ReadLine() + ".txt";
            FileWriter.WriteConties(nameFileSort, Contry.SelectByContinent(input, continent));

            string letterString;
            char letter;
            do
            {
                Console.WriteLine("Введите символ по которому нужно составить выборку");
                letterString = Console.ReadLine();
                letter = letterString[0];
            } while (letterString.Length != 1 || !Char.IsLetter(letter));

            Contry[] contriesLetter = Contry.GetContriesByLetter(input, letter);
            Contry[] contriesRes = Contry.SelectByRemoveContinent(contriesLetter, continent);

            Console.WriteLine("Куда сохранить выборку?");
            string nameFileSelection = Console.ReadLine() + ".txt";
            FileWriter.WriteConties(nameFileSelection, contriesRes);
        }
    }
}