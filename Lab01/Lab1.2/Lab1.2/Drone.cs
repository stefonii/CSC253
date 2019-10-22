using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1._2
{
    class Drone
    {

        private int speed = 0; // instance variable and set to 0
        private int height = 0; // instance variable and set to 0

        // properties with get and set accessors 
        public void SetSpeed(int s)
        {
            speed = s;
        }

        public int GetSpeed()
        {
            return speed;
        }

        public void SetHeight(int h)
        {
            height = h;
        }
        public int GetHeight()
        {
            return height;
        }

        public string ID { get; set; } // auto-implemented property for drone ID

        // constructor with one parameter, used to initialized drone ID
        public Drone(string droneID)
        {
            ID = droneID;
        }

        // Accelerate method to increase speed by 10
        public void Accelerate()
        {
            speed = speed + 10;
            SetSpeed(speed);
        }

        // Decelerate method to decrease speed by 10
        public void Decelerate()
        {
            speed = speed - 10;
            SetSpeed(speed);
        }

        // Descend method to decrease height by 10
        public void Descend()
        {
            height = height - 10;
            SetHeight(height);
        }
        // Ascend method to increase height by 10
        public void Ascend()
        {
            height = height + 10;
            SetHeight(height);
        }
    }
}
