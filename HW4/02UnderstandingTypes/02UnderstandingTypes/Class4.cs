using System;
using System.Net;
using System.Numerics;
using System.Reflection;
using System.Text;



public class Class4
{ 
    public void programming1()
    {
        Console.WriteLine(" reverses its letters");
        string a = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        for(int i = a.Length - 1; i>=0 ; i--)
        {
            sb.Append(a[i]);
        }
        Console.WriteLine(sb.ToString());
    }
    
    public void programming2()
    {
        Console.WriteLine(" reverses the words in a given sentence");
        string a = Console.ReadLine();
        char[] spliter = { ' ', '.' ,',', ':', ';' ,'=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?' };
        string[] words = a.Split(spliter, StringSplitOptions.RemoveEmptyEntries);
        
        Array.Reverse(words);



        char[] spliterChar = new char[55];
        int index = 0;
        for (char c = 'a'; c <= 'z'; c++)
        {
            spliterChar[index++] = c;
        }

        // Adding uppercase letters 'A' to 'Z'
        for (char c = 'A'; c <= 'Z'; c++)
        {
            spliterChar[index++] = c;
        }
        spliterChar[index++] = '#';
        spliterChar[index++] = '-';
        spliterChar[index] = '+';

        string[] charas = a.Split(spliterChar, StringSplitOptions.RemoveEmptyEntries);
        
        //Console.WriteLine(charas.Length);
        //Console.WriteLine(words.Length);
        int i = 0;
        while(i < words.Length) {
            Console.Write(words[i]);
            if(i != charas.Length)
                Console.Write(charas[i]);
            i++;
        }
        Console.WriteLine();
    }

    public void programming3() {
        Console.WriteLine("extracts from a given text all palindromes");
        string a = Console.ReadLine();
        char[] spliter = { ' ', ',', '.', '?', '!', ':', ';' };
        string[] num = a.Split(spliter, StringSplitOptions.RemoveEmptyEntries);

        Array.Sort(num);

        foreach(string s in num)
        {
            if (IsPalindrome(s))
            {
                Console.Write($"{s}, ");
            }
        }
        Console.WriteLine();
    }

    public bool IsPalindrome(string word)
    {
        int l = 0;
        int r = word.Length - 1;
        while(l  < r)
        {
            if (word[l++] != word[r--]) return false;
        
        }
        return true;
    }

    public void programming4()
    {
        Console.WriteLine("parses an URL");
        string a= Console.ReadLine();
        int protocolIndex = a.IndexOf("://");
        string protocol = "";
        string server = "";
        string resource = "";
        
        if(protocolIndex != -1)
        {
            protocol = a.Substring(0,protocolIndex);
            a = a.Substring(protocolIndex+3);
        }
        int serverIndex = a.IndexOf('/');
        if(serverIndex != -1)
        {
            server = a.Substring(0,serverIndex);
            resource = a.Substring(serverIndex + 1);
        }
        else
        {
            server = a;
        }
        Console.WriteLine($"[protocol] = {protocol}");
        Console.WriteLine($"[server] = {server}");
        Console.WriteLine($"[resource] = {resource}");
        Console.WriteLine();
    }
}