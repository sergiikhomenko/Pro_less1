namespace task6;
/*
 * Створіть метод, який як аргумент приймає масив цілих чисел і повертає колекцію
 * квадратів усіх непарних чисел масиву.
 * Для формування колекції використовуйте оператор yield.
 */
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        IEnumerable<int> res = UnpairedSquaresOfEars(numbers);
        foreach (var re in res)
        {
            Console.WriteLine($" {re} ");
        }
    }

    public static IEnumerable<int> UnpairedSquaresOfEars(int[] num )
    {
        foreach (var number in num)
        {
            if (number % 2 != 0)
            {
                yield return number * number;
            }
        }
    }
}