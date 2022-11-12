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
        }
    }
}