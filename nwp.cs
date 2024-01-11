namespace LCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string s2 = "abaabbaaa";
            string s1 = "babab";
            int n = s1.Length;
            int m = s2.Length;
            int[,] tab = new int[n + 1, m + 1];
            char[] a1 = s1.ToCharArray();
            char[] a2 = s2.ToCharArray();

            for (int i = 0; i < tab.GetLength(0); i++)
                tab[i, 0] = 0;

            for (int i = 0; i < tab.GetLength(1); i++)
                tab[0, i] = 0;

            for (int i = 1; i<tab.GetLength(0); i++)
            {
                for (int j = 1; j < tab.GetLength(1); j++)
                {
                    if (a1[i - 1] == a2[j - 1])
                    {
                        tab[i, j] = tab[i - 1, j - 1]+1;
                    }
                    else
                    {
                        if (tab[i, j - 1] >= tab[i - 1, j])
                        {
                            tab[i, j] = tab[i, j - 1];
                        }
                        else
                        {
                            tab[i, j] = tab[i - 1, j];
                        }
                    }
                    Console.Write(tab[i, j]);
                }
                Console.WriteLine();
                
            }
            tab[5, 9] = 5;
            Console.WriteLine(tab[tab.GetLength(0) - 1, tab.GetLength(1) - 1]);

            int tmp;
            for (int i = 1; i < tab.GetLength(0); i++)
            {
                for (int j = 1; j < tab.GetLength(1); j++)
                {

                    tmp = tab[tab.GetLength(0) - i, tab.GetLength(1) - j];
                }
            }
        }
    }
}
