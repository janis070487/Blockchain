
namespace Blockchain_Demo
{
    public static class CheckBlock
    {
        public static bool Check(int how, string stringHash)
        {
            for (int a = 0; a < how; a++) // Pārbauda vai ir vajadzīgās nules
            {
                if (stringHash[a] != '0') // ja kārtējais pārbaudāmais skaitlis neatbilst vajadzīgajam tad atgriež false
                {
                    return false;
                }
            }
            return true; // bet ja iziet parbaudi tad atgriež true
        }
    }
}
