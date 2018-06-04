using System;
using System.Collections.Generic;

/// <summary>
/// This code demonstrates the Builder pattern in which different cars 
/// are assembled in a step-by-step fashion. The CarFactory uses 
/// CarBuilders to construct a two types of cars in a series of 
/// sequential steps.
/// </summary>
namespace Builder.Demonstration
{
    class Program
    {
        /// <summary>
        /// The Client
        /// </summary>
        static void Main(string[] args)
        {
            var superBuilder = new SuperCarBuilder();
            var notSuperBuilder = new NotSoSuperCarBuilder();

            var factory = new CarFactory();
            var builders = new List<CarBuilder> {
                superBuilder, notSuperBuilder
            };

            foreach (var b in builders)
            {
                var c = factory.Build(b);
                Console.WriteLine($"The Car requested by " +
                    $"{b.GetType().Name}: " +
                    $"\n--------------------------------------" +
                    $"\nHorse Power: {c.HorsePower}" +
                    $"\nImpressive Feature: {c.MostImpressiveFeature}" +
                    $"\nTop Speed: {c.TopSpeedMPH} mph\n");
            }
        }
    }
}