internal class Program
{
    private static void Main(string[] args)
    {
        int degreeNumber = 2;
        int degreeCount = 1;
        long degree = 2;
        Random number = new Random();
        int value = number.Next();
        Console.WriteLine(value);

        while (degree < value)
        {
            degreeCount++;
            degree *= degreeNumber;
            Console.WriteLine($"{degreeCount}. {degree}");
        }

        Console.WriteLine($"Минимальная степень двойки равная {degreeCount}" +
            $" превосходящая случайное число {value} равна {degree}.");
    }
}