using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Lab1._2
{
    class DroneTest
    {
        static void Main()
        {
            // create Drone object with ID D1234
            Drone obj = new Drone("D1234");
            

            /* perform sequence of operations: ascend, descend, descend, decelerate, accelerate, and decelerate. 
             * display drone ID, speed, and height after each operation. */
            obj.Ascend();
            Console.WriteLine($"ID: {obj.ID}\n Speed: {obj.GetSpeed()}\n Height: {obj.GetHeight()}");

            obj.Descend();
            Console.WriteLine($"ID: {obj.ID}\n Speed: {obj.GetSpeed()}\n Height: {obj.GetHeight()}");

            obj.Descend();
            Console.WriteLine($"ID: {obj.ID}\n Speed: {obj.GetSpeed()}\n Height: {obj.GetHeight()}");

            obj.Decelerate();
            Console.WriteLine($"ID: {obj.ID}\n Speed: {obj.GetSpeed()}\n Height: {obj.GetHeight()}");

            obj.Accelerate();
            Console.WriteLine($"ID: {obj.ID}\n Speed: {obj.GetSpeed()}\n Height: {obj.GetHeight()}");

            obj.Decelerate();
            Console.WriteLine($"ID: {obj.ID}\n Speed: {obj.GetSpeed()}\n Height: {obj.GetHeight()}");


        }
    }
}
