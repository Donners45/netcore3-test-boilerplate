using System;
using domain;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {

            var @object = new SomeClass
            {
                SomeProperty = "Hello World!"
            };


            Console.WriteLine($"{@object.SomeProperty}, from {nameof(@object)}.");
        }
    }
}
