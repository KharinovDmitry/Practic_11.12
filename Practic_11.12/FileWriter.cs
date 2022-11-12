using System.Text;

namespace Practic_11._12
{
    internal static class FileWriter
    {
        public static void WriteConties(string path, Contry[] contries)
        {
            string title0 = File.ReadAllLines("countrey.txt")[0] + "\n";
            StringBuilder text = new StringBuilder();
            text.Append(title0);
            foreach (var contry in contries)
            {
                string newLine = String.Join(';', contry.Name, contry.Capital, contry.Squre, contry.Population, contry.Continent);
                text.Append(newLine + "\n");
            }
            File.WriteAllText(path, text.ToString());
        }
    }
}
