using System;

namespace checkava
{
    class Program
    {
        static bool FinnsTecknetIAllaSträngar(string[] ord, char tecken)
        {
            for (int i = 0; i < ord.Length; i++)
            {
                if (ord[i].ToLower().Contains(tecken.ToString().ToLower()))
                {
                    return true;
                }
            }
            return false;
        }
        static void Main()
        {
            string[] namn = { "Johan", "Programmering", "Självklart" };
            Console.WriteLine(FinnsTecknetIAllaSträngar(namn, 'a'));
        }
    }
}