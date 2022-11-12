namespace Practic_11._12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Contry[] input = Parser.Parse("./contrey.txt");
            input = Contry.SortByPoplation(input);
            string nameFile = Console.ReadLine();
            FileWriter.WriteConties(nameFile, input);

            string letterString;
            char letter;
            do
            {
                letterString = Console.ReadLine();
                letter = letterString[0];
            } while (letterString.Length != 1);

            Contry[] contriesLetter = Contry.GetContriesByLetter(input, letter);
        }
    }
}