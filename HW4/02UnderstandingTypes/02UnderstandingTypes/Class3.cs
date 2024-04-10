

using System;
using System.Collections;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;



public class Class3
{
    public void programming1()
    {
        int[] a = new int[10];
        for(int i = 0; i < a.Length; i++)
        {
            a[i] = i;
        }
        int[] b = new int[a.Length];
        for(int i = 0; i < b.Length ; i++)
        {
            b[i] = a[i];
        }

        //print part
        for(int i =0; i< a.Length; i++) Console.Write(a[i] + ' ');
        Console.WriteLine();
        for (int i = 0; i < b.Length; i++) Console.Write(b[i] + ' ');
        Console.WriteLine();
    }

    public void programming2()
    {
        List<string> list = new List<string>();
        while (true)
        {
            Console.WriteLine("Enter command (+ item, - item, -- to clear, exit to quit):");
            string input = Console.ReadLine();
            if (input.ToLower() == "exit") break;
            if (input.StartsWith("+"))
            {
                string itemAdd = input.Substring(1).Trim();
                list.Add(itemAdd);
                Console.WriteLine($"Added {itemAdd}");
            }else if (input.StartsWith("-"))
            {
                string[] itemCheck = input.Split();

                if(itemCheck.Length == 2)
                {
                    list.Remove(itemCheck[1]);
                    Console.WriteLine($"Removed {itemCheck}.");
                }
                else
                {
                    list.Clear();
                    Console.WriteLine("List cleared.");
                }
            }else if (input == "--")
            {
                list.Clear();
                Console.WriteLine("List cleared.");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }


            Console.WriteLine("Current list:");
            foreach (string item in list) Console.WriteLine(item);
            Console.WriteLine() ;
        }
    }
    public bool CheckPrime(int num)
    {
        for (int j = 2; j <= Math.Sqrt(num); j++)
        {
            if (num % j == 0)
            {
                return false;
            }
        }
        return true;
    }

    public void FindPrimesInRange(int begin, int end) 
    {
        Console.WriteLine("The prime: ");
        for(int i = begin; i<=end ; i++){
            if (CheckPrime(i))
            {
                Console.Write($"{i} ");
            }
        }
        Console.WriteLine();
    }


    public void programming4()
    {
        Console.WriteLine("Give a set of input(eg: 3 2 4 -1): ");
        string inputLine = Console.ReadLine();
        string[] parts = inputLine.Split(' ');
        int[] a = new int[parts.Length * 2];
        
        for (int j = 0; j < parts.Length; j++)
        {
            a[j] = int.Parse(parts[j]);
            a[j + parts.Length] = a[j];
        }

        Console.WriteLine("Input the rotations times: ");
        int divide = int.Parse(Console.ReadLine());

        int rest =  divide % a.Length;
        int result = divide / a.Length;

        int[] b = new int[parts.Length];


        for (int i = parts.Length; i < parts.Length * 2; i++)
        {
            for(int j = i; j > i - rest; j--)
            {
                b[i - parts.Length] += a[j];
            }
        }

        int sums = 0;
        for(int i = 0; i < parts.Length; i++)
        {
            sums += a[i];
        }

        Console.Write(b[b.Length - 1]);
        for (int i = 0; i < parts.Length - 1; i++)
        {
            Console.Write($" {b[i]}");
        }

        Console.WriteLine();
    }

    public void programming5()
    {
        Console.WriteLine("Find The longest sequence: (eg: 2 1 1 2 3 3 2 2 2 1)");
        string a = Console.ReadLine();
        string[] b = a.Split(' ');
        int[] nums = new int[b.Length];
        for(int i = 0; i< nums.Length; i++)
        {
            nums[i] = int.Parse(b[i]);
        }

        int begin = 0;
        int lenCurrent = 1;
        int bestBegin = 0;
        int lenMax = 1;
        
        for(int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i-1]) {
                lenCurrent++;
                if(lenCurrent > lenMax)
                {
                    lenMax = lenCurrent;
                    bestBegin = begin;
                }
            }
            else
            {
                lenCurrent = 1;
                begin = i;
            }
        }

        for(int i = bestBegin; i < lenMax + bestBegin; i++)
        {
            Console.Write(nums[i] + " ");
        }

        Console.WriteLine();
        
    }


    public void programming7()
    {
        Dictionary<string, int> hashMap = new Dictionary<string, int>();
        Console.WriteLine("finds the most frequent number (eg: 4 1 1 4 2 3 4 4 1 2 4 9 3 )");
        string a = Console.ReadLine();
        string[] b = a.Split();
        for(int i = 0; i< b.Length; i++)
        {
            if (!hashMap.ContainsKey(b[i]))
            {
                hashMap[b[i]] = 1;
            }
            else
            {
                hashMap[b[i]]++;
            }
        }

        int maxFreq = hashMap.Values.Max();

        List<string> list = new List<string>();
        foreach(var i in hashMap)
        {
            if(i.Value == maxFreq)
            {
                list.Add(i.Key);
            }
        }

        if(list.Count == 1)
        {
            Console.WriteLine($"The number {list[0]} is the most frequent(occurs {maxFreq} times)");
        }
        else
        {
            var strNumbers = string.Join(", ", list);
            Console.WriteLine($"The numbers {strNumbers} have the same maximal frequency (each occurs {maxFreq} times). The leftmost of them is {list[0]}");
        }

    }
}
