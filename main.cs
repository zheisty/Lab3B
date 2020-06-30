using System;

class MainClass
{
    public static void Main(string[] args)
    {

        double carD = 1;
        double carT = 1;
        double totalD = 0;
        double totalT = 0;
        double totalS = 0;

        Console.WriteLine("How many Cars are Measured for Distance ");
        int numCarsD = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("How many Cars are Measured for Time ");
        int numCarsT = Convert.ToInt32(Console.ReadLine());

        while (carT <= numCarsD) 
        while (carD <= numCarsT) 
        {
            Console.WriteLine("Enter the Distance Covered by car" + carD++);           
            double distance = Convert.ToInt32(Console.ReadLine());
            totalD = totalD + distance;



            Console.WriteLine("Enter the Time Taken by car" + carT++);       
            double time = Convert.ToInt32(Console.ReadLine ());
            totalT = totalT + time;


            double speed = distance / time;
            totalS = totalS + speed;

            Console.WriteLine("The Speed of This Car is " + speed + " miles per hour");






        }
       

        Console.WriteLine("The Average Speed of the Cars is " + (totalS / numCarsD));



    }
}