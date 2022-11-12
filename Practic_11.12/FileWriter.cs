using System.Text;

namespace Practic_11._12
{
    internal static class FileWriter
    {
        public static void WriteConties(string path, Contry[] contries)
        {
            string[] title0 = File.ReadAllLines("countrey.txt")[0].Split(';');
            string title = String.Join(' ', title0);
            StringBuilder text = new StringBuilder();
            text.Append(title0);
            text.Append(contries);
            File.WriteAllText(path, text.ToString());
        }
    }
}
