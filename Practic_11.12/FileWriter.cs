namespace Practic_11._12
{
    internal static class FileWriter
    {
        public static void WriteConties(string path, Contry[] contries)
        {
            string title = File.ReadAllText("countrey.txt");
            foreach (var cont in title)
                Console.WriteLine(cont);
            //File.WriteAllLines(path, contries);
        }
    }
}
