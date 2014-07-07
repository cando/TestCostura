using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCostura
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Sample>().As<ISample>();
            var container = builder.Build();
        }
    }
}