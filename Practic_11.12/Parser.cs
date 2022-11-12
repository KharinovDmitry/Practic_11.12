namespace Practic_11._12
{
    internal static class Parser
    {
        public static Contry[] Parse(string path)
        {
            string[] input = File.ReadAllLines(path);
            Contry[] result = new Contry[input.Length - 1];
            for(int i = 0; i < input.Length - 1; i++)
            {
                string[] data = input[i + 1].Split(";");

                string name = data[0];
                string capital = data[1];
                int squre = int.Parse(data[2]);
                int population = int.Parse(data[3]);
                string continent = data[4];

                result[i] = new Contry(name, capital, squre, population, continent);
            }
            return result;
        }
    }
}
