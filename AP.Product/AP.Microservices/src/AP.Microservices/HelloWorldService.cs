using System;
using Volo.Abp.DependencyInjection;

namespace AP.Microservices
{
    public class HelloWorldService : ITransientDependency
    {
        public void SayHello()
        {
            Console.WriteLine("\tHello World!");
        }
    }
}
