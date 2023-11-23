class Program
{
    static void Main(string[] args)
    {
        string input = "*****";
        string output = ReplaceStars(input);

        Console.WriteLine(output);
    }
    static string ReplaceStars(string input)
    {
        Dictionary<char, int> starCounter = new Dictionary<char, int>();
        string output = "";
        foreach (char c in input)
        {
            if (c == '*')
            {
                if (starCounter.ContainsKey(c))
                {
                    starCounter[c]++;
                }
                else
                {
                    starCounter[c] = 1;
                }

                output += starCounter[c].ToString();
            }
            else
            {
                output += c;
            }
        }
        return output;
    }
}
