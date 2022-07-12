﻿namespace AdapterPattern
{
    public class MallardDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("Fly");
        }

        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }

}
