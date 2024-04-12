// See https://aka.ms/new-console-template for more information
MyStack<int> programming1 = new MyStack<int>();
programming1.Push(1);
programming1.Push(2);
programming1.Push(3);
programming1.Push(4);
programming1.Push(5);
programming1.Push(6);

programming1.Pop();
Console.WriteLine(programming1.Count());




MyList<int> programming2 = new MyList<int>();
programming2.Add(1);
programming2.Add(2);
programming2.Add(4);

Console.WriteLine(programming2.Find(2));
Console.WriteLine(programming2.Contains(3));
Console.WriteLine(programming2.Contains(4));


//the interface define in IReposity.cs and Class3.cs


