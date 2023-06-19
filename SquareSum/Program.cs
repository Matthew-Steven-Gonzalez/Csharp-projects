
class Program
{
    public static int SquareSum(int[] numbers)
    { 
        int sum = 0;
        for(int i = 0; i < numbers.Length;i++)
        {
            sum += (numbers[i] * numbers[i]);
        }
        return sum;
    }
}
