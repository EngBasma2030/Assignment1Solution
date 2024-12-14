using System.Runtime.Serialization;

namespace Assignment1
{
    internal class Program
    {
        //1-	Write a program that allows the user to enter a number then print it
        static void Main(string[] args)
        {
            int x = 5;
            Console.WriteLine(x); //5


            /*2-	Write C# program that Assigning one value type variable to another and 
             * modifying the value of one variable and mention what will happen*/
            Console.WriteLine("point2");
            int B = 20;
            Console.WriteLine(B); // 20
            int y = 30;
            Console.WriteLine(y); // 30

            B = y;

            Console.WriteLine("After Equal");
            Console.WriteLine(B); // 30
            Console.WriteLine(y); // 30

            B += 8;

            Console.WriteLine("After B += 8");
            Console.WriteLine(B); // 30
            Console.WriteLine(y); // 30 

            // عندما يحدث تغيير في متغير لا يتأثر المتغير الاخر بالتغيير الذي يحدث علي المتغير الاول 


            /*3-	Write C# program that Assigning one reference type variable to another and
             * modifying the object through one variable and mention what will happen*/
            Console.WriteLine("point3");
            point3 p1;
            p1 = new point3();

            Console.WriteLine(p1.x); // 0
            Console.WriteLine(p1.x); // 0

            point3 p2 = new point3();

            Console.WriteLine(p2.x); // 0
            Console.WriteLine(p2.x); // 0

            p2 = p1; // two referance refare the same object
            p1.x = 100;
            p1.y = 200;
           

            Console.WriteLine("After change in p1");
            Console.WriteLine(p1.x); 
            Console.WriteLine(p1.y);
            Console.WriteLine("p2");
            Console.WriteLine(p2.x); 
            Console.WriteLine(p2.y);

            p2.x = 500;
            p2.y = 600;


            Console.WriteLine("After change in p2");
            Console.WriteLine(p1.x);
            Console.WriteLine(p1.y);
            Console.WriteLine("p2");
            Console.WriteLine(p2.x);
            Console.WriteLine(p2.y);
        }
    }
}
