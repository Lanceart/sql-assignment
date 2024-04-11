// See https://aka.ms/new-console-template for more information
using System;
using TaskTwo;

Class1 temp1 = new Class1();
temp1.programming1();
Console.WriteLine();
temp1.Fibonacci(4);
temp1.programming2(14);
Console.WriteLine();


Cat kitty = new Cat("blue");
kitty.Eat();







Student student1 = new Student();
student1.Gpa = 3.5;


Course course1 = new Course();
course1.EnrollStudent(student1);
student1.Courses = new List<Course> { new Course() };








Ball redBall = new Ball(new Color(255, 0, 0), 10);
Ball greenBall = new Ball(new Color(0, 255, 0), 15);


redBall.Throw();
redBall.Throw();
greenBall.Throw();


redBall.Pop();
redBall.Throw();


Console.WriteLine($"Red ball was thrown {redBall.GetThrowCount()} times.");
Console.WriteLine($"Green ball was thrown {greenBall.GetThrowCount()} times.");

