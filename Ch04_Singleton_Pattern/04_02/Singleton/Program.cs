﻿using System;

namespace Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var policy = new Policy();
            var insuredName = Policy.Instance.GetInsuredName();

            Console.WriteLine(insuredName);
        }
    }
}
