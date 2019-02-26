using NUnit.Framework;
using FunctionApp1;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Function1.Run( "Hello, world!", null );
        }
    }
}