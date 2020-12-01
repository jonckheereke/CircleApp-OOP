using System;

namespace CircleApp_OOP
{
    class Program
    {
        public static double RequestRadius()
        {
            Console.Write("Please enter the radius of the circle: ");
            return Convert.ToDouble(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to super fancy circle app.");

            // Object maken van Circle
            Circle myCircle = new Circle();
            Circle anotherCircle = new Circle();

            myCircle.SetRadius(RequestRadius());
            anotherCircle.SetRadius(3.6);

            Console.WriteLine("Area MyCircle = " + myCircle.GetArea());
            Console.WriteLine("Area Another = " + anotherCircle.GetArea());

            Console.WriteLine("Circumference MyCircle = " + myCircle.GetCircumference());
            Console.WriteLine("Circumference Another = " + anotherCircle.GetCircumference());

            Console.WriteLine("Radius MyCircle = " + myCircle.GetRadius());
            Console.WriteLine("Radius Another = " + anotherCircle.GetRadius());

            // Equivalent - implicit ToString() call
            Console.WriteLine(myCircle);
            Console.WriteLine(anotherCircle.ToString());        // Same as previous (explicit call ToString())

            string circleOutput = "" + myCircle;        // myCircle.ToString()
            string anotherCircleOutput = anotherCircle.ToString();
            Console.WriteLine(circleOutput);
        }
    }
}
