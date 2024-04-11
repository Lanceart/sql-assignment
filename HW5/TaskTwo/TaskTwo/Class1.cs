using System;


public class Class1
{
    public void programming1()
    {
        int[] numbers = GenerateNumbers();
        Reverse(ref numbers);
        PrintNumbers(numbers);
    }

    public int[] GenerateNumbers()
    {
        int[] numbers = new int[10];
        for(int i = 0; i < 10; i++)
        {
            numbers[i] = i;
        }
        return numbers;
    }

    public int[] GenerateNumbers(int len)
    {
        int[] numbers = new int[len];
        for (int i = 0; i < len; i++)
        {
            numbers[i] = i;
        }
        return numbers;
    }

    public void Reverse(ref int[] numbers)
    {
        for(int i = 0; i<numbers.Length / 2; i++)
        {
            int temp = numbers[i];
            numbers[i] = numbers[numbers.Length -1 - i];
            numbers[numbers.Length - 1 - i] = temp;
        }
    }

    public void PrintNumbers(int[] numbers)
    {
        for(int i = 0; i< numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    }

    public void Fibonacci(int num)
    {
        Console.WriteLine(InterationFibo(num));
    }

    public int InterationFibo(int num)
    {
        if (num == 1) return 1;
        if(num == 2) return 1;
    
        return InterationFibo(num - 1) + InterationFibo(num - 2);

    }

    public void programming2(int num)
    {
        int l1 = 1;int l2 = 1;
        Console.Write("1 1 ");
        for(int i = 3; i <= num; i++)
        {
            int r = l1 + l2;
            l1 = l2;
            l2 = r;
            Console.Write($"{r} ");
        }

    }
}
