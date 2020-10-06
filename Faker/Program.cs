using System;

namespace Faker
{
    class Program
    {
        static void Main(string[] args)
        {
            var faker = new Faker();
            Bar foo = faker.Create<Bar>();
            Console.WriteLine(foo);
        }
    }
}