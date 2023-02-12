// See https://aka.ms/new-console-template for more information
internal class Program


{
    /* Name: James McGuinness
     * Date: 25/01/23
     * Desc: Worksheet 1 Q 1
     * */

    static void Main(string[] args)
    {
        PrintIntegersFor();
        PrintIntegersWhile();
        PrintIntegersDo();
        PrintExcludingFor();
        PrintDescendingFor();

    }

    static private void PrintIntegersFor() //(a)vvv
    {
        for (int i = 40; i <= 60;)
        {
            Console.WriteLine($"{i}");
            i = i + 1;

        }
    }
    static private void PrintIntegersWhile() //(b)
    {
        int z = 40;

        while (z <= 60)
        {
            Console.WriteLine($"{z}");
            z = z + 1;
        }
    }

    static private void PrintIntegersDo() //(c)
    {
        int y = 40;
        do
        {
            Console.WriteLine($"{y}");
            y = y + 1;


        } while (y <= 60);
    }

    static private void PrintExcludingFor() //(D)
    {
        for (int j = 40; j <= 60; j++)
        {
            Console.WriteLine($"{j}");
            j = j + 1;
            if (j == 46 || j == 48)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(j);
            }

        }

    }
    static private void PrintDescendingFor() //(e)
    {
        for (int q = 60; q <= 40;)
        {
            Console.WriteLine($"{q}");
            q = q - 1;
        }
    }

}

