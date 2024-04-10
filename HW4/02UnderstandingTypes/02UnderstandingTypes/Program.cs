// See https://aka.ms/new-console-template for more information


using System;
using System.Numerics;



Class1 temp1 = new Class1();
//Programming 1
temp1.Programming1();

Console.WriteLine(new String('=', 75));

//Programming 2
temp1.programming2();

Console.WriteLine(new String('=', 75));


Class2 temp2 = new Class2();
temp2.programming1();
Console.WriteLine(new String('=', 75));
// it won't stop because the max value of bytes is 255. And this will cause dead loop.
// it should be updated like this
//int max = 500;
//for (int i = 0; i < max; i++)
//{
//    Console.WriteLine(i);
//}

temp2.programming2(); // print Pyramind
Console.WriteLine(new String('=', 75));
temp2.programming3();// random number guess
Console.WriteLine(new String('=', 75));
temp2.programming4(); // anniversary
Console.WriteLine(new String('=', 75));
temp2.programming5();
Console.WriteLine(new String('=', 75));
temp2.programming6();
Console.WriteLine(new String('=', 75));


Class3 temp3 = new Class3();
temp3.programming1();
Console.WriteLine(new String('=', 75));
temp3.programming2();
Console.WriteLine(new String('=', 75));
temp3.FindPrimesInRange(2, 15);
Console.WriteLine(new String('=', 75));
temp3.programming4();
Console.WriteLine(new String('=', 75));
temp3.programming5();
Console.WriteLine(new String('=', 75));
temp3.programming7();
Console.WriteLine(new String('=', 75));



Class4 temp4 = new Class4();
temp4.programming1();
Console.WriteLine(new String('=', 75));
temp4.programming2();
Console.WriteLine(new String('=', 75));
temp4.programming3();
Console.WriteLine(new String('=', 75));
temp4.programming4();
