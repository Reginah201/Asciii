namespace Asciii
{
    internal class Program
    {
      
            static void Main()
            {
            int height = 10; // You can change the height of the diamond here
                int width = height * 5 - 1; // The width of the diamond

                // Draw the upper part of the diamond
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        if (j >= height - i - 1 && j <= height + i - 1)
                        
                    Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                Console.ForegroundColor= ConsoleColor.Magenta;
                // Draw the lower part of the diamond
                for (int i = height - 1; i >= 0; i--)
                {
                    for (int j = 0; j < width; j++)
                    {
                        if (j >= height - i - 1 && j <= height + i - 1)
                            Console.Write("#");
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
        }

    }

