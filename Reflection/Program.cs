using System;
using System.Collections.Generic;

namespace Reflection
{
    public class Types
    {
        public List<int> Numbers { get; set; }
        public List<string> Letter { get; set; }
        public double[] array { get; set; }
        public string word { get; set; }
        public double _number { get; set; }
        public char ch { get; set; }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Types _types = new Types()
            {
                Numbers = new List<int> { 5, 3, 2 },
                Letter = new List<string> { "Red", "Green", "Black" },
                array = new double[5] { 5, 3, 2, 1, 5 },
                word = "Door",
                _number = 873.552,
                ch = 'T'
            };

            GetTypeInformation(_types);
        }

        private static void GetTypeInformation(object obj)
        {
            var type = obj.GetType();
            Console.WriteLine(type.FullName);
            
            var properties = type.GetProperties();
            foreach (var pr in properties)
            {
                Console.WriteLine($"Name: {pr.Name} \n " +
                    $"Declaring: {pr.DeclaringType} \n " +
                    $"Member:{pr.MemberType} \n " +
                    $"Property:{pr.PropertyType}");
            }
        }
    }
}

            
    
    
