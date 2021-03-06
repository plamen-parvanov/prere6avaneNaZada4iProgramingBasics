﻿namespace _12.Google.Units
{
    public class Car
    {
        private string model;
        private int speed;

        public Car(string model, int speed)
        {
            this.model = model;
            this.speed = speed;
        }

        public override string ToString()
        {
            return $"{this.model} {this.speed}"; 
        }
    }
}
