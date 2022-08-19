namespace ArraysTask
{
    class Program
    {
        static void Main()
        {
            Apple(200, 8);
            Numbers();

        }

        static void Apple(double ter, byte year)
        {
            for (byte i = 1; i <= year; i++)
            {
                ter = ter * 1.1;
            }
            Console.WriteLine(ter);
        }

        static void Numbers()
        {
            foreach (int i in Enumerable.Range(0, 100))
            {
                if (i % 8 == 0)
                {
                    Console.WriteLine(i);
                }
            };
        }
     
    }
}



